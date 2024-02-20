CREATE PROCEDURE [dbo].[SP_PartialOrder_GetAll]
AS
	SELECT	[Id],
			[Product_Id],
			[Amount]
	FROM [PartialOrder]