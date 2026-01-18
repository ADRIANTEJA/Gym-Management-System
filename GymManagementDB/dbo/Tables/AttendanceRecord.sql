CREATE TABLE [dbo].[AttendanceHistory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MemberId] INT NOT NULL, 
    [MemberFullName] NVARCHAR(30) NOT NULL, 
    [DateAndTime] DATETIME2 NOT NULL, 
    [IsSchedule] TINYINT NOT NULL, 
    CONSTRAINT [FK_AttendanceHistory_ToMember] FOREIGN KEY ([MemberId]) REFERENCES [Member](Id)
)
