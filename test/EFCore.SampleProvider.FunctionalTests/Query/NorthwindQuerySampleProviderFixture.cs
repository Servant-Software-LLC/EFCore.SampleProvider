using EFCore.SampleProvider.FunctionalTests.TestModels.Northwind;
using EFCore.SampleProvider.FunctionalTests.TestUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestModels.Northwind;
using Microsoft.EntityFrameworkCore.TestUtilities;

namespace EFCore.SampleProvider.FunctionalTests.Query;

public class NorthwindQuerySampleProviderFixture<TModelCustomizer> : NorthwindQueryRelationalFixture<TModelCustomizer>
        where TModelCustomizer : IModelCustomizer, new()
{
    protected override ITestStoreFactory TestStoreFactory => SampleProviderNorthwindTestStoreFactory.Instance;

    protected override void OnModelCreating(ModelBuilder modelBuilder, DbContext context)
    {
        base.OnModelCreating(modelBuilder, context);

        // NB: SQLite doesn't support decimal very well. Using double instead
        modelBuilder.Entity<OrderDetail>().Property(o => o.UnitPrice).HasConversion<double>();
        modelBuilder.Entity<Product>().Property(o => o.UnitPrice).HasConversion<double?>();
    }

    protected override Type ContextType
        => typeof(NorthwindSampleProviderContext);
}
