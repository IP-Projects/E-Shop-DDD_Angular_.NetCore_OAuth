Open Package Manager Console 
Select Database.SQLite

Run for initial migration

Add-Migration InitialCreate -Context SqLiteContext -Project Database.SQLite -StartUpProject Database.SQLite

For migrations
Add-Migration <name> -Context SqLiteContext -Project Database.SQLite -StartUpProject Database.SQLite
Remove-Migration -Context SqLiteContext -Project Database.SqlServer -StartUpProject Database.SqlServer

For updating database 

Update-Database -Context SqLiteContext -Project Database.SQLite -StartUpProject Database.SQLite
