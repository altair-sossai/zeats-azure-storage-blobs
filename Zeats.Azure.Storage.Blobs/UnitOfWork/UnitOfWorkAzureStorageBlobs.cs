using System.Threading.Tasks;
using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Zeats.Azure.Storage.Blobs.Extensions;

namespace Zeats.Azure.Storage.Blobs.UnitOfWork;

public class UnitOfWorkAzureStorageBlobs
{
    private readonly BlobServiceClient _blobServiceClient;

    public UnitOfWorkAzureStorageBlobs(string connectionString)
    {
        _blobServiceClient = new BlobServiceClient(connectionString);
    }

    public async Task<BlobContainerClient> CreateBlobContainerIfNotExistsAsync(string blobContainerName, PublicAccessType publicAccessType = PublicAccessType.None)
    {
        return await _blobServiceClient.CreateBlobContainerIfNotExistsAsync(blobContainerName, publicAccessType);
    }

    public BlobContainerClient GetBlobContainerClient(string blobContainerName)
    {
        return _blobServiceClient.GetBlobContainerClient(blobContainerName);
    }

    public AsyncPageable<BlobItem> GetBlobsAsync(string blobContainerName)
    {
        return _blobServiceClient.GetBlobsAsync(blobContainerName);
    }
}