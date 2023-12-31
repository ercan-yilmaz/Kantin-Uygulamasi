USE [KariyerIT]
GO
/****** Object:  Table [dbo].[Gelir]    Script Date: 17.06.2019 01:35:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gelir](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciId] [int] NULL,
	[Tutar] [float] NOT NULL,
	[Detay] [nvarchar](50) NULL,
	[EklenmeTarihi] [datetime] NOT NULL,
	[GuncellenmeTarihi] [datetime] NULL,
	[SilindiMi] [bit] NOT NULL,
	[GelirTipiId] [int] NOT NULL,
 CONSTRAINT [PK_Gelir] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GelirTipi]    Script Date: 17.06.2019 01:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GelirTipi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nchar](10) NOT NULL,
	[EklenmeTarihi] [datetime] NOT NULL,
	[SilindiMi] [bit] NOT NULL,
 CONSTRAINT [PK_GelirTipi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gider]    Script Date: 17.06.2019 01:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gider](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciId] [int] NULL,
	[Tutar] [float] NOT NULL,
	[Detay] [nvarchar](50) NULL,
	[GiderTipiId] [int] NOT NULL,
	[EklenmeTarihi] [datetime] NOT NULL,
	[GuncellenmeTarihi] [datetime] NULL,
	[SilindiMi] [bit] NOT NULL,
 CONSTRAINT [PK_Gider] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiderTipi]    Script Date: 17.06.2019 01:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiderTipi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](30) NOT NULL,
	[EklenmeTarihi] [datetime] NOT NULL,
	[SilindiMi] [bit] NOT NULL,
 CONSTRAINT [PK_GiderTipi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 17.06.2019 01:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NOT NULL,
	[TelNo] [int] NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[EklenmeTarihi] [datetime] NOT NULL,
	[SilindiMi] [bit] NOT NULL,
	[PersonelMi] [bit] NOT NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stok]    Script Date: 17.06.2019 01:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stok](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UrunId] [int] NULL,
	[StokSayısı] [int] NOT NULL,
	[EklemeTarihi] [datetime] NOT NULL,
	[GuncellenmeTarihi] [datetime] NULL,
	[SilindiMi] [bit] NOT NULL,
 CONSTRAINT [PK_Stok] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 17.06.2019 01:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysdiagrams](
	[name] [nvarchar](128) NOT NULL,
	[principal_id] [int] NOT NULL,
	[diagram_id] [int] IDENTITY(1,1) NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL,
 CONSTRAINT [PK_sysdiagrams] PRIMARY KEY CLUSTERED 
(
	[diagram_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun]    Script Date: 17.06.2019 01:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](30) NOT NULL,
	[UrunTipiId] [int] NULL,
	[EklenmeTarihi] [datetime] NOT NULL,
	[GuncellemeTarihi] [datetime] NULL,
	[SilindiMi] [bit] NOT NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunTipi]    Script Date: 17.06.2019 01:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunTipi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](30) NOT NULL,
	[EklenmeTarihi] [datetime] NOT NULL,
	[GuncellenmeTarihi] [datetime] NULL,
	[SilindiMi] [bit] NOT NULL,
 CONSTRAINT [PK_UrunTipi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yonetici]    Script Date: 17.06.2019 01:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yonetici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](30) NULL,
	[Soyadi] [nvarchar](30) NULL,
	[Mail] [nvarchar](30) NOT NULL,
	[Sifre] [nvarchar](30) NOT NULL,
	[SilindiMi] [bit] NOT NULL,
 CONSTRAINT [PK_Yonetici] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Gelir] ON 
GO
INSERT [dbo].[Gelir] ([Id], [KullaniciId], [Tutar], [Detay], [EklenmeTarihi], [GuncellenmeTarihi], [SilindiMi], [GelirTipiId]) VALUES (1, 2, 50, N'Test', CAST(N'2019-06-17T00:33:36.127' AS DateTime), NULL, 0, 1)
GO
INSERT [dbo].[Gelir] ([Id], [KullaniciId], [Tutar], [Detay], [EklenmeTarihi], [GuncellenmeTarihi], [SilindiMi], [GelirTipiId]) VALUES (2, 2, 20, N'asdas', CAST(N'2019-06-17T00:46:13.063' AS DateTime), NULL, 1, 2)
GO
INSERT [dbo].[Gelir] ([Id], [KullaniciId], [Tutar], [Detay], [EklenmeTarihi], [GuncellenmeTarihi], [SilindiMi], [GelirTipiId]) VALUES (3, 3, 5, N'asdas', CAST(N'2019-06-17T00:56:53.140' AS DateTime), NULL, 0, 2)
GO
SET IDENTITY_INSERT [dbo].[Gelir] OFF
GO
SET IDENTITY_INSERT [dbo].[GelirTipi] ON 
GO
INSERT [dbo].[GelirTipi] ([Id], [Ad], [EklenmeTarihi], [SilindiMi]) VALUES (1, N'Vr        ', CAST(N'2019-05-29T00:05:58.170' AS DateTime), 0)
GO
INSERT [dbo].[GelirTipi] ([Id], [Ad], [EklenmeTarihi], [SilindiMi]) VALUES (2, N'Kantin    ', CAST(N'2019-05-29T00:05:58.170' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[GelirTipi] OFF
GO
SET IDENTITY_INSERT [dbo].[Gider] ON 
GO
INSERT [dbo].[Gider] ([Id], [KullaniciId], [Tutar], [Detay], [GiderTipiId], [EklenmeTarihi], [GuncellenmeTarihi], [SilindiMi]) VALUES (1, 3, 2000, N'Ocak maaş', 1, CAST(N'2019-06-17T00:59:51.983' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Gider] ([Id], [KullaniciId], [Tutar], [Detay], [GiderTipiId], [EklenmeTarihi], [GuncellenmeTarihi], [SilindiMi]) VALUES (2, 3, 2000, N'Elektrik', 2, CAST(N'2019-06-17T01:00:36.567' AS DateTime), NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[Gider] OFF
GO
SET IDENTITY_INSERT [dbo].[GiderTipi] ON 
GO
INSERT [dbo].[GiderTipi] ([Id], [Ad], [EklenmeTarihi], [SilindiMi]) VALUES (1, N'Maaş', CAST(N'2019-05-29T00:05:58.170' AS DateTime), 0)
GO
INSERT [dbo].[GiderTipi] ([Id], [Ad], [EklenmeTarihi], [SilindiMi]) VALUES (2, N'Fatura', CAST(N'2019-05-29T00:05:58.170' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[GiderTipi] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 
GO
INSERT [dbo].[Kullanici] ([Id], [Adi], [Soyadi], [TelNo], [Mail], [EklenmeTarihi], [SilindiMi], [PersonelMi]) VALUES (1, N'Test', N'Test', 123456, N'b@c.com', CAST(N'2019-06-16T15:58:19.460' AS DateTime), 1, 1)
GO
INSERT [dbo].[Kullanici] ([Id], [Adi], [Soyadi], [TelNo], [Mail], [EklenmeTarihi], [SilindiMi], [PersonelMi]) VALUES (2, N'Test', N'Test2', 123456, N'b@c.com', CAST(N'2019-06-16T16:00:01.663' AS DateTime), 1, 0)
GO
INSERT [dbo].[Kullanici] ([Id], [Adi], [Soyadi], [TelNo], [Mail], [EklenmeTarihi], [SilindiMi], [PersonelMi]) VALUES (3, N'A', N'CD', 121212, N'c@b.com', CAST(N'2019-06-17T00:54:35.370' AS DateTime), 0, 1)
GO
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[Stok] ON 
GO
INSERT [dbo].[Stok] ([Id], [UrunId], [StokSayısı], [EklemeTarihi], [GuncellenmeTarihi], [SilindiMi]) VALUES (1, 1, 123, CAST(N'2019-06-17T00:56:28.707' AS DateTime), CAST(N'2019-06-17T00:56:34.920' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Stok] OFF
GO
SET IDENTITY_INSERT [dbo].[Urun] ON 
GO
INSERT [dbo].[Urun] ([Id], [Ad], [UrunTipiId], [EklenmeTarihi], [GuncellemeTarihi], [SilindiMi]) VALUES (1, N'ABC', 1, CAST(N'2019-06-16T16:15:03.207' AS DateTime), CAST(N'2019-06-17T00:56:14.710' AS DateTime), 0)
GO
INSERT [dbo].[Urun] ([Id], [Ad], [UrunTipiId], [EklenmeTarihi], [GuncellemeTarihi], [SilindiMi]) VALUES (2, N'Test', 1, CAST(N'2019-06-17T01:11:06.697' AS DateTime), NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[Urun] OFF
GO
SET IDENTITY_INSERT [dbo].[UrunTipi] ON 
GO
INSERT [dbo].[UrunTipi] ([Id], [Ad], [EklenmeTarihi], [GuncellenmeTarihi], [SilindiMi]) VALUES (1, N'Test', CAST(N'2019-05-29T00:05:58.170' AS DateTime), NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[UrunTipi] OFF
GO
SET IDENTITY_INSERT [dbo].[Yonetici] ON 
GO
INSERT [dbo].[Yonetici] ([Id], [Adi], [Soyadi], [Mail], [Sifre], [SilindiMi]) VALUES (1, N'Test', N'Test', N'a@b.com', N'123456', 0)
GO
SET IDENTITY_INSERT [dbo].[Yonetici] OFF
GO
ALTER TABLE [dbo].[Gelir]  WITH CHECK ADD  CONSTRAINT [FK_Gelir_GelirTipi] FOREIGN KEY([GelirTipiId])
REFERENCES [dbo].[GelirTipi] ([Id])
GO
ALTER TABLE [dbo].[Gelir] CHECK CONSTRAINT [FK_Gelir_GelirTipi]
GO
ALTER TABLE [dbo].[Gelir]  WITH CHECK ADD  CONSTRAINT [FK_Gelir_Kullanici] FOREIGN KEY([KullaniciId])
REFERENCES [dbo].[Kullanici] ([Id])
GO
ALTER TABLE [dbo].[Gelir] CHECK CONSTRAINT [FK_Gelir_Kullanici]
GO
ALTER TABLE [dbo].[Gider]  WITH CHECK ADD  CONSTRAINT [FK_Gider_GiderTipi] FOREIGN KEY([GiderTipiId])
REFERENCES [dbo].[GiderTipi] ([Id])
GO
ALTER TABLE [dbo].[Gider] CHECK CONSTRAINT [FK_Gider_GiderTipi]
GO
ALTER TABLE [dbo].[Gider]  WITH CHECK ADD  CONSTRAINT [FK_Gider_Kullanici] FOREIGN KEY([KullaniciId])
REFERENCES [dbo].[Kullanici] ([Id])
GO
ALTER TABLE [dbo].[Gider] CHECK CONSTRAINT [FK_Gider_Kullanici]
GO
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Urun] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urun] ([Id])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Urun]
GO
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK_Urun_UrunTipi] FOREIGN KEY([UrunTipiId])
REFERENCES [dbo].[UrunTipi] ([Id])
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK_Urun_UrunTipi]
GO
