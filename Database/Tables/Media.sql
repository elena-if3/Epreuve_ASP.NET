CREATE TABLE [dbo].[Media]
(
	[Media_Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [Link] NVARCHAR(100) NOT NULL, 
    [Product_Id] INT NULL, 
    CONSTRAINT [FK_Media_Product] FOREIGN KEY ([Product_Id]) REFERENCES [Product]([Product_Id])
)
