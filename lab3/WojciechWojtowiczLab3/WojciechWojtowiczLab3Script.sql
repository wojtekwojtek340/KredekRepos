USE [master]
GO
/****** Object:  Database [WarhouseManagment]    Script Date: 05.12.2019 17:29:42 ******/
CREATE DATABASE [WarhouseManagment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WarhouseManagment', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.WOJTEKSQL\MSSQL\DATA\WarhouseManagment.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WarhouseManagment_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.WOJTEKSQL\MSSQL\DATA\WarhouseManagment_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [WarhouseManagment] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WarhouseManagment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WarhouseManagment] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WarhouseManagment] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WarhouseManagment] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WarhouseManagment] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WarhouseManagment] SET ARITHABORT OFF 
GO
ALTER DATABASE [WarhouseManagment] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WarhouseManagment] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WarhouseManagment] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WarhouseManagment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WarhouseManagment] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WarhouseManagment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WarhouseManagment] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WarhouseManagment] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WarhouseManagment] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WarhouseManagment] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WarhouseManagment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WarhouseManagment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WarhouseManagment] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WarhouseManagment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WarhouseManagment] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WarhouseManagment] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WarhouseManagment] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WarhouseManagment] SET RECOVERY FULL 
GO
ALTER DATABASE [WarhouseManagment] SET  MULTI_USER 
GO
ALTER DATABASE [WarhouseManagment] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WarhouseManagment] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WarhouseManagment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WarhouseManagment] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WarhouseManagment] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WarhouseManagment', N'ON'
GO
ALTER DATABASE [WarhouseManagment] SET QUERY_STORE = OFF
GO
USE [WarhouseManagment]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 05.12.2019 17:29:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Surname] [nvarchar](30) NULL,
	[Address] [nvarchar](max) NULL,
	[ZipCode] [int] NULL,
	[City] [nvarchar](30) NULL,
	[Country] [nvarchar](30) NULL,
	[Email] [nvarchar](30) NULL,
	[NumberPhone] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderProduct]    Script Date: 05.12.2019 17:29:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProduct](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NULL,
	[ProductID] [int] NULL,
	[DateOrder] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producer]    Script Date: 05.12.2019 17:29:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producer](
	[ProducerID] [int] IDENTITY(1,1) NOT NULL,
	[ProducerName] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProducerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 05.12.2019 17:29:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](30) NULL,
	[ProducerID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 05.12.2019 17:29:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogin]    Script Date: 05.12.2019 17:29:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogin](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) NULL,
	[Password] [nvarchar](30) NULL,
	[RoleID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ClientID], [Name], [Surname], [Address], [ZipCode], [City], [Country], [Email], [NumberPhone]) VALUES (1, N'Frederic', N'Mistral', N'Francja ', 55900, N'Paryż', N'Francja', N'Frederic@gmail.com', 999000349)
SET IDENTITY_INSERT [dbo].[Client] OFF
SET IDENTITY_INSERT [dbo].[OrderProduct] ON 

INSERT [dbo].[OrderProduct] ([OrderID], [ClientID], [ProductID], [DateOrder]) VALUES (1, 1, 2, CAST(N'2019-03-04' AS Date))
SET IDENTITY_INSERT [dbo].[OrderProduct] OFF
SET IDENTITY_INSERT [dbo].[Producer] ON 

INSERT [dbo].[Producer] ([ProducerID], [ProducerName]) VALUES (1, N'Asus')
INSERT [dbo].[Producer] ([ProducerID], [ProducerName]) VALUES (2, N'Archos')
SET IDENTITY_INSERT [dbo].[Producer] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [ProducerID]) VALUES (1, N'ZenBook', 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProducerID]) VALUES (2, N'Vivobook', 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (1, N'Client')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (2, N'Warehousman')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (3, N'Management')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[UserLogin] ON 

INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleID]) VALUES (1, N'a', N'b', 3)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleID]) VALUES (2, N'Alan', N'AL121518', 3)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleID]) VALUES (3, N'Aron', N'AR121518', 2)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleID]) VALUES (4, N'Bartosz', N'BA121518', 1)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleID]) VALUES (5, N'Bastian', N'BA121518', 2)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleID]) VALUES (6, N'Bruno', N'BR121518', 3)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleID]) VALUES (7, N'Eliasz', N'El151218', 2)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleID]) VALUES (8, N'Eryk', N'ER151218', 3)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleID]) VALUES (9, N'Feliks', N'FE151218', 1)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleID]) VALUES (10, N'Gustaw', N'GU151218', 2)
SET IDENTITY_INSERT [dbo].[UserLogin] OFF
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([ProducerID])
REFERENCES [dbo].[Producer] ([ProducerID])
GO
ALTER TABLE [dbo].[UserLogin]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
USE [master]
GO
ALTER DATABASE [WarhouseManagment] SET  READ_WRITE 
GO
