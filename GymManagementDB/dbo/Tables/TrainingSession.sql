CREATE TABLE [dbo].[TrainingSession]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TrainerId] INT NOT NULL, 
    [ScheduleDate] DATETIME2 NOT NULL, 
    [SessionDescription] NVARCHAR(MAX) NULL
)
