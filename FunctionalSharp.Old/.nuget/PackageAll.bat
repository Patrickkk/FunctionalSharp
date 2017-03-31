mode con:cols=140 lines=2500

nuget.exe update -self

CALL PackageFunctionalSharp.DiscriminatedUnions
CALL PackageFunctionalSharp.OptionTypes
CALL PackageFunctionalSharp.PatternMatching
CALL PackageFunctionalSharp.PatternMatching.DiscriminatedUnions.nuspec