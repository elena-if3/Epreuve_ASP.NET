CREATE PROCEDURE [dbo].[SP_Product_GetAll]
AS
	SELECT 	[Product_Id],
            [Name], 
            [Description], 
            [Price], 
            [Category], 
            [EcoScore], 
            [Media_Id]
        FROM [Product]