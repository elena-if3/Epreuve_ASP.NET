CREATE PROCEDURE [dbo].[SP_Product_Insert]
    @name NVARCHAR(50),
    @description NVARCHAR(MAX),
    @price MONEY,
    @category NVARCHAR(25),
    @eco_score CHAR(1),
    @media_id INT
AS
	INSERT INTO [Product] ([Name],[Description],[Price],[Category],[EcoScore],[Media_Id])
        OUTPUT [inserted].[Product_Id]
        VALUES (@name, @description, @price, @category, @eco_score, @media_id)