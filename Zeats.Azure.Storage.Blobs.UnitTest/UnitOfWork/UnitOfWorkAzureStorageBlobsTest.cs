using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeats.Azure.Storage.Blobs.UnitOfWork;
using Zeats.Azure.Storage.Blobs.UnitTest.Factories;

namespace Zeats.Azure.Storage.Blobs.UnitTest.UnitOfWork;

[TestClass]
public class UnitOfWorkAzureStorageBlobsTest
{
    private UnitOfWorkAzureStorageBlobs _unitOfWork;

    [TestInitialize]
    public void Initialize()
    {
        _unitOfWork = UnitOfWorkAzureStorageBlobsFactory.New();
    }

    [TestMethod]
    public async Task CreateBlobContainerAsync()
    {
        var blobContainerClient = await _unitOfWork.CreateBlobContainerIfNotExistsAsync("unit-test");

        Assert.IsNotNull(blobContainerClient);
    }

    [TestMethod]
    public async Task GetBlobContainerClient()
    {
        var blobContainerClient = _unitOfWork.GetBlobContainerClient("unit-test");

        Assert.IsNotNull(blobContainerClient);
        Assert.IsTrue(await blobContainerClient.ExistsAsync());
    }

    [TestMethod]
    public async Task GetBlobsAsync()
    {
        await foreach (var blobItem in _unitOfWork.GetBlobsAsync("unit-test"))
            Assert.IsNotNull(blobItem);
    }
}