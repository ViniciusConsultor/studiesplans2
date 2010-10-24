USE [master]
GO
/****** Object:  Database [SP]    Script Date: 10/24/2010 15:51:26 ******/
CREATE DATABASE [SP] ON  PRIMARY 
( NAME = N'SP', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\SP.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SP_log', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\SP_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 COLLATE Latin1_General_CI_AS
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
ALTER DATABASE [SP] SET  DISABLE_BROKER
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
GO
USE [SP]
GO
/****** Object:  ForeignKey [FK_Plans_Departaments]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [FK_Plans_Departaments]
GO
/****** Object:  ForeignKey [FK_Plans_Faculties]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [FK_Plans_Faculties]
GO
/****** Object:  ForeignKey [FK_Plans_StudiesTypes]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [FK_Plans_StudiesTypes]
GO
/****** Object:  ForeignKey [FK_Plans_Users]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [FK_Plans_Users]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Departaments]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Departaments]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Faculties]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Faculties]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Institutes]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Institutes]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Semesters]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Semesters]
GO
/****** Object:  ForeignKey [FK_SubjectsData_SpecializationsData]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_SpecializationsData]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Subjects]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Subjects]
GO
/****** Object:  ForeignKey [FK_SpecializationsData_Specializations]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SpecializationsData] DROP CONSTRAINT [FK_SpecializationsData_Specializations]
GO
/****** Object:  ForeignKey [FK_Users_Roles]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_Users_Roles]
GO
/****** Object:  ForeignKey [FK_RolesPrivilages_Privilages]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[RolesPrivilages] DROP CONSTRAINT [FK_RolesPrivilages_Privilages]
GO
/****** Object:  ForeignKey [FK_RolesPrivilages_Roles]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[RolesPrivilages] DROP CONSTRAINT [FK_RolesPrivilages_Roles]
GO
/****** Object:  ForeignKey [FK_InstitutesDepartaments_Departaments]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[InstitutesDepartaments] DROP CONSTRAINT [FK_InstitutesDepartaments_Departaments]
GO
/****** Object:  ForeignKey [FK_InstitutesDepartaments_Institutes]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[InstitutesDepartaments] DROP CONSTRAINT [FK_InstitutesDepartaments_Institutes]
GO
/****** Object:  ForeignKey [FK_SubjectTypesData_SubjectsData]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectTypesData] DROP CONSTRAINT [FK_SubjectTypesData_SubjectsData]
GO
/****** Object:  ForeignKey [FK_SubjectTypesData_SubjectTypes]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectTypesData] DROP CONSTRAINT [FK_SubjectTypesData_SubjectTypes]
GO
/****** Object:  ForeignKey [FK_PlansData_Plans]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[PlansData] DROP CONSTRAINT [FK_PlansData_Plans]
GO
/****** Object:  ForeignKey [FK_PlansData_SubjectsData]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[PlansData] DROP CONSTRAINT [FK_PlansData_SubjectsData]
GO
/****** Object:  ForeignKey [FK_sub_spec_id_specialization]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_spec] DROP CONSTRAINT [FK_sub_spec_id_specialization]
GO
/****** Object:  ForeignKey [FK_sub_spec_id_subject]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_spec] DROP CONSTRAINT [FK_sub_spec_id_subject]
GO
/****** Object:  ForeignKey [FK_id_subject]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_plan] DROP CONSTRAINT [FK_id_subject]
GO
/****** Object:  ForeignKey [FK_sub_fac_id_faculty]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_fac] DROP CONSTRAINT [FK_sub_fac_id_faculty]
GO
/****** Object:  ForeignKey [FK_sub_fac_id_subject]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_fac] DROP CONSTRAINT [FK_sub_fac_id_subject]
GO
/****** Object:  ForeignKey [FK_sub_type_id_subject]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_type] DROP CONSTRAINT [FK_sub_type_id_subject]
GO
/****** Object:  ForeignKey [FK_sub_type_id_type]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_type] DROP CONSTRAINT [FK_sub_type_id_type]
GO
/****** Object:  ForeignKey [FK_fac_type_id_faculty]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[fac_type] DROP CONSTRAINT [FK_fac_type_id_faculty]
GO
/****** Object:  ForeignKey [FK_fac_type_id_type]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[fac_type] DROP CONSTRAINT [FK_fac_type_id_type]
GO
/****** Object:  ForeignKey [FK_FacultiesDepartaments_Departaments]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[FacultiesDepartaments] DROP CONSTRAINT [FK_FacultiesDepartaments_Departaments]
GO
/****** Object:  ForeignKey [FK_FacultiesDepartaments_Faculties]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[FacultiesDepartaments] DROP CONSTRAINT [FK_FacultiesDepartaments_Faculties]
GO
/****** Object:  Table [dbo].[FacultiesDepartaments]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[FacultiesDepartaments]
GO
/****** Object:  Table [dbo].[InstitutesDepartaments]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[InstitutesDepartaments]
GO
/****** Object:  Table [dbo].[RolesPrivilages]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[RolesPrivilages]
GO
/****** Object:  Table [dbo].[PlansData]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[PlansData]
GO
/****** Object:  Table [dbo].[SubjectTypesData]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[SubjectTypesData]
GO
/****** Object:  Table [dbo].[sub_type]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[sub_type]
GO
/****** Object:  Table [dbo].[sub_spec]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[sub_spec]
GO
/****** Object:  Table [dbo].[sub_plan]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[sub_plan]
GO
/****** Object:  Table [dbo].[sub_fac]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[sub_fac]
GO
/****** Object:  Table [dbo].[fac_type]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[fac_type]
GO
/****** Object:  Table [dbo].[user]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[user]
GO
/****** Object:  Table [dbo].[studiestype]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[studiestype]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[Subjects]
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[Faculties]
GO
/****** Object:  Table [dbo].[Departaments]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[Departaments]
GO
/****** Object:  Table [dbo].[SpecializationsData]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[SpecializationsData]
GO
/****** Object:  Table [dbo].[Semesters]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[Semesters]
GO
/****** Object:  Table [dbo].[Institutes]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[Institutes]
GO
/****** Object:  Table [dbo].[Specializations]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[Specializations]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[Roles]
GO
/****** Object:  Table [dbo].[Privilages]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[Privilages]
GO
/****** Object:  Table [dbo].[SubjectsData]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[SubjectsData]
GO
/****** Object:  Table [dbo].[Plans]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[Plans]
GO
/****** Object:  Table [dbo].[SubjectTypes]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[SubjectTypes]
GO
/****** Object:  Table [dbo].[subject]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[subject]
GO
/****** Object:  Table [dbo].[type]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[type]
GO
/****** Object:  Table [dbo].[specialization]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[specialization]
GO
/****** Object:  Table [dbo].[faculty]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[faculty]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[Users]
GO
/****** Object:  Table [dbo].[StudiesTypes]    Script Date: 10/24/2010 15:51:26 ******/
DROP TABLE [dbo].[StudiesTypes]
GO
/****** Object:  Table [dbo].[StudiesTypes]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudiesTypes](
	[StudiesTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_StudiesTypes] PRIMARY KEY CLUSTERED 
(
	[StudiesTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Semesters]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semesters](
	[SemesterID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[StudyYear] [int] NOT NULL,
	[Semester] [int] NOT NULL,
 CONSTRAINT [PK_Semesters] PRIMARY KEY CLUSTERED 
(
	[SemesterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specializations]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specializations](
	[SpecializationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Specializations] PRIMARY KEY CLUSTERED 
(
	[SpecializationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Institutes]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Institutes](
	[InstituteID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](300) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Institutes] PRIMARY KEY CLUSTERED 
(
	[InstituteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectTypes]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectTypes](
	[SubjectTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_SubjectTypes] PRIMARY KEY CLUSTERED 
(
	[SubjectTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Privilages]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Privilages](
	[PrivilageID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Privilages] PRIMARY KEY CLUSTERED 
(
	[PrivilageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subject]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subject](
	[id_subject] [int] IDENTITY(1,1) NOT NULL,
	[subject] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[ects] [int] NOT NULL,
	[semester] [int] NOT NULL,
	[exam] [bit] NULL,
	[elective] [bit] NULL,
 CONSTRAINT [PK_subject] PRIMARY KEY CLUSTERED 
(
	[id_subject] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_subject] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[type]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[type](
	[id_type] [int] IDENTITY(1,1) NOT NULL,
	[typename] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_type] PRIMARY KEY CLUSTERED 
(
	[id_type] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_type] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[faculty]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[faculty](
	[id_faculty] [int] IDENTITY(1,1) NOT NULL,
	[facultyname] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_faculty] PRIMARY KEY CLUSTERED 
(
	[id_faculty] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_faculty] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](45) COLLATE Latin1_General_CI_AS NOT NULL,
	[password] [nvarchar](45) COLLATE Latin1_General_CI_AS NOT NULL,
	[email] [nvarchar](45) COLLATE Latin1_General_CI_AS NULL,
	[role] [nvarchar](45) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[studiestype]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studiestype](
	[id_studies] [int] IDENTITY(1,1) NOT NULL,
	[studiestypename] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_studiestype] PRIMARY KEY CLUSTERED 
(
	[id_studies] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_studies] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[specialization]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[specialization](
	[id_specialization] [int] IDENTITY(1,1) NOT NULL,
	[specialization] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_specialization] PRIMARY KEY CLUSTERED 
(
	[id_specialization] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_specialization] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[FacultyID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[FacultyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departaments]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departaments](
	[DepartamentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](300) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Departaments] PRIMARY KEY CLUSTERED 
(
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plans]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plans](
	[PlanID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[YearStart] [datetime] NULL,
	[YearEnd] [datetime] NULL,
	[SemesterStart] [int] NULL,
	[SemesterEnd] [int] NULL,
	[IsMandatory] [bit] NOT NULL,
	[DepartamentID] [int] NOT NULL,
	[FacultyID] [int] NOT NULL,
	[StudiesTypeID] [int] NOT NULL,
	[LastEditUserID] [int] NOT NULL,
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
/****** Object:  Table [dbo].[SubjectsData]    Script Date: 10/24/2010 15:51:26 ******/
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
	[SpecializationDataID] [int] NULL,
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
/****** Object:  Table [dbo].[SpecializationsData]    Script Date: 10/24/2010 15:51:26 ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) COLLATE Latin1_General_CI_AS NOT NULL,
	[Password] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[LastActiveDate] [datetime] NULL,
	[RoleID] [int] NOT NULL,
	[Email] [nvarchar](100) COLLATE Latin1_General_CI_AS NULL,
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
/****** Object:  Table [dbo].[RolesPrivilages]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolesPrivilages](
	[RoleID] [int] NOT NULL,
	[PrivilageID] [int] NOT NULL,
 CONSTRAINT [PK_RolesPrivilages] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[PrivilageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_RolesPrivilages_Privilages] ON [dbo].[RolesPrivilages] 
(
	[PrivilageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_RolesPrivilages_Roles] ON [dbo].[RolesPrivilages] 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InstitutesDepartaments]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstitutesDepartaments](
	[DepartamentID] [int] NOT NULL,
	[InstituteID] [int] NOT NULL,
 CONSTRAINT [PK_InstitutesDepartaments] PRIMARY KEY CLUSTERED 
(
	[DepartamentID] ASC,
	[InstituteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_InstitutesDepartaments_DepartamentID] ON [dbo].[InstitutesDepartaments] 
(
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [FK_InstitutesDepartaments_InstituteID] ON [dbo].[InstitutesDepartaments] 
(
	[InstituteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectTypesData]    Script Date: 10/24/2010 15:51:26 ******/
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
/****** Object:  Table [dbo].[PlansData]    Script Date: 10/24/2010 15:51:26 ******/
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
/****** Object:  Table [dbo].[sub_spec]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sub_spec](
	[id_subject] [int] NOT NULL,
	[id_SPecialization] [int] NOT NULL,
 CONSTRAINT [PK_sub_SPec] PRIMARY KEY CLUSTERED 
(
	[id_subject] ASC,
	[id_SPecialization] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sub_plan]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sub_plan](
	[id_subject] [int] NOT NULL,
	[id_plan] [int] NOT NULL,
 CONSTRAINT [PK_sub_plan] PRIMARY KEY CLUSTERED 
(
	[id_subject] ASC,
	[id_plan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sub_fac]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sub_fac](
	[id_subject] [int] NOT NULL,
	[id_faculty] [int] NOT NULL,
 CONSTRAINT [PK_sub_fac] PRIMARY KEY CLUSTERED 
(
	[id_subject] ASC,
	[id_faculty] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sub_type]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sub_type](
	[id_type] [int] NOT NULL,
	[id_subject] [int] NOT NULL,
	[hours] [tinyint] NOT NULL,
 CONSTRAINT [PK_sub_type] PRIMARY KEY CLUSTERED 
(
	[id_type] ASC,
	[id_subject] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fac_type]    Script Date: 10/24/2010 15:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fac_type](
	[id_faculty] [int] NOT NULL,
	[id_type] [int] NOT NULL,
 CONSTRAINT [PK_fac_type] PRIMARY KEY CLUSTERED 
(
	[id_faculty] ASC,
	[id_type] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacultiesDepartaments]    Script Date: 10/24/2010 15:51:26 ******/
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
/****** Object:  ForeignKey [FK_Plans_Departaments]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
GO
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_Departaments]
GO
/****** Object:  ForeignKey [FK_Plans_Faculties]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_Faculties] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculties] ([FacultyID])
GO
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_Faculties]
GO
/****** Object:  ForeignKey [FK_Plans_StudiesTypes]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_StudiesTypes] FOREIGN KEY([StudiesTypeID])
REFERENCES [dbo].[StudiesTypes] ([StudiesTypeID])
GO
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_StudiesTypes]
GO
/****** Object:  ForeignKey [FK_Plans_Users]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_Users] FOREIGN KEY([LastEditUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_Users]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Departaments]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
GO
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Departaments]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Faculties]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Faculties] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculties] ([FacultyID])
GO
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Faculties]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Institutes]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Institutes] FOREIGN KEY([InstituteID])
REFERENCES [dbo].[Institutes] ([InstituteID])
GO
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Institutes]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Semesters]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Semesters] FOREIGN KEY([SemesterID])
REFERENCES [dbo].[Semesters] ([SemesterID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Semesters]
GO
/****** Object:  ForeignKey [FK_SubjectsData_SpecializationsData]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_SpecializationsData] FOREIGN KEY([SpecializationDataID])
REFERENCES [dbo].[SpecializationsData] ([SpecializationDataID])
GO
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_SpecializationsData]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Subjects]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Subjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([SubjectID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Subjects]
GO
/****** Object:  ForeignKey [FK_SpecializationsData_Specializations]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SpecializationsData]  WITH CHECK ADD  CONSTRAINT [FK_SpecializationsData_Specializations] FOREIGN KEY([SpecializationID])
REFERENCES [dbo].[Specializations] ([SpecializationID])
GO
ALTER TABLE [dbo].[SpecializationsData] CHECK CONSTRAINT [FK_SpecializationsData_Specializations]
GO
/****** Object:  ForeignKey [FK_Users_Roles]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
/****** Object:  ForeignKey [FK_RolesPrivilages_Privilages]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[RolesPrivilages]  WITH CHECK ADD  CONSTRAINT [FK_RolesPrivilages_Privilages] FOREIGN KEY([PrivilageID])
REFERENCES [dbo].[Privilages] ([PrivilageID])
GO
ALTER TABLE [dbo].[RolesPrivilages] CHECK CONSTRAINT [FK_RolesPrivilages_Privilages]
GO
/****** Object:  ForeignKey [FK_RolesPrivilages_Roles]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[RolesPrivilages]  WITH CHECK ADD  CONSTRAINT [FK_RolesPrivilages_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[RolesPrivilages] CHECK CONSTRAINT [FK_RolesPrivilages_Roles]
GO
/****** Object:  ForeignKey [FK_InstitutesDepartaments_Departaments]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[InstitutesDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_InstitutesDepartaments_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
GO
ALTER TABLE [dbo].[InstitutesDepartaments] CHECK CONSTRAINT [FK_InstitutesDepartaments_Departaments]
GO
/****** Object:  ForeignKey [FK_InstitutesDepartaments_Institutes]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[InstitutesDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_InstitutesDepartaments_Institutes] FOREIGN KEY([InstituteID])
REFERENCES [dbo].[Institutes] ([InstituteID])
GO
ALTER TABLE [dbo].[InstitutesDepartaments] CHECK CONSTRAINT [FK_InstitutesDepartaments_Institutes]
GO
/****** Object:  ForeignKey [FK_SubjectTypesData_SubjectsData]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectTypesData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectTypesData_SubjectsData] FOREIGN KEY([SubjectDataID])
REFERENCES [dbo].[SubjectsData] ([SubjectDataID])
GO
ALTER TABLE [dbo].[SubjectTypesData] CHECK CONSTRAINT [FK_SubjectTypesData_SubjectsData]
GO
/****** Object:  ForeignKey [FK_SubjectTypesData_SubjectTypes]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[SubjectTypesData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectTypesData_SubjectTypes] FOREIGN KEY([SubjectTypeID])
REFERENCES [dbo].[SubjectTypes] ([SubjectTypeID])
GO
ALTER TABLE [dbo].[SubjectTypesData] CHECK CONSTRAINT [FK_SubjectTypesData_SubjectTypes]
GO
/****** Object:  ForeignKey [FK_PlansData_Plans]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[PlansData]  WITH CHECK ADD  CONSTRAINT [FK_PlansData_Plans] FOREIGN KEY([PlanID])
REFERENCES [dbo].[Plans] ([PlanID])
GO
ALTER TABLE [dbo].[PlansData] CHECK CONSTRAINT [FK_PlansData_Plans]
GO
/****** Object:  ForeignKey [FK_PlansData_SubjectsData]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[PlansData]  WITH CHECK ADD  CONSTRAINT [FK_PlansData_SubjectsData] FOREIGN KEY([SubjectDataID])
REFERENCES [dbo].[SubjectsData] ([SubjectDataID])
GO
ALTER TABLE [dbo].[PlansData] CHECK CONSTRAINT [FK_PlansData_SubjectsData]
GO
/****** Object:  ForeignKey [FK_sub_spec_id_specialization]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_spec]  WITH CHECK ADD  CONSTRAINT [FK_sub_spec_id_specialization] FOREIGN KEY([id_SPecialization])
REFERENCES [dbo].[specialization] ([id_specialization])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sub_spec] CHECK CONSTRAINT [FK_sub_spec_id_specialization]
GO
/****** Object:  ForeignKey [FK_sub_spec_id_subject]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_spec]  WITH CHECK ADD  CONSTRAINT [FK_sub_spec_id_subject] FOREIGN KEY([id_subject])
REFERENCES [dbo].[subject] ([id_subject])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sub_spec] CHECK CONSTRAINT [FK_sub_spec_id_subject]
GO
/****** Object:  ForeignKey [FK_id_subject]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_plan]  WITH CHECK ADD  CONSTRAINT [FK_id_subject] FOREIGN KEY([id_subject])
REFERENCES [dbo].[subject] ([id_subject])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sub_plan] CHECK CONSTRAINT [FK_id_subject]
GO
/****** Object:  ForeignKey [FK_sub_fac_id_faculty]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_fac]  WITH CHECK ADD  CONSTRAINT [FK_sub_fac_id_faculty] FOREIGN KEY([id_faculty])
REFERENCES [dbo].[faculty] ([id_faculty])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sub_fac] CHECK CONSTRAINT [FK_sub_fac_id_faculty]
GO
/****** Object:  ForeignKey [FK_sub_fac_id_subject]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_fac]  WITH CHECK ADD  CONSTRAINT [FK_sub_fac_id_subject] FOREIGN KEY([id_subject])
REFERENCES [dbo].[subject] ([id_subject])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sub_fac] CHECK CONSTRAINT [FK_sub_fac_id_subject]
GO
/****** Object:  ForeignKey [FK_sub_type_id_subject]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_type]  WITH CHECK ADD  CONSTRAINT [FK_sub_type_id_subject] FOREIGN KEY([id_subject])
REFERENCES [dbo].[subject] ([id_subject])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sub_type] CHECK CONSTRAINT [FK_sub_type_id_subject]
GO
/****** Object:  ForeignKey [FK_sub_type_id_type]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[sub_type]  WITH CHECK ADD  CONSTRAINT [FK_sub_type_id_type] FOREIGN KEY([id_type])
REFERENCES [dbo].[type] ([id_type])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sub_type] CHECK CONSTRAINT [FK_sub_type_id_type]
GO
/****** Object:  ForeignKey [FK_fac_type_id_faculty]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[fac_type]  WITH CHECK ADD  CONSTRAINT [FK_fac_type_id_faculty] FOREIGN KEY([id_faculty])
REFERENCES [dbo].[faculty] ([id_faculty])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[fac_type] CHECK CONSTRAINT [FK_fac_type_id_faculty]
GO
/****** Object:  ForeignKey [FK_fac_type_id_type]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[fac_type]  WITH CHECK ADD  CONSTRAINT [FK_fac_type_id_type] FOREIGN KEY([id_type])
REFERENCES [dbo].[type] ([id_type])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[fac_type] CHECK CONSTRAINT [FK_fac_type_id_type]
GO
/****** Object:  ForeignKey [FK_FacultiesDepartaments_Departaments]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[FacultiesDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_FacultiesDepartaments_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FacultiesDepartaments] CHECK CONSTRAINT [FK_FacultiesDepartaments_Departaments]
GO
/****** Object:  ForeignKey [FK_FacultiesDepartaments_Faculties]    Script Date: 10/24/2010 15:51:26 ******/
ALTER TABLE [dbo].[FacultiesDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_FacultiesDepartaments_Faculties] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculties] ([FacultyID])
GO
ALTER TABLE [dbo].[FacultiesDepartaments] CHECK CONSTRAINT [FK_FacultiesDepartaments_Faculties]
GO
