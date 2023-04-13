#!/bin/sh -x

yum update -y
yum install csh
yum install mesa-libGLU.x86_64 -y
yum install libXp-1.0.2-2.1.el7.x86_64 -y
yum install libXmu-1.1.2-2.el7.x86_64 -y
yum install libXpm -y
yum install libXi -y
yum install compat-libtiff3-3.9.4-11.el7.x86_64 -y
yum install fontconfig -y
yum install libXinerama-1.1.3-2.1.el7.x86_64 -y
yum install gamin-0.1.10-16.el7.x86_64 -y
yum install libpng12-1.2.50-10.el7.x86_64 -y
yum install libXrender -y
yum install libXcomposite-0.4.4-4.1.el7.x86_64 -y
yum install libxslt-1.1.28-5.el7.x86_64 -y
yum install pulseaudio-libs -y
yum install libunwind -y
yum install libicu -y
yum install wget -y
yum install which -y
yum install rsync -y
yum install tcsh -y
rpm --import https://packages.microsoft.com/keys/microsoft.asc
sh -c 'echo -e "[packages-microsoft-com-prod]\nname=packages-microsoft-com-prod \nbaseurl=https://packages.microsoft.com/yumrepos/microsoft-rhel7.3-prod\nenabled=1\ngpgcheck=1\ngpgkey=https://packages.microsoft.com/keys/microsoft.asc" > /etc/yum.repos.d/dotnetdev.repo'
sh -c 'echo -e "[azure-cli]\nname=Azure CLI\nbaseurl=https://packages.microsoft.com/yumrepos/azure-cli\nenabled=1\ngpgcheck=1\ngpgkey=https://packages.microsoft.com/keys/microsoft.asc" > /etc/yum.repos.d/azure-cli.repo'
yum install libunwind libicu -y
yum install ImageMagick -y
yum install dotnet-sdk-2.1.4 -y
yum install epel-release -y
yum install p7zip -y
yum install azure-cli -y
yum install sudo -y

echo 'Installing azcopy'
wget -O azcopy.tar.gz https://aka.ms/downloadazcopyprlinux
tar -xf azcopy.tar.gz
./install.sh

yum install python-pyasn1 WALinuxAgent -y
yum clean all