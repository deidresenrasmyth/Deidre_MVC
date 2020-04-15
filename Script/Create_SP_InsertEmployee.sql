USE [EMPLOYEEDB]
GO

/****** Object:  StoredProcedure [dbo].[SP_InsertEmployee]    Script Date: 15/04/2020 19:47:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_InsertEmployee]
(
@Name varchar(150)='',
@Gender varchar(50)='',
@Company varchar(150)='',
@Departament varchar(150)=''
)
as 
BEGIN
	insert into Employee (Name, Gender, Company, Departament)
	values (@Name,@Gender,@Company,@Departament)
END
GO

