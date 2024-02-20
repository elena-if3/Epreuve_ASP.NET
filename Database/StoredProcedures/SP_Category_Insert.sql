CREATE PROCEDURE [dbo].[SP_Category_Insert]
	@new_category NVARCHAR(25)
AS
	INSERT INTO [Category] ([Category])
		OUTPUT [inserted].[Category]
		VALUES (@new_category)
