CREATE PROCEDURE [dbo].[SP_Product_Update]
    @product_id INT,
    @name NVARCHAR(50),
    @description NVARCHAR(MAX),
    @price MONEY,
    @category_id INT,
    @eco_score CHAR(1)
AS
	UPDATE [Product]
        SET [Name] = @name,
            [Description] = @description,
            [Price] = @price,
            [Category_Id] = @category_id,
            [EcoScore] = @eco_score
        WHERE [Product_Id] = @product_id