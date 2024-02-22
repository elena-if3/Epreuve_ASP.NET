CREATE PROCEDURE [dbo].[SP_Media_Insert]
	@link NVARCHAR(100),
	@product_id INT
AS
	INSERT INTO [Media] ([Link],[Product_Id])
		OUTPUT [inserted].[Media_Id]
		VALUES (@link, @product_id)