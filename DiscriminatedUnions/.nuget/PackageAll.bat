mode con:cols=140 lines=2500

nuget.exe update -self

CALL Build.bat

NuGet Pack DiscriminatedUnions.nuspec
Nuget push DiscriminatedUnions*.nupkg
pause