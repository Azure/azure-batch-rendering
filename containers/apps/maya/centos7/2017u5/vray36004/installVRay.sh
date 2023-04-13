#!/bin/sh -x

echo 'INSTALLER_SAS='$1
INSTALLER_SAS=$1

echo '-=Download=-'
echo 'download vray4batch_maya2017_linux_x64'
azcopy --source $INSTALLER_SAS --destination /tmp/vray/vray4batch_maya2017_linux_x64 

echo '-=Extract and Install=-'
chmod +x /tmp/vray/vray4batch_maya2017_linux_x64
/tmp/vray/vray4batch_maya2017_linux_x64 -gui=0 -configFile='/tmp/vray/vray_config2017.xml' -ignoreErrors=1

rm -rf /tmp/vray

echo '-=Install script complete=-'