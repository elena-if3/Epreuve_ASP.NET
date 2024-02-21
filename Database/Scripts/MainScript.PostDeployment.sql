/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

-- Inserting sample categories
INSERT INTO [dbo].[Category] ([CatName], [CatDescr])
VALUES ('Home & Living', 'Eco-friendly household items'),
       ('Baby & Kids', 'Sustainable products for babies and children'),
       ('Fashion & Textiles', 'Eco-conscious clothing and textiles'),
       ('Eco-Friendly Gifts', 'Fair-trade and environmentally friendly gifts');
GO

-- Inserting sample eco scores
INSERT INTO [dbo].[EcoScore] ([EcoScore])
VALUES ('A'), ('B'), ('C'), ('D'), ('E');
GO

-- Inserting sample products
INSERT INTO [dbo].[Product] ([Name], [Description], [Price], [Category_Id], [EcoScore])
VALUES ('Reusable Bamboo Utensil Set', 'Set of bamboo utensils for eco-friendly dining', 14.99, 1, 'A'),
       ('Organic Cotton Baby Onesie', 'Soft and organic cotton onesie for babies', 19.99, 2, 'C'),
       ('Recycled Paper Notebook', 'Eco-friendly notebook made from recycled paper', 9.99, 4, 'B'),
       ('Upcycled Glass Vase', 'Handcrafted vase made from upcycled glass', 24.99, 1, 'B');
GO
