@ECHO OFF
ECHO ..Class=%1
xsd.exe "%2" /type:%1
ren *.xsd %1.xsd
move *.xsd %3