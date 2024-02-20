CREATE PROCEDURE [dbo].[SP_Product_GetById]
	@id INT
AS
	SELECT 	[Product_Id],
            [Name], 
            [Description], 
            [Price], 
            [Category_Id], 
            [EcoScore]
        FROM [Product]
        WHERE [Product_Id] = @id