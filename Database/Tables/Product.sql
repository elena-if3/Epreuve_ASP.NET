CREATE TABLE [dbo].[Product]
(
	[Product_Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [Category_Id] INT NOT NULL, 
    [EcoScore] CHAR(1) NOT NULL, 
    CONSTRAINT [FK_Product_Category] FOREIGN KEY ([Category_Id]) REFERENCES [Category]([Cat_Id]),
    CONSTRAINT [FK_Product_EcoScore] FOREIGN KEY ([EcoScore]) REFERENCES [EcoScore]([EcoScore])
)
