CREATE PROCEDURE [dbo].[spMember_Create]
	@FullName nvarchar(30),
	@Age int,
	@PhoneNumber nvarchar(20),
	@PersonalId nvarchar(50)
AS

BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.Member (FullName, Age, PhoneNumber, PersonalId)
	VALUES (@FullName, @Age, @PhoneNumber, @PersonalId);

END