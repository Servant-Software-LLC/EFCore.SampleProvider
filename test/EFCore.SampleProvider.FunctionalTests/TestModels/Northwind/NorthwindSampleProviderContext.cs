using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.TestModels.Northwind;

namespace EFCore.SampleProvider.FunctionalTests.TestModels.Northwind;

public class NorthwindSampleProviderContext : NorthwindRelationalContext
{
	public NorthwindSampleProviderContext(DbContextOptions options)
        : base(options)
    {

	}
}
