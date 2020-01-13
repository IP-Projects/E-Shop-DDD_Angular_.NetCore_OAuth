Open Package Manager Console 
Select Database.Database.SqlServer

Run for initial migration

Add-Migration InitialCreate -Context DatabaseContext -Project Database.SqlServer -StartUpProject Database.SqlServer

For migrations
Add-Migration <name> -Context DatabaseContext -Project Database.SqlServer -StartUpProject Database.SqlServer

For updating database 

Update-Database -Context DatabaseContext -Project Database.SqlServer -StartUpProject Database.SqlServer
