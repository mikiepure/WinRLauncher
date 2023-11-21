$MSBuild = "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin"
$Version = "x.x.x"

$env:PATH = "$env:PATH;$MSBuild"

# Build app
MSBuild .\ShellLinkBinder\ShellLinkBinder.vcxproj -p:configuration=Release -p:platform=x64
MSBuild .\WinRLauncher\WinRLauncher.csproj -p:configuration=Release -p:platform=x64

# Create archive
$DirName = "WinRLauncher_$Version"
New-Item -Path $DirName -ItemType Directory
Compress-Archive -Path .\WinRLauncher\bin\x64\Release\* -DestinationPath .\$DirName.zip
