USE [EMPLOYEEDB]
GO

/****** Object:  StoredProcedure [dbo].[SP_GetEmployeeById]    Script Date: 15/04/2020 19:43:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_GetEmployeeById]
(
	@EmpId int=0
)
as 
BEGIN
	select * from Employee where ID=@EmpId
END
GO

