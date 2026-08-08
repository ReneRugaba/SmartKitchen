using System.Reflection;
using Skoruba.Duende.IdentityServer.Admin.EntityFramework.Configuration.Configuration;
using SqlMigrationAssembly = MyProject.Admin.EntityFramework.SqlServer.Helpers.MigrationAssembly;
using PostgreSQLMigrationAssembly = MyProject.Admin.EntityFramework.PostgreSQL.Helpers.MigrationAssembly;

namespace MyProject.Admin.Configuration;

public static class MigrationAssemblyConfiguration
{
    public static string GetMigrationAssemblyByProvider(DatabaseProviderConfiguration databaseProvider)
    {
        return (databaseProvider.ProviderType switch
        {
            DatabaseProviderType.SqlServer => typeof(SqlMigrationAssembly).GetTypeInfo().Assembly.GetName().Name,
            DatabaseProviderType.PostgreSQL => typeof(PostgreSQLMigrationAssembly).GetTypeInfo()
                .Assembly.GetName()
                .Name,
            _ => throw new ArgumentOutOfRangeException()
        })!;
    }
}
