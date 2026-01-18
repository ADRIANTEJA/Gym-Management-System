CREATE TABLE [dbo].[UserCredentials]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmailAddress] NVARCHAR(30) NOT NULL, 
    [Password] NVARCHAR(20) NOT NULL
)
