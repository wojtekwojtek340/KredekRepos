USE [master]
GO
/****** Object:  Database [FishingDatabase]    Script Date: 08.12.2019 01:30:04 ******/
CREATE DATABASE [FishingDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FishingDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.WOJTEKSQL\MSSQL\DATA\FishingDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FishingDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.WOJTEKSQL\MSSQL\DATA\FishingDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FishingDatabase] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FishingDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FishingDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FishingDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FishingDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FishingDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FishingDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [FishingDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FishingDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FishingDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FishingDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FishingDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FishingDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FishingDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FishingDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FishingDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FishingDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FishingDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FishingDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FishingDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FishingDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FishingDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FishingDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FishingDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FishingDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [FishingDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [FishingDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FishingDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FishingDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FishingDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FishingDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FishingDatabase', N'ON'
GO
ALTER DATABASE [FishingDatabase] SET QUERY_STORE = OFF
GO
USE [FishingDatabase]
GO
/****** Object:  Table [dbo].[CatchedFish]    Script Date: 08.12.2019 01:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatchedFish](
	[FishId] [int] IDENTITY(1,1) NOT NULL,
	[FishName] [nvarchar](30) NULL,
	[FishWeight] [int] NULL,
	[FishLenght] [int] NULL,
	[FishProtectionLenght] [int] NULL,
	[UserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FishId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08.12.2019 01:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) NULL,
	[UserPassword] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CatchedFish] ON 

INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (1, N'Szczupak', 2, 7, 50, 1)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (2, N'Leszcz', 2, 2, 0, 1)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (3, N'Leszcz', 2, 17, 0, 1)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (4, N'Szczupak', 2, 24, 50, 1)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (5, N'Leszcz', 2, 17, 0, 2)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (6, N'Szczupak', 1, 14, 50, 2)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (7, N'Karp', 2, 16, 25, 2)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (8, N'Leszcz', 2, 2, 0, 3)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (9, N'Leszcz', 2, 9, 0, 3)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (10, N'Szczupak', 2, 29, 50, 3)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (11, N'Leszcz', 1, 6, 0, 3)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (12, N'Szczupak', 2, 5, 50, 3)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (13, N'Szczupak', 1, 14, 50, 3)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (14, N'Leszcz', 2, 16, 0, 3)
INSERT [dbo].[CatchedFish] ([FishId], [FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (15, N'Szczupak', 1, 4, 50, 3)
SET IDENTITY_INSERT [dbo].[CatchedFish] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [UserName], [UserPassword]) VALUES (1, N'Wojtek', N'123')
INSERT [dbo].[Users] ([UserId], [UserName], [UserPassword]) VALUES (2, N'Kacper', N'123')
INSERT [dbo].[Users] ([UserId], [UserName], [UserPassword]) VALUES (3, N'Michał', N'123')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[CatchedFish]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
USE [master]
GO
ALTER DATABASE [FishingDatabase] SET  READ_WRITE 
GO
