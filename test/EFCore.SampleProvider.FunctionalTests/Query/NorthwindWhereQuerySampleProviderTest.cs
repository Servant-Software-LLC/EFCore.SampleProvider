﻿using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestUtilities;
using Xunit.Abstractions;

namespace EFCore.SampleProvider.FunctionalTests.Query;

public class NorthwindWhereQuerySampleProviderTest : NorthwindWhereQueryRelationalTestBase<NorthwindQuerySampleProviderFixture<NoopModelCustomizer>>
{
	public NorthwindWhereQuerySampleProviderTest(NorthwindQuerySampleProviderFixture<NoopModelCustomizer> fixture, ITestOutputHelper testOutputHelper)
		:base(fixture)
	{
		ClearLog();
	}


}
