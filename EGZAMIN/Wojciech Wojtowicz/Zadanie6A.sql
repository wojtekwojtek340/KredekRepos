USE [master]
GO
/****** Object:  Database [CodersTeam]    Script Date: 05.02.2020 20:04:34 ******/
CREATE DATABASE [CodersTeam]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CodersTeam', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.WOJTEKSQL\MSSQL\DATA\CodersTeam.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CodersTeam_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.WOJTEKSQL\MSSQL\DATA\CodersTeam_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CodersTeam] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CodersTeam].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CodersTeam] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CodersTeam] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CodersTeam] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CodersTeam] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CodersTeam] SET ARITHABORT OFF 
GO
ALTER DATABASE [CodersTeam] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CodersTeam] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CodersTeam] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CodersTeam] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CodersTeam] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CodersTeam] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CodersTeam] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CodersTeam] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CodersTeam] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CodersTeam] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CodersTeam] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CodersTeam] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CodersTeam] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CodersTeam] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CodersTeam] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CodersTeam] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CodersTeam] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CodersTeam] SET RECOVERY FULL 
GO
ALTER DATABASE [CodersTeam] SET  MULTI_USER 
GO
ALTER DATABASE [CodersTeam] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CodersTeam] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CodersTeam] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CodersTeam] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CodersTeam] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CodersTeam', N'ON'
GO
ALTER DATABASE [CodersTeam] SET QUERY_STORE = OFF
GO
USE [CodersTeam]
GO
/****** Object:  Table [dbo].[Programmers]    Script Date: 05.02.2020 20:04:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Programmers](
	[idProgrammers] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[surname] [nvarchar](100) NULL,
	[levell] [int] NULL,
 CONSTRAINT [PK_Programmers] PRIMARY KEY CLUSTERED 
(
	[idProgrammers] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 05.02.2020 20:04:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[idProject] [int] IDENTITY(1,1) NOT NULL,
	[idProgrammer] [int] NULL,
	[name] [nvarchar](100) NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[idProject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Programmers] ON 

INSERT [dbo].[Programmers] ([idProgrammers], [name], [surname], [levell]) VALUES (1, N'WOjtek', N'wojtek', 2)
INSERT [dbo].[Programmers] ([idProgrammers], [name], [surname], [levell]) VALUES (2, N'michal', N'michal', 4)
INSERT [dbo].[Programmers] ([idProgrammers], [name], [surname], [levell]) VALUES (3, N'lukasz', N'lukasz', 6)
INSERT [dbo].[Programmers] ([idProgrammers], [name], [surname], [levell]) VALUES (4, N'janek', N'janek', 10)
SET IDENTITY_INSERT [dbo].[Programmers] OFF
SET IDENTITY_INSERT [dbo].[Projects] ON 

INSERT [dbo].[Projects] ([idProject], [idProgrammer], [name]) VALUES (1, 2, N'test2')
INSERT [dbo].[Projects] ([idProject], [idProgrammer], [name]) VALUES (2, 2, N'test3')
SET IDENTITY_INSERT [dbo].[Projects] OFF
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_Projects_Projects] FOREIGN KEY([idProject])
REFERENCES [dbo].[Projects] ([idProject])
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_Projects_Projects]
GO
USE [master]
GO
ALTER DATABASE [CodersTeam] SET  READ_WRITE 
GO
