mode con:cols=140 lines=2500

nuget.exe update -self

CALL Build.bat

mkdir Publish
NuGet Pack DiscriminatedUnions.nuspec -OutputDirectory Publish
Nuget push "\Publish\DiscriminatedUnions*.nupkg"
rmdir Publish /s /q
pause