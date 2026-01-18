CREATE TABLE [dbo].[Trainer]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FullName] NVARCHAR(30) NOT NULL, 
    [Age] INT NOT NULL, 
    [ProfilePicture] NVARCHAR(MAX) NOT NULL, 
    [PhoneNumber] NVARCHAR(20) NOT NULL, 
    [YearsExperience] INT NOT NULL, 
    [PersonalId] NVARCHAR(50) NOT NULL, 
    [UserCredentianlsId] INT NOT NULL 
)
