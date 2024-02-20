CREATE PROCEDURE [dbo].[SP_Product_GetByName]
	@name NVARCHAR(50)
AS
	SELECT 	[Product_Id],
            [Name], 
            [Description], 
            [Price], 
            [Category], 
            [EcoScore], 
            [Media_Id]
        FROM [Product]
        WHERE [Name] = @name