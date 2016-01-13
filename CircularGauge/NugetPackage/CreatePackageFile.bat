mkdir Lib
mkdir Lib\Net40-Client
copy "..\CircularGauge\Bin\Release\CircularGauge.dll" "Lib\Net40-Client\CircularGauge.dll"
nuget pack CircularGauge.nuspec