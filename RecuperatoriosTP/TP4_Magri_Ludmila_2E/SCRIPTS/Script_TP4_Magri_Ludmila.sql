USE [TP4_MAGRI_LUDMILA]
GO
/****** Object:  Table [dbo].[Planta_Con_Fruto]    Script Date: 22/11/2021 14:27:12 ******/
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
/****** Object:  Table [dbo].[Planta_Musgo]    Script Date: 22/11/2021 14:27:12 ******/
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
/****** Object:  Table [dbo].[Planta_Sin_Fruto]    Script Date: 22/11/2021 14:27:12 ******/
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
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (5, N'Helianthus annuus', N'Asteraceae', N'America', 1, 15000, 1, N'Seco', 1000)
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (6, N'Brugmansia arborea', N'Solanaceae', N'America', 2, 1000, 1, N'Seco', 1000)
GO
INSERT [dbo].[Planta_Con_Fruto] ([ID], [Nombre], [Familia], [Origen], [Anios_De_Vida], [Cantidad_De_Agua], [Color_Flor], [Fruto], [Altura]) VALUES (7, N'Cestrum elegans', N'Solanaceae', N'America', 2, 2000, 0, N'Carnoso', 1500)
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
