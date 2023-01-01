using EFCore.SampleProvider.Extensions;
using EFCore.SampleProvider.FunctionalTests.TestUtilities;
using Microsoft.EntityFrameworkCore.TestUtilities;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore.SampleProvider.FunctionalTests;

public class SampleProviderTestStoreFactory : RelationalTestStoreFactory
{
    public static SampleProviderTestStoreFactory Instance { get; } = new SampleProviderTestStoreFactory();

    public override TestStore Create(string storeName)
        => SampleProviderTestStore.Create(storeName);

    public override TestStore GetOrCreate(string storeName)
        => SampleProviderTestStore.GetOrCreate(storeName);

    public override IServiceCollection AddProviderServices(IServiceCollection serviceCollection)
        => serviceCollection.AddEntityFrameworkSampleProvider();
}
