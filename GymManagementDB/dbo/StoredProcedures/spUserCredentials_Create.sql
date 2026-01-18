CREATE PROCEDURE [dbo].[spUserCredentials_Create]
	@EmailAddress nvarchar(30),
	@Password nvarchar(20)

AS

BEGIN 

	SET NOCOUNT ON;

	INSERT INTO dbo.UserCredentials (EmailAddress, [Password])
	VALUES (@EmailAddress, @Password)

END
