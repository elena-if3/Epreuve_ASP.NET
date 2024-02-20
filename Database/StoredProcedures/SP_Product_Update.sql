CREATE PROCEDURE [dbo].[SP_Product_Update]
    @product_id INT,
    @name NVARCHAR(50),
    @description NVARCHAR(MAX),
    @price MONEY,
    @category NVARCHAR(25),
    @eco_score CHAR(1),
    @media_id INT
AS
	UPDATE [Product]
        SET [Name] = @name,
            [Description] = @description,
            [Price] = @price,
            [Category] = @category,
            [EcoScore] = @eco_score,
            [Media_Id] = @media_id
        WHERE [Product_Id] = @product_id