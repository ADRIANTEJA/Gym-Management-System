CREATE PROCEDURE [dbo].[spUserCredentials_GetById]
	@Id int
AS

BEGIN

	SET NOCOUNT ON;

	SELECT * FROM dbo.UserCredentials
	WHERE Id = @Id;

END
