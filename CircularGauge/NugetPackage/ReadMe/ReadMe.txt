========================================================
Steps to update Nuget Package
========================================================

1. Get latest and build the project in release mode
2. Make any required edits to the CircularGauge.nuspec file
3. Run the CreatePackageFile.bat as Administrator
	a) Copies over the required assembly to the Nuget package folder
	b) Build the Nuget Package file
4. Upload CircularGauge.1.0.0.nupkg to Nuget by running PushPackageFile.bat as Administrator
	a) First edit this file as it will require your nuget API Key
	b) Or Drop me an email to upload