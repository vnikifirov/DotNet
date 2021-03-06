USE [BNKSEEK]
GO
/****** Object:  StoredProcedure [dbo].[uspImportDbf]    Script Date: 10/03/2014 00:55:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: Punit Jain
-- Create date: 02-10-2014
-- Description:	Import data from DBF (Foxpro database) into sql table
-- Edited: Vadim N.
-- Edited date: 10-04-2018
-- =============================================
CREATE PROCEDURE [dbo].[uspImportDataFromDbf] 
	@FolderPath nvarchar(max),
	@FileName nvarchar(max)
AS
BEGIN
	Exec sp_configure 'show advanced options',1
	reconfigure

	Exec sp_configure 'Ad Hoc Distributed Queries', 1
	reconfigure

	
	EXEC(
		'SELECT TOp 10 * 
		FROM OPENROWSET
		(
			''MICROSOFT.JET.OLEDB.4.0'',
			''dBase IV;HDR={0};IMEX=2;DATABASE=' + @FolderPath + ''',
			''SELECT * FROM ' + @FileName + '''
		)'
	)

	Exec sp_configure 'Ad Hoc Distributed Queries', 0
	reconfigure

	Exec sp_configure 'show advanced options',0
	reconfigure
END
