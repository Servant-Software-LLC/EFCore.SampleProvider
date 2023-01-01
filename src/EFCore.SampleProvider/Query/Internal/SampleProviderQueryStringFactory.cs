using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Sqlite.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data.Common;

namespace EFCore.SampleProvider.Query.Internal;

public class SampleProviderQueryStringFactory : IRelationalQueryStringFactory
{
	private readonly SqliteQueryStringFactory sqliteQueryStringFactory;

    public SampleProviderQueryStringFactory(IRelationalTypeMappingSource typeMapper)
	{
        sqliteQueryStringFactory = new(typeMapper);
    }

    public virtual string Create(DbCommand command) => sqliteQueryStringFactory.Create(command);
}
