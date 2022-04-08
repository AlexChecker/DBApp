use [MVD]
go


select name from SYSOBJECTS where xtype='U'
go
select * from master.sys.server_principals
go

select * from Citizen

select * from Citizen where Division_Code_Citizen not like '%6%'
go
--Определить уникальность столбца в таблице
SELECT CONSTRAINT_TYPE
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc 
    inner join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE cu 
        on cu.CONSTRAINT_NAME = tc.CONSTRAINT_NAME 
where 
    tc.TABLE_NAME = 'Citizen'
    and cu.COLUMN_NAME = 'Citizen_Password'
	go

	select DATA_TYPE, COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'Employee' order by COLUMN_NAME ASC
	go
	select DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'Employee' and COLUMN_NAME='Employee_Login' order by COLUMN_NAME ASC
	go
	SELECT CONSTRAINT_TYPE,COLUMN_NAME
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc 
    inner join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE cu 
        on cu.CONSTRAINT_NAME = tc.CONSTRAINT_NAME 
where 
    tc.TABLE_NAME = 'Citizen'
	go
select * from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'Citizen' order by COLUMN_NAME ASC
go

select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'Citizen' order by COLUMN_NAME ASC
go

update Citizen set Email_Adress_Citizen=null where ID_Citizen=2
go

select * from Employee where Employee_Service_Number!=35
go

select * from Citizen where Email_Adress_Citizen is null
go

select * from Employee where Employee_Service_Number is null
go

select * from [dbo].[Citizen]
go
select * from[dbo].[Department]
go
select * from[dbo].[Status]
go
select * from[dbo].[Post]
go
select * from[dbo].[Rank]
go
select * from[dbo].[Work_Schedule]
go
select * from[dbo].[Section]
go
select  Section_Name from Section order by [ID_Section] ASC
go
select * from[dbo].[Service_Weapon_Type]
go
select * from[dbo].[Employee]
go
select * from[dbo].[Service_Weapon_Number]
go
select * from[dbo].[Appeal]
go
select * from[dbo].[Case]
go
select * from[dbo].[Investigation_Report]
go
select * from[dbo].[Appeal_Composition]
go
select * from[dbo].[Service_Weapon_Posession]
go
