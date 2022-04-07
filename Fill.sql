use [MVD]
go

insert into [dbo].[Citizen] ([Passport_Series_Citizen],[Passport_Number_Citizen],[Birth_Day_Citizen],[Date_Of_Issue],[Division_Code_Citizen],[Issued_By_Citizen],[Registration_Adress_Citizen],[First_Name_Citizen],[Second_Name_Citizen],[Middle_Name_Citizen],[Phone_Number_Citizen],[Residential_Adress_Citizen],[Email_Adress_Citizen],[Citizen_Login],[Citizen_Password])
values 
('4787','234331','1971-04-12','2012-07-10','750-801','������� ���������� ��� ������ �� �. ���������','������, �. ���������, ��������� ��., �. 20 ��.110','������������','�����','��������������','+7(908)905-63-11','������, �. �������������, ��������� ��., �. 23 ��.56','root.hour.240@gmail.com','first','1'),
('4123','825755','1990-01-24','2018-11-05','470-398','���������� ���� ������ �� �. ������','������, �. ������, ��������� ��., �. 25 ��.50',	'�����������',	'��������',	'�����������',	'+7(963)523-76-15',	'������, �. �����, ���������������� ��., �. 20 ��.23',	'konstantin38@ya.ru','second','2'),
('4784','187510','1986-09-18','2015-06-16','700-814','����� ������ �� �. ������������','������, �. ������������, ������� ��., �. 7 ��.88','���������','�������','����������','+7(995)749-62-86','������, �. ������, ������� ��., �. 12 ��.40','rostislav34@ya.ru','third','3'),
('4871','941797','1978-03-24','2019-04-01','570-763','������� ���� ������ �� �. ��������','������, �. ��������, ��������� ��., �. 9 ��.193',	'�������',	'�������',	'����������',	'+7(965)567-63-49',	'������, �. ��������, �������� ��., �. 3 ��.188',	'zoya9679@ya.ru','fourth','4'),
('4782','234335','1977-07-21','2016-03-15','300-486','���������� ���� ������ � �. ��������','������, �. ��������, ���������� ��., �. 13 ��.41',	'�����',	'����',	'�����������',	'+7(927)748-78-52',	'������, �. ������, ����� ��., �. 8 ��.207',	'darya34@rambler.ru','fifth','5')
go
insert into [dbo].[Department] ([Name_Department])
values
('�������� �����'),('����� �� ������ ������'),('����� �� ����������� ������������')
go
insert into [dbo].[Status] ([Name_Status])
values ('��������'),('�������'),('�� ������������')
go
insert into [dbo].[Post] ([Name_Post])
values ('������� ������'),('������� �������������� ������'),('������� �������������� ������'),('������� �������������� ������'),('������ �������������� ������')
go
insert into [dbo].[Rank] ([Name_Rank])
values('�������'),('��������'),('���������')
go
insert into [dbo].[Work_Schedule] ([Work_Schedule_Description])
values ('������'),('��� ������'),('��,��,��,��,��')
go
insert into [dbo].[Section] ([Section_Name],[Section_Description])
values ('6.3 ����','������������ ������ �������� ���������� ���������-������������������ ����������, �� ������� ������������� ���������������'),
('158.1 ���������� ������� ��','��������� ��������������� �� ������ �������'),
('20.1 ������� ���������� ���������','�� ������ ����������� �������20.1�������� ���������� ��������� �� ���������������� ��������������� ������������� ��������� � ���� ����������������� ������ � ������� �� 500 �� 1000 ���.'),
('6.4 ����','��������� ���������-������������������ ���������� � ������������ ����� ��������� � ������������ ���������, ������, ���������� � ���������� �������� ��������������� � ���� ����������������� ������ �� ���������� ��� � ������� �� 500 �� 1 000 ������.')
go
insert into [dbo].[Service_Weapon_Type] ([Service_Weapon_Type_Name])
values ('��74�'),('���������')
go
insert into [dbo].[Employee] ([Employee_Service_Number],[Employee_First_Name],[Employee_Second_Name],[Employee_Middle_Name],[Employee_Personal_File_Number],[Employee_Date_Of_Admission],[Department_ID],[Post_ID],[Rank_ID],[Work_Schedule_ID],[Employee_Password],[Employee_Login])
values
(35,'�������','���������','�����������',1029850106,'2020-03-04',1,1,1,1,'6','a'),
(323,'�������','�����','��������',1050930316,'2016-11-02',1,1,1,2,'7','b'),
(123,'���������','���','����������',1013503093,	'2020-10-06',1,1,2,3,'8','c'),
(32,'�������','����','����������',1058807997,'2017-01-01',1,2,2,1,'9','d'),
(54,'���������','��������','����������',1040219748,'2017-04-26',1,3,3,2,'10','e')
go
insert into [dbo].[Service_Weapon_Number] ([Service_Number],[Employee_ID])
values
(8784732,1),
(4324324,2),
(7867800,3),
(9704231,4),
(4783264,5)
go

insert into [dbo].[Appeal] ([Appeal_Number],[Appeal_Date_Time],[Appeal_Description],[Citizen_ID],[Status_ID],[Employee_ID])
values
(5204830,	'2020-02-02T12:30:00.000','������ ������� ������ ����� �� �����',1,1,1),
(4286441,	'2020-01-28T14:50:00.000','������ ������ � ���������',2,1,2),
(7776009,	'2020-01-29T09:00:00.000',	'�������� ����������� ���� �������',3,2,3),
(8996084,	'2020-01-26T13:48:00.000',	'����� �� ����� ������� ������� ��������� ������, ��� �� ���� ������������',4,2,4),
(7459968,	'2020-01-14T18:17:00.000',	'�������� ��������� ������ *****',	5,	3,	5)
go
insert into [dbo].[Case] ([Case_Number],[Appeal_ID])
values
(2432432,1),
(4324423,2),
(2342344,3),
(3243244,4),
(4353455,5)
go
insert into [dbo].[Investigation_Report] ([Investigation_Report_Number],[Investigation_Report_Facts],[Investigation_Beginning_Date],[Investigation_Ending_Date],[Case_ID])
values
(105174827,null, '2022-02-03',null,1),
(101158951,null,	'2022-01-29',null,	2),
(101158952,'�� ������� � ����� ��������, ��� ������ �������� � ������������������, ������� � ������ ��������',	'2022-01-30',	'2022-02-04',	3),
(108892461,	'�����������, ��� �� � ���� �� ������� �� ����� ��� ��������� ������ �������. �������� ��������� ���� ������ � ������ ������','2022-01-27',	'2022-01-29',	4),
(109365464,	'������� ����������������� ��������','2022-01-15','',	5)
go
insert into [dbo].[Appeal_Composition]([Appeal_ID],[Section_ID])
values
(1,1),
(2,2),
(3,3),
(4,4),
(5,3)
go
insert into [dbo].[Service_Weapon_Posession]([Service_Weapon_Type_ID],[Employee_ID])
values
(1,1),
(1,2),
(1,3),
(1,4),
(2,5)
go
