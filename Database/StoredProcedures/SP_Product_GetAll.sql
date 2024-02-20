CREATE PROCEDURE [dbo].[SP_Product_GetAll]
AS
	SELECT 	[Product_Id],
            [Name], 
            [Description], 
            [Price], 
            [Category_Id], 
            [EcoScore]
        FROM [Product]