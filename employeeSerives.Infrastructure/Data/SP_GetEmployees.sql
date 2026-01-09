-- =============================================
-- Author:		Aravind Vangari
-- Create date: 01-01-2026
-- Description:	To Get all the Employees Data
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[SP_GetEmployees]
AS
BEGIN
   select * from [dbo].[Employees]
END
GO