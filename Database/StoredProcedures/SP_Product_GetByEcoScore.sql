CREATE PROCEDURE [dbo].[SP_Product_GetByEcoScore]
	@eco_score CHAR(1)
AS
	SELECT 	[Product_Id],
            [Name], 
            [Description], 
            [Price], 
            [Category_Id], 
            [EcoScore]
        FROM [Product]
        WHERE [EcoScore] = @eco_score