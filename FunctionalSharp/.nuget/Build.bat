mode con:cols=140 lines=2500

CALL "%VS140COMNTOOLS%"\\vsvars32.bat

msbuild.exe "..\FunctionalSharp.sln" /t:Rebuild /p:TargetFrameworkVersion=v3.5;Configuration=release35 
msbuild.exe "..\FunctionalSharp.sln" /t:Rebuild /p:TargetFrameworkVersion=v4.0;Configuration=release40
msbuild.exe "..\FunctionalSharp.sln" /t:Rebuild /p:TargetFrameworkVersion=v4.5;Configuration=release45 
msbuild.exe "..\FunctionalSharp.sln" /t:Rebuild /p:TargetFrameworkVersion=v4.5.1;Configuration=release451