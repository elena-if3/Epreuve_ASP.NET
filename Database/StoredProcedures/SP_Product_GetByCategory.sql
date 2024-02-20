CREATE PROCEDURE [dbo].[SP_Product_GetByCategory]
	@category NVARCHAR(25)
AS
	SELECT 	[Product_Id],
            [Name], 
            [Description], 
            [Price], 
            [Category], 
            [EcoScore], 
            [Media_Id]
        FROM [Product]
        WHERE [Category] = @category