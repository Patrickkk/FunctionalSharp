mode con:cols=140 lines=2500

nuget.exe update -self

CALL Build.bat

mkdir Publish
NuGet Pack FunctionalSharp.DiscriminatedUnions.nuspec -OutputDirectory "D:\Nuget"
NuGet Pack FunctionalSharp.OptionTypes.nuspec -OutputDirectory "D:\Nuget"
NuGet Pack FunctionalSharp.PatternMatching.nuspec -OutputDirectory "D:\Nuget"
pause