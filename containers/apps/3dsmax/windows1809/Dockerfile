FROM mcr.microsoft.com/windows:1809

COPY installDependencies.ps1 C:/temp/installDependencies.ps1

SHELL ["cmd", "/S", "/C"] 
RUN powershell -ExecutionPolicy ByPass -noexit "& ""C:/temp/installDependencies.ps1"""