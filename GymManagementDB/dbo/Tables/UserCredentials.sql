CREATE TABLE [dbo].[UserCredentials]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmailAddress] NVARCHAR(50) NOT NULL, 
    [HashedPassword] NVARCHAR(20) NOT NULL
)
