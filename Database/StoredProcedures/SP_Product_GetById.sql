CREATE PROCEDURE [dbo].[SP_Product_GetById]
	@id INT
AS
	SELECT 	[Product_Id],
            [Name], 
            [Description], 
            [Price], 
            [Category], 
            [EcoScore], 
            [Media_Id]
        FROM [Product]
        WHERE [Product_Id] = @id