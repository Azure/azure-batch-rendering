#!/bin/sh -x

echo 'INSTALLER_SAS='$1
INSTALLER_SAS=$1

mkdir -m777 /tmp/mtoa

echo '-=Download=-'
azcopy --source $INSTALLER_SAS --destination /tmp/mtoa/MtoA-linux-2017.run

echo '-=Extract and Install=-'
7za x /tmp/mtoa/MtoA-linux-2017.run -o/tmp/mtoa/
7za x /tmp/mtoa/MtoA-linux-2017 -o/tmp/mtoa/MtoA2017
7za x /tmp/mtoa/MtoA2017/package.zip -o/opt/solidangle/mtoa/2017/

cp /opt/solidangle/mtoa/2017/arnoldRenderer.xml /usr/autodesk/mayaIO2017/bin/rendererDesc/
chmod 755 -R /opt/solidangle

rm -rf /tmp/mtoa

echo '-=Install script complete=-'