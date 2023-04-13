#!/bin/sh -x

echo 'INSTALLER_SAS='$1
INSTALLER_SAS=$1

mkdir -m777 /tmp/mtoa

echo '-=Download=-'
azcopy --source $INSTALLER_SAS --destination /tmp/mtoa/MtoA-3.2.1.1-linux-2019.run

echo '-=Extract and Install=-'
7za x /tmp/mtoa/MtoA-3.2.1.1-linux-2019.run -o/tmp/mtoa/
7za x /tmp/mtoa/MtoA-3.2.1.1-linux-2019 -o/tmp/mtoa/MtoA2019
7za x /tmp/mtoa/MtoA2019/package.zip -o/opt/solidangle/mtoa/2019/

cp /opt/solidangle/mtoa/2019/arnoldRenderer.xml /usr/autodesk/mayaIO2019/bin/rendererDesc/
chmod 755 -R /opt/solidangle

rm -rf /tmp/mtoa

echo '-=Install script complete=-'