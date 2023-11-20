#pragma once

using namespace System::Runtime::InteropServices;

namespace ShellLinkBinder
{
	public ref class ShellLink
	{
	public:
		static bool CreateNewFile(System::String^ filepath,
			System::String^ path, System::String^ arguments, System::String^ workingDirectory);
		static bool LoadFromFile(System::String^ filepath,
			[Out] System::String^% path, [Out] System::String^% arguments, [Out] System::String^% workingDirectory);
	};
}
