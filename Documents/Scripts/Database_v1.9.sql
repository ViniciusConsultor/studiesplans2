USE [master]
GO
/****** Object:  Database [SP]    Script Date: 11/20/2010 16:40:35 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'SP')
BEGIN
CREATE DATABASE [SP] ON  PRIMARY 
( NAME = N'SP', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\SP.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SP_log', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\SP_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END
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
ALTER DATABASE [SP] SET READ_COMMITTED_SNAPSHOT OFF
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
/****** Object:  ForeignKey [FK_SubjectTypesData_SubjectsData]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectTypesData_SubjectsData]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectTypesData]'))
ALTER TABLE [dbo].[SubjectTypesData] DROP CONSTRAINT [FK_SubjectTypesData_SubjectsData]
GO
/****** Object:  ForeignKey [FK_SubjectTypesData_SubjectTypes]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectTypesData_SubjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectTypesData]'))
ALTER TABLE [dbo].[SubjectTypesData] DROP CONSTRAINT [FK_SubjectTypesData_SubjectTypes]
GO
/****** Object:  ForeignKey [FK_PlansData_Plans]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PlansData_Plans]') AND parent_object_id = OBJECT_ID(N'[dbo].[PlansData]'))
ALTER TABLE [dbo].[PlansData] DROP CONSTRAINT [FK_PlansData_Plans]
GO
/****** Object:  ForeignKey [FK_PlansData_SubjectsData]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PlansData_SubjectsData]') AND parent_object_id = OBJECT_ID(N'[dbo].[PlansData]'))
ALTER TABLE [dbo].[PlansData] DROP CONSTRAINT [FK_PlansData_SubjectsData]
GO
/****** Object:  ForeignKey [FK_Users_Roles]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Users_Roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_Users_Roles]
GO
/****** Object:  ForeignKey [FK_RolesPrivilages_Privilages]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RolesPrivilages_Privilages]') AND parent_object_id = OBJECT_ID(N'[dbo].[RolesPrivilages]'))
ALTER TABLE [dbo].[RolesPrivilages] DROP CONSTRAINT [FK_RolesPrivilages_Privilages]
GO
/****** Object:  ForeignKey [FK_RolesPrivilages_Roles]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RolesPrivilages_Roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[RolesPrivilages]'))
ALTER TABLE [dbo].[RolesPrivilages] DROP CONSTRAINT [FK_RolesPrivilages_Roles]
GO
/****** Object:  ForeignKey [FK_InstitutesDepartaments_Departaments]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstitutesDepartaments_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstitutesDepartaments]'))
ALTER TABLE [dbo].[InstitutesDepartaments] DROP CONSTRAINT [FK_InstitutesDepartaments_Departaments]
GO
/****** Object:  ForeignKey [FK_InstitutesDepartaments_Institutes]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstitutesDepartaments_Institutes]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstitutesDepartaments]'))
ALTER TABLE [dbo].[InstitutesDepartaments] DROP CONSTRAINT [FK_InstitutesDepartaments_Institutes]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Departaments]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Departaments]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Faculties]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Faculties]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Institutes]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Institutes]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Institutes]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Semesters]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Semesters]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Semesters]
GO
/****** Object:  ForeignKey [FK_SubjectsData_SpecializationsData]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_SpecializationsData]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_SpecializationsData]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Subjects]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Subjects]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Subjects]
GO
/****** Object:  ForeignKey [FK_Plans_Departaments]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [FK_Plans_Departaments]
GO
/****** Object:  ForeignKey [FK_Plans_Faculties]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [FK_Plans_Faculties]
GO
/****** Object:  ForeignKey [FK_Plans_StudiesTypes]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_StudiesTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [FK_Plans_StudiesTypes]
GO
/****** Object:  ForeignKey [FK_Plans_Users]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [FK_Plans_Users]
GO
/****** Object:  ForeignKey [FK_FacultiesDepartaments_Departaments]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FacultiesDepartaments_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[FacultiesDepartaments]'))
ALTER TABLE [dbo].[FacultiesDepartaments] DROP CONSTRAINT [FK_FacultiesDepartaments_Departaments]
GO
/****** Object:  ForeignKey [FK_FacultiesDepartaments_Faculties]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FacultiesDepartaments_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[FacultiesDepartaments]'))
ALTER TABLE [dbo].[FacultiesDepartaments] DROP CONSTRAINT [FK_FacultiesDepartaments_Faculties]
GO
/****** Object:  ForeignKey [FK_Specializations_Departaments]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Specializations_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[Specializations]'))
ALTER TABLE [dbo].[Specializations] DROP CONSTRAINT [FK_Specializations_Departaments]
GO
/****** Object:  ForeignKey [FK_Specializations_Faculties]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Specializations_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[Specializations]'))
ALTER TABLE [dbo].[Specializations] DROP CONSTRAINT [FK_Specializations_Faculties]
GO
/****** Object:  ForeignKey [FK_SpecializationsData_Specializations]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SpecializationsData_Specializations]') AND parent_object_id = OBJECT_ID(N'[dbo].[SpecializationsData]'))
ALTER TABLE [dbo].[SpecializationsData] DROP CONSTRAINT [FK_SpecializationsData_Specializations]
GO
/****** Object:  Table [dbo].[SpecializationsData]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SpecializationsData_Specializations]') AND parent_object_id = OBJECT_ID(N'[dbo].[SpecializationsData]'))
ALTER TABLE [dbo].[SpecializationsData] DROP CONSTRAINT [FK_SpecializationsData_Specializations]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpecializationsData]') AND type in (N'U'))
DROP TABLE [dbo].[SpecializationsData]
GO
/****** Object:  Table [dbo].[Specializations]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Specializations_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[Specializations]'))
ALTER TABLE [dbo].[Specializations] DROP CONSTRAINT [FK_Specializations_Departaments]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Specializations_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[Specializations]'))
ALTER TABLE [dbo].[Specializations] DROP CONSTRAINT [FK_Specializations_Faculties]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Specializations]') AND type in (N'U'))
DROP TABLE [dbo].[Specializations]
GO
/****** Object:  Table [dbo].[FacultiesDepartaments]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FacultiesDepartaments_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[FacultiesDepartaments]'))
ALTER TABLE [dbo].[FacultiesDepartaments] DROP CONSTRAINT [FK_FacultiesDepartaments_Departaments]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FacultiesDepartaments_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[FacultiesDepartaments]'))
ALTER TABLE [dbo].[FacultiesDepartaments] DROP CONSTRAINT [FK_FacultiesDepartaments_Faculties]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FacultiesDepartaments]') AND type in (N'U'))
DROP TABLE [dbo].[FacultiesDepartaments]
GO
/****** Object:  Table [dbo].[Plans]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [FK_Plans_Departaments]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [FK_Plans_Faculties]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_StudiesTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [FK_Plans_StudiesTypes]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [FK_Plans_Users]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Plans_IsArchiewed]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Plans] DROP CONSTRAINT [DF_Plans_IsArchiewed]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Plans]') AND type in (N'U'))
DROP TABLE [dbo].[Plans]
GO
/****** Object:  Table [dbo].[SubjectsData]    Script Date: 11/20/2010 16:40:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Departaments]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Faculties]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Institutes]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Institutes]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Semesters]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Semesters]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_SpecializationsData]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_SpecializationsData]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Subjects]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] DROP CONSTRAINT [FK_SubjectsData_Subjects]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SubjectsData]') AND type in (N'U'))
DROP TABLE [dbo].[SubjectsData]
GO
/****** Object:  Table [dbo].[InstitutesDepartaments]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstitutesDepartaments_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstitutesDepartaments]'))
ALTER TABLE [dbo].[InstitutesDepartaments] DROP CONSTRAINT [FK_InstitutesDepartaments_Departaments]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstitutesDepartaments_Institutes]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstitutesDepartaments]'))
ALTER TABLE [dbo].[InstitutesDepartaments] DROP CONSTRAINT [FK_InstitutesDepartaments_Institutes]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstitutesDepartaments]') AND type in (N'U'))
DROP TABLE [dbo].[InstitutesDepartaments]
GO
/****** Object:  Table [dbo].[RolesPrivilages]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RolesPrivilages_Privilages]') AND parent_object_id = OBJECT_ID(N'[dbo].[RolesPrivilages]'))
ALTER TABLE [dbo].[RolesPrivilages] DROP CONSTRAINT [FK_RolesPrivilages_Privilages]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RolesPrivilages_Roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[RolesPrivilages]'))
ALTER TABLE [dbo].[RolesPrivilages] DROP CONSTRAINT [FK_RolesPrivilages_Roles]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RolesPrivilages]') AND type in (N'U'))
DROP TABLE [dbo].[RolesPrivilages]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Users_Roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_Users_Roles]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
DROP TABLE [dbo].[Users]
GO
/****** Object:  Table [dbo].[PlansData]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PlansData_Plans]') AND parent_object_id = OBJECT_ID(N'[dbo].[PlansData]'))
ALTER TABLE [dbo].[PlansData] DROP CONSTRAINT [FK_PlansData_Plans]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PlansData_SubjectsData]') AND parent_object_id = OBJECT_ID(N'[dbo].[PlansData]'))
ALTER TABLE [dbo].[PlansData] DROP CONSTRAINT [FK_PlansData_SubjectsData]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PlansData]') AND type in (N'U'))
DROP TABLE [dbo].[PlansData]
GO
/****** Object:  Table [dbo].[SubjectTypesData]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectTypesData_SubjectsData]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectTypesData]'))
ALTER TABLE [dbo].[SubjectTypesData] DROP CONSTRAINT [FK_SubjectTypesData_SubjectsData]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectTypesData_SubjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectTypesData]'))
ALTER TABLE [dbo].[SubjectTypesData] DROP CONSTRAINT [FK_SubjectTypesData_SubjectTypes]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SubjectTypesData]') AND type in (N'U'))
DROP TABLE [dbo].[SubjectTypesData]
GO
/****** Object:  Table [dbo].[Semesters]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Semesters]') AND type in (N'U'))
DROP TABLE [dbo].[Semesters]
GO
/****** Object:  Table [dbo].[StudiesTypes]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StudiesTypes]') AND type in (N'U'))
DROP TABLE [dbo].[StudiesTypes]
GO
/****** Object:  Table [dbo].[Departaments]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Departaments]') AND type in (N'U'))
DROP TABLE [dbo].[Departaments]
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Faculties]') AND type in (N'U'))
DROP TABLE [dbo].[Faculties]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Subjects]') AND type in (N'U'))
DROP TABLE [dbo].[Subjects]
GO
/****** Object:  Table [dbo].[Privilages]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Privilages]') AND type in (N'U'))
DROP TABLE [dbo].[Privilages]
GO
/****** Object:  Table [dbo].[SubjectTypes]    Script Date: 11/20/2010 16:40:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SubjectTypes]') AND type in (N'U'))
DROP TABLE [dbo].[SubjectTypes]
GO
/****** Object:  Table [dbo].[Institutes]    Script Date: 11/20/2010 16:40:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Institutes]') AND type in (N'U'))
DROP TABLE [dbo].[Institutes]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 11/20/2010 16:40:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Roles]') AND type in (N'U'))
DROP TABLE [dbo].[Roles]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 11/20/2010 16:40:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Roles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Institutes]    Script Date: 11/20/2010 16:40:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Institutes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Institutes](
	[InstituteID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_Institutes] PRIMARY KEY CLUSTERED 
(
	[InstituteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[SubjectTypes]    Script Date: 11/20/2010 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SubjectTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SubjectTypes](
	[SubjectTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SubjectTypes] PRIMARY KEY CLUSTERED 
(
	[SubjectTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Privilages]    Script Date: 11/20/2010 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Privilages]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Privilages](
	[PrivilageID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Privilages] PRIMARY KEY CLUSTERED 
(
	[PrivilageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 11/20/2010 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Subjects]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Subjects](
	[SubjectID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 11/20/2010 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Faculties]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Faculties](
	[FacultyID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[FacultyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Departaments]    Script Date: 11/20/2010 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Departaments]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Departaments](
	[DepartamentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_Departaments] PRIMARY KEY CLUSTERED 
(
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[StudiesTypes]    Script Date: 11/20/2010 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StudiesTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StudiesTypes](
	[StudiesTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_StudiesTypes] PRIMARY KEY CLUSTERED 
(
	[StudiesTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Semesters]    Script Date: 11/20/2010 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Semesters]') AND type in (N'U'))
BEGIN
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
END
GO
/****** Object:  Table [dbo].[SubjectTypesData]    Script Date: 11/20/2010 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SubjectTypesData]') AND type in (N'U'))
BEGIN
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
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[SubjectTypesData]') AND name = N'FK_SubjectDataID')
CREATE NONCLUSTERED INDEX [FK_SubjectDataID] ON [dbo].[SubjectTypesData] 
(
	[SubjectDataID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[SubjectTypesData]') AND name = N'FK_SubjectTypeID')
CREATE NONCLUSTERED INDEX [FK_SubjectTypeID] ON [dbo].[SubjectTypesData] 
(
	[SubjectTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlansData]    Script Date: 11/20/2010 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PlansData]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PlansData](
	[PlanID] [int] NOT NULL,
	[SubjectDataID] [int] NOT NULL,
 CONSTRAINT [PK_PlansData] PRIMARY KEY CLUSTERED 
(
	[PlanID] ASC,
	[SubjectDataID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[PlansData]') AND name = N'FK_PlanID')
CREATE NONCLUSTERED INDEX [FK_PlanID] ON [dbo].[PlansData] 
(
	[PlanID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[PlansData]') AND name = N'FK_Subject_DataID_Plans')
CREATE NONCLUSTERED INDEX [FK_Subject_DataID_Plans] ON [dbo].[PlansData] 
(
	[SubjectDataID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/20/2010 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[LastActiveDate] [datetime] NULL,
	[RoleID] [int] NOT NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND name = N'FK_RoleID')
CREATE NONCLUSTERED INDEX [FK_RoleID] ON [dbo].[Users] 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolesPrivilages]    Script Date: 11/20/2010 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RolesPrivilages]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RolesPrivilages](
	[RoleID] [int] NOT NULL,
	[PrivilageID] [int] NOT NULL,
 CONSTRAINT [PK_RolesPrivilages] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[PrivilageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[RolesPrivilages]') AND name = N'FK_RolesPrivilages_Privilages')
CREATE NONCLUSTERED INDEX [FK_RolesPrivilages_Privilages] ON [dbo].[RolesPrivilages] 
(
	[PrivilageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[RolesPrivilages]') AND name = N'FK_RolesPrivilages_Roles')
CREATE NONCLUSTERED INDEX [FK_RolesPrivilages_Roles] ON [dbo].[RolesPrivilages] 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InstitutesDepartaments]    Script Date: 11/20/2010 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstitutesDepartaments]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InstitutesDepartaments](
	[DepartamentID] [int] NOT NULL,
	[InstituteID] [int] NOT NULL,
 CONSTRAINT [PK_InstitutesDepartaments] PRIMARY KEY CLUSTERED 
(
	[DepartamentID] ASC,
	[InstituteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[InstitutesDepartaments]') AND name = N'FK_InstitutesDepartaments_DepartamentID')
CREATE NONCLUSTERED INDEX [FK_InstitutesDepartaments_DepartamentID] ON [dbo].[InstitutesDepartaments] 
(
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[InstitutesDepartaments]') AND name = N'FK_InstitutesDepartaments_InstituteID')
CREATE NONCLUSTERED INDEX [FK_InstitutesDepartaments_InstituteID] ON [dbo].[InstitutesDepartaments] 
(
	[InstituteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectsData]    Script Date: 11/20/2010 16:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SubjectsData]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SubjectsData](
	[SubjectID] [int] NOT NULL,
	[SemesterID] [int] NOT NULL,
	[FacultyID] [int] NOT NULL,
	[Ects] [float] NOT NULL,
	[IsExam] [bit] NOT NULL,
	[SpecializationDataID] [int] NULL,
	[DepartamentID] [int] NOT NULL,
	[SubjectDataID] [int] IDENTITY(1,1) NOT NULL,
	[InstituteID] [int] NULL,
	[IsElective] [bit] NOT NULL,
	[IsGeneral] [bit] NOT NULL,
 CONSTRAINT [PK_SubjectsData] PRIMARY KEY CLUSTERED 
(
	[SubjectDataID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[SubjectsData]') AND name = N'FK_DepartamentID')
CREATE NONCLUSTERED INDEX [FK_DepartamentID] ON [dbo].[SubjectsData] 
(
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[SubjectsData]') AND name = N'FK_FacultyID')
CREATE NONCLUSTERED INDEX [FK_FacultyID] ON [dbo].[SubjectsData] 
(
	[FacultyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[SubjectsData]') AND name = N'FK_InstituteID')
CREATE NONCLUSTERED INDEX [FK_InstituteID] ON [dbo].[SubjectsData] 
(
	[InstituteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[SubjectsData]') AND name = N'FK_SemesterID')
CREATE NONCLUSTERED INDEX [FK_SemesterID] ON [dbo].[SubjectsData] 
(
	[SemesterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[SubjectsData]') AND name = N'FK_SpcializationsData')
CREATE NONCLUSTERED INDEX [FK_SpcializationsData] ON [dbo].[SubjectsData] 
(
	[SubjectDataID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[SubjectsData]') AND name = N'FK_SubjectID')
CREATE NONCLUSTERED INDEX [FK_SubjectID] ON [dbo].[SubjectsData] 
(
	[SubjectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plans]    Script Date: 11/20/2010 16:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Plans]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Plans](
	[PlanID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[YearStart] [datetime] NULL,
	[YearEnd] [datetime] NULL,
	[SemesterStart] [int] NULL,
	[SemesterEnd] [int] NULL,
	[IsMandatory] [bit] NOT NULL,
	[DepartamentID] [int] NOT NULL,
	[FacultyID] [int] NOT NULL,
	[StudiesTypeID] [int] NOT NULL,
	[LastEditUserID] [int] NOT NULL,
	[Review] [ntext] NULL,
	[IsArchiewed] [bit] NOT NULL CONSTRAINT [DF_Plans_IsArchiewed]  DEFAULT ((0)),
 CONSTRAINT [PK_Plans] PRIMARY KEY CLUSTERED 
(
	[PlanID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Plans]') AND name = N'FK_DepartamentID_Plans')
CREATE NONCLUSTERED INDEX [FK_DepartamentID_Plans] ON [dbo].[Plans] 
(
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Plans]') AND name = N'FK_FacultyID_Plans')
CREATE NONCLUSTERED INDEX [FK_FacultyID_Plans] ON [dbo].[Plans] 
(
	[FacultyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Plans]') AND name = N'FK_LastEditUserID')
CREATE NONCLUSTERED INDEX [FK_LastEditUserID] ON [dbo].[Plans] 
(
	[LastEditUserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Plans]') AND name = N'FK_StudiesTypeID')
CREATE NONCLUSTERED INDEX [FK_StudiesTypeID] ON [dbo].[Plans] 
(
	[SemesterStart] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacultiesDepartaments]    Script Date: 11/20/2010 16:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FacultiesDepartaments]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FacultiesDepartaments](
	[FacultyID] [int] NOT NULL,
	[DepartamentID] [int] NOT NULL,
 CONSTRAINT [PK_FacultiesDepartaments] PRIMARY KEY CLUSTERED 
(
	[FacultyID] ASC,
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[FacultiesDepartaments]') AND name = N'FK_FacultiesDepartaments_DepartamentID')
CREATE NONCLUSTERED INDEX [FK_FacultiesDepartaments_DepartamentID] ON [dbo].[FacultiesDepartaments] 
(
	[DepartamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[FacultiesDepartaments]') AND name = N'FK_FacultiesDepartaments_FacultyID')
CREATE NONCLUSTERED INDEX [FK_FacultiesDepartaments_FacultyID] ON [dbo].[FacultiesDepartaments] 
(
	[FacultyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specializations]    Script Date: 11/20/2010 16:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Specializations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Specializations](
	[SpecializationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[DepartamentID] [int] NOT NULL,
	[FacultyID] [int] NOT NULL,
 CONSTRAINT [PK_Specializations] PRIMARY KEY CLUSTERED 
(
	[SpecializationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[SpecializationsData]    Script Date: 11/20/2010 16:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpecializationsData]') AND type in (N'U'))
BEGIN
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
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[SpecializationsData]') AND name = N'FK_SpecializationID')
CREATE NONCLUSTERED INDEX [FK_SpecializationID] ON [dbo].[SpecializationsData] 
(
	[SpecializationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_SubjectTypesData_SubjectsData]    Script Date: 11/20/2010 16:40:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectTypesData_SubjectsData]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectTypesData]'))
ALTER TABLE [dbo].[SubjectTypesData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectTypesData_SubjectsData] FOREIGN KEY([SubjectDataID])
REFERENCES [dbo].[SubjectsData] ([SubjectDataID])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectTypesData_SubjectsData]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectTypesData]'))
ALTER TABLE [dbo].[SubjectTypesData] CHECK CONSTRAINT [FK_SubjectTypesData_SubjectsData]
GO
/****** Object:  ForeignKey [FK_SubjectTypesData_SubjectTypes]    Script Date: 11/20/2010 16:40:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectTypesData_SubjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectTypesData]'))
ALTER TABLE [dbo].[SubjectTypesData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectTypesData_SubjectTypes] FOREIGN KEY([SubjectTypeID])
REFERENCES [dbo].[SubjectTypes] ([SubjectTypeID])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectTypesData_SubjectTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectTypesData]'))
ALTER TABLE [dbo].[SubjectTypesData] CHECK CONSTRAINT [FK_SubjectTypesData_SubjectTypes]
GO
/****** Object:  ForeignKey [FK_PlansData_Plans]    Script Date: 11/20/2010 16:40:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PlansData_Plans]') AND parent_object_id = OBJECT_ID(N'[dbo].[PlansData]'))
ALTER TABLE [dbo].[PlansData]  WITH CHECK ADD  CONSTRAINT [FK_PlansData_Plans] FOREIGN KEY([PlanID])
REFERENCES [dbo].[Plans] ([PlanID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PlansData_Plans]') AND parent_object_id = OBJECT_ID(N'[dbo].[PlansData]'))
ALTER TABLE [dbo].[PlansData] CHECK CONSTRAINT [FK_PlansData_Plans]
GO
/****** Object:  ForeignKey [FK_PlansData_SubjectsData]    Script Date: 11/20/2010 16:40:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PlansData_SubjectsData]') AND parent_object_id = OBJECT_ID(N'[dbo].[PlansData]'))
ALTER TABLE [dbo].[PlansData]  WITH CHECK ADD  CONSTRAINT [FK_PlansData_SubjectsData] FOREIGN KEY([SubjectDataID])
REFERENCES [dbo].[SubjectsData] ([SubjectDataID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PlansData_SubjectsData]') AND parent_object_id = OBJECT_ID(N'[dbo].[PlansData]'))
ALTER TABLE [dbo].[PlansData] CHECK CONSTRAINT [FK_PlansData_SubjectsData]
GO
/****** Object:  ForeignKey [FK_Users_Roles]    Script Date: 11/20/2010 16:40:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Users_Roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Users_Roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
/****** Object:  ForeignKey [FK_RolesPrivilages_Privilages]    Script Date: 11/20/2010 16:40:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RolesPrivilages_Privilages]') AND parent_object_id = OBJECT_ID(N'[dbo].[RolesPrivilages]'))
ALTER TABLE [dbo].[RolesPrivilages]  WITH CHECK ADD  CONSTRAINT [FK_RolesPrivilages_Privilages] FOREIGN KEY([PrivilageID])
REFERENCES [dbo].[Privilages] ([PrivilageID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RolesPrivilages_Privilages]') AND parent_object_id = OBJECT_ID(N'[dbo].[RolesPrivilages]'))
ALTER TABLE [dbo].[RolesPrivilages] CHECK CONSTRAINT [FK_RolesPrivilages_Privilages]
GO
/****** Object:  ForeignKey [FK_RolesPrivilages_Roles]    Script Date: 11/20/2010 16:40:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RolesPrivilages_Roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[RolesPrivilages]'))
ALTER TABLE [dbo].[RolesPrivilages]  WITH CHECK ADD  CONSTRAINT [FK_RolesPrivilages_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RolesPrivilages_Roles]') AND parent_object_id = OBJECT_ID(N'[dbo].[RolesPrivilages]'))
ALTER TABLE [dbo].[RolesPrivilages] CHECK CONSTRAINT [FK_RolesPrivilages_Roles]
GO
/****** Object:  ForeignKey [FK_InstitutesDepartaments_Departaments]    Script Date: 11/20/2010 16:40:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstitutesDepartaments_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstitutesDepartaments]'))
ALTER TABLE [dbo].[InstitutesDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_InstitutesDepartaments_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstitutesDepartaments_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstitutesDepartaments]'))
ALTER TABLE [dbo].[InstitutesDepartaments] CHECK CONSTRAINT [FK_InstitutesDepartaments_Departaments]
GO
/****** Object:  ForeignKey [FK_InstitutesDepartaments_Institutes]    Script Date: 11/20/2010 16:40:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstitutesDepartaments_Institutes]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstitutesDepartaments]'))
ALTER TABLE [dbo].[InstitutesDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_InstitutesDepartaments_Institutes] FOREIGN KEY([InstituteID])
REFERENCES [dbo].[Institutes] ([InstituteID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstitutesDepartaments_Institutes]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstitutesDepartaments]'))
ALTER TABLE [dbo].[InstitutesDepartaments] CHECK CONSTRAINT [FK_InstitutesDepartaments_Institutes]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Departaments]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Departaments]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Faculties]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Faculties] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculties] ([FacultyID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Faculties]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Institutes]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Institutes]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Institutes] FOREIGN KEY([InstituteID])
REFERENCES [dbo].[Institutes] ([InstituteID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Institutes]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Institutes]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Semesters]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Semesters]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Semesters] FOREIGN KEY([SemesterID])
REFERENCES [dbo].[Semesters] ([SemesterID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Semesters]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Semesters]
GO
/****** Object:  ForeignKey [FK_SubjectsData_SpecializationsData]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_SpecializationsData]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_SpecializationsData] FOREIGN KEY([SpecializationDataID])
REFERENCES [dbo].[SpecializationsData] ([SpecializationDataID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_SpecializationsData]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_SpecializationsData]
GO
/****** Object:  ForeignKey [FK_SubjectsData_Subjects]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Subjects]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData]  WITH CHECK ADD  CONSTRAINT [FK_SubjectsData_Subjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([SubjectID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubjectsData_Subjects]') AND parent_object_id = OBJECT_ID(N'[dbo].[SubjectsData]'))
ALTER TABLE [dbo].[SubjectsData] CHECK CONSTRAINT [FK_SubjectsData_Subjects]
GO
/****** Object:  ForeignKey [FK_Plans_Departaments]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_Departaments]
GO
/****** Object:  ForeignKey [FK_Plans_Faculties]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_Faculties] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculties] ([FacultyID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_Faculties]
GO
/****** Object:  ForeignKey [FK_Plans_StudiesTypes]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_StudiesTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_StudiesTypes] FOREIGN KEY([StudiesTypeID])
REFERENCES [dbo].[StudiesTypes] ([StudiesTypeID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_StudiesTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_StudiesTypes]
GO
/****** Object:  ForeignKey [FK_Plans_Users]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans]  WITH CHECK ADD  CONSTRAINT [FK_Plans_Users] FOREIGN KEY([LastEditUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Plans_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Plans]'))
ALTER TABLE [dbo].[Plans] CHECK CONSTRAINT [FK_Plans_Users]
GO
/****** Object:  ForeignKey [FK_FacultiesDepartaments_Departaments]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FacultiesDepartaments_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[FacultiesDepartaments]'))
ALTER TABLE [dbo].[FacultiesDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_FacultiesDepartaments_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FacultiesDepartaments_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[FacultiesDepartaments]'))
ALTER TABLE [dbo].[FacultiesDepartaments] CHECK CONSTRAINT [FK_FacultiesDepartaments_Departaments]
GO
/****** Object:  ForeignKey [FK_FacultiesDepartaments_Faculties]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FacultiesDepartaments_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[FacultiesDepartaments]'))
ALTER TABLE [dbo].[FacultiesDepartaments]  WITH CHECK ADD  CONSTRAINT [FK_FacultiesDepartaments_Faculties] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculties] ([FacultyID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FacultiesDepartaments_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[FacultiesDepartaments]'))
ALTER TABLE [dbo].[FacultiesDepartaments] CHECK CONSTRAINT [FK_FacultiesDepartaments_Faculties]
GO
/****** Object:  ForeignKey [FK_Specializations_Departaments]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Specializations_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[Specializations]'))
ALTER TABLE [dbo].[Specializations]  WITH CHECK ADD  CONSTRAINT [FK_Specializations_Departaments] FOREIGN KEY([DepartamentID])
REFERENCES [dbo].[Departaments] ([DepartamentID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Specializations_Departaments]') AND parent_object_id = OBJECT_ID(N'[dbo].[Specializations]'))
ALTER TABLE [dbo].[Specializations] CHECK CONSTRAINT [FK_Specializations_Departaments]
GO
/****** Object:  ForeignKey [FK_Specializations_Faculties]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Specializations_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[Specializations]'))
ALTER TABLE [dbo].[Specializations]  WITH CHECK ADD  CONSTRAINT [FK_Specializations_Faculties] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculties] ([FacultyID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Specializations_Faculties]') AND parent_object_id = OBJECT_ID(N'[dbo].[Specializations]'))
ALTER TABLE [dbo].[Specializations] CHECK CONSTRAINT [FK_Specializations_Faculties]
GO
/****** Object:  ForeignKey [FK_SpecializationsData_Specializations]    Script Date: 11/20/2010 16:40:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SpecializationsData_Specializations]') AND parent_object_id = OBJECT_ID(N'[dbo].[SpecializationsData]'))
ALTER TABLE [dbo].[SpecializationsData]  WITH CHECK ADD  CONSTRAINT [FK_SpecializationsData_Specializations] FOREIGN KEY([SpecializationID])
REFERENCES [dbo].[Specializations] ([SpecializationID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SpecializationsData_Specializations]') AND parent_object_id = OBJECT_ID(N'[dbo].[SpecializationsData]'))
ALTER TABLE [dbo].[SpecializationsData] CHECK CONSTRAINT [FK_SpecializationsData_Specializations]
GO

USE [SP]
GO
/****** Object:  Table [dbo].[Rules]    Script Date: 12/12/2010 10:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rules](
	[RuleId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](300) COLLATE Polish_CI_AS NOT NULL,
	[Value] [float] NOT NULL,
	[SubjectType] [nvarchar](100) COLLATE Polish_CI_AS NULL,
	[Semester] [smallint] NOT NULL,
	[Subject] [nvarchar](100) COLLATE Polish_CI_AS NULL,
	[PlanId] [int] NOT NULL,
 CONSTRAINT [PK_Rules] PRIMARY KEY CLUSTERED 
(
	[RuleId] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Rules]  WITH CHECK ADD  CONSTRAINT [FK_Rules_Plans] FOREIGN KEY([PlanId])
REFERENCES [dbo].[Plans] ([PlanID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Rules] CHECK CONSTRAINT [FK_Rules_Plans]