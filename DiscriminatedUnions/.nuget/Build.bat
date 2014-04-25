CALL "%VS120COMNTOOLS%"\\vsvars32.bat

msbuild.exe /t:Rebuild /p:TargetFrameworkVersion=v3.5;Configuration=release35 "..\DiscriminatedUnions.sln" 
msbuild.exe /t:Rebuild /p:TargetFrameworkVersion=v4.0;Configuration=release40 "..\DiscriminatedUnions.sln"
msbuild.exe /t:Rebuild /p:TargetFrameworkVersion=v4.5;Configuration=release45 "..\DiscriminatedUnions.sln"
msbuild.exe /t:Rebuild /p:TargetFrameworkVersion=v4.5.1;Configuration=release451 "..\DiscriminatedUnions.sln"