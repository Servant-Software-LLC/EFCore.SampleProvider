using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Sqlite.Metadata.Internal;

namespace EFCore.SampleProvider.Metadata.Internal;

public class SampleProviderAnnotationProvider : RelationalAnnotationProvider
{
    private readonly SqliteAnnotationProvider sqliteAnnotationProvider;

    public SampleProviderAnnotationProvider(RelationalAnnotationProviderDependencies dependencies)
    : base(dependencies)
    {
        sqliteAnnotationProvider = new(dependencies);
    }

    public override IEnumerable<IAnnotation> For(IRelationalModel model, bool designTime) => sqliteAnnotationProvider.For(model, designTime);

    public override IEnumerable<IAnnotation> For(IColumn column, bool designTime) => sqliteAnnotationProvider.For(column, designTime);
}
