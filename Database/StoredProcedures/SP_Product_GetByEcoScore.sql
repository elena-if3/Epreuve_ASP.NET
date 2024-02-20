CREATE PROCEDURE [dbo].[SP_Product_GetByEcoScore]
	@eco_score CHAR(1)
AS
	SELECT 	[Product_Id],
            [Name], 
            [Description], 
            [Price], 
            [Category], 
            [EcoScore], 
            [Media_Id]
        FROM [Product]
        WHERE [EcoScore] = @eco_score