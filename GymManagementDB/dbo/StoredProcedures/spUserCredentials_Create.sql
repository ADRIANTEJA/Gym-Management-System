CREATE PROCEDURE [dbo].[spUserCredentials_Create]
	@EmailAddress nvarchar(50),
	@HashedPassword nvarchar(20),
	@Id int OUTPUT

AS

BEGIN 

	SET NOCOUNT ON;

	INSERT INTO dbo.UserCredentials (EmailAddress, HashedPassword)
	VALUES (@EmailAddress, @HashedPassword);

    SET @Id = SCOPE_IDENTITY();
END
