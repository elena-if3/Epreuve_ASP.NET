CREATE PROCEDURE [dbo].[SP_Category_GetById]
	@id int
AS
	SELECT	[Cat_Id],
			[CatName],
			[CatDescr]
		FROM [Category]
		WHERE [Cat_Id] = @id