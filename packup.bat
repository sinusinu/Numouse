@echo off

del Numouse.zip
rmdir /s /q bin\Release\net6.0-windows\publish

dotnet publish -c Release
xcopy "bin\Release\net6.0-windows\lang\*.*" "bin\Release\net6.0-windows\publish\lang\" /E /Y

cd bin\Release\net6.0-windows\publish

del Numouse.pdb

where bz
if %ERRORLEVEL% neq 0 goto nobz

bz c -r Numouse.zip *.* ..\..\..\..\COPYING
move Numouse.zip ..\..\..\..

goto end

:nobz
echo Bandizip is not found, skipping ZIP creation

:end
cd ..\..\..\..
echo.
echo Done!
pause