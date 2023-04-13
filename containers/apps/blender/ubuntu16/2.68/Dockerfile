ARG PARENT_TAG
ARG ACR_SERVER_REPO

FROM $ACR_SERVER_REPO/blender:$PARENT_TAG

RUN apt-get update && \
    apt-get install -y libSDL1.2debian

RUN curl -SL "http://download.blender.org/release/Blender2.68/blender-2.68-linux-glibc211-x86_64.tar.bz2" -o blender.tar.bz2 && \
	tar -jxvf blender.tar.bz2 -C /usr/local/bin --strip-components=1 && \
	rm blender.tar.bz2
  
RUN  apt-get update && \
  apt-get install python-pyasn1 walinuxagent -y && \
  apt-get clean
