#include "pch.h"

#include "ShellLinkBinder.h"

namespace ShellLinkBinder
{

	bool ShellLink::CreateNewFile(System::String^ filepath,
		System::String^ path, System::String^ arguments, System::String^ workingDirectory)
	{
		bool ret = false;

		IShellLink* shellLink = nullptr;
		if (SUCCEEDED(CoCreateInstance(CLSID_ShellLink, nullptr, CLSCTX_INPROC_SERVER, IID_IShellLink, reinterpret_cast<LPVOID*>(&shellLink)))) {
			IPersistFile* file = nullptr;
			if (SUCCEEDED(shellLink->QueryInterface(IID_IPersistFile, reinterpret_cast<void**>(&file)))) {
				msclr::interop::marshal_context^ mc = gcnew msclr::interop::marshal_context;
				LPCTSTR filepathNative = mc->marshal_as<LPCTSTR>(filepath);

				shellLink->SetPath(mc->marshal_as<LPCTSTR>(path));
				shellLink->SetArguments(mc->marshal_as<LPCTSTR>(arguments));
				shellLink->SetWorkingDirectory(mc->marshal_as<LPCTSTR>(workingDirectory));

				file->Save(filepathNative, TRUE);
				file->Release();

				ret = true;
			}

			shellLink->Release();
		}

		return ret;
	}

	bool ShellLink::LoadFromFile(System::String^ filepath,
		[Out] System::String^% path, [Out] System::String^% arguments, [Out] System::String^% workingDirectory)
	{
		bool ret = false;

		IShellLink* shellLink = nullptr;
		if (SUCCEEDED(CoCreateInstance(CLSID_ShellLink, nullptr, CLSCTX_INPROC_SERVER, IID_IShellLink, reinterpret_cast<LPVOID*>(&shellLink)))) {
			IPersistFile* file = nullptr;
			if (SUCCEEDED(shellLink->QueryInterface(IID_IPersistFile, reinterpret_cast<void**>(&file)))) {
				msclr::interop::marshal_context^ mc = gcnew msclr::interop::marshal_context;
				LPCTSTR filepathNative = mc->marshal_as<LPCTSTR>(filepath);

				file->Load(filepathNative, STGM_READ);
				file->Release();

				TCHAR buf[_MAX_PATH];

				TCHAR productCode[MAX_FEATURE_CHARS + 1];
				TCHAR featureId[MAX_FEATURE_CHARS + 1];
				TCHAR componentCode[MAX_FEATURE_CHARS + 1];
				if (MsiGetShortcutTarget(filepathNative, productCode, featureId, componentCode) == ERROR_SUCCESS) {
					// The file is advertise shortcut
					DWORD bufLength = DWORD(_MAX_PATH);
					(void)MsiGetComponentPath(productCode, componentCode, buf, &bufLength);
					path = msclr::interop::marshal_as<System::String^>(buf);
				}
				else {
					shellLink->GetPath(buf, _MAX_PATH, nullptr, SLGP_RAWPATH);
					path = msclr::interop::marshal_as<System::String^>(buf);
				}
				shellLink->GetArguments(buf, _MAX_PATH);
				arguments = msclr::interop::marshal_as<System::String^>(buf);
				shellLink->GetWorkingDirectory(buf, _MAX_PATH);
				workingDirectory = msclr::interop::marshal_as<System::String^>(buf);

				ret = true;
			}

			shellLink->Release();
		}

		return ret;
	}
}
