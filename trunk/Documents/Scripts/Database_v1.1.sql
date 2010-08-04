USE [master]
GO
/****** Object:  Database [SP]    Script Date: 08/04/2010 18:56:03 ******/
CREATE DATABASE [SP] ON  PRIMARY 
( NAME = N'SP', FILENAME = N'e:\SQLEE2005\MSSQL.1\MSSQL\DATA\SP.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SP_log', FILENAME = N'e:\SQLEE2005\MSSQL.1\MSSQL\DATA\SP_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'SP', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SP] SET ARITHABORT OFF 
GO
ALTER DATABASE [SP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SP] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SP] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SP] SET  READ_WRITE 
GO
ALTER DATABASE [SP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SP] SET  MULTI_USER 
GO
ALTER DATABASE [SP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SP] SET DB_CHAINING OFF 

USE [SP]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[FacultyID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[FacultyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departaments]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departaments](
	[DepartamentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_Departaments] PRIMARY KEY CLUSTERED 
(
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectTypes]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectTypes](
	[SubjectTypeID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SubjectTypes] PRIMARY KEY CLUSTERED 
(
	[SubjectTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudiesTypes]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudiesTypes](
	[StudiesTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_StudiesTypes] PRIMARY KEY CLUSTERED 
(
	[StudiesTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Semesters]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semesters](
	[SemesterID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[StudyYear] [int] NOT NULL,
	[Semester] [int] NOT NULL,
 CONSTRAINT [PK_Semesters] PRIMARY KEY CLUSTERED 
(
	[SemesterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specializations]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specializations](
	[SpecializationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Specializations] PRIMARY KEY CLUSTERED 
(
	[SpecializationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectsData]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectsData](
	[SubjectID] [int] NOT NULL,
	[SemesterID] [int] NOT NULL,
	[FacultyID] [int] NOT NULL,
	[Ects] [float] NOT NULL,
	[IsExam] [bit] NOT NULL,
	[SpecializationDataID] [int] NOT NULL,
	[DepartamentID] [int] NOT NULL,
	[SubjectDataID] [int] IDENTITY(1,1) NOT NULL,
	[InstituteID] [int] NOT NULL,
 CONSTRAINT [PK_SubjectsData] PRIMARY KEY CLUSTERED 
(
	[SubjectDataID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_DepartamentID] ON [dbo].[SubjectsData] 
(
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_FacultyID] ON [dbo].[SubjectsData] 
(
	[FacultyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_InstituteID] ON [dbo].[SubjectsData] 
(
	[InstituteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_SemesterID] ON [dbo].[SubjectsData] 
(
	[SemesterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_SpcializationsData] ON [dbo].[SubjectsData] 
(
	[SubjectDataID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_SubjectID] ON [dbo].[SubjectsData] 
(
	[SubjectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacultiesDepartaments]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacultiesDepartaments](
	[FacultyID] [int] NOT NULL,
	[DepartamentID] [int] NOT NULL,
 CONSTRAINT [PK_FacultiesDepartaments] PRIMARY KEY CLUSTERED 
(
	[FacultyID] ASC,
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_FacultiesDepartaments_DepartamentID] ON [dbo].[FacultiesDepartaments] 
(
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_FacultiesDepartaments_FacultyID] ON [dbo].[FacultiesDepartaments] 
(
	[FacultyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plans]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plans](
	[PlanID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [int] NOT NULL,
	[YearStart] [datetime] NOT NULL,
	[YearEnd] [datetime] NULL,
	[SemesterStart] [nvarchar](50) NOT NULL,
	[SemesterEnd] [nvarchar](50) NOT NULL,
	[IsMandatory] [bit] NOT NULL,
	[DepartamentID] [int] NOT NULL,
	[FacultyID] [int] NOT NULL,
	[StudiesTypeID] [int] NOT NULL,
	[LastEditUserID] [int] NULL,
 CONSTRAINT [PK_Plans] PRIMARY KEY CLUSTERED 
(
	[PlanID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_DepartamentID_Plans] ON [dbo].[Plans] 
(
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_FacultyID_Plans] ON [dbo].[Plans] 
(
	[FacultyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_LastEditUserID] ON [dbo].[Plans] 
(
	[LastEditUserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_StudiesTypeID] ON [dbo].[Plans] 
(
	[SemesterStart] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Institutes]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Institutes](
	[InstituteID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](300) NOT NULL,
	[DepartamentID] [int] NOT NULL,
 CONSTRAINT [PK_Institutes] PRIMARY KEY CLUSTERED 
(
	[InstituteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_Departaments] ON [dbo].[Institutes] 
(
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectTypesData]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectTypesData](
	[SubjectDataID] [int] NOT NULL,
	[SubjectTypeID] [int] NOT NULL,
	[Hours] [float] NOT NULL,
 CONSTRAINT [PK_SubjectTypesData] PRIMARY KEY CLUSTERED 
(
	[SubjectDataID] ASC,
	[SubjectTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_SubjectDataID] ON [dbo].[SubjectTypesData] 
(
	[SubjectDataID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_SubjectTypeID] ON [dbo].[SubjectTypesData] 
(
	[SubjectTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlansData]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlansData](
	[PlanID] [int] NOT NULL,
	[SubjectDataID] [int] NOT NULL,
 CONSTRAINT [PK_PlansData] PRIMARY KEY CLUSTERED 
(
	[PlanID] ASC,
	[SubjectDataID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_PlanID] ON [dbo].[PlansData] 
(
	[PlanID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_Subject_DataID_Plans] ON [dbo].[PlansData] 
(
	[SubjectDataID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpecializationsData]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpecializationsData](
	[SpecializationDataID] [int] IDENTITY(1,1) NOT NULL,
	[SpecializationID] [int] NOT NULL,
	[IsGeneral] [bit] NOT NULL,
	[IsElective] [bit] NOT NULL,
 CONSTRAINT [PK_SpecializationsData] PRIMARY KEY CLUSTERED 
(
	[SpecializationDataID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_SpecializationID] ON [dbo].[SpecializationsData] 
(
	[SpecializationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08/04/2010 18:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[LastActiveDate] [datetime] NULL,
	[RoleID] [int] NOT NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_RoleID] ON [dbo].[Users] 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_FacultiesDepartaments_Departaments]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[FacultiesDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_FacultiesDepartaments_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FacultiesDepartaments] CHECK CONSTRAINT [FK_FacultiesDepartaments_Departaments]
GO
/****** Object:  ForeignKey [FK_FacultiesDepartaments_Faculties]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[FacultiesDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_FacultiesDepartaments_Faculties] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculties] ([FacultyID])
GO
ALTER TABLE [dbo].[FacultiesDepartaments] CHECK CONSTRAINT [FK_FacultiesDepartaments_Faculties]
GO
/****** Object:  ForeignKey [FK_Institutes_Departaments]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[Institutes]  WITH CHECK ADD  CONSTRAINT [FK_Institutes_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
GO
ALTER TABLE [dbo].[Institutes] CHECK CONSTRAINT [FK_Institutes_Departaments]
GO
/****** Object:  ForeignKey [FK_Plans_Departaments]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
GO
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_Departaments]
GO
/****** Object:  ForeignKey [FK_Plans_Faculties]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_Faculties] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculties] ([FacultyID])
GO
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_Faculties]
GO
/****** Object:  ForeignKey [FK_Plans_StudiesTypes]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_StudiesTypes] FOREIGN KEY([StudiesTypeID])
REFERENCES [dbo].[StudiesTypes] ([StudiesTypeID])
GO
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_StudiesTypes]
GO
/****** Object:  ForeignKey [FK_Plans_Users]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_Users] FOREIGN KEY([LastEditUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_Users]
GO
/****** Object:  ForeignKey [FK_PlansData_Plans]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[PlansData]  WITH CHECK ADD  CONSTRAINT [FK_PlansData_Plans] FOREIGN KEY([PlanID])
REFERENCES [dbo].[Plans] ([PlanID])
GO
ALTER TABLE [dbo].[PlansData] CHECK CONSTRAINT [FK_PlansData_Plans]
GO
/****** Object:  ForeignKey [FK_PlansData_SubjectsData]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[PlansData]  WITH CHECK ADD  CONSTRAINT [FK_PlansData_SubjectsData] FOREIGN KEY([SubjectDataID])
REFERENCES [dbo].[SubjectsData] ([SubjectDataID])
GO
ALTER TABLE [dbo].[PlansData] CHECK CONSTRAINT [FK_PlansData_SubjectsData]
GO
/****** Object:  ForeignKey [FK_SpecializationsData_Specializations]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[SpecializationsData]  WITH CHECK ADD  CONSTRAINT [FK_SpecializationsData_Specializations] FOREIGN KEY([SpecializationID])
REFERENCES [dbo].[Specializations] ([SpecializationID])
GO
ALTER TABLE [dbo].[SpecializationsData] CHECK CONSTRAINT [FK_SpecializationsData_Specializations]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Departaments]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
GO
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Departaments]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Faculties]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Faculties] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculties] ([FacultyID])
GO
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Faculties]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Institutes]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Institutes] FOREIGN KEY([InstituteID])
REFERENCES [dbo].[Institutes] ([InstituteID])
GO
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Institutes]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Semesters]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Semesters] FOREIGN KEY([SemesterID])
REFERENCES [dbo].[Semesters] ([SemesterID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Semesters]
GO
/****** Object:  ForeignKey [FK_SubjectsData_SpecializationsData]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_SpecializationsData] FOREIGN KEY([SpecializationDataID])
REFERENCES [dbo].[SpecializationsData] ([SpecializationDataID])
GO
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_SpecializationsData]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Subjects]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Subjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([SubjectID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Subjects]
GO
/****** Object:  ForeignKey [FK_SubjectTypesData_SubjectsData]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[SubjectTypesData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectTypesData_SubjectsData] FOREIGN KEY([SubjectDataID])
REFERENCES [dbo].[SubjectsData] ([SubjectDataID])
GO
ALTER TABLE [dbo].[SubjectTypesData] CHECK CONSTRAINT [FK_SubjectTypesData_SubjectsData]
GO
/****** Object:  ForeignKey [FK_SubjectTypesData_SubjectTypes]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[SubjectTypesData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectTypesData_SubjectTypes] FOREIGN KEY([SubjectTypeID])
REFERENCES [dbo].[SubjectTypes] ([SubjectTypeID])
GO
ALTER TABLE [dbo].[SubjectTypesData] CHECK CONSTRAINT [FK_SubjectTypesData_SubjectTypes]
GO
/****** Object:  ForeignKey [FK_Users_Roles]    Script Date: 08/04/2010 18:53:52 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
