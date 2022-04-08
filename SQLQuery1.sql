set ansi_padding on
go
set ansi_nulls on
go
set quoted_identifier on
go



drop database [MVD]
go

create database [MVD]
go
use [MVD]
go


create table [dbo].[Citizen]
(
	[ID_Citizen] [int] not null identity(1,1),
	[Passport_Series_Citizen] [varchar] (4) not null default('1111'),
	[Passport_Number_Citizen] [varchar] (6) not null default('111111'),
	[Birth_Day_Citizen] [date] not null default(getdate()),
	[Date_Of_Issue] [date] not null default(getdate()),
	[Division_Code_Citizen] [varchar] (7) not null default('000-000'),
	[Issued_By_Citizen] [varchar] (max) not null default('Далёкая-далёкая галактика'),
	[Registration_Adress_Citizen] [varchar] (max) not null default('Канава'),
	[First_Name_Citizen] [varchar] (30) not null default('Абоба'),
	[Second_Name_Citizen] [varchar] (30) not null default('Абобиенко'),
	[Middle_Name_Citizen] [varchar] (30) null,
	[Phone_Number_Citizen] [varchar] (16) not null default('+7(000)000-00-00'),
	[Residential_Adress_Citizen] [varchar] (max) not null default('Караганда'),
	[Email_Adress_Citizen] [varchar] (50) null,
	[Citizen_Login] [varchar] (30) not null,
	[Citizen_Password] [varchar] (30) not null


	constraint [PK_Citizen] primary key clustered([ID_Citizen] ASC) on [PRIMARY],
	constraint [UQ_Passport_Series_Citizen] unique ([Passport_Series_Citizen]),
	constraint [CH_Passport_Series_Citizen] check ([Passport_Series_Citizen] like '[0-9][0-9][0-9][0-9]'),
	constraint [UQ_Passport_Number_Citizen] unique ([Passport_Number_Citizen]),
	constraint [CH_Passport_Number_Citizen] check ([Passport_Number_Citizen] like '[0-9][0-9][0-9][0-9][0-9][0-9]'),
	constraint [UQ_Division_Code_Citizen] unique ([Division_Code_Citizen]),
	constraint [CH_Division_Code_Citizen] check ([Division_Code_Citizen] like '[0-9][0-9][0-9]-[0-9][0-9][0-9]'),
	constraint [UQ_Phone_Number_Citizen] unique ([Phone_Number_Citizen]),
	constraint [CH_Phone_Number_Citizen] check ([Phone_Number_Citizen] like '+7([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]'),
	constraint [UQ_Email_Adress_Citizen] unique ([Email_Adress_Citizen]),
	constraint [CH_Email_Adress_Citizen] check ([Email_Adress_Citizen] like '%@%.%'),
	constraint [UQ_Citizen_Login] unique ([Citizen_Login]),
)
go



create table [dbo].[Department]
(
	[ID_Department] [int] not null identity(1,1),
	[Name_Department] [varchar] (50) not null default('Отдел варёных груш')

	constraint [PK_Department] primary key clustered([ID_Department] ASC) on [PRIMARY],
	constraint [UQ_Name_Department] unique ([Name_Department])
)
go



create table[dbo].[Status]
(
	[ID_Status] [int] not null identity(1,1),
	[Name_Status] [varchar] (15) not null default('На рассмотрении')

	constraint [PK_Status] primary key clustered([ID_Status] ASC) on [PRIMARY],
	constraint [CH_Name_Status] check ([Name_status] like 'Закрыто' or [Name_status] like 'Открытое' or [Name_status] like 'На рассмотрении'),
)
go


create table [dbo].[Post]
(
	[ID_Post] [int] not null identity(1,1),
	[Name_Post] [varchar] (32) not null default('Пост')

	constraint [PK_Post] primary key clustered([ID_Post] ASC) on [PRIMARY],
	constraint [UQ_Name_Post] unique ([Name_Post])
)
go

create table [dbo].[Rank]
(
	[ID_Rank] [int] not null identity(1,1),
	[Name_Rank] [varchar] (11) not null default('Звание')

	constraint [PK_Rank] primary key clustered([ID_Rank] ASC) on [PRIMARY],
	constraint [UQ_Name_Rank] unique ([Name_Rank])
)
go


create table [dbo].[Work_Schedule]
(
	[ID_Work_Schedule] [int] not null identity(1,1),
	[Work_Schedule_Description] [varchar] (15) not null default('Без выходных')

	constraint [PK_Work_Schedule] primary key clustered([ID_Work_Schedule] ASC) on [PRIMARY],
	constraint [UQ_Work_Schedule_Description] unique ([Work_Schedule_Description])
)
go


create table [dbo].[Section]
(
	[ID_Section] [int] not null identity(1,1),
	[Section_Name] [varchar] (50) not null default('Заглушка'),
	[Section_Description] [varchar] (300) not null default('Заглушка')

	constraint [PK_Section] primary key clustered([ID_Section] ASC) on [PRIMARY],
	constraint [UQ_Section_Name] unique ([Section_Name]),
	constraint [UQ_Section_Description] unique ([Section_Description])
)
go


create table [dbo].[Service_Weapon_Type]
(
	[ID_Service_Weapon_Type] [int] not null identity(1,1),
	[Service_Weapon_Type_Name] [varchar] (25) not null default('Заглушка'),

	constraint[PK_Service_Weapon_Type] primary key clustered ([ID_Service_Weapon_Type] ASC) on [PRIMARY],
	constraint [UQ_Service_Weapon_Type_Name] unique ([Service_Weapon_Type_Name])
)
go


create table [dbo].[Employee]
(
	[ID_Employee] [int] not null identity(1,1),
	[Employee_Service_Number] [int] not null default('0'),
	[Employee_First_Name] [varchar] (30) not null default('Шлёпа'),
	[Employee_Second_Name] [varchar] (30) not null default('Гигачадович'),
	[Employee_Middle_Name] [varchar] (30) null,
	[Employee_Personal_File_Number] [int] not null default(0),
	[Employee_Date_Of_Admission] [date] not null default(getdate()),
	[Employee_Login] [varchar] (30) not null,
	[Employee_Password] [varchar] (30) not null,
	[Department_ID] [int] not null,
	[Post_ID] [int] not null,
	[Rank_ID] [int] not null,
	[Work_Schedule_ID] [int] not null

	constraint [PK_Employee] primary key clustered([ID_Employee] ASC) on [PRIMARY],
	constraint [UQ_Employee_Service_Number] unique ([Employee_Service_Number]),
	constraint [UQ_Employee_Personal_File_Number] unique ([Employee_Personal_File_Number]),
	constraint [UQ_Employee_Login] unique ([Employee_Login]),
	constraint [UQ_Employee_Password] unique ([Employee_Password]),
	foreign key ([Department_ID]) references [dbo].[Department] ([ID_Department]),
	foreign key ([Post_ID]) references [dbo].[Post] ([ID_Post]),
	foreign key ([Rank_ID]) references [dbo].[Rank] ([ID_Rank]),
	foreign key ([Work_Schedule_ID]) references [dbo].[Work_Schedule] ([ID_Work_Schedule])	
)
go



create table [dbo].[Service_Weapon_Number]
(
	[ID_Service_Weapon_Number] [int] not null identity(1,1),
	[Service_Number] [int] not null default(0),
	[Employee_ID] [int] not null

	constraint [PK_Service_Weapon_Number] primary key clustered([ID_Service_Weapon_Number] ASC) on [PRIMARY],
	constraint [UQ_Service_Number] unique ([Service_Number]),
	foreign key ([Employee_ID]) references [dbo].[Employee] ([ID_Employee])
)
go




create table [dbo].[Appeal]
(
	[ID_Appeal] [int] not null identity(1,1),
	[Appeal_Number] [int] not null default(0),
	[Appeal_Date_Time] [datetime] not null default(getdate()),
	[Appeal_Description] [varchar] (500) not null default('Заглушка'),
	[Citizen_ID] [int] not null,
	[Status_ID] [int] not null,
	[Employee_ID] [int] not null,

	constraint [PK_Appeal] primary key clustered([ID_Appeal] ASC) on [PRIMARY],
	constraint [UQ_Appeal_Number] unique ([Appeal_Number]),
	foreign key ([Citizen_ID]) references [dbo].[Citizen] ([ID_Citizen]),
	foreign key ([Status_ID]) references [dbo].[Status] ([ID_Status]),
	foreign key ([Employee_ID])references [dbo].[Employee] ([ID_Employee])
)
go


create table [dbo].[Case]
(
	[ID_Case] [int] not null identity(1,1),
	[Case_Number] [int] not null default(0),
	[Appeal_ID] [int] not null

	constraint [PK_Case] primary key clustered([ID_Case] ASC) on [PRIMARY],
	constraint [UQ_Case_Number] unique ([Case_Number]),
	foreign key ([Appeal_ID]) references [dbo].[Appeal] ([ID_Appeal])
)
go




create table [dbo].[Investigation_Report] 
(
	[ID_Investigation_Report] [int] not null identity(1,1),
	[Investigation_Report_Number] [int] not null default(0),
	[Investigation_Report_Facts] [varchar](max) null default('Нет данных'),
	[Investigation_Beginning_Date] [date] not null default(getdate()),
	[Investigation_Ending_Date] [date] null,
	[Case_ID] [int] not null

	constraint [PK_Investigation_Report] primary key clustered([ID_Investigation_Report] ASC) on [PRIMARY],
	constraint [UQ_Investigation_Report_Number] unique ([Investigation_Report_Number]),
	foreign key ([Case_ID]) references [dbo].[Case] ([ID_Case])
)
go




create table [dbo].[Appeal_Composition]
(
	[ID_Composition] [int] not null identity(1,1),
	[Appeal_ID] [int] not null,
	[Section_ID] [int] not null

	constraint [PK_Composition] primary key clustered ([ID_Composition] ASC) on [PRIMARY],
	foreign key ([Appeal_ID]) references [dbo].[Appeal] ([ID_Appeal]),
	foreign key ([Section_ID]) references [dbo].[Section] ([ID_Section])
)
go


create table [dbo].[Service_Weapon_Posession]
(
	[ID_Posession] [int] not null identity(1,1),
	[Service_Weapon_Type_ID] [int] not null,
	[Employee_ID] [int] not null

	constraint [PK_Posession] primary key clustered ([ID_Posession] ASC) on [PRIMARY],
	foreign key ([Service_Weapon_Type_ID]) references [dbo].[Service_Weapon_Type] ([ID_Service_Weapon_Type]),
	foreign key ([Employee_ID]) references [dbo].[Employee] ([ID_Employee])
)
go


