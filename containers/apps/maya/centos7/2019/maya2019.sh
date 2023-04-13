#!/bin/bash

#Below is needed to prevent the following warning:
#[mtoa] Error loading extension library: libAdskSeExpr.so: cannot open shared object file: No such file or directory
#[mtoa] Error loading extension library: libAdskSeExpr.so: cannot open shared object file: No such file or directory
#unable to load dynamic library /opt/solidangle/mtoa/2019/procedurals/xgen_procedural.so: libAdskSeExpr.so: cannot open shared object file: No such file or directory
#unable to load dynamic library /opt/solidangle/mtoa/2019/procedurals/xgenSpline_procedural.so: libAdskSeExpr.so: cannot open shared object file: No such file or directory
export LD_LIBRARY_PATH=$LD_LIBRARY_PATH:/usr/autodesk/mayaIO2019/plug-ins/xgen/lib

/usr/autodesk/mayaIO2019/bin/Render "$@"
exit $?