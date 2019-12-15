USE [master]
GO
/****** Object:  Database [SkiJumping]    Script Date: 13.12.2019 01:21:41 ******/
CREATE DATABASE [SkiJumping]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SkiJumping', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.WOJTEKSQL\MSSQL\DATA\SkiJumping.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SkiJumping_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.WOJTEKSQL\MSSQL\DATA\SkiJumping_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SkiJumping] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SkiJumping].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SkiJumping] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SkiJumping] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SkiJumping] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SkiJumping] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SkiJumping] SET ARITHABORT OFF 
GO
ALTER DATABASE [SkiJumping] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SkiJumping] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SkiJumping] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SkiJumping] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SkiJumping] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SkiJumping] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SkiJumping] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SkiJumping] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SkiJumping] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SkiJumping] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SkiJumping] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SkiJumping] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SkiJumping] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SkiJumping] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SkiJumping] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SkiJumping] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SkiJumping] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SkiJumping] SET RECOVERY FULL 
GO
ALTER DATABASE [SkiJumping] SET  MULTI_USER 
GO
ALTER DATABASE [SkiJumping] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SkiJumping] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SkiJumping] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SkiJumping] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SkiJumping] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SkiJumping', N'ON'
GO
ALTER DATABASE [SkiJumping] SET QUERY_STORE = OFF
GO
USE [SkiJumping]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 13.12.2019 01:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 13.12.2019 01:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[CountryRecord] [real] NOT NULL,
 CONSTRAINT [PK_dbo.Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jumpers]    Script Date: 13.12.2019 01:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jumpers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](250) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Birtdate] [datetime] NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Jumpers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201912121527536_SkiJumping', N'WojciechWojtowiczLab4.Migrations.Configuration', 0x1F8B0800000000000400ED59DD6EE43414BE47E21DA25C01EA4EA65D90A09AD95577DAA242FFD47417EE569EE4CCD4AC6307DB2933209E8C0B1E8957E038FF713293CCEC760508556A13DBE7F3F9B7BFF4AF3FFE9CBC5C45CC7904A9A8E053F77034761DE08108295F4EDD442F9E7DEDBE7CF1E92793B3305A396F8A75CFCD3A94E46AEA3E681D1F7B9E0A1E20226A14D1400A25167A1488C823A1F08EC6E36FBCC3430F10C2452CC799DC255CD308D2177C9D091E40AC13C2AE44084CE5E338E3A7A8CE358940C52480A9FB83F829A0103CE05F2D7EA1C1AF9764FEE52893739D134609EAE4035BB80EE15C68A251E3E3D70A7C2D055FFA310E1076BF8E01D72D0853905B725C2D1F6AD4F8C818E55582055490282DA21D010F9FE75EF26CF1BD7CED965E443F9EA1BFF5DA589DFA72EACE048640AE5DC7DEEB78C6A459B7DDD3A35CFEC0E95C7550A60A6694F939706609D389842987444BC20E9CDB64CE68F03DACEFC53BE0539E3056571995C6B9C6000EDD4A1183D4EB3B58E4865C84AEE335E53C5BB014ABC964365E70FDFCC875AE71733267506644CD1FBE1612BE050E9268086F89D620B9C180D4A7ADDDADBDCCEF62374C41AC2BD7B922AB4BE04BFD3075F1D175CEE90AC26224D7E035A7588628A465027D9BE4D1B88340C8D2361FF762D0619C85754D1EE932B5D542FD2E89F015ABEA0E583AAF1E689C15D7289B7B5BA6D1B914D19D60A55431F3F69EC82568D449744EFB229181A5D3C4ABD2756B1267587BE77026FE7F0AF765D739954AF7E4F1D157E34179DC978CD6D697A477E7A115B4E3CEAFA8D421BAABD8F9149FEF69B43B509EE9FD011B5A9665CDBD4F591675B7A12C8BAA1D5296274A8980A69A34EAB2D4A269D7190F9DED2A6591AECCC17063E5D1186B0DB79FBA5FB47CB511B3EC3E1566E99B26E8A16B17EA0D3F05061A9C93203BC3674405246C470AFD123647B0B6419AE2220CEF360ABB05E5BADD08280F684CD856D52DA9810DC46855E2DB33A7100337B5BF350E4336AEE5767BFF721BCB5B7DCE9978B58C6AF77F94D1280132D7C17F478D01D816CC0CAC74C77980D7BFFC4850793BB0F3C720FBA01B7651C0B3AFCA793B7F5A39D8C4284FCF164291D51640CD6A1BA52AE8DAA2EE92B7C3D05B6EA5DE35955BC1EC2DB01A4ACD7976A1344DECE82D65702B0AE0651CA0E00ADE06B230B922B149821A79C8471C3F630EB367FEEE17E928C3F002D5719F2EB52D77C283962CC19A352E09213D45F114217362BAFD2C8C5ACBDAA9BC21C58AFDEC6C6D87AD48BD42C23C675243AEF71D4D20073A473B23D342D2BB452BFA1D92299B238CC88E9BCC4CB024E29B9BD966E9EC725097CF4686235877E73A9435D5C69C78963B5A4DB01581D6D1D10CE9A0801775FAC1C29D77A4DDA3BD49F069825DBB88D6416AC3C3B1AA9B651DAA1A1D8E54DD14EB48D5E8CEA9683B69CB29FBC429D86ACBF69272F7B23D5B6D7892B7C4FE0F3BAD1E992D711D74D2230DD3FEB8561AA2915930F27F663346D1DE6AC115E174014A676CCC3D1A1F1E595F84FE395F673CA54236EC13CD476794D438B59733EE4883EA2C8E3F12193C10F95944569FD791F6FED62181B01E9576FDAAF0DF707B8BBB17BE6FB3F7F7A4E61B83BA17DD36CFFA83D0EDD4AD2D467081CC6435757F4BA58E9D8B1FDF968207CE8DC46E72EC8C9DDFF7CCA9BD297179CFFFC884D5BEDFEFC5C2F762BD9B6F9A4FC473FF35C4B64D1A8690D6F536CA9A1DA9585D738111CED27A335DEB66B45B086D17FC064EF9E46CD7F246839BF4F3DB0E5AFC346CB67D3DC23CAAFD770C9358D1650561FE57C621686450B9E6822F4491CB9646C512AB5B5E8126D86AC989D47441028DD30128957E637D4358824BCEA2398417FC26D171A2D16488E6ACE1425310DBF64F297B53E7C94D9C7EB8FC1026A09AD49C1637FC55425958EA7DDED1AE3740984ACBCF5C134B6DCEDEE5BA44BA167C2050EEBEB241DC431433045337DC278FB08F6EAF155CC29204EBE296BB19A43F104DB74F4E29594A12A91CA392C757CCE1305ABDF81BCCC73440241E0000, N'6.4.0')
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Id], [Name], [CountryRecord]) VALUES (1, N'Polska', 90)
INSERT [dbo].[Countries] ([Id], [Name], [CountryRecord]) VALUES (7, N'Niemcy', 120)
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[Jumpers] ON 

INSERT [dbo].[Jumpers] ([Id], [FirstName], [LastName], [Birtdate], [CountryId]) VALUES (2, N'Wojciech', N'Wojtowicz', CAST(N'1997-03-03T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Jumpers] ([Id], [FirstName], [LastName], [Birtdate], [CountryId]) VALUES (10, N'test2', N'test', CAST(N'2019-12-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Jumpers] ([Id], [FirstName], [LastName], [Birtdate], [CountryId]) VALUES (12, N'test3', N'test', CAST(N'2019-12-12T00:00:00.000' AS DateTime), 7)
INSERT [dbo].[Jumpers] ([Id], [FirstName], [LastName], [Birtdate], [CountryId]) VALUES (13, N'test4', N'test', CAST(N'2019-12-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Jumpers] ([Id], [FirstName], [LastName], [Birtdate], [CountryId]) VALUES (14, N'test5', N'test', CAST(N'2019-12-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Jumpers] ([Id], [FirstName], [LastName], [Birtdate], [CountryId]) VALUES (15, N'test6', N'r', CAST(N'2019-12-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Jumpers] ([Id], [FirstName], [LastName], [Birtdate], [CountryId]) VALUES (16, N'test7', N'r', CAST(N'2019-12-12T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Jumpers] OFF
/****** Object:  Index [IX_CountryId]    Script Date: 13.12.2019 01:21:41 ******/
CREATE NONCLUSTERED INDEX [IX_CountryId] ON [dbo].[Jumpers]
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Jumpers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Jumpers_dbo.Countries_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Jumpers] CHECK CONSTRAINT [FK_dbo.Jumpers_dbo.Countries_CountryId]
GO
USE [master]
GO
ALTER DATABASE [SkiJumping] SET  READ_WRITE 
GO
