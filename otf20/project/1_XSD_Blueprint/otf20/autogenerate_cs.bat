@echo off
CLS
ECHO Generate .CS file from source XSD files

ECHO.
ECHO Step (1/7) - Preparations

REM Prepare folders
set sourceXSD=%cd%\xsd
set targetCS=%cd%\cs_autogenerated
ECHO XSD definitions folder (source) = %sourceXSD%
ECHO Autogenerated CS folder (target) = %targetCS%

REM Iterate files in XSD subdir and put in string (since XSD.exe cannot handle * to process multiple files at once)
setlocal enabledelayedexpansion
set xsd_files=
for /r %sourceXSD% %%f in (Message*.xsd) do (
    set xsd_files=!xsd_files! "%%~dpf%%~nxf"
)
echo XSD files found = %xsd_files%

REM Prepare CS filename
for %%I in (.) do set CurrDirName=%%~nxI
set targetCSFileName=%CurrDirName%_autogenerated.cs
ECHO Subfoldername = %CurrDirName%
ECHO Target CS filename = %targetCSFileName%

ECHO.
ECHO Step (2/7) - Check CS dir and remove old files (if any)
if not exist "%targetCS%" mkdir "%targetCS%"
del %sourceXSD%\*.bak
del %targetCS%\*.cs

ECHO.
ECHO Step (3/7) - DEBUGGING; generate each file separately.
for /r %sourceXSD% %%f in (*.xsd) do (
  ECHO.
  ECHO Processing "%%f"...
  xsd.exe "%%f" /c /n:"%CurrDirName%"
)
ECHO.
PAUSE
ECHO Deleting debug files...
del *.cs

ECHO.
ECHO Step (4/7) - Generate CS file from XSD source files
xsd.exe %xsd_files% /c /n:"%CurrDirName%"

ECHO.
ECHO Step (5/7). Rename generated CS file
ren "*.cs" "%targetCSFileName%"

ECHO.
ECHO Step (6/7) - Move generated CS file to CS subfolder
move "*.cs" "%targetCS%"

ECHO.
ECHO Step (7/7) - Generation completed

ECHO.
PAUSE