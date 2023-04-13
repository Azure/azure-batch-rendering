cd C:\temp
pwd
wget -O C:\temp\install.ps1 https://chocolatey.org/install.ps1
.\install.ps1
choco install 7zip.portable -y
choco install azcopy -y
choco install vcredist2012 -y
choco install vcredist2015 -y
choco install kb3118401 -y
choco install imagemagick --version 7.0.7.5 -y
choco install dotnetcore -y
choco install azure-cli -y
choco install python2 -y
Get-PackageProvider -Name NuGet -Force
Install-Module PowerShellGet -Force
Install-Module -Name AzureRm -Repository PSGallery -Force
$oldPath=(Get-ItemProperty -Path 'Registry::HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Session Manager\Environment' -Name PATH).Path
$newPath=$oldPath+';C:\Program Files (x86)\Microsoft SDKs\Azure\AzCopy\;C:\ProgramData\chocolatey\lib\7zip.portable\tools\7z-extra\;'
Set-ItemProperty -Path 'Registry::HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Session Manager\Environment' -name 'PATH' -value $newPath
$env:Path += 'C:\Program Files (x86)\Microsoft SDKs\Azure\AzCopy\'

echo '-------------------------------------------------------------------------------------'
echo '---------------------=Speculative and Execution side-channel fix=-----------------------'
echo '-------------------------------------------------------------------------------------'
reg add 'HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management' /v FeatureSettingsOverride /t REG_DWORD /d 0 /f
reg add 'HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management' /v FeatureSettingsOverrideMask /t REG_DWORD /d 3 /f
reg add 'HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Virtualization' /v MinVmVersionForCpuBasedMitigations /t REG_SZ /d '1.0' /f

Remove-Item C:\Users\ContainerAdministrator\AppData\Local\Temp -Force -Recurse