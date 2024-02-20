CREATE PROCEDURE [dbo].[SP_Product_GetByCategory]
	@category_id INT
AS
	SELECT 	[Product_Id],
            [Name], 
            [Description], 
            [Price], 
            [Category_Id], 
            [EcoScore]
        FROM [Product]
        WHERE [Category_Id] = @category_id