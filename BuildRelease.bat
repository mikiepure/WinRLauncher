@echo off
cd %~dp0

set MSBuild="C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe"
set Version=x.x.x

%MSBuild% ShellLinkBinder\ShellLinkBinder.vcxproj -p:configuration=Release;platform=x64
%MSBuild% WinRLauncher\WinRLauncher.csproj -p:configuration=Release;platform=x64

mkdir publish\WinRLauncher_%Version%
copy WinRLauncher\bin\x64\Release\ShellLinkBinder.dll publish\WinRLauncher_%Version%\
copy WinRLauncher\bin\x64\Release\Uninstall.bat       publish\WinRLauncher_%Version%\
copy WinRLauncher\bin\x64\Release\WinRLauncher.exe    publish\WinRLauncher_%Version%\
