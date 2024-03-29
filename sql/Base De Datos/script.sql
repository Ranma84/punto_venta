USE [master]
GO
/****** Object:  Database [PuntoVenta]    Script Date: 02/06/2019 1:41:14 ******/
CREATE DATABASE [PuntoVenta]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PuntoVenta', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PuntoVenta.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PuntoVenta_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PuntoVenta_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PuntoVenta] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PuntoVenta].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PuntoVenta] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PuntoVenta] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PuntoVenta] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PuntoVenta] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PuntoVenta] SET ARITHABORT OFF 
GO
ALTER DATABASE [PuntoVenta] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PuntoVenta] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [PuntoVenta] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PuntoVenta] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PuntoVenta] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PuntoVenta] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PuntoVenta] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PuntoVenta] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PuntoVenta] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PuntoVenta] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PuntoVenta] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PuntoVenta] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PuntoVenta] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PuntoVenta] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PuntoVenta] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PuntoVenta] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PuntoVenta] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PuntoVenta] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PuntoVenta] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PuntoVenta] SET  MULTI_USER 
GO
ALTER DATABASE [PuntoVenta] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PuntoVenta] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PuntoVenta] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PuntoVenta] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PuntoVenta] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PuntoVenta]
GO
/****** Object:  User [Ventas]    Script Date: 02/06/2019 1:41:14 ******/
CREATE USER [Ventas] FOR LOGIN [Ventas] WITH DEFAULT_SCHEMA=[venta]
GO
ALTER ROLE [db_owner] ADD MEMBER [Ventas]
GO
/****** Object:  Schema [venta]    Script Date: 02/06/2019 1:41:15 ******/
CREATE SCHEMA [venta]
GO
/****** Object:  Table [dbo].[Bodega]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bodega](
	[id] [int] NOT NULL,
	[empresa] [nvarchar](13) NULL,
	[sucursal] [nvarchar](13) NULL,
	[Nombre] [nvarchar](50) NULL,
	[estado] [bit] NULL,
	[usuario_creacion] [char](13) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_modificacion] [char](13) NULL,
	[fecha_modificacion] [datetime] NULL,
 CONSTRAINT [PK_Bodega] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bodega_producto]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bodega_producto](
	[id] [int] NOT NULL,
	[bodega] [int] NULL,
	[producto] [int] NULL,
	[stock] [numeric](18, 3) NULL,
 CONSTRAINT [PK_bodega_producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[id] [int] NOT NULL,
	[codigo] [nvarchar](50) NULL,
	[Ciudad] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[movimiento_bodega]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[movimiento_bodega](
	[id] [int] NOT NULL,
	[bodega] [int] NULL,
	[producto] [int] NULL,
	[fecha] [date] NULL,
	[fecha_creacion] [datetime] NULL,
	[cantidad] [numeric](18, 4) NULL,
	[valor] [numeric](18, 3) NULL,
	[tipo_movimiento] [int] NULL,
	[usurio_creacion] [char](13) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_movimiento_bodega] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[precios]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[precios](
	[id] [int] NOT NULL,
	[id_producto] [int] NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_creacion] [char](13) NULL,
	[precio] [numeric](18, 4) NULL,
	[fecha_eliminacion] [datetime] NULL,
	[usuario_eliminacion] [char](13) NULL,
	[estado] [bit] NULL,
	[tipo] [int] NOT NULL,
 CONSTRAINT [PK_precios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[producto_proveedor]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[producto_proveedor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[proveedor] [nvarchar](13) NULL,
	[producto] [int] NULL,
	[usuario_creacion] [char](13) NULL,
	[fecha_creacion] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_producto_proveedor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[id] [nvarchar](13) NOT NULL,
	[NombreCompania] [nvarchar](50) NULL,
	[NombreContacto] [nvarchar](50) NULL,
	[CargoContacto] [nchar](10) NULL,
	[Direccion] [text] NULL,
	[Ciudad] [int] NULL,
	[Region] [int] NULL,
	[CodPostal] [nvarchar](50) NULL,
	[Pais] [int] NULL,
	[Telefono] [nvarchar](50) NULL,
	[Logo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbCliente]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbCliente](
	[id] [nvarchar](13) NOT NULL,
	[Nombre] [nvarchar](13) NULL,
	[usuario_creacion] [nvarchar](13) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_modificacion] [char](10) NULL,
 CONSTRAINT [PK_tbCliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbempresa]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbempresa](
	[codigo] [nvarchar](13) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[NombreComercial] [nvarchar](50) NULL,
	[usuario:_creacion] [char](13) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_modificacion] [char](13) NULL,
	[fecha_modificacion] [datetime] NULL,
 CONSTRAINT [PK_tbempresa_1] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbProducto]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbProducto](
	[id] [int] NOT NULL,
	[codigo] [nchar](50) NULL,
	[NombreProducto] [nvarchar](50) NULL,
	[usuario_creacion] [char](13) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_modificacion] [char](13) NULL,
	[fecha_modificacion] [datetime] NULL,
	[precio] [numeric](18, 4) NULL,
 CONSTRAINT [PK_tbProducto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_tbProducto] UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbsucursal]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbsucursal](
	[codigo_empresa] [nvarchar](13) NOT NULL,
	[codigo] [nvarchar](13) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Ubicacion] [nvarchar](100) NULL,
	[ruc] [nchar](15) NULL,
	[telefono] [nvarchar](50) NULL,
	[Encargado] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbsucursal] PRIMARY KEY CLUSTERED 
(
	[codigo_empresa] ASC,
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbusuario]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbusuario](
	[id] [char](13) NOT NULL,
	[empresa] [nvarchar](50) NULL,
	[sucursal] [nchar](13) NULL,
	[usuario] [nvarchar](50) NULL,
	[contrasnia] [nvarchar](100) NULL,
	[establecimiento] [char](3) NULL,
	[emision] [char](3) NULL,
	[perfil] [int] NULL,
	[usuario_creacion] [char](13) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_modificacion] [char](13) NULL,
	[fecha_modificacion] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_tbusuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_movimiento]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_movimiento](
	[id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[tipo] [char](1) NULL,
 CONSTRAINT [PK_tipo_movimiento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[venta]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[venta](
	[empresa] [nvarchar](13) NOT NULL,
	[sucursal] [nvarchar](13) NOT NULL,
	[id] [int] NOT NULL,
	[id_cliente] [nvarchar](13) NULL,
	[fecha] [date] NULL,
	[fecha_creacion] [datetime] NULL,
	[numero_legal] [char](17) NULL,
	[establecimiento] [char](3) NULL,
	[emision] [char](3) NULL,
	[usuario_creacion] [char](13) NULL,
	[estado] [smallint] NULL,
	[autorizacion] [nvarchar](100) NULL,
	[ip] [nvarchar](50) NULL,
 CONSTRAINT [PK_venta] PRIMARY KEY CLUSTERED 
(
	[empresa] ASC,
	[sucursal] ASC,
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[venta_detalle]    Script Date: 02/06/2019 1:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[venta_detalle](
	[codigo_empresa] [nvarchar](13) NOT NULL,
	[codigo_sucursal] [nvarchar](13) NOT NULL,
	[id_venta] [int] NOT NULL,
	[secuencia] [int] NOT NULL,
	[id_producto] [int] NULL,
	[id_cliente] [nvarchar](13) NULL,
	[fecha] [date] NULL,
	[fecha_venta] [datetime] NULL,
	[cantidad] [numeric](20, 6) NULL,
	[precio] [numeric](18, 4) NULL,
	[subtotal] [numeric](18, 4) NULL,
	[iva] [numeric](18, 6) NULL,
	[descuento] [numeric](18, 2) NULL,
	[total] [numeric](18, 4) NULL,
	[total_pagar] [numeric](18, 2) NULL,
	[usuario] [char](13) NULL,
 CONSTRAINT [PK_venta_detalle] PRIMARY KEY CLUSTERED 
(
	[codigo_empresa] ASC,
	[codigo_sucursal] ASC,
	[id_venta] ASC,
	[secuencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Bodega]  WITH CHECK ADD  CONSTRAINT [FK_Bodega_tbsucursal] FOREIGN KEY([empresa], [sucursal])
REFERENCES [dbo].[tbsucursal] ([codigo_empresa], [codigo])
GO
ALTER TABLE [dbo].[Bodega] CHECK CONSTRAINT [FK_Bodega_tbsucursal]
GO
ALTER TABLE [dbo].[Bodega]  WITH CHECK ADD  CONSTRAINT [FK_Bodega_tbusuario] FOREIGN KEY([usuario_creacion])
REFERENCES [dbo].[tbusuario] ([id])
GO
ALTER TABLE [dbo].[Bodega] CHECK CONSTRAINT [FK_Bodega_tbusuario]
GO
ALTER TABLE [dbo].[bodega_producto]  WITH CHECK ADD  CONSTRAINT [FK_bodega_producto_Bodega] FOREIGN KEY([bodega])
REFERENCES [dbo].[Bodega] ([id])
GO
ALTER TABLE [dbo].[bodega_producto] CHECK CONSTRAINT [FK_bodega_producto_Bodega]
GO
ALTER TABLE [dbo].[bodega_producto]  WITH CHECK ADD  CONSTRAINT [FK_bodega_producto_tbProducto] FOREIGN KEY([producto])
REFERENCES [dbo].[tbProducto] ([id])
GO
ALTER TABLE [dbo].[bodega_producto] CHECK CONSTRAINT [FK_bodega_producto_tbProducto]
GO
ALTER TABLE [dbo].[movimiento_bodega]  WITH CHECK ADD  CONSTRAINT [FK_movimiento_bodega_tbusuario] FOREIGN KEY([usurio_creacion])
REFERENCES [dbo].[tbusuario] ([id])
GO
ALTER TABLE [dbo].[movimiento_bodega] CHECK CONSTRAINT [FK_movimiento_bodega_tbusuario]
GO
ALTER TABLE [dbo].[movimiento_bodega]  WITH CHECK ADD  CONSTRAINT [FK_movimiento_bodega_tipo_movimiento] FOREIGN KEY([tipo_movimiento])
REFERENCES [dbo].[tipo_movimiento] ([id])
GO
ALTER TABLE [dbo].[movimiento_bodega] CHECK CONSTRAINT [FK_movimiento_bodega_tipo_movimiento]
GO
ALTER TABLE [dbo].[precios]  WITH CHECK ADD  CONSTRAINT [FK_precios_tbProducto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[tbProducto] ([id])
GO
ALTER TABLE [dbo].[precios] CHECK CONSTRAINT [FK_precios_tbProducto]
GO
ALTER TABLE [dbo].[precios]  WITH CHECK ADD  CONSTRAINT [FK_precios_tbusuario] FOREIGN KEY([usuario_creacion])
REFERENCES [dbo].[tbusuario] ([id])
GO
ALTER TABLE [dbo].[precios] CHECK CONSTRAINT [FK_precios_tbusuario]
GO
ALTER TABLE [dbo].[precios]  WITH CHECK ADD  CONSTRAINT [FK_precios_tipo_movimiento] FOREIGN KEY([tipo])
REFERENCES [dbo].[tipo_movimiento] ([id])
GO
ALTER TABLE [dbo].[precios] CHECK CONSTRAINT [FK_precios_tipo_movimiento]
GO
ALTER TABLE [dbo].[producto_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_producto_proveedor_producto_proveedor] FOREIGN KEY([proveedor])
REFERENCES [dbo].[Proveedores] ([id])
GO
ALTER TABLE [dbo].[producto_proveedor] CHECK CONSTRAINT [FK_producto_proveedor_producto_proveedor]
GO
ALTER TABLE [dbo].[producto_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_producto_proveedor_tbProducto] FOREIGN KEY([producto])
REFERENCES [dbo].[tbProducto] ([id])
GO
ALTER TABLE [dbo].[producto_proveedor] CHECK CONSTRAINT [FK_producto_proveedor_tbProducto]
GO
ALTER TABLE [dbo].[tbsucursal]  WITH CHECK ADD  CONSTRAINT [FK_tbsucursal_tbempresa] FOREIGN KEY([codigo_empresa])
REFERENCES [dbo].[tbempresa] ([codigo])
GO
ALTER TABLE [dbo].[tbsucursal] CHECK CONSTRAINT [FK_tbsucursal_tbempresa]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_tbCliente] FOREIGN KEY([usuario_creacion])
REFERENCES [dbo].[tbusuario] ([id])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_tbCliente]
GO
ALTER TABLE [dbo].[venta_detalle]  WITH CHECK ADD  CONSTRAINT [FK_venta_detalle_tbCliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[tbCliente] ([id])
GO
ALTER TABLE [dbo].[venta_detalle] CHECK CONSTRAINT [FK_venta_detalle_tbCliente]
GO
ALTER TABLE [dbo].[venta_detalle]  WITH CHECK ADD  CONSTRAINT [FK_venta_detalle_tbProducto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[tbProducto] ([id])
GO
ALTER TABLE [dbo].[venta_detalle] CHECK CONSTRAINT [FK_venta_detalle_tbProducto]
GO
ALTER TABLE [dbo].[venta_detalle]  WITH CHECK ADD  CONSTRAINT [FK_venta_detalle_tbsucursal] FOREIGN KEY([codigo_empresa], [codigo_sucursal])
REFERENCES [dbo].[tbsucursal] ([codigo_empresa], [codigo])
GO
ALTER TABLE [dbo].[venta_detalle] CHECK CONSTRAINT [FK_venta_detalle_tbsucursal]
GO
ALTER TABLE [dbo].[venta_detalle]  WITH CHECK ADD  CONSTRAINT [FK_venta_detalle_tbusuario] FOREIGN KEY([usuario])
REFERENCES [dbo].[tbusuario] ([id])
GO
ALTER TABLE [dbo].[venta_detalle] CHECK CONSTRAINT [FK_venta_detalle_tbusuario]
GO
USE [master]
GO
ALTER DATABASE [PuntoVenta] SET  READ_WRITE 
GO
