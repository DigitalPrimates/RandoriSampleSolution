rem $(ProjectDir) $(SolutionDir)
echo Moving Randori Framework
xcopy %2Randori\res\*.js /Y /I /D %1\generated\randori
echo Moving Guice
xcopy %2RandoriGuiceJS\res\*.js /Y /I /D %1\generated\randori

