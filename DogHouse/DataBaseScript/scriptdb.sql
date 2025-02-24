USE [DogHome]
GO
/****** Object:  Table [dbo].[Dog]    Script Date: 17.02.2025 22:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dog](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NULL,
	[Height] [int] NULL,
	[Weight] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[IdAviary] [int] NULL,
	[AboutAge] [int] NULL,
	[IdGender] [int] NULL,
	[IsDie] [bit] NULL,
	[IsGive] [bit] NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[Photo] [nvarchar](max) NULL,
 CONSTRAINT [PK_Dog] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 17.02.2025 22:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[IdType] [int] NULL,
	[Login] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 17.02.2025 22:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusSurvey]    Script Date: 17.02.2025 22:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusSurvey](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_StatusSurvey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Survey]    Script Date: 17.02.2025 22:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Survey](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdDog] [int] NULL,
	[Illness] [nvarchar](max) NULL,
	[Date] [datetime] NULL,
	[IdStatus] [int] NULL,
	[Comment] [nvarchar](max) NULL,
	[IdDoctor] [int] NULL,
 CONSTRAINT [PK_Survey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeAviary]    Script Date: 17.02.2025 22:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeAviary](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_TypeAviary] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeEmployee]    Script Date: 17.02.2025 22:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeEmployee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_TypeEmployee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Dog] ON 

INSERT [dbo].[Dog] ([ID], [Number], [Height], [Weight], [Description], [IdAviary], [AboutAge], [IdGender], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (1, N'D001', 50, 20, N'Ласковая собака', 3, 3, 1, 0, 0, N'1234567890', NULL)
INSERT [dbo].[Dog] ([ID], [Number], [Height], [Weight], [Description], [IdAviary], [AboutAge], [IdGender], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (2, N'D002', 45, 18, N'Активная собака', 2, 2, 2, 0, 1, N'9876543210', NULL)
INSERT [dbo].[Dog] ([ID], [Number], [Height], [Weight], [Description], [IdAviary], [AboutAge], [IdGender], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (3, N'D003', 60, 25, N'Защитная собака', 3, 4, 1, 0, 0, N'5678901234', NULL)
INSERT [dbo].[Dog] ([ID], [Number], [Height], [Weight], [Description], [IdAviary], [AboutAge], [IdGender], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (4, N'D004', 30, 10, N'Маленький щенок', 4, 1, 2, 0, 0, N'8765432109', NULL)
INSERT [dbo].[Dog] ([ID], [Number], [Height], [Weight], [Description], [IdAviary], [AboutAge], [IdGender], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (5, N'D005', 55, 22, N'Дружелюбная собака', 5, 5, 1, 0, 1, N'3456789012', NULL)
INSERT [dbo].[Dog] ([ID], [Number], [Height], [Weight], [Description], [IdAviary], [AboutAge], [IdGender], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (6, N'D006', 40, 15, N'Спокойная собака', 6, 6, 2, 0, 0, N'9012345678', NULL)
INSERT [dbo].[Dog] ([ID], [Number], [Height], [Weight], [Description], [IdAviary], [AboutAge], [IdGender], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (7, N'D007', 70, 30, N'Охранная собака', 7, 7, 1, 0, 1, N'1122334455', NULL)
INSERT [dbo].[Dog] ([ID], [Number], [Height], [Weight], [Description], [IdAviary], [AboutAge], [IdGender], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (8, N'D008', 35, 12, N'Собака-компаньон', 8, 8, 2, 0, 0, N'2233445566', NULL)
INSERT [dbo].[Dog] ([ID], [Number], [Height], [Weight], [Description], [IdAviary], [AboutAge], [IdGender], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (9, N'D009', 65, 28, N'Лидерская собака', 9, 9, 1, 0, 0, N'3344556677', NULL)
INSERT [dbo].[Dog] ([ID], [Number], [Height], [Weight], [Description], [IdAviary], [AboutAge], [IdGender], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (10, N'D010', 50, 20, N'Обучаемая собака', 10, 10, 2, 0, 1, N'4455667788', NULL)
INSERT [dbo].[Dog] ([ID], [Number], [Height], [Weight], [Description], [IdAviary], [AboutAge], [IdGender], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (11, N'0d011', 50, 50, N'gggg', 1, 23, 1, 0, 1, N'0d011', NULL)
INSERT [dbo].[Dog] ([ID], [Number], [Height], [Weight], [Description], [IdAviary], [AboutAge], [IdGender], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (12, N'0d011', 50, 50, N'gggg', 1, 10, 1, 1, 1, N'0d011', NULL)
SET IDENTITY_INSERT [dbo].[Dog] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([ID], [FirstName], [Name], [LastName], [IdType], [Login], [Password]) VALUES (1, N'Иван', N'Иванович', N'Иванов', 1, N'admin', N'admin123')
INSERT [dbo].[Employee] ([ID], [FirstName], [Name], [LastName], [IdType], [Login], [Password]) VALUES (2, N'Петр', N'Петрович', N'Петров', 2, N'vet1', N'pass123')
INSERT [dbo].[Employee] ([ID], [FirstName], [Name], [LastName], [IdType], [Login], [Password]) VALUES (3, N'Сергей', N'Сергеевич', N'Сергеев', 3, N'clean1', N'clean123')
INSERT [dbo].[Employee] ([ID], [FirstName], [Name], [LastName], [IdType], [Login], [Password]) VALUES (4, N'Анна', N'Александровна', N'Александрова', 4, N'trainer1', N'train123')
INSERT [dbo].[Employee] ([ID], [FirstName], [Name], [LastName], [IdType], [Login], [Password]) VALUES (5, N'Ольга', N'Олеговна', N'Олегова', 5, N'manager1', N'manage123')
INSERT [dbo].[Employee] ([ID], [FirstName], [Name], [LastName], [IdType], [Login], [Password]) VALUES (6, N'Дмитрий', N'Дмитриевич', N'Дмитриев', 6, N'intern1', N'intern123')
INSERT [dbo].[Employee] ([ID], [FirstName], [Name], [LastName], [IdType], [Login], [Password]) VALUES (7, N'Николай', N'Николаевич', N'Николаев', 7, N'guard1', N'guard123')
INSERT [dbo].[Employee] ([ID], [FirstName], [Name], [LastName], [IdType], [Login], [Password]) VALUES (8, N'Елена', N'Еленовна', N'Еленова', 8, N'dog1', N'dog123')
INSERT [dbo].[Employee] ([ID], [FirstName], [Name], [LastName], [IdType], [Login], [Password]) VALUES (9, N'Алексей', N'Алексеевич', N'Алексеев', 9, N'volunteer1', N'vol123')
INSERT [dbo].[Employee] ([ID], [FirstName], [Name], [LastName], [IdType], [Login], [Password]) VALUES (10, N'Мария', N'Марковна', N'Маркова', 10, N'consultant1', N'consult123')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([ID], [Name]) VALUES (1, N'Мужской')
INSERT [dbo].[Gender] ([ID], [Name]) VALUES (2, N'Женский')
SET IDENTITY_INSERT [dbo].[Gender] OFF
GO
SET IDENTITY_INSERT [dbo].[StatusSurvey] ON 

INSERT [dbo].[StatusSurvey] ([ID], [Name]) VALUES (1, N'Планируется')
INSERT [dbo].[StatusSurvey] ([ID], [Name]) VALUES (2, N'В процессе')
INSERT [dbo].[StatusSurvey] ([ID], [Name]) VALUES (3, N'Завершено')
INSERT [dbo].[StatusSurvey] ([ID], [Name]) VALUES (4, N'Ожидается')
INSERT [dbo].[StatusSurvey] ([ID], [Name]) VALUES (5, N'Отменено')
INSERT [dbo].[StatusSurvey] ([ID], [Name]) VALUES (6, N'На доработке')
INSERT [dbo].[StatusSurvey] ([ID], [Name]) VALUES (7, N'Повторный осмотр')
INSERT [dbo].[StatusSurvey] ([ID], [Name]) VALUES (8, N'Положительно')
INSERT [dbo].[StatusSurvey] ([ID], [Name]) VALUES (9, N'Отрицательно')
INSERT [dbo].[StatusSurvey] ([ID], [Name]) VALUES (10, N'Неопределено')
SET IDENTITY_INSERT [dbo].[StatusSurvey] OFF
GO
SET IDENTITY_INSERT [dbo].[Survey] ON 

INSERT [dbo].[Survey] ([ID], [IdDog], [Illness], [Date], [IdStatus], [Comment], [IdDoctor]) VALUES (1, 1, N'Нет', CAST(N'2025-01-01T00:00:00.000' AS DateTime), 1, N'Проверка общего состояния', 2)
INSERT [dbo].[Survey] ([ID], [IdDog], [Illness], [Date], [IdStatus], [Comment], [IdDoctor]) VALUES (2, 2, N'Легкая простуда', CAST(N'2025-02-01T00:00:00.000' AS DateTime), 2, N'Лечение простуды', 2)
INSERT [dbo].[Survey] ([ID], [IdDog], [Illness], [Date], [IdStatus], [Comment], [IdDoctor]) VALUES (3, 3, N'Нет', CAST(N'2025-03-01T00:00:00.000' AS DateTime), 3, N'Регулярный осмотр', 2)
INSERT [dbo].[Survey] ([ID], [IdDog], [Illness], [Date], [IdStatus], [Comment], [IdDoctor]) VALUES (4, 4, N'Проблемы с лапой', CAST(N'2025-04-01T00:00:00.000' AS DateTime), 4, N'Рентген', 2)
INSERT [dbo].[Survey] ([ID], [IdDog], [Illness], [Date], [IdStatus], [Comment], [IdDoctor]) VALUES (5, 5, N'Нет', CAST(N'2025-05-01T00:00:00.000' AS DateTime), 5, N'Прививка', 2)
INSERT [dbo].[Survey] ([ID], [IdDog], [Illness], [Date], [IdStatus], [Comment], [IdDoctor]) VALUES (6, 6, N'Блохи', CAST(N'2025-06-01T00:00:00.000' AS DateTime), 6, N'Обработка от паразитов', 2)
INSERT [dbo].[Survey] ([ID], [IdDog], [Illness], [Date], [IdStatus], [Comment], [IdDoctor]) VALUES (7, 7, N'Ранение', CAST(N'2025-07-01T00:00:00.000' AS DateTime), 7, N'Швы наложены', 2)
INSERT [dbo].[Survey] ([ID], [IdDog], [Illness], [Date], [IdStatus], [Comment], [IdDoctor]) VALUES (8, 8, N'Нет', CAST(N'2025-08-01T00:00:00.000' AS DateTime), 8, N'Проверка', 2)
INSERT [dbo].[Survey] ([ID], [IdDog], [Illness], [Date], [IdStatus], [Comment], [IdDoctor]) VALUES (9, 9, N'Аллергия', CAST(N'2025-09-01T00:00:00.000' AS DateTime), 9, N'Изменение рациона', 2)
INSERT [dbo].[Survey] ([ID], [IdDog], [Illness], [Date], [IdStatus], [Comment], [IdDoctor]) VALUES (10, 10, N'Нет', CAST(N'2025-10-01T00:00:00.000' AS DateTime), 10, N'Заключение', 2)
INSERT [dbo].[Survey] ([ID], [IdDog], [Illness], [Date], [IdStatus], [Comment], [IdDoctor]) VALUES (11, 1, N'Ramil', NULL, NULL, N'Очень плохо', NULL)
SET IDENTITY_INSERT [dbo].[Survey] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeAviary] ON 

INSERT [dbo].[TypeAviary] ([ID], [Name]) VALUES (1, N'Малый')
INSERT [dbo].[TypeAviary] ([ID], [Name]) VALUES (2, N'Средний')
INSERT [dbo].[TypeAviary] ([ID], [Name]) VALUES (3, N'Большой')
INSERT [dbo].[TypeAviary] ([ID], [Name]) VALUES (4, N'Закрытый')
INSERT [dbo].[TypeAviary] ([ID], [Name]) VALUES (5, N'Открытый')
INSERT [dbo].[TypeAviary] ([ID], [Name]) VALUES (6, N'Зимний')
INSERT [dbo].[TypeAviary] ([ID], [Name]) VALUES (7, N'Летний')
INSERT [dbo].[TypeAviary] ([ID], [Name]) VALUES (8, N'Для щенков')
INSERT [dbo].[TypeAviary] ([ID], [Name]) VALUES (9, N'Для больных')
INSERT [dbo].[TypeAviary] ([ID], [Name]) VALUES (10, N'Для активных')
INSERT [dbo].[TypeAviary] ([ID], [Name]) VALUES (11, N'RamilDog')
SET IDENTITY_INSERT [dbo].[TypeAviary] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeEmployee] ON 

INSERT [dbo].[TypeEmployee] ([ID], [Name]) VALUES (1, N'Администратор')
INSERT [dbo].[TypeEmployee] ([ID], [Name]) VALUES (2, N'Ветеринар')
INSERT [dbo].[TypeEmployee] ([ID], [Name]) VALUES (3, N'Уборщик')
INSERT [dbo].[TypeEmployee] ([ID], [Name]) VALUES (4, N'Тренер')
INSERT [dbo].[TypeEmployee] ([ID], [Name]) VALUES (5, N'Менеджер')
INSERT [dbo].[TypeEmployee] ([ID], [Name]) VALUES (6, N'Стажер')
INSERT [dbo].[TypeEmployee] ([ID], [Name]) VALUES (7, N'Охранник')
INSERT [dbo].[TypeEmployee] ([ID], [Name]) VALUES (8, N'Кинолог')
INSERT [dbo].[TypeEmployee] ([ID], [Name]) VALUES (9, N'Волонтер')
INSERT [dbo].[TypeEmployee] ([ID], [Name]) VALUES (10, N'Консультант')
SET IDENTITY_INSERT [dbo].[TypeEmployee] OFF
GO
ALTER TABLE [dbo].[Dog]  WITH CHECK ADD  CONSTRAINT [FK_Dog_Gender] FOREIGN KEY([IdGender])
REFERENCES [dbo].[Gender] ([ID])
GO
ALTER TABLE [dbo].[Dog] CHECK CONSTRAINT [FK_Dog_Gender]
GO
ALTER TABLE [dbo].[Dog]  WITH CHECK ADD  CONSTRAINT [FK_Dog_TypeAviary] FOREIGN KEY([IdAviary])
REFERENCES [dbo].[TypeAviary] ([ID])
GO
ALTER TABLE [dbo].[Dog] CHECK CONSTRAINT [FK_Dog_TypeAviary]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_TypeEmployee] FOREIGN KEY([IdType])
REFERENCES [dbo].[TypeEmployee] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_TypeEmployee]
GO
ALTER TABLE [dbo].[Survey]  WITH CHECK ADD  CONSTRAINT [FK_Survey_Dog] FOREIGN KEY([IdDog])
REFERENCES [dbo].[Dog] ([ID])
GO
ALTER TABLE [dbo].[Survey] CHECK CONSTRAINT [FK_Survey_Dog]
GO
ALTER TABLE [dbo].[Survey]  WITH CHECK ADD  CONSTRAINT [FK_Survey_Employee] FOREIGN KEY([IdDoctor])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Survey] CHECK CONSTRAINT [FK_Survey_Employee]
GO
ALTER TABLE [dbo].[Survey]  WITH CHECK ADD  CONSTRAINT [FK_Survey_StatusSurvey] FOREIGN KEY([IdStatus])
REFERENCES [dbo].[StatusSurvey] ([ID])
GO
ALTER TABLE [dbo].[Survey] CHECK CONSTRAINT [FK_Survey_StatusSurvey]
GO
