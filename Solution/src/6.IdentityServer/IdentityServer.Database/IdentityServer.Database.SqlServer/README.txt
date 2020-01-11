Open Package Manager Console 
Select IdentityServer.Database.SqlServer

Run for initial migration

Add-Migration InitialCreate -Context OidcSqlServerContext -Project IdentityServer.Database.SqlServer -StartUpProject IdentityServer.Database.SqlServer
Add-Migration InitialCreate -Context PersistedGrantDbContext -Project IdentityServer.Database.SqlServer -StartUpProject IdentityServer.Database.SqlServer


For migrations

Add-Migration <name> -Context OidcSqlServerContext -Project IdentityServer.Database.SqlServer -StartUpProject IdentityServer.Database.SqlServer
Add-Migration <name> -Context PersistedGrantDbContext -Project IdentityServer.Database.SqlServer -StartUpProject IdentityServer.Database.SqlServer

For updating database 

Update-Database -Context OidcSqlServerContext -Project IdentityServer.Database.SqlServer -StartUpProject IdentityServer.Database.SqlServer
Update-Database -Context PersistedGrantDbContext -Project IdentityServer.Database.SqlServer -StartUpProject IdentityServer.Database.SqlServer