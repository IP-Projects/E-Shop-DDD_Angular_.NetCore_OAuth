Open Package Manager Console 
Select IdentityServer.Database.SqLite

Run for initial migration

Add-Migration InitialCreate -Context OidcSqLiteContext -Project IdentityServer.Database.SqLite -StartUpProject IdentityServer.Database.SqLite
Add-Migration InitialCreate -Context PersistedGrantDbContext -Project IdentityServer.Database.SqLite -StartUpProject IdentityServer.Database.SqLite


For migrations
Add-Migration <name> -Context OidcSqLiteContext -Project IdentityServer.Database.SqLite -StartUpProject IdentityServer.Database.SqLite
Add-Migration <name> -Context PersistedGrantDbContext -Project IdentityServer.Database.SqLite -StartUpProject IdentityServer.Database.SqLite

For updating database 

Update-Database -Context OidcSqLiteContext -Project IdentityServer.Database.SqLite -StartUpProject IdentityServer.Database.SqLite
Update-Database -Context PersistedGrantDbContext -Project IdentityServer.Database.SqLite -StartUpProject IdentityServer.Database.SqLite