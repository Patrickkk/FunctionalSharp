mode con:cols=140 lines=2500

CALL "%VS120COMNTOOLS%"\\vsvars32.bat

msbuild.exe /t:Rebuild /p:TargetFrameworkVersion=v3.5;Configuration=release35 "..\FunctionalSharp.sln" 
msbuild.exe /t:Rebuild /p:TargetFrameworkVersion=v4.0;Configuration=release40 "..\FunctionalSharp.sln"
msbuild.exe /t:Rebuild /p:TargetFrameworkVersion=v4.5;Configuration=release45 "..\FunctionalSharp.sln"
msbuild.exe /t:Rebuild /p:TargetFrameworkVersion=v4.5.1;Configuration=release451 "..\FunctionalSharp.sln"