Open Package Manager Console 
Select Database.Database.SqlServer

Run for initial migration
Add-Migration InitialCreate -Context SqlServerContext -Project Database.SqlServer -StartUpProject Database.SqlServer

For migrations
Add-Migration <name> -Context SqlServerContext -Project Database.SqlServer -StartUpProject Database.SqlServer
Remove-Migration -Context SqlServerContext -Project Database.SqlServer -StartUpProject Database.SqlServer

For updating database 

Update-Database -Context SqlServerContext -Project Database.SqlServer -StartUpProject Database.SqlServer
