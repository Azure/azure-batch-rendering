FROM azurebatchrendering/3dsmax:1.1.2018-1.1.1809

ARG INSTALLER_SAS

COPY installArnold.ps1 C:/temp/installArnold.ps1

RUN powershell -ExecutionPolicy ByPass -noexit C:/temp/installArnold.ps1 "'%INSTALLER_SAS%'"
