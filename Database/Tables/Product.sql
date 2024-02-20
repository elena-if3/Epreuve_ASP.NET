CREATE TABLE [dbo].[Product]
(
	[Product_Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [Category] NVARCHAR(25) NOT NULL, 
    [EcoScore] CHAR(1) NOT NULL, 
    [Media_Id] INT NULL, 
    CONSTRAINT [FK_Product_Category] FOREIGN KEY ([Category]) REFERENCES [Category]([Category]),
    CONSTRAINT [FK_Product_EcoScore] FOREIGN KEY ([EcoScore]) REFERENCES [EcoScore]([EcoScore])
)
