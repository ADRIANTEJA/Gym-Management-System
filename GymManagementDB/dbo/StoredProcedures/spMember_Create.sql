CREATE PROCEDURE [dbo].[spMember_Create]
	@FullName nvarchar(30),
	@Age int,
	@PhoneNumber nvarchar(20),
	@PersonalId nvarchar(50),
	@UserCredentialsId int
AS

BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.Member (FullName, Age, PhoneNumber, PersonalId, UserCredentialsId)
	VALUES (@FullName, @Age, @PhoneNumber, @PersonalId, @UserCredentialsId);

	SELECT * FROM dbo.Member 
	WHERE Id = SCOPE_IDENTITY();
END