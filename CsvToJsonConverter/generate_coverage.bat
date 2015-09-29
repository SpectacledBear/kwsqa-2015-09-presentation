@ECHO OFF
"%LOCALAPPDATA%\Apps\OpenCover\OpenCover.Console.exe" -output:"opencover.xml" -register:user -target:"packages\NUnit.Runners.2.6.4\tools\nunit-console.exe" -targetargs:"CsvToJsonConverter.Tests\bin\Debug\CsvToJsonConverter.Tests.dll /noshadow"
