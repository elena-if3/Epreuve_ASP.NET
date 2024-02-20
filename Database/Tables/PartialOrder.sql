CREATE TABLE [dbo].[PartialOrder]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [Product_Id] INT NOT NULL, 
    [Amount] INT NOT NULL, 
    CONSTRAINT [FK_PartialOrder_Product] FOREIGN KEY ([Product_Id]) REFERENCES [Product]([Product_Id])
)
