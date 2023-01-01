using EFCore.SampleProvider.Infrastructure.Internal;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.EntityFrameworkCore.Infrastructure;

public class SampleProviderDbContextOptionsBuilder : RelationalDbContextOptionsBuilder<SampleProviderDbContextOptionsBuilder, SampleProviderOptionsExtension>
{
    public SampleProviderDbContextOptionsBuilder(DbContextOptionsBuilder optionsBuilder)
        : base(optionsBuilder)
    {
    }
}
