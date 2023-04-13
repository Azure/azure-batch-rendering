#!/bin/sh -x

echo 'INSTALLER_SAS='$1
INSTALLER_SAS=$1

mkdir -m777 /tmp/maya2017 -p
mkdir -m777 /tmp/maya/Maya2017 -p

echo '-=Download=-'
azcopy --source $INSTALLER_SAS --destination /tmp/maya/Autodesk_MayaIO_2017_Linux_64bit.run

echo '-=Extract and Install=-'
7za e /tmp/maya/Autodesk_MayaIO_2017_Linux_64bit.run -o/tmp/maya/
7za e /tmp/maya/Autodesk_MayaIO_2017_Linux_64bit -o/tmp/maya/Maya2017/
chmod +x /tmp/maya/Maya2017/setup.sh
/tmp/maya/Maya2017/setup.sh 127.0.0.1

cp /usr/bin/maya2017.sh /usr/bin/maya.sh

chmod +x /usr/bin/maya.sh
chmod +x /usr/bin/maya2017.sh

rm -rf /tmp/maya2017
rm -rf /tmp/maya
rm -rf /usr/autodesk/mayaIO

echo '-=Install script complete=-'
