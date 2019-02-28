# ConfigurationOptionsExample

In most projects the appsettings.json has sensitive data that should not be uploaded to Github. This project usee IOptions to add data from appsettings.json to the project. 

In order to use appsettings.json data, make sure to  add the nuget package:
dotnet add package Microsoft.Extensions.Configuration.Binder --version 2.2.0
