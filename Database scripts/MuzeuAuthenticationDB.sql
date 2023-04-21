USE master
GO

DROP DATABASE MuzeuAuthenticationDB
GO

CREATE DATABASE MuzeuAuthenticationDB
GO
USE MuzeuAuthenticationDB
GO

CREATE TABLE UserCredentials
(
	Email VARCHAR(50) PRIMARY KEY,
	Username VARCHAR(50) CONSTRAINT uq_UserCredentials_Username UNIQUE CONSTRAINT nn_UserCredentials_Username NOT NULL,
	UserPassword VARCHAR(50) CONSTRAINT nn_UserCredentials_UserPassword NOT NULL
)

DELETE FROM [MuzeuAuthenticationDB].[dbo].[UserCredentials]

SELECT * FROM [MuzeuAuthenticationDB].[dbo].[UserCredentials]