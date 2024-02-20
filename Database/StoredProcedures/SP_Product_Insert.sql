CREATE PROCEDURE [dbo].[SP_Product_Insert]
    @name NVARCHAR(50),
    @description NVARCHAR(MAX),
    @price MONEY,
    @category_id INT,
    @eco_score CHAR(1)
AS
	INSERT INTO [Product] ([Name],[Description],[Price],[Category_Id],[EcoScore])
        OUTPUT [inserted].[Product_Id]
        VALUES (@name, @description, @price, @category_id, @eco_score)