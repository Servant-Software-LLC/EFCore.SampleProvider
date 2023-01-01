using Microsoft.EntityFrameworkCore.Query;

namespace EFCore.SampleProvider.Query.Internal;

public class SampleProviderQuerySqlGeneratorFactory : IQuerySqlGeneratorFactory
{
	public SampleProviderQuerySqlGeneratorFactory(QuerySqlGeneratorDependencies dependencies)
    {
        Dependencies = dependencies;
    }

    /// <summary>
    ///     Relational provider-specific dependencies for this service.
    /// </summary>
    protected virtual QuerySqlGeneratorDependencies Dependencies { get; }

    public virtual QuerySqlGenerator Create()
        => new SampleProviderQuerySqlGenerator(Dependencies);
}
