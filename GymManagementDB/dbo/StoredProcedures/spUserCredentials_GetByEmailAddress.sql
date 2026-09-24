CREATE PROCEDURE [dbo].[spUserCredentials_GetByEmailAddress]
	@EmailAddress nvarchar(50)
AS

BEGIN

	SET NOCOUNT ON;

	SELECT * FROM UserCredentials 
	WHERE EmailAddress = @EmailAddress;

END
