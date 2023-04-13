#!/bin/sh -x

echo 'INSTALLER_SAS='$1
INSTALLER_SAS=$1

mkdir -m777 /tmp/maya2019 -p
mkdir -m777 /tmp/maya/Maya2019 -p

echo '-=Install Maya2019 specific dependencies=-'
yum install gstreamer1 -y
yum install gstreamer1-plugins-base -y
yum clean all

echo '-=Download Installer=-'
azcopy --source $INSTALLER_SAS --destination /tmp/maya/Autodesk_MayaIO_2019_1_Update_Linux_64bit.run

echo '-=Extract and Install=-'
7za e /tmp/maya/Autodesk_MayaIO_2019_1_Update_Linux_64bit.run -o/tmp/maya/
7za e /tmp/maya/Autodesk_MayaIO_2019_1_Update_Linux_64bit -o/tmp/maya/Maya2019/
chmod +x /tmp/maya/Maya2019/setup.sh
/tmp/maya/Maya2019/setup.sh 127.0.0.1

cp /usr/bin/maya2019.sh /usr/bin/maya.sh

chmod +x /usr/bin/maya2019.sh
chmod +x /usr/bin/maya.sh

rm -rf /tmp/maya2019
rm -rf /tmp/maya
rm -rf /usr/autodesk/mayaIO

echo '-=Install script complete=-'