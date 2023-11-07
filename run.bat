@echo off
set filename=%~n1
csc "%1"
if %errorlevel% neq 0 (
    echo Compilation failed
) else (
    .\%filename%.exe
    del "%filename%.exe"
)