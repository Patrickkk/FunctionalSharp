mode con:cols=140 lines=2500

nuget.exe update -self

CALL Build.bat

mkdir Publish
NuGet Pack FunctionalSharp.PatternMatching.DiscriminatedUnions.nuspec -OutputDirectory Publish
Nuget push "Publish\FunctionalSharp.PatternMatching.DiscriminatedUnions*.nupkg"
rmdir Publish /s /q
pause