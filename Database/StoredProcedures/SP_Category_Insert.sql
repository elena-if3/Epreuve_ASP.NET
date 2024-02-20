CREATE PROCEDURE [dbo].[SP_Category_Insert]
	@cat_name NVARCHAR(25),
	@cat_descr NVARCHAR(MAX)
AS
	INSERT INTO [Category] ([CatName],[CatDescr])
		OUTPUT [inserted].[Cat_Id]
		VALUES (@cat_name, @cat_descr)
