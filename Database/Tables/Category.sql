﻿CREATE TABLE [dbo].[Category]
(
	[Cat_Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [CatName] NVARCHAR(25) NOT NULL, 
    [CatDescr] NVARCHAR(250) NULL
)
