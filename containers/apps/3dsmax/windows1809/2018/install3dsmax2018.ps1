$INSTALLER_SAS = $args[0].trim("'")

echo $INSTALLER_SAS

New-Item 'C:\temp' -type directory 
New-Item 'C:\Autodesk' -type directory
New-Item 'C:\temp\log' -type directory
New-Item 'C:\Autodesk\3dsMax2018' -type directory

[Environment]::SetEnvironmentVariable('3DSMAX_2018','C:\Autodesk\3dsMax2018\', 'Machine')
[Environment]::SetEnvironmentVariable('3DSMAX_2018_EXEC','C:\Autodesk\3dsMax2018\3dsmaxcmdio.exe', 'Machine')

echo '-------------------------------------------------------------------------------------'
echo '------------------------=Download and install 3DS Max 2018=--------------------------'
echo '-------------------------------------------------------------------------------------'
AzCopy.exe /source:$INSTALLER_SAS /dest:Autodesk_3ds_Max_IO_2018_EFGJKPS_Win_part4_64bit.zip
echo 'Download complete'
7za x Autodesk_3ds_Max_IO_2018_EFGJKPS_Win_part4_64bit.zip -o'C:\temp\3dsmax2018\'
echo 'Extraction complete'
cd 'C:\temp\3dsmax2018\Autodesk_3ds_Max_IO_2018_EFGJKPS_Win_part4_64bit'
(Get-Content setup.ini) | ForEach { $_ -replace "PREREQUISITE=IE;", "PREREQUISITE="} | Out-File setup.ini
Start-Process cmd.exe -ArgumentList @("/c","setup.exe", "/t","/c","/w","/q","MAXIO:", "INSTALLDIR=C:\Autodesk\3dsMax2018\", "InstallLevel=5") -wait

Remove-Item 'C:\temp\3dsmax2018' -Force -Recurse
echo 'Finished installing 3dsmax2018'

