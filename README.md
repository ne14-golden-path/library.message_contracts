# library.message_contracts

``` powershell
# Restore tools
dotnet tool restore

# General clean up
rd -r **/bin/; rd -r **/obj/;

# Run unit tests
gci -r -dir ../TestResults | % { rm -r $_ }; dotnet test -c Release -s .runsettings; dotnet reportgenerator -targetdir:coveragereport -reports:**/coverage.cobertura.xml -reporttypes:"html;jsonsummary"; start coveragereport/index.html;

# Run mutation tests
gci -r -dir ../StrykerOutput | % { rm -r $_ }; dotnet stryker -o;

# Pack and publish a pre-release to a local feed
$suffix="alpha001"; dotnet pack -c Release -o nu --version-suffix $suffix; dotnet nuget push "nu\*.*$suffix.nupkg" --source localdev; gci nu/ | ri -r; rmdir nu;

# Pack and publish current release to a local feed
dotnet pack -c Release -o nu; dotnet nuget push "nu\*.nupkg" --source localdev; gci nu/ | ri -r; rmdir nu;
```
