USE [master]
GO
/****** Object:  Database [TP4_MAGRI_LUDMILA]    Script Date: 27/11/2021 14:57:00 ******/
CREATE DATABASE [TP4_MAGRI_LUDMILA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP4_MAGRI_LUDMILA', FILENAME = N'E:\Documentos\Nueva carpeta\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP4_MAGRI_LUDMILA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP4_MAGRI_LUDMILA_log', FILENAME = N'E:\Documentos\Nueva carpeta\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP4_MAGRI_LUDMILA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4_MAGRI_LUDMILA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET  MULTI_USER 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET QUERY_STORE = OFF
GO
USE [TP4_MAGRI_LUDMILA]
GO
/****** Object:  Table [dbo].[Planta_Con_Fruto]    Script Date: 27/11/2021 14:57:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planta_Con_Fruto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Familia] [varchar](50) NOT NULL,
	[Origen] [varchar](50) NOT NULL,
	[Anios_De_Vida] [int] NOT NULL,
	[Cantidad_De_Agua] [float] NOT NULL,
	[Color_Flor] [int] NOT NULL,
	[Fruto] [varchar](50) NOT NULL,
	[Altura] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planta_Musgo]    Script Date: 27/11/2021 14:57:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planta_Musgo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Familia] [varchar](50) NOT NULL,
	[Origen] [varchar](50) NOT NULL,
	[Anios_De_Vida] [int] NOT NULL,
	[Cantidad_De_Agua] [float] NOT NULL,
	[Cantidad_De_Esporas] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planta_Sin_Fruto]    Script Date: 27/11/2021 14:57:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planta_Sin_Fruto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Familia] [varchar](50) NOT NULL,
	[Origen] [varchar](50) NOT NULL,
	[Anios_De_Vida] [int] NOT NULL,
	[Cantidad_De_Agua] [float] NOT NULL,
	[Tipo_De_Planta] [int] NOT NULL,
	[Altura] [float] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Planta_Con_Fruto] ON 
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (1, N'Lantana camara', N'Verbenaceae', N'Nativa', 1, 10000, 0, N'Carnoso', 1000)
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (2, N'Hibiscus striatus', N'Malvaceae', N'Nativa', 1, 50000, 2, N'Seco', 2000)
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (3, N'Sphaeralcea bonariensis', N'Malvaceae', N'Nativa', 1, 8000, 2, N'Carnoso', 1500)
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (4, N'Cucurbita maxima', N'Cucurbitaceae', N'America', 2, 20000, 1, N'Carnoso', 1500)
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (5, N'Helianthus annuus', N'Asteraceae', N'America', 1, 15000, 1, N'Seco', 800)
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (6, N'Brugmansia arborea', N'Solanaceae', N'America', 2, 1000, 1, N'Seco', 500)
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (7, N'Cestrum elegans', N'Solanaceae', N'America', 2, 2000, 0, N'Carnoso', 1500)
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (23, N'Brugmansia arborea', N'Solanaceae', N'America', 2, 1000, 0, N'Seco', 500)
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (24, N'Linum L', N'Linaceae', N'Europa', 10, 150000, 2, N'Carnoso', 500)
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (25, N'Schoenolirion wrightii', N'Linaceae', N'Europa', 10, 3000, 2, N'Carnoso', 900)
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (26, N'Krigia Schreb', N'Asteraceae', N'Europa', 5, 3000, 1, N'Carnoso', 2000)
GO
SET IDENTITY_INSERT [dbo].[Planta_Con_Fruto] OFF
GO
SET IDENTITY_INSERT [dbo].[Planta_Musgo] ON 
GO
INSERT [dbo].[Planta_Musgo] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Cantidad_De_Esporas]) VALUES (1, N'Weymouthia mollis', N'Lembophyllaceae', N'America', 100, 6000, 1000)
GO
INSERT [dbo].[Planta_Musgo] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Cantidad_De_Esporas]) VALUES (2, N'Dendroligotrichum dendroides', N'Polytrichaceae', N'America', 500, 4000, 120)
GO
INSERT [dbo].[Planta_Musgo] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Cantidad_De_Esporas]) VALUES (3, N'Sphagnum magellanicum', N'Sphagnaceae', N'Nativa', 200, 1000, 200000)
GO
INSERT [dbo].[Planta_Musgo] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Cantidad_De_Esporas]) VALUES (4, N'Archidium alternifolium', N'Archidiaceae', N'Nativa', 300, 1000, 500000)
GO
INSERT [dbo].[Planta_Musgo] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Cantidad_De_Esporas]) VALUES (7, N'Andreaea rupestris', N'Andreaeaceae', N'Europa', 600, 4000, 15000)
GO
SET IDENTITY_INSERT [dbo].[Planta_Musgo] OFF
GO
SET IDENTITY_INSERT [dbo].[Planta_Sin_Fruto] ON 
GO
INSERT [dbo].[Planta_Sin_Fruto] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Tipo_De_Planta], [Altura]) VALUES (53, N'Araucaria araucana', N'Araucariaceae', N'Nativa', 1000, 50000, 0, 3000)
GO
INSERT [dbo].[Planta_Sin_Fruto] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Tipo_De_Planta], [Altura]) VALUES (54, N'Juniperus deppeana', N'Cupressaceae', N'America', 500, 250000, 0, 3000)
GO
INSERT [dbo].[Planta_Sin_Fruto] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Tipo_De_Planta], [Altura]) VALUES (55, N'Taxus globosa', N'Taxaceae', N'America', 10, 10000, 1, 800)
GO
INSERT [dbo].[Planta_Sin_Fruto] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Tipo_De_Planta], [Altura]) VALUES (56, N'Ginkgo biloba', N'Ginkgoaceae', N'Asia', 1200, 10000, 1, 3000)
GO
INSERT [dbo].[Planta_Sin_Fruto] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Tipo_De_Planta], [Altura]) VALUES (57, N'Pinus uncinata', N'Pinaceas', N'Europa', 1000, 60000, 1, 4000)
GO
INSERT [dbo].[Planta_Sin_Fruto] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Tipo_De_Planta], [Altura]) VALUES (58, N'Pinus cembra', N'Pinaceas', N'Europa', 1600, 5000, 1, 2500)
GO
INSERT [dbo].[Planta_Sin_Fruto] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Tipo_De_Planta], [Altura]) VALUES (59, N'Juniperus chinensis', N'Cupressaceae', N'Asia', 1040, 6000, 0, 1500)
GO
INSERT [dbo].[Planta_Sin_Fruto] ([Id], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Tipo_De_Planta], [Altura]) VALUES (62, N'Pinus sylvestris', N'Pinaceae', N'Europa', 3000, 40000, 0, 500)
GO
SET IDENTITY_INSERT [dbo].[Planta_Sin_Fruto] OFF
GO
USE [master]
GO
ALTER DATABASE [TP4_MAGRI_LUDMILA] SET  READ_WRITE 
GO
