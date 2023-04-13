FROM ubuntu:xenial

RUN apt-get update && \
	apt-get install -y \
    sudo \
		curl \
		bzip2 \
		libfreetype6 \
		libgl1-mesa-dev \
		libglu1-mesa \
		libxi6 \
    imagemagick \
    wget \
    rsync \
		libxrender1
	
RUN curl -sL https://aka.ms/InstallAzureCLIDeb | sudo bash

RUN wget -q https://packages.microsoft.com/config/ubuntu/16.04/packages-microsoft-prod.deb && \
  sudo dpkg -i packages-microsoft-prod.deb && \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-2.2
    
RUN sudo wget -O azcopy.tar.gz https://aka.ms/downloadazcopyprlinux && \
  tar -xf azcopy.tar.gz && \
  ./install.sh && \
  rm azcopy.tar.gz

RUN sudo apt-get clean && \
  apt-get -y autoremove && \
	rm -rf /var/lib/apt/lists/*