USE [EMPLOYEEDB]
GO

/****** Object:  StoredProcedure [dbo].[SP_GetAllEmployee]    Script Date: 15/04/2020 19:43:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[SP_GetAllEmployee]
as
BEGIN
	select * from Employee
END
GO

