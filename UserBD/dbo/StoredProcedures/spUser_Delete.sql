CREATE PROCEDURE [dbo].[spUser_Delete]
	@Id int
AS
BEGIN
	Delete
	from dbo.[User]
	where [User].Id = @Id;
END
