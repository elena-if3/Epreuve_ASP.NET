CREATE PROCEDURE [dbo].[SP_Product_Delete]
	@product_id int
AS
	DELETE FROM [Product]
		WHERE [Product_Id] = @product_id
