$INSTALLER_SAS = $args[0].trim("'")

echo $INSTALLER_SAS

New-Item 'C:\temp' -type directory 
New-Item 'C:\Autodesk' -type directory
New-Item 'C:\temp\log' -type directory
New-Item 'C:\Autodesk\3dsMax2018' -type directory
New-Item 'C:\temp\Max2018ToArnold' -type directory

echo '-------------------------------------------------------------------------------------'
echo '------------------=Download and install Arnold for 3DS Max 2018=---------------------'
echo '-------------------------------------------------------------------------------------'
AzCopy.exe /source:$INSTALLER_SAS /dest:'MAXtoA-1.2.926.2018.exe'
echo 'Download complete'
7z e 'MAXtoA-1.2.926.2018.exe' -o'C:\temp\Max2018ToArnold\'
echo 'Extraction complete'
Start-Process msiexec.exe -ArgumentList @("/I", "C:\temp\Max2018ToArnold\ArnoldPlug.msi", "/passive", "/qn") -Wait

Remove-Item 'C:\temp\Max2018ToArnold' -Force -Recurse
echo 'Finished installing Arnold for 3dsmax2018'
