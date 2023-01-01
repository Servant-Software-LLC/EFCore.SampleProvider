﻿using Microsoft.EntityFrameworkCore.Query;

namespace EFCore.SampleProvider.Query.Internal;

internal class SampleProviderQueryTranslationPostprocessorFactory : IQueryTranslationPostprocessorFactory
{
	public SampleProviderQueryTranslationPostprocessorFactory(
        QueryTranslationPostprocessorDependencies dependencies,
        RelationalQueryTranslationPostprocessorDependencies relationalDependencies)
    {
        Dependencies = dependencies;
        RelationalDependencies = relationalDependencies;
    }

    /// <summary>
    ///     Dependencies for this service.
    /// </summary>
    protected virtual QueryTranslationPostprocessorDependencies Dependencies { get; }

    /// <summary>
    ///     Relational provider-specific dependencies for this service.
    /// </summary>
    protected virtual RelationalQueryTranslationPostprocessorDependencies RelationalDependencies { get; }

    public virtual QueryTranslationPostprocessor Create(QueryCompilationContext queryCompilationContext)
        => new SampleProviderQueryTranslationPostprocessor(
            Dependencies,
            RelationalDependencies,
            queryCompilationContext);
}
