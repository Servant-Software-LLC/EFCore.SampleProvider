# EFCore.SampleProvider
The goal of this repo is to provide to the EFCore community the absolute minimal code needed in order to produce an **EF Core Provider** that is external to the EFCore repo.  In order to avoid the complexities that lie within a provider, this provider with just be a wrapper around the [SQLite in-memory EFCore Provider](https://learn.microsoft.com/en-us/ef/core/testing/choosing-a-testing-strategy#sqlite-as-a-database-fake).  In effect then, the code within this repo becomes simply the API surface required for an EFCore provider.   

This hopefully will (at least partially) address the open issue https://github.com/dotnet/EntityFramework.Docs/issues/681 
