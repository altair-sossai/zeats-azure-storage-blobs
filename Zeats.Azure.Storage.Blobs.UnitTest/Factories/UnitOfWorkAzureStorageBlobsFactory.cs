using Microsoft.Extensions.Configuration;
using Zeats.Azure.Storage.Blobs.UnitOfWork;

namespace Zeats.Azure.Storage.Blobs.UnitTest.Factories
{
    public static class UnitOfWorkAzureStorageBlobsFactory
    {
        public static UnitOfWorkAzureStorageBlobs New()
        {
            var configuration = ConfigurationFactory.New();
            var connectionString = configuration.GetValue<string>("AzureWebJobsStorage");

            return new UnitOfWorkAzureStorageBlobs(connectionString);
        }
    }
}