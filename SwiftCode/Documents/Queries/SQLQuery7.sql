USE [BNKSEEK]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[uspImportDataFromDbf]
		@FolderPath = N'C:\Users\nikif\Google Drive\1. TODO\!center-bank\docs\workspace\',
		@FileName = N'PZN.DBF'

SELECT	'Return Value' = @return_value

GO
