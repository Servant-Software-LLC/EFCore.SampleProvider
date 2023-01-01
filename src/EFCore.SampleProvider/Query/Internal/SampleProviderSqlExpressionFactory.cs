﻿using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Sqlite.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore.SampleProvider.Query.Internal;

public class SampleProviderSqlExpressionFactory : SqlExpressionFactory
{
    public SampleProviderSqlExpressionFactory(SqlExpressionFactoryDependencies dependencies)
        : base(dependencies)
    {
        SqliteSqlExpressionFactory = new(dependencies);
    }

    public SqliteSqlExpressionFactory SqliteSqlExpressionFactory { get; }

    public override SqlExpression? ApplyTypeMapping(SqlExpression? sqlExpression, RelationalTypeMapping? typeMapping) 
        => SqliteSqlExpressionFactory.ApplyTypeMapping(sqlExpression, typeMapping);
}
