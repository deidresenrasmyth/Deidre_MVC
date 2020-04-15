USE [EMPLOYEEDB]
GO

/****** Object:  StoredProcedure [dbo].[SP_UpdateEmployee]    Script Date: 15/04/2020 19:47:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_UpdateEmployee]
(
@EmpId int=0,
@Name varchar(150)='',
@Gender varchar(50)='',
@Company varchar(150)='',
@Departament varchar(150)=''
)
as 
BEGIN
	Update Employee set Name=@Name,Gender=@Gender,Company=@Company,Departament=@Departament where ID=@EmpId
END
GO

