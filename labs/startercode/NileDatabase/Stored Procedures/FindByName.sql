CREATE PROCEDURE [dbo].[FindByName]
	@name NVARCHAR(255)
AS BEGIN
    SET NOCOUNT ON;

	SET @name = LTRIM(RTRIM(ISNULL(@name, '')))

	SELECT Id, Name, Price, Description, IsDiscontinued
    FROM Products
    WHERE Name = @name
END
