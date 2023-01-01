﻿using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Sqlite.Query.Internal;

namespace EFCore.SampleProvider.Query.Internal;

public class SampleProviderMemberTranslatorProvider : RelationalMemberTranslatorProvider
{
    public SampleProviderMemberTranslatorProvider(RelationalMemberTranslatorProviderDependencies dependencies)
    : base(dependencies)
    {
        //TODO: Replace the logic in this ctor.  All was taken from https://github.dev/dotnet/efcore/blob/38f69c6c9a773e3395f507d7e054f40d55962ced/src/EFCore.Sqlite.Core/Query/Internal/SqliteMemberTranslatorProvider.cs#L23-L31
        //      Copying was necessary since SqliteMemberTranslatorProvider's ctor casts dependencies.SqlExpressionFactory to a SqliteSqlExpressionFactory, but ours is a SampleProviderSqlExpressionFactory
        var sqlExpressionFactory = ((SampleProviderSqlExpressionFactory)dependencies.SqlExpressionFactory).SqliteSqlExpressionFactory;

        AddTranslators(
            new IMemberTranslator[]
            {
                new SqliteDateTimeMemberTranslator(sqlExpressionFactory),
                new SqliteStringLengthTranslator(sqlExpressionFactory),
                new SqliteDateOnlyMemberTranslator(sqlExpressionFactory)
            });
    }
}
