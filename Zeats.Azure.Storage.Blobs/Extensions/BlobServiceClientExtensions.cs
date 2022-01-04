using System.Threading.Tasks;
using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace Zeats.Azure.Storage.Blobs.Extensions;

public static class BlobServiceClientExtensions
{
    public static async Task<BlobContainerClient> CreateBlobContainerIfNotExistsAsync(this BlobServiceClient blobServiceClient, string blobContainerName, PublicAccessType publicAccessType = PublicAccessType.None)
    {
        var blobContainerClient = blobServiceClient.GetBlobContainerClient(blobContainerName);

        if (await blobContainerClient.ExistsAsync())
            return blobContainerClient;

        return await blobServiceClient.CreateBlobContainerAsync(blobContainerName, publicAccessType);
    }

    public static AsyncPageable<BlobItem> GetBlobsAsync(this BlobServiceClient blobServiceClient, string blobContainerName)
    {
        var blobContainerClient = blobServiceClient.GetBlobContainerClient(blobContainerName);

        return blobContainerClient.GetBlobsAsync();
    }
}