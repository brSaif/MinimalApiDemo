CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int
AS
BEGIN
	select Id, FirstName, LastName
	from dbo.[User]
	where [User].Id = @Id;
END
