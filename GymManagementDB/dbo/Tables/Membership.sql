CREATE TABLE [dbo].[Membership]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MemberId] INT NOT NULL, 
    [ExpeditionDate] DATETIME2 NOT NULL, 
    [ExpirationDate] DATETIME2 NOT NULL, 
    [BillAmount] MONEY NOT NULL, 
    [Status] NVARCHAR(10) NOT NULL, 
    [Type] NVARCHAR(10) NOT NULL, 
    CONSTRAINT [FK_Membership_ToMember] FOREIGN KEY ([MemberId]) REFERENCES [Member](Id)
)
