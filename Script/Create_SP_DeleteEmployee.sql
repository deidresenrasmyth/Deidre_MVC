USE [EMPLOYEEDB]
GO

/****** Object:  StoredProcedure [dbo].[SP_DeleteEmployee]    Script Date: 15/04/2020 19:42:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_DeleteEmployee]
(
	@EmpId int=0
)
as 
BEGIN
	Delete from Employee where ID=@EmpId
END
GO

