ARG PARENT_TAG
ARG ACR_SERVER_REPO

FROM $ACR_SERVER_REPO/maya:$PARENT_TAG

ARG INSTALLER_SAS

COPY installVRay.sh /tmp/installVRay.sh
COPY vray_config2018.xml /tmp/vray/vray_config2018.xml
COPY VRayForMaya.module /usr/autodesk/mayaIO2018/modules/VRayForMaya.module
COPY vrayRenderer.xml /usr/autodesk/mayaIO2018/bin/rendererDesc/vrayRenderer.xml

RUN sh /tmp/installVRay.sh $INSTALLER_SAS