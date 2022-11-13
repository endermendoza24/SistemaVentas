USE [SistemaVentasCaprichos]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/31/2022 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 10/31/2022 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Url_Imagen] [nvarchar](max) NULL,
	[PrecioMayorista] [decimal](18, 2) NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
	[Ultima_Modificación] [datetime2](7) NOT NULL,
	[Codigo] [nvarchar](15) NOT NULL,
	[StockMinimo] [int] NOT NULL,
	[StockMaximo] [int] NOT NULL,
	[StockActual] [int] NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[TallasId] [int] NOT NULL,
	[MarcaId] [int] NOT NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 10/31/2022 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[FechaRegistro] [datetime2](7) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/31/2022 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreyApellido] [nvarchar](max) NOT NULL,
	[Cedula] [nvarchar](8) NOT NULL,
	[Sexo] [int] NOT NULL,
	[Dirección] [nvarchar](max) NOT NULL,
	[Teléfono] [nvarchar](max) NOT NULL,
	[Saldo] [decimal](18, 2) NOT NULL,
	[FechaAlta] [datetime2](7) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 10/31/2022 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[ProveedoresId] [int] NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCompras]    Script Date: 10/31/2022 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCompras](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArticuloId] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioMayorista] [decimal](18, 2) NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
	[CompraId] [int] NOT NULL,
 CONSTRAINT [PK_DetalleCompras] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVentas]    Script Date: 10/31/2022 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVentas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArticuloId] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Descuento] [int] NOT NULL,
	[VentaId] [int] NOT NULL,
 CONSTRAINT [PK_DetalleVentas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 10/31/2022 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[Descripcion] [nvarchar](100) NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 10/31/2022 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](20) NOT NULL,
	[Direccion] [nvarchar](50) NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tallas]    Script Date: 10/31/2022 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tallas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Tallas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 10/31/2022 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[FormaPago] [int] NOT NULL,
	[ClienteId] [int] NULL,
	[Total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221027220352_Initial', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221027223550_segunda', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221031232034_prueba', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[Articulos] ON 

INSERT [dbo].[Articulos] ([Id], [Nombre], [Descripcion], [Url_Imagen], [PrecioMayorista], [PrecioUnitario], [Ultima_Modificación], [Codigo], [StockMinimo], [StockMaximo], [StockActual], [CategoriaId], [TallasId], [MarcaId]) VALUES (1, N'CAMISETA', N'CAMISA NIKE BONITA', N'https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/f953a263-1c2e-4466-8897-f0b0fff371fc/playera-de-entrenamiento-de-manga-corta-dri-fit-superset-MqS7hk.png', CAST(600.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), CAST(N'2022-10-31T17:13:17.7631618' AS DateTime2), N'0977yytre', 2, 10, 11, 1, 1, 1)
INSERT [dbo].[Articulos] ([Id], [Nombre], [Descripcion], [Url_Imagen], [PrecioMayorista], [PrecioUnitario], [Ultima_Modificación], [Codigo], [StockMinimo], [StockMaximo], [StockActual], [CategoriaId], [TallasId], [MarcaId]) VALUES (2, N'PANTALON', N'PANTALON MARCA HOLLISTER AZUL', N'https://img.hollisterco.com/is/image/anf/KIC_331-9046-1957-279_prod1?policy=product-large', CAST(910.00 AS Decimal(18, 2)), CAST(910.00 AS Decimal(18, 2)), CAST(N'2022-10-31T17:24:45.1130114' AS DateTime2), N'7645tr', 1, 20, 25, 2, 1, 2)
SET IDENTITY_INSERT [dbo].[Articulos] OFF
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([Id], [Nombre], [Descripcion], [FechaRegistro], [Estado]) VALUES (1, N'Deportivo', N'Solo ropa deportiva', CAST(N'2022-10-31T17:04:58.5930000' AS DateTime2), 1)
INSERT [dbo].[Categoria] ([Id], [Nombre], [Descripcion], [FechaRegistro], [Estado]) VALUES (2, N'Casual', N'Ropa casual', CAST(N'2022-10-31T17:05:58.9960000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Id], [NombreyApellido], [Cedula], [Sexo], [Dirección], [Teléfono], [Saldo], [FechaAlta], [Estado]) VALUES (1, N'SARA GUADALUPE MENDIETA OBANDO', N'1234567', 2, N'RESIDENCIAL EL CARMEN', N'897436438', CAST(0.00 AS Decimal(18, 2)), CAST(N'2022-10-31T17:03:48.6660000' AS DateTime2), 1)
INSERT [dbo].[Clientes] ([Id], [NombreyApellido], [Cedula], [Sexo], [Dirección], [Teléfono], [Saldo], [FechaAlta], [Estado]) VALUES (2, N'GREYVIN MORA ZUNIGA', N'9876543', 1, N'BARRIO SAN ANTONIO', N'345567645', CAST(0.00 AS Decimal(18, 2)), CAST(N'2022-10-31T17:04:23.7930000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Compras] ON 

INSERT [dbo].[Compras] ([Id], [Fecha], [Total], [ProveedoresId]) VALUES (1, CAST(N'2022-10-31T17:13:17.7338822' AS DateTime2), CAST(1800.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Compras] ([Id], [Fecha], [Total], [ProveedoresId]) VALUES (2, CAST(N'2022-10-31T17:13:39.0599986' AS DateTime2), CAST(9100.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Compras] ([Id], [Fecha], [Total], [ProveedoresId]) VALUES (3, CAST(N'2022-10-31T17:24:44.8140245' AS DateTime2), CAST(4550.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[Compras] OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleCompras] ON 

INSERT [dbo].[DetalleCompras] ([Id], [ArticuloId], [Cantidad], [PrecioMayorista], [PrecioUnitario], [CompraId]) VALUES (1, 1, 3, CAST(600.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[DetalleCompras] ([Id], [ArticuloId], [Cantidad], [PrecioMayorista], [PrecioUnitario], [CompraId]) VALUES (2, 2, 10, CAST(910.00 AS Decimal(18, 2)), CAST(910.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[DetalleCompras] ([Id], [ArticuloId], [Cantidad], [PrecioMayorista], [PrecioUnitario], [CompraId]) VALUES (3, 2, 5, CAST(910.00 AS Decimal(18, 2)), CAST(910.00 AS Decimal(18, 2)), 3)
SET IDENTITY_INSERT [dbo].[DetalleCompras] OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleVentas] ON 

INSERT [dbo].[DetalleVentas] ([Id], [ArticuloId], [Precio], [Cantidad], [Descuento], [VentaId]) VALUES (1, 1, CAST(600.00 AS Decimal(18, 2)), 2, 0, 1)
SET IDENTITY_INSERT [dbo].[DetalleVentas] OFF
GO
SET IDENTITY_INSERT [dbo].[Marca] ON 

INSERT [dbo].[Marca] ([Id], [Nombre], [Descripcion], [Fecha], [Estado]) VALUES (1, N'Nike', N'Nike es una empresa estadounidense', CAST(N'2022-10-31T17:07:38.2030000' AS DateTime2), 1)
INSERT [dbo].[Marca] ([Id], [Nombre], [Descripcion], [Fecha], [Estado]) VALUES (2, N'Hollister', N'Hollister', CAST(N'2022-10-31T17:07:57.6560000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Marca] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([Id], [Nombre], [Telefono], [Direccion], [Fecha], [Estado]) VALUES (1, N'Best brand', N'46888333', N'Jinotepe', CAST(N'2022-10-31T17:11:55.8250000' AS DateTime2), 1)
INSERT [dbo].[Proveedores] ([Id], [Nombre], [Telefono], [Direccion], [Fecha], [Estado]) VALUES (2, N'Pacas lcas', N'14262828', N'San Marcos', CAST(N'2022-10-31T17:12:32.3240000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[Tallas] ON 

INSERT [dbo].[Tallas] ([Id], [Nombre], [Fecha], [Estado]) VALUES (1, N'M', CAST(N'2022-10-31T17:05:17.8390000' AS DateTime2), 1)
INSERT [dbo].[Tallas] ([Id], [Nombre], [Fecha], [Estado]) VALUES (2, N'S', CAST(N'2022-10-31T17:05:24.7070000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Tallas] OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([Id], [Fecha], [FormaPago], [ClienteId], [Total]) VALUES (1, CAST(N'2022-10-31T17:11:42.6287696' AS DateTime2), 1, 2, CAST(1380.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Ventas] OFF
GO
ALTER TABLE [dbo].[Articulos] ADD  DEFAULT (N'') FOR [Codigo]
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Categoria_CategoriaId] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categoria] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Categoria_CategoriaId]
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Marca_MarcaId] FOREIGN KEY([MarcaId])
REFERENCES [dbo].[Marca] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Marca_MarcaId]
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Tallas_TallasId] FOREIGN KEY([TallasId])
REFERENCES [dbo].[Tallas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Tallas_TallasId]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Proveedores_ProveedoresId] FOREIGN KEY([ProveedoresId])
REFERENCES [dbo].[Proveedores] ([Id])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Proveedores_ProveedoresId]
GO
ALTER TABLE [dbo].[DetalleCompras]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompras_Articulos_ArticuloId] FOREIGN KEY([ArticuloId])
REFERENCES [dbo].[Articulos] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleCompras] CHECK CONSTRAINT [FK_DetalleCompras_Articulos_ArticuloId]
GO
ALTER TABLE [dbo].[DetalleCompras]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompras_Compras_CompraId] FOREIGN KEY([CompraId])
REFERENCES [dbo].[Compras] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleCompras] CHECK CONSTRAINT [FK_DetalleCompras_Compras_CompraId]
GO
ALTER TABLE [dbo].[DetalleVentas]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVentas_Articulos_ArticuloId] FOREIGN KEY([ArticuloId])
REFERENCES [dbo].[Articulos] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleVentas] CHECK CONSTRAINT [FK_DetalleVentas_Articulos_ArticuloId]
GO
ALTER TABLE [dbo].[DetalleVentas]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVentas_Ventas_VentaId] FOREIGN KEY([VentaId])
REFERENCES [dbo].[Ventas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleVentas] CHECK CONSTRAINT [FK_DetalleVentas_Ventas_VentaId]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes_ClienteId] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes_ClienteId]
GO
