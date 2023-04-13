ARG PARENT_TAG
ARG ACR_SERVER_REPO

FROM $ACR_SERVER_REPO/maya:$PARENT_TAG

ARG INSTALLER_SAS

COPY installArnold.sh /tmp/installArnold.sh
COPY mtoa.mod /usr/autodesk/mayaIO2019/modules/mtoa.mod

RUN sh /tmp/installArnold.sh $INSTALLER_SAS