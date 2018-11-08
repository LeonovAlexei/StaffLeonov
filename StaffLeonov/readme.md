1.Создать БД с именем StaffLeonov

2.Создать таблицы:
CREATE TABLE [dbo].[Address]
 (
    [IdAddress]            INT           NOT NULL,
    [idAddressType] INT  NOT NULL,
    [Address]       VARCHAR (MAX) COLLATE Cyrillic_General_CI_AS NULL,
    [IdEmployee] INT NOT NULL, 
    CONSTRAINT [PK_Address] PRIMARY KEY ([IdAddress]) 
);
CREATE TABLE [dbo].[AddressType]
 (
    [idAddressType]              INT          NOT NULL,
    [NameAddressType] VARCHAR (15) COLLATE Cyrillic_General_CI_AS NOT NULL, 
    CONSTRAINT [PK_AddressType] PRIMARY KEY ([idAddressType])
);
CREATE TABLE [dbo].[Departments]
(
	[IdDepartment] INT NOT NULL , 
    [DepartmentName] VARCHAR(100) COLLATE Cyrillic_General_CI_AS NULL,
	[DepartmentPhoneNumber] VARCHAR(15) NULL,
	[DepartmentHead] INT NULL, 
    [IdEmployee] INT NULL, 
    CONSTRAINT [PK_Departments] PRIMARY KEY ([IdDepartment]) 
)
CREATE TABLE [dbo].[Employee] 
(
    [IdEmployee]           INT          NOT NULL,
    [LastName]     VARCHAR (50) COLLATE Cyrillic_General_CI_AS NULL,
    [FirstName]    VARCHAR (50) COLLATE Cyrillic_General_CI_AS NULL,
    [Patronymic]   VARCHAR (50) COLLATE Cyrillic_General_CI_AS NULL,
    [Birthday]     VARCHAR (50) COLLATE Cyrillic_General_CI_AS NULL,
    [PolicyNumber] VARCHAR (50) NULL,
    [IdPassport] INT NULL, 
    [IdDepartment] INT NULL, 
    [IdAddress] INT NULL, 
    CONSTRAINT [PK_Employee] PRIMARY KEY ([IdEmployee]) 
);

CREATE TABLE [dbo].[Passports] 
(
    [IdPassport]                  INT           NOT NULL,
    [PassportSerNum]      VARCHAR (15)  NULL,
    [PassportDateOfIssue] VARCHAR (10)  NULL,
    [PassporIssuedBy]     VARCHAR (MAX) COLLATE Cyrillic_General_CI_AS NULL,
    [IdEmployee] INT NOT NULL, 
    [IdAddress] INT NOT NULL, 
    CONSTRAINT [PK_Passports] PRIMARY KEY ([IdPassport]) 
);

INSERT INTO AddressType (idAddressType, NameAddressType) VALUES ('1', N'Проживания')
INSERT INTO AddressType (idAddressType, NameAddressType) VALUES ('2', N'Рождения')
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (1, N'Руководство', N'111', 1, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (2, N'Административный отдел', N'222', 2, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (3, N'Отдел закупок', N'333', 3, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (4, N'Отдел продаж', N'444', 4, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (5, N'Бухгалтерия', N'555', 5, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (6, N'Хозяйственный отдел', N'666', 6, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (7, N'Отдел рекламы', N'777', 7, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (8, N'Отдел рекламаций', N'888', 8, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (9, N'Отдел поддержки пользователей', N'999', 9, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (10, N'Транспортный отдел', N'011', 10, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (11, N'Отдел кадров', N'012', 11, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (12, N'Отдел финансов', N'013', 12, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (13, N'Отдел логистики', N'014', 13, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (14, N'Отдел ИТ', N'015', 14, 5)
INSERT INTO [dbo].[Departments] ([IdDepartment], [DepartmentName], [DepartmentPhoneNumber], [DepartmentHead], [IdEmployee]) VALUES (15, N'Отдел развития', N'016', 15, 5)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (1, N'Богданов', N'Владислав', N'Алексеевич', N'16.06.1943', N'105-494-409-01', 17, 2, 1)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (2, N'Зименко', N'Ирина', N'Георгиевна', N'25.10.1951', N'073-228-398-03', 16, 2, 3)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (3, N'Калугина', N'Алла', N'Ивановна', N'13.11.1977', N'105-494-409-01', 15, 1, 5)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (4, N'Васильева', N'Татьяна', N'Викторовна', N'12.03.1985', N'105-494-409-05', 14, 3, 7)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (5, N'Леонов', N'Алексей', N'Александрович', N'12.11.1946', N'006-859-387-08', 13, 8, 9)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (6, N'Купина', N'Юлия', N'Викторовна', N'17.06.1957', N'105-494-409-01', 12, 5, 11)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (7, N'Стеблевская', N'Илона', N'Вячеславовна', N'25.10.1951', N'073-228-398-03', 11, 8, 13)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (8, N'Поторочина', N'Наталья', N'Викторовна', N'12.03.1985', N'006-859-387-10', 10, 4, 15)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (9, N'Томилин', N'Александр', N'Григорьеквич', N'17.06.1957', N'006-859-387-08', 9, 6, 17)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (10, N'Лобанов', N'Евгений', N'Игоревич', N'17.06.1957', N'105-494-409-05', 8, 7, 19)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (11, N'Швец', N'Юрий', N'Анатольевич', N'25.10.1951', N'105-494-409-01', 7, 8, 21)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (12, N'Зотов', N'Юрий', N'Анатольевич', N'12.03.1985', N'073-228-398-03', 6, 9, 23)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (13, N'Слюсарь', N'Ростислав', N'Анатольевич', N'12.03.1985 ', N'006-859-387-10', 5, 10, 25)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (14, N'Хасанов', N'Ильхомжон', N'Анатольевич', N'17.06.1957', N'006-859-387-08', 4, 11, 27)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (15, N'Мурукин', N'Анрей', N'Иванович', N'12.03.1985', N'105-494-409-05', 3, 12, 29)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (16, N'Папкина', N'Татьяна', N'Михайловна', N'25.10.1951', N'073-228-398-03', 2, 13, 31)
INSERT INTO [dbo].[Employee] ([IdEmployee], [LastName], [FirstName], [Patronymic], [Birthday], [PolicyNumber], [IdPassport], [IdDepartment], [IdAddress]) VALUES (17, N'Шевченко', N'Светлана', N'Николаевна', N'17.06.1957', N'105-494-409-01', 1, 9, 33)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (1, N'03 01 200001', N'31.10.2018', N'Федеральной миграционной службой', 1, 2)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (2, N'03 09 200002', N'31.10.2018', N'УВД Центрального округа гор. Краснодара', 2, 4)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (3, N'03 01 200003', N'31.10.2018', N'ПВС УВД Карасунского округа гор.Краснодара', 3, 6)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (4, N'03 01 200004', N'31.10.2018', N'УВД Карасунского округа, г. Краснодара', 4, 8)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (5, N'03 01 200005', N'31.10.2018', N'ПВС УВД Западного округа  гор.Краснодара', 5, 10)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (6, N'03 01 200006', N'31.10.2018', N'Федеральной миграционной службой', 6, 12)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (7, N'03 01 200007', N'31.10.2018', N'УВД Центрального округа гор. Краснодара', 7, 14)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (8, N'03 01 200008', N'31.10.2018', N'ПВС УВД Карасунского округа гор.Краснодара', 8, 16)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (9, N'03 01 200009', N'31.10.2018', N'ПВС УВД Западного округа  гор.Краснодара', 9, 18)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (10, N'03 01 200013', N'31.10.2018', N'УВД Карасунского округа, г. Краснодара', 10, 20)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (11, N'03 01 200010', N'31.10.2018', N'УВД Центрального округа гор. Краснодара', 11, 22)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (12, N'03 01 200011', N'31.10.2018', N'ПВС УВД Карасунского округа гор.Краснодара', 12, 24)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (13, N'03 01 200012', N'31.10.2018', N'Федеральной миграционной службой', 13, 26)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (14, N'03 01 200014', N'31.10.2018', N'УВД Центрального округа гор. Краснодара', 14, 28)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (15, N'03 01 200015', N'31.10.2018', N'ПВС УВД Карасунского округа гор.Краснодара', 15, 30)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (16, N'03 01 200017', N'31.10.2018', N'УВД Центрального округа гор. Краснодара', 16, 32)
INSERT INTO [dbo].[Passports] ([IdPassport], [PassportSerNum], [PassportDateOfIssue], [PassporIssuedBy], [IdEmployee], [IdAddress]) VALUES (17, N'03 01 200016', N'31.10.2018', N'Федеральной миграционной службой', 17, 34)

INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (1, 1, N'г. Краснодар, ул. Селезнева, д. 6', 1)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (2, 2,N'с. Столбовое, Сакского -на,крымской обл. УССР',1)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (3, 1, N'г. Краснодар, ул. Ставропольская, д.22, корп. Б, кв. 1 ',2)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (4, 2, N'ст.Гривенская, Красноармейский район, Краснодарский Край ',2)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (5, 1, N'г.Краснодар, ул.Волжская, д.4, кв.35 ',3)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (6, 2, N'Кашпир-Рудмий, Куйбышевской области ',3)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (7, 1, N'г. Краснодар, ул.Воронежская д.539, кв.3854 ',4)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (8, 2, N'с. Кучурган, раздельнянского р-на, Одесской области ',4)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (9, 1, N'г. Краснодар, ул.Красная д.58, кв.389 ',5)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (10, 2, N'Кашпир-Рудмий, Куйбышевской области ',5)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (11, 1, N'г. Краснодар, ул. Селезнева, д. 6, кв.14 ',6)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (12, 2,N'с. Кучурган, раздельнянского р-на, Одесской области ',6)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (13, 1, N'г. Краснодар, ул. Ставропольская, д.22, корп. Б, кв. 181 ',7)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (14, 2, N'пос. Пашковский гор. Краснодара ',7)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (15, 1, N'г.Краснодар, ул.Волжская, д.4, кв.63 ',8)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (16, 2, N'гор.Краснодар ',8)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (17, 1, N'г. Краснодар, ул.Воронежская д.539, кв.25 ',9)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (18, 2, N'гор.Краснодар ',9)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (19, 1, N'г. Краснодар, ул.Красная д.58, кв.45 ',10)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (20, 2, N'ст.Гривенская, Красноармейский район, Краснодарский Край ',10)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (21, 1, N'г.Краснодар, ул.Волжская, д.4, кв.34 ',11)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (22, 2, N'Кашпир-Рудмий, Куйбышевской области ',11)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (23, 1, N'г. Краснодар, ул.Воронежская д.539, кв.387 ',12)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (24, 2, N'с. Кучурган, раздельнянского р-на, Одесской области ',12)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (25, 1, N'г. Краснодар, ул.Красная д.58, кв.387 ',13)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (26, 2, N'пос. Пашковский гор. Краснодара ',13)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (27, 1, N'г.Краснодар, ул.Волжская, д.4, кв.3 ',14)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (28, 2, N'гор.Краснодар ',14)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (29, 1,N'г. Краснодар, ул.Воронежская д.539, кв.385 ',15)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (30, 2, N'гор.Краснодар ',15)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (31, 1, N'г. Краснодар, ул.Красная д.58, кв.38 ',16)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (32, 2, N'Кашпир-Рудмий, Куйбышевской области ',16)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (33, 1, N'г. Краснодар, ул. Селезнева, д. 6, кв.12 ',17)
INSERT INTO [dbo].[Address] ([IdAddress], [idAddressType], [Address], [IdEmployee]) VALUES (34, 2, N'с. Кучурган, раздельнянского р-на, Одесской области ',17)


