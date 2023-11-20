<# : batch
@echo off
setlocal
cd %~dp0
powershell -ExecutionPolicy RemoteSigned -Command "iex $(gc '%~f0' -Raw)"
endlocal
goto:eof
#>
$LauncherFolder = "$env:UserProfile\.WinRLauncher"

Write-Output "Start uninstall..."
$rebootRequired = $false

# Remove launcher folder
if (Test-Path $LauncherFolder) {
    Write-Output "  Remove Folder: $LauncherFolder"
    Remove-Item $LauncherFolder -Force -Recurse
}

# Remove launcher folder from PATH of environment variable
$oldPath = [System.Environment]::GetEnvironmentVariable("PATH", [System.EnvironmentVariableTarget]::User);
$newPath = ($oldPath -split ";" | Where-Object { $_ -ne $LauncherFolder }) -join ";"
if ($oldPath -ne $newPath) {
    Write-Output "  Remove from PATH: $LauncherFolder"
    [System.Environment]::SetEnvironmentVariable("PATH", $newPath, [System.EnvironmentVariableTarget]::User)
    $rebootRequired = $true
}

Write-Output "Uninstall was finished."
if ($rebootRequired) {
    Write-Output ""
    Write-Output "------------------------------------------------------------"
    Write-Output "| The value of environment variable PATH was changed.      |"
    Write-Output "| Please reboot Windows to apply it.                       |"
    Write-Output "------------------------------------------------------------"
    Write-Output ""
}

Write-Host -NoNewLine "Press any key to exit..."
$null = $host.ui.RawUI.ReadKey("NoEcho, IncludeKeyDown")
