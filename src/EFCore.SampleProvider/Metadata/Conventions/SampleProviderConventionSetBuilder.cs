﻿using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace EFCore.SampleProvider.Metadata.Conventions;

public class SampleProviderConventionSetBuilder : RelationalConventionSetBuilder
{
    private readonly SqliteConventionSetBuilder sqliteConventionSetBuilder;

    public SampleProviderConventionSetBuilder(
        ProviderConventionSetBuilderDependencies dependencies,
        RelationalConventionSetBuilderDependencies relationalDependencies)
        : base(dependencies, relationalDependencies)
    {
        sqliteConventionSetBuilder = new(dependencies, relationalDependencies);
    }

    public override ConventionSet CreateConventionSet() => sqliteConventionSetBuilder.CreateConventionSet();
}
