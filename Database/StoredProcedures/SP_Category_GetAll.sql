CREATE PROCEDURE [dbo].[SP_Category_GetAll]
AS
	SELECT	[Cat_Id],
			[CatName],
			[CatDescr]
		FROM [Category]