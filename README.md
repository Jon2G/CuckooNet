# CuckooNet - A full implementation of the Cuckoo Sandbox Rest 2.0.7 API 
 

[![NuGet](https://img.shields.io/nuget/v/Cuckoo.Net.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Cuckoo.Net/)

### Features

* Modular
* Response objectes mapped to C# objects
* Fully asynchronous API
* Take a look at the Cuckoo API documentation [https://developers.virustotal.com/reference for the VT API documentation (https://cuckoo.readthedocs.io/en/latest/usage/api)

### Example

```csharp
CuckooAPI api = new Cuckoo.Net.CuckooAPI("http://localhost:8090", "<Your API Key>");

//Get Cuckoo status
Response<CuckooStatus> status = await api.Cuckoo.Status();
Console.WriteLine($"Hostname is:{status.Content.HostName}"); 

```
