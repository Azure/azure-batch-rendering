#!/bin/sh -x

echo 'INSTALLER_SAS='$1
INSTALLER_SAS=$1

mkdir -m777 /tmp/maya2018 -p
mkdir -m777 /tmp/maya/Maya2018 -p

echo '-=Download=-'
azcopy --source $INSTALLER_SAS --destination /tmp/maya/Autodesk_MayaIO_2018_Linux_64bit.run

echo '-=Extract and Install=-'
7za e /tmp/maya/Autodesk_MayaIO_2018_Linux_64bit.run -o/tmp/maya/
7za e /tmp/maya/Autodesk_MayaIO_2018_Linux_64bit -o/tmp/maya/Maya2018/
chmod +x /tmp/maya/Maya2018/setup.sh
/tmp/maya/Maya2018/setup.sh 127.0.0.1

cp /usr/bin/maya2018.sh /usr/bin/maya.sh

chmod +x /usr/bin/maya2018.sh
chmod +x /usr/bin/maya.sh

rm -rf /tmp/maya2018
rm -rf /tmp/maya
rm -rf /usr/autodesk/mayaIO

echo '-=Install script complete=-'