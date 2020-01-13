Open Package Manager Console 
Select Database.SQLite

Run for initial migration

Add-Migration InitialCreate -Context DatabaseContext -Project Database.SQLite -StartUpProject Database.SQLite

For migrations
Add-Migration <name> -Context DatabaseContext -Project Database.SQLite -StartUpProject Database.SQLite

For updating database 

Update-Database -Context DatabaseContext -Project Database.SQLite -StartUpProject Database.SQLite
