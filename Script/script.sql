/****** Object:  Database [ThesisBase]    Script Date: 17.05.2021 8:45:31 ******/
CREATE DATABASE [ThesisBase]
USE [ThesisBase]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 17.05.2021 8:45:31 ******/

CREATE TABLE [dbo].[Attendance](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[Day] [date] NOT NULL,
	[IsPresense] [bit] NULL,
 CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 17.05.2021 8:45:31 ******/

CREATE TABLE [dbo].[Gender](
	[Code] [nchar](1) NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 17.05.2021 8:45:31 ******/

CREATE TABLE [dbo].[Group](
	[Code] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[CuratorID] [int] NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Q&A]    Script Date: 17.05.2021 8:45:31 ******/
CREATE TABLE [dbo].[Q&A](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](250) NOT NULL,
	[Answer] [nvarchar](350) NULL,
 CONSTRAINT [PK_Q&A] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 17.05.2021 8:45:31 ******/
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[GroupID] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 17.05.2021 8:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[Code] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](150) NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 17.05.2021 8:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[GenderCode] [nchar](1) NOT NULL,
	[DateOfBirth] [date] NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeacherSubject]    Script Date: 17.05.2021 8:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherSubject](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherID] [int] NOT NULL,
	[SubjectCode] [int] NOT NULL,
 CONSTRAINT [PK_TeacherSubject] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


-- Внесение данных
SET IDENTITY_INSERT [dbo].[Attendance] ON 

INSERT [dbo].[Attendance] ([ID], [StudentID], [Day], [IsPresense]) VALUES (1, 1, CAST(N'2020-03-03' AS Date), 0)
INSERT [dbo].[Attendance] ([ID], [StudentID], [Day], [IsPresense]) VALUES (2, 2, CAST(N'2021-04-20' AS Date), 0)
INSERT [dbo].[Attendance] ([ID], [StudentID], [Day], [IsPresense]) VALUES (3, 1, CAST(N'2021-04-21' AS Date), 0)
INSERT [dbo].[Attendance] ([ID], [StudentID], [Day], [IsPresense]) VALUES (4, 5, CAST(N'2021-04-21' AS Date), 0)
INSERT [dbo].[Attendance] ([ID], [StudentID], [Day], [IsPresense]) VALUES (5, 5, CAST(N'2021-04-21' AS Date), 0)
INSERT [dbo].[Attendance] ([ID], [StudentID], [Day], [IsPresense]) VALUES (6, 1, CAST(N'2021-04-21' AS Date), 0)
INSERT [dbo].[Attendance] ([ID], [StudentID], [Day], [IsPresense]) VALUES (7, 1, CAST(N'2021-05-06' AS Date), 0)
INSERT [dbo].[Attendance] ([ID], [StudentID], [Day], [IsPresense]) VALUES (8, 1, CAST(N'2021-05-06' AS Date), 0)
INSERT [dbo].[Attendance] ([ID], [StudentID], [Day], [IsPresense]) VALUES (9, 2, CAST(N'2021-05-06' AS Date), 0)
INSERT [dbo].[Attendance] ([ID], [StudentID], [Day], [IsPresense]) VALUES (1007, 1, CAST(N'2021-05-10' AS Date), 0)
INSERT [dbo].[Attendance] ([ID], [StudentID], [Day], [IsPresense]) VALUES (1008, 2, CAST(N'2021-05-10' AS Date), 0)
SET IDENTITY_INSERT [dbo].[Attendance] OFF
GO
INSERT [dbo].[Gender] ([Code]) VALUES (N'Ж')
INSERT [dbo].[Gender] ([Code]) VALUES (N'М')
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([Code], [Title], [CuratorID]) VALUES (1, N'1 ИСП', 2)
INSERT [dbo].[Group] ([Code], [Title], [CuratorID]) VALUES (2, N'2 ИСП', NULL)
INSERT [dbo].[Group] ([Code], [Title], [CuratorID]) VALUES (3, N'4 ИСП', NULL)
INSERT [dbo].[Group] ([Code], [Title], [CuratorID]) VALUES (4, N'5 ИСП', NULL)
INSERT [dbo].[Group] ([Code], [Title], [CuratorID]) VALUES (5, N'6 ИСП', NULL)
SET IDENTITY_INSERT [dbo].[Group] OFF
GO
SET IDENTITY_INSERT [dbo].[Q&A] ON 

INSERT [dbo].[Q&A] ([ID], [Question], [Answer]) VALUES (1, N'Что выполняет наша программа?', N'Наша программа облегчает вам жизнь :)')
SET IDENTITY_INSERT [dbo].[Q&A] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [GroupID]) VALUES (1, N'Магомедов', N'Мухаммад', 1)
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [GroupID]) VALUES (2, N'Алиев', N'Эльдар', 1)
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [GroupID]) VALUES (3, N'Сулейманов', N'Марат', 3)
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [GroupID]) VALUES (4, N'Керимов', N'Саид', 4)
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [GroupID]) VALUES (5, N'Магомедов', N'Абдулхаким', 4)
INSERT [dbo].[Student] ([ID], [FirstName], [LastName], [GroupID]) VALUES (6, N'Шаихов', N'Магомедсалим', 4)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([Code], [Title], [Description]) VALUES (1, N'Стандартизация', NULL)
INSERT [dbo].[Subject] ([Code], [Title], [Description]) VALUES (2, N'Основы алгоритмизации и прораммирования', N'')
SET IDENTITY_INSERT [dbo].[Subject] OFF
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([ID], [FirstName], [LastName], [Patronymic], [GenderCode], [DateOfBirth]) VALUES (2, N'Азизова', N'Лилия', N'Насрулаховна', N'ж', CAST(N'1990-12-27' AS Date))
INSERT [dbo].[Teacher] ([ID], [FirstName], [LastName], [Patronymic], [GenderCode], [DateOfBirth]) VALUES (3, N'Азизов', N'Мирзамагомед', N'Насрулахович', N'м', CAST(N'1990-12-30' AS Date))
INSERT [dbo].[Teacher] ([ID], [FirstName], [LastName], [Patronymic], [GenderCode], [DateOfBirth]) VALUES (4, N'Полозкова', N'Елена', N'Николаевна', N'ж', CAST(N'1990-12-25' AS Date))
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([ID])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Student]
GO
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_Teacher] FOREIGN KEY([CuratorID])
REFERENCES [dbo].[Teacher] ([ID])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_Teacher]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Group] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Group] ([Code])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Group]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Gender] FOREIGN KEY([GenderCode])
REFERENCES [dbo].[Gender] ([Code])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Gender]
GO
ALTER TABLE [dbo].[TeacherSubject]  WITH CHECK ADD  CONSTRAINT [FK_TeacherSubject_Subject] FOREIGN KEY([SubjectCode])
REFERENCES [dbo].[Subject] ([Code])
GO
ALTER TABLE [dbo].[TeacherSubject] CHECK CONSTRAINT [FK_TeacherSubject_Subject]
GO
ALTER TABLE [dbo].[TeacherSubject]  WITH CHECK ADD  CONSTRAINT [FK_TeacherSubject_Teacher] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([ID])
GO
ALTER TABLE [dbo].[TeacherSubject] CHECK CONSTRAINT [FK_TeacherSubject_Teacher]
GO

