CREATE PROCEDURE [dbo].[SP_Product_Update]
    @product_id INT,
    @name NVARCHAR(50),
    @description NVARCHAR(1000),
    @price MONEY,
    @category_id INT,
    @ecoscore CHAR(1)
AS
	UPDATE [Product]
        SET [Name] = @name,
            [Description] = @description,
            [Price] = @price,
            [Category_Id] = @category_id,
            [EcoScore] = @ecoscore
        WHERE [Product_Id] = @product_id