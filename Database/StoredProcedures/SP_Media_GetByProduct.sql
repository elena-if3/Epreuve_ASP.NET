CREATE PROCEDURE [dbo].[SP_Media_GetByProduct]
	@product_id INT
AS
	SELECT	[Media_Id],
			[Link],
			[Product_Id]
		FROM [Media]
		WHERE [Product_Id] = @product_id