FROM azurebatchrendering/3dsmax:1.1.1809

ARG INSTALLER_SAS

COPY install3dsmax2018.ps1 C:/temp/install3dsmax2018.ps1

RUN powershell -ExecutionPolicy ByPass -noexit C:/temp/install3dsmax2018.ps1 "'%INSTALLER_SAS%'"
