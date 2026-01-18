CREATE TABLE [dbo].[Schedule]
(
	[MemberId] INT NOT NULL, 
    [TrainingSessionId] INT NOT NULL, 
    CONSTRAINT [FK_Schedule_ToMember] FOREIGN KEY ([MemberId]) REFERENCES [Member](id), 
    CONSTRAINT [FK_Schedule_ToTrainingSession] FOREIGN KEY ([TrainingSessionId]) REFERENCES [TrainingSession](id) 
)
