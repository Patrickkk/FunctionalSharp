mode con:cols=140 lines=2500

nuget.exe update -self

CALL Build.bat

mkdir Publish
NuGet Pack FunctionalSharp.PatternMatching.nuspec -OutputDirectory Publish
Nuget push "\Publish\FunctionalSharp.PatternMatching*.nupkg"
rmdir Publish /s /q
pause