// This is the main DLL source file.

#include "stdafx.h"

#include "ShellLinkBinding.h"

namespace ShellLinkBinding
{
	ShellLinkBinding::ShellLinkBinding(System::String^ filepath)
		: shellLink(nullptr)
	{
		IShellLink * shellLinkTemp = nullptr;
		CoCreateInstance(CLSID_ShellLink, nullptr, CLSCTX_INPROC_SERVER, IID_IShellLink, reinterpret_cast<LPVOID *>(&shellLinkTemp));
		this->shellLink = shellLinkTemp;

		IPersistFile * file = nullptr;
		this->shellLink->QueryInterface(IID_IPersistFile, reinterpret_cast<void **>(&file));

		msclr::interop::marshal_context^ context = gcnew msclr::interop::marshal_context;
		LPCTSTR nativeFilepath = context->marshal_as<LPCTSTR>(filepath);
		file->Load(nativeFilepath, STGM_READ);
		file->Release();

		// Convert from advertise shortcut
		TCHAR productCode[MAX_FEATURE_CHARS + 1];
		TCHAR featureId[MAX_FEATURE_CHARS + 1];
		TCHAR componentCode[MAX_FEATURE_CHARS + 1];
		bool isAdvertise = isAdvertiseFile(filepath, productCode, featureId, componentCode);
		if (isAdvertise) {
			TCHAR pathBuffer[_MAX_PATH];
			DWORD pathBufferLength = DWORD(_MAX_PATH);
			(void)MsiGetComponentPath(productCode, componentCode, pathBuffer, &pathBufferLength);
			this->Path = msclr::interop::marshal_as<System::String^>(pathBuffer);
		}
	}

	ShellLinkBinding::ShellLinkBinding(System::String^ filepath, System::String^ path, System::String^ arguments, System::String^ workingDirectory)
		: shellLink(nullptr)
	{
		IShellLink * shellLinkTemp = nullptr;
		CoCreateInstance(CLSID_ShellLink, nullptr, CLSCTX_INPROC_SERVER, IID_IShellLink, reinterpret_cast<LPVOID *>(&shellLinkTemp));
		this->shellLink = shellLinkTemp;

		IPersistFile * file = nullptr;
		this->shellLink->QueryInterface(IID_IPersistFile, reinterpret_cast<void **>(&file));

		this->Path = path;
		this->Arguments = arguments;
		this->WorkingDirectory = workingDirectory;

		msclr::interop::marshal_context^ context = gcnew msclr::interop::marshal_context;
		LPCTSTR nativeFilepath = context->marshal_as<LPCTSTR>(filepath);
		file->Save(nativeFilepath, TRUE);
		file->Release();
	}

	ShellLinkBinding::~ShellLinkBinding(void)
	{
		this->!ShellLinkBinding();
	}

	ShellLinkBinding::!ShellLinkBinding(void)
	{
		if (this->shellLink) this->shellLink->Release();
	}

	ShellLinkBinding^ ShellLinkBinding::create(System::String^ filepath, System::String^ path, System::String^ arguments, System::String^ workingDirectory)
	{
		return gcnew ShellLinkBinding(filepath, path, arguments, workingDirectory);
	}

	ShellLinkBinding^ ShellLinkBinding::load(System::String^ filepath)
	{
		return gcnew ShellLinkBinding(filepath);
	}

	System::String^ ShellLinkBinding::Path::get(void)
	{
		TCHAR value[_MAX_PATH];
		this->shellLink->GetPath(value, _MAX_PATH, nullptr, SLGP_RAWPATH);
		return msclr::interop::marshal_as<System::String^>(value);
	}

	void ShellLinkBinding::Path::set(System::String^ value)
	{
		msclr::interop::marshal_context^ context = gcnew msclr::interop::marshal_context;
		this->shellLink->SetPath(context->marshal_as<LPCTSTR>(value));
	}

	System::String^ ShellLinkBinding::Arguments::get(void)
	{
		TCHAR value[_MAX_PATH];
		this->shellLink->GetArguments(value, _MAX_PATH);
		return msclr::interop::marshal_as<System::String^>(value);
	}

	void ShellLinkBinding::Arguments::set(System::String^ value)
	{
		msclr::interop::marshal_context^ context = gcnew msclr::interop::marshal_context;
		this->shellLink->SetArguments(context->marshal_as<LPCTSTR>(value));
	}

	System::String^ ShellLinkBinding::WorkingDirectory::get(void)
	{
		TCHAR value[_MAX_PATH];
		this->shellLink->GetWorkingDirectory(value, _MAX_PATH);
		return msclr::interop::marshal_as<System::String^>(value);
	}

	void ShellLinkBinding::WorkingDirectory::set(System::String^ value)
	{
		msclr::interop::marshal_context^ context = gcnew msclr::interop::marshal_context;
		this->shellLink->SetWorkingDirectory(context->marshal_as<LPCTSTR>(value));
	}

	bool ShellLinkBinding::isAdvertiseFile(System::String ^filepath, TCHAR * productCode, TCHAR * featureId, TCHAR * componentCode)
	{
		msclr::interop::marshal_context^ context = gcnew msclr::interop::marshal_context;
		LPCTSTR shortcutPath = context->marshal_as<LPCTSTR>(filepath);

		UINT isAdvertisable = MsiGetShortcutTarget(shortcutPath, productCode, featureId, componentCode);
		return isAdvertisable == ERROR_SUCCESS;
	}
}
