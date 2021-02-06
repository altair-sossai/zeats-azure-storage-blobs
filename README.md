<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-azure-storage-blobs

Extensions to facilitate AutoMapper use

[![Build Status](https://dev.azure.com/zeats/Zeats/_apis/build/status/build-zeats-azure-storage-blobs?branchName=master)](https://dev.azure.com/zeats/Zeats/_build/latest?definitionId=45&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Azure.Storage.Blobs.svg)](https://www.nuget.org/packages/Zeats.Azure.Storage.Blobs)

## Installation

```PM>
dotnet add package Zeats.Azure.Storage.Blobs 
```

## Extensions

### GetBlobsAsync(serviceClient, blobContainerName)
Extension designed to make it easier to write code for using Azure object storage.

See the following example:
```c#
public static AsyncPageable<BlobItem> GetBlobsAsync(this BlobServiceClient blobServiceClient, string blobContainerName)
{
    var blobContainerClient = blobServiceClient.GetBlobContainerClient(blobContainerName);

    return blobContainerClient.GetBlobsAsync();
}
```
---
