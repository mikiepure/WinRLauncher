// ShellLinkBinding.h

#pragma once

#include "Stdafx.h"

namespace ShellLinkBinding
{
	public ref class ShellLinkBinding
	{
	private:
		ShellLinkBinding(System::String^ filepath);
		ShellLinkBinding(System::String^ filepath, System::String^ path, System::String^ arguments, System::String^ workingDirectory);
	public:
		ShellLinkBinding::~ShellLinkBinding(void);
		ShellLinkBinding::!ShellLinkBinding(void);

	public:
		static ShellLinkBinding^ load(System::String^ filepath);
		static ShellLinkBinding^ create(System::String^ filepath, System::String^ path, System::String^ arguments, System::String^ workingDirectory);

	public:
		property System::String^ Path {
			System::String^ get(void);
			void set(System::String^ value);
		}
		property System::String^ Arguments {
			System::String^ get(void);
			void set(System::String^ value);
		}
		property System::String^ WorkingDirectory {
			System::String^ get(void);
			void set(System::String^ value);
		}

	private:
		static bool isAdvertiseFile(System::String ^filepath, TCHAR * productCode, TCHAR * featureId, TCHAR * componentCode);

	private:
		IShellLink * shellLink;
	};
}
