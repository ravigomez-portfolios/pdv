USE master;
CREATE DATABASE POS;
GO

CREATE LOGIN pos   
    WITH PASSWORD = '55564f40$Uuxwp7Mcxo7Khy';
GO  

CREATE USER pos FOR LOGIN pos 
    WITH DEFAULT_SCHEMA = dbo
GO

-- Add user to the database roles you want
EXEC sp_addrolemember 'db_owner', 'pos'  
GO

USE POS;
GRANT CONTROL ON DATABASE::POS TO pos;
GO