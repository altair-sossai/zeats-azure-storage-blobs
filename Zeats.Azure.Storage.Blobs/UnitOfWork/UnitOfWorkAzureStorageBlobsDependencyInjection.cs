using Microsoft.Extensions.DependencyInjection;

namespace Zeats.Azure.Storage.Blobs.UnitOfWork;

public static class UnitOfWorkAzureStorageBlobsDependencyInjection
{
    public static IServiceCollection AddUnitOfWorkAzureStorageBlobs(this IServiceCollection serviceCollection, string connectionString)
    {
        serviceCollection
            .AddScoped(s => new UnitOfWorkAzureStorageBlobs(connectionString));

        return serviceCollection;
    }
}