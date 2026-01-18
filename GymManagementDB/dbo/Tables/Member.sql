CREATE TABLE [dbo].[Member]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FullName] NVARCHAR(30) NOT NULL, 
    [Age] INT NOT NULL, 
    [PhoneNumber] NVARCHAR(20) NOT NULL, 
    [PersonalId] NVARCHAR(50) NOT NULL, 
    [UserCredentialsId] INT NOT NULL 
)
