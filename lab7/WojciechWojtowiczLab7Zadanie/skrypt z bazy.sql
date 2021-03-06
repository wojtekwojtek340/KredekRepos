USE [master]
GO
/****** Object:  Database [Restaurant]    Script Date: 19.01.2020 15:19:51 ******/
CREATE DATABASE [Restaurant]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Restaurant', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.WOJTEKSQL\MSSQL\DATA\Restaurant.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Restaurant_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.WOJTEKSQL\MSSQL\DATA\Restaurant_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Restaurant] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Restaurant].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Restaurant] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Restaurant] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Restaurant] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Restaurant] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Restaurant] SET ARITHABORT OFF 
GO
ALTER DATABASE [Restaurant] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Restaurant] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Restaurant] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Restaurant] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Restaurant] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Restaurant] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Restaurant] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Restaurant] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Restaurant] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Restaurant] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Restaurant] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Restaurant] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Restaurant] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Restaurant] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Restaurant] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Restaurant] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Restaurant] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Restaurant] SET RECOVERY FULL 
GO
ALTER DATABASE [Restaurant] SET  MULTI_USER 
GO
ALTER DATABASE [Restaurant] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Restaurant] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Restaurant] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Restaurant] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Restaurant] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Restaurant', N'ON'
GO
ALTER DATABASE [Restaurant] SET QUERY_STORE = OFF
GO
USE [Restaurant]
GO
/****** Object:  Table [dbo].[Cakes]    Script Date: 19.01.2020 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cakes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NULL,
	[Cost] [money] NULL,
 CONSTRAINT [PK_Cakes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Coffee]    Script Date: 19.01.2020 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coffee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](100) NULL,
	[Cost] [money] NULL,
 CONSTRAINT [PK_Caffe] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cakes] ON 

INSERT [dbo].[Cakes] ([Id], [Name], [Description], [Cost]) VALUES (1, N'CIASTO LION', N'Ciasto bez pieczenia na herbatnikach z masą kajmakową, budyniową i masłem orzechowym', 12.0000)
INSERT [dbo].[Cakes] ([Id], [Name], [Description], [Cost]) VALUES (2, N'MAKOWA PANIENKA', N'Ciasto makowe z kremem budyniowym i dżemem', 11.0000)
INSERT [dbo].[Cakes] ([Id], [Name], [Description], [Cost]) VALUES (3, N'BROWNIE Z MALINAMI', N'Wilgotne ciasto czekoladowe z malinami', 13.0000)
SET IDENTITY_INSERT [dbo].[Cakes] OFF
SET IDENTITY_INSERT [dbo].[Coffee] ON 

INSERT [dbo].[Coffee] ([Id], [Name], [Description], [Cost]) VALUES (1, N'Espresso', N'Idealny sposób na szybkie pobudzenie!', 8.0000)
INSERT [dbo].[Coffee] ([Id], [Name], [Description], [Cost]) VALUES (2, N'Ristretto', N'Ristretto to w zasadzie espresso o podwójnej mocy! ', 10.0000)
INSERT [dbo].[Coffee] ([Id], [Name], [Description], [Cost]) VALUES (5, N'Cappuccino', N'Cappuccino to napój kawowy, którego głównymi składnikami są espresso i spienione mleko.', 11.0000)
INSERT [dbo].[Coffee] ([Id], [Name], [Description], [Cost]) VALUES (6, N'Caffe Latte', N'Wyjątkowo mleczna i łagodna kawa.', 9.0000)
INSERT [dbo].[Coffee] ([Id], [Name], [Description], [Cost]) VALUES (7, N'Latte Macchiato', N'Latte macchiato to również dobra opcja dla miłośników mlecznej piany!', 13.0000)
SET IDENTITY_INSERT [dbo].[Coffee] OFF
USE [master]
GO
ALTER DATABASE [Restaurant] SET  READ_WRITE 
GO
