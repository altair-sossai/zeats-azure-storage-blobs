using Zeats.Azure.Storage.Blobs.UnitOfWork;

namespace Zeats.Azure.Storage.Blobs.UnitTest.Factories
{
    public static class UnitOfWorkAzureStorageBlobsFactory
    {
        public static UnitOfWorkAzureStorageBlobs New()
        {
            const string connectionString = "DefaultEndpointsProtocol=https;AccountName=zeatslauncherstorage;AccountKey=Rv7HvqP9C2u3RYBMw0OhLIrHQJvyz3Ae9Yuz8233geDkdtyYdGDWpM74uu6mqRfF0+h0TX5jX27l0cTn9fok+g==;EndpointSuffix=core.windows.net";

            return new UnitOfWorkAzureStorageBlobs(connectionString);
        }
    }
}