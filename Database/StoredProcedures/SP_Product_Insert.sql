CREATE PROCEDURE [dbo].[SP_Product_Insert]
    @name NVARCHAR(50),
    @description NVARCHAR(1000),
    @price MONEY,
    @category_id INT,
    @ecoscore CHAR(1)
AS
	INSERT INTO [Product] ([Name],[Description],[Price],[Category_Id],[EcoScore])
        OUTPUT [inserted].[Product_Id]
        VALUES (@name, @description, @price, @category_id, @ecoscore)