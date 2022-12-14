USE [master]
GO
/****** Object:  Database [Canchas_2022]    Script Date: 22/11/2022 21:38:26 ******/
CREATE DATABASE [Canchas_2022]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Canchas_2022', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Canchas_2022.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Canchas_2022_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Canchas_2022_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Canchas_2022] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Canchas_2022].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Canchas_2022] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Canchas_2022] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Canchas_2022] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Canchas_2022] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Canchas_2022] SET ARITHABORT OFF 
GO
ALTER DATABASE [Canchas_2022] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Canchas_2022] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Canchas_2022] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Canchas_2022] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Canchas_2022] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Canchas_2022] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Canchas_2022] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Canchas_2022] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Canchas_2022] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Canchas_2022] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Canchas_2022] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Canchas_2022] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Canchas_2022] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Canchas_2022] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Canchas_2022] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Canchas_2022] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Canchas_2022] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Canchas_2022] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Canchas_2022] SET  MULTI_USER 
GO
ALTER DATABASE [Canchas_2022] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Canchas_2022] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Canchas_2022] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Canchas_2022] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Canchas_2022] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Canchas_2022] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Canchas_2022] SET QUERY_STORE = OFF
GO
USE [Canchas_2022]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Usuario] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](100) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Criticidad] [nvarchar](50) NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cancha]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cancha](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
	[Material] [nvarchar](50) NOT NULL,
	[PrecioBase] [float] NULL,
 CONSTRAINT [PK_Cancha] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ControlCliente]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlCliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Fecha] [datetime] NULL,
	[UsuarioId] [int] NOT NULL,
	[Descripcion] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ControlCliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deudas]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deudas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Reserva] [int] NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Fecha_Pago] [datetime] NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Deudas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DigitoVerificador]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DigitoVerificador](
	[Id_Tabla] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Tabla] [nvarchar](50) NOT NULL,
	[DV] [int] NOT NULL,
 CONSTRAINT [PK_DigitoVerificador] PRIMARY KEY CLUSTERED 
(
	[Id_Tabla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Etiqueta]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etiqueta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Etiqueta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamiliaPatente](
	[PadreId] [int] NOT NULL,
	[HijoId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
	[Default] [bit] NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
	[Permiso] [nvarchar](200) NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cancha] [int] NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [nvarchar](5) NOT NULL,
	[Semana] [bit] NOT NULL,
	[Forma_Pago] [nvarchar](50) NOT NULL,
	[Seña] [float] NOT NULL,
	[Total] [float] NOT NULL,
	[Pagar] [float] NOT NULL,
	[Pagado] [nvarchar](20) NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdiomaId] [int] NOT NULL,
	[EtiquetaId] [int] NOT NULL,
	[Traduccion] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Traduccion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioPermiso]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPermiso](
	[Id_UsuarioPermiso] [int] IDENTITY(1,1) NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[PatenteId] [int] NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioPermiso] PRIMARY KEY CLUSTERED 
(
	[Id_UsuarioPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/11/2022 21:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Nombre_Usuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Puesto] [nvarchar](50) NOT NULL,
	[Dni] [int] NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](100) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
	[Estado] [int] NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5902, N'ramiro', N'Se eliminaron las bitacoras desde el día 22/11/2022 hasta el día 16/11/2022.', CAST(N'2022-11-22T20:57:16.310' AS DateTime), N'ALTA', 215391)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5903, N'ramiro', N'Se dió de alta la reserva 1132.', CAST(N'2022-11-22T20:57:36.867' AS DateTime), N'MEDIA', 51766)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5904, N'ramiro', N'Se modificó la reserva 132.', CAST(N'2022-11-22T20:58:15.907' AS DateTime), N'MEDIA', 43426)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5905, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-11-22T20:59:45.247' AS DateTime), N'BAJA', 32576)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5906, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-11-22T21:00:27.337' AS DateTime), N'BAJA', 32376)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5907, N'ramiro', N'Cerró la sesión.', CAST(N'2022-11-22T21:00:58.303' AS DateTime), N'BAJA', 24759)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5908, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-11-22T21:02:38.753' AS DateTime), N'BAJA', 32453)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5909, N'ramiro', N'Se pagó la deuda de la reserva 132.', CAST(N'2022-11-22T21:03:12.647' AS DateTime), N'ALTA', 63234)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5910, N'ramiro', N'Se dió de alta la reserva 1133.', CAST(N'2022-11-22T21:03:32.383' AS DateTime), N'MEDIA', 51585)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5911, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-11-22T21:23:49.170' AS DateTime), N'BAJA', 32511)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5912, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-11-22T21:24:21.373' AS DateTime), N'BAJA', 32343)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5913, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-11-22T21:24:40.320' AS DateTime), N'BAJA', 32364)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5914, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-11-22T21:26:06.487' AS DateTime), N'BAJA', 32442)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5915, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-11-22T21:29:36.803' AS DateTime), N'BAJA', 32548)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5916, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-11-22T21:32:57.463' AS DateTime), N'BAJA', 32510)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5917, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-11-22T21:35:01.100' AS DateTime), N'BAJA', 32358)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5918, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-11-22T21:37:16.837' AS DateTime), N'BAJA', 32507)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (5919, N'ramiro', N'Se realizó una copia de seguridad.', CAST(N'2022-11-22T21:37:37.313' AS DateTime), N'ALTA', 67994)
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[Cancha] ON 

INSERT [dbo].[Cancha] ([Id], [Tipo], [Material], [PrecioBase]) VALUES (1, N'F5', N'Cesped sintetico', 3500)
INSERT [dbo].[Cancha] ([Id], [Tipo], [Material], [PrecioBase]) VALUES (2, N'F8', N'Cesped sintetico', 6000)
INSERT [dbo].[Cancha] ([Id], [Tipo], [Material], [PrecioBase]) VALUES (3, N'F5', N'Piso', 3000)
INSERT [dbo].[Cancha] ([Id], [Tipo], [Material], [PrecioBase]) VALUES (4, N'F11', N'Cesped natural', 8000)
SET IDENTITY_INSERT [dbo].[Cancha] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Telefono]) VALUES (1, N'Lucas', N'Gonzalez', 1158174329)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[ControlCliente] ON 

INSERT [dbo].[ControlCliente] ([Id], [ClienteId], [Nombre], [Apellido], [Telefono], [Fecha], [UsuarioId], [Descripcion]) VALUES (1, 1, N'Lucas', N'Gonzalez', 1158174329, CAST(N'2022-11-20T13:16:58.310' AS DateTime), 2, N'Se dió de alta el cliente')
INSERT [dbo].[ControlCliente] ([Id], [ClienteId], [Nombre], [Apellido], [Telefono], [Fecha], [UsuarioId], [Descripcion]) VALUES (4, 1, N'Lucas', N'Gonzalez', 0, CAST(N'2022-11-20T16:32:51.233' AS DateTime), 2, N'Se realizaron modificaciones en el cliente')
INSERT [dbo].[ControlCliente] ([Id], [ClienteId], [Nombre], [Apellido], [Telefono], [Fecha], [UsuarioId], [Descripcion]) VALUES (5, 1, N'Lucas', N'Gonzalez', 1158174329, CAST(N'2022-11-20T16:32:58.293' AS DateTime), 2, N'Se realizaron modificaciones en el cliente')
SET IDENTITY_INSERT [dbo].[ControlCliente] OFF
GO
SET IDENTITY_INSERT [dbo].[DigitoVerificador] ON 

INSERT [dbo].[DigitoVerificador] ([Id_Tabla], [Nombre_Tabla], [DV]) VALUES (1, N'Usuarios', 298864)
INSERT [dbo].[DigitoVerificador] ([Id_Tabla], [Nombre_Tabla], [DV]) VALUES (2, N'Bitacora', 875143)
INSERT [dbo].[DigitoVerificador] ([Id_Tabla], [Nombre_Tabla], [DV]) VALUES (4, N'Reserva', 548278)
INSERT [dbo].[DigitoVerificador] ([Id_Tabla], [Nombre_Tabla], [DV]) VALUES (9, N'UsuarioPermiso', 299)
INSERT [dbo].[DigitoVerificador] ([Id_Tabla], [Nombre_Tabla], [DV]) VALUES (10, N'Deudas', 0)
SET IDENTITY_INSERT [dbo].[DigitoVerificador] OFF
GO
SET IDENTITY_INSERT [dbo].[Etiqueta] ON 

INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1, N'menu_Menu')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (2, N'menu_Cancha')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (3, N'menu_Gestion')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (4, N'menu_Informes')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (5, N'menu_Idioma')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (6, N'menu_Seguridad')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (7, N'menu_Cerrar_Sesion')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (8, N'menu_Reserva')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (9, N'menu_Listado')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (10, N'menu_Gestion_Usuarios')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (11, N'menu_Gestion_Canchas')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (12, N'menu_Gestion_Clientes')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (13, N'menu_Gestion_Idioma')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (14, N'menu_AltaIdioma')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (15, N'menu_CargarEtiquetas')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (16, N'menu_ModificarEtiquetas')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (17, N'menu_Roles_Familia')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (18, N'menu_Asignar_Permisos')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (19, N'menu_Consultar_Permisos')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (20, N'menu_Salir')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (21, N'lbl_Nombre')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (22, N'lbl_Apellido')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (23, N'lbl_NombreUJsuario')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (24, N'lbl_Contraseña')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (25, N'lbl_Puesto')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (26, N'lbl_Dni')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (27, N'lbl_Sexo')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (28, N'lbl_Mail')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (29, N'lbl_Telefono')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (30, N'lbl_Tipo')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (31, N'btn_Alta')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (32, N'btn_Modificar')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (33, N'btn_Baja')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (34, N'btn_Cancelar')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (35, N'lbl_Material')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (36, N'lbl_Precio')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (37, N'lbl_TipoCancha')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (38, N'lbl_Cancha')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (39, N'lbl_EsCliente')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (40, N'btn_AltaCliente')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (41, N'lbl_IngreseFecha')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (42, N'lbl_Hora')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (43, N'lbl_Seña')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (44, N'lbl_Total')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (45, N'lbl_Deuda')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (46, N'btn_CalcularDeuda')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (47, N'btn_Reservar')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (48, N'btn_ModificarReserva')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (49, N'btn_EliminarReserva')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (50, N'btn_CancelarReserva')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (51, N'chk_Fecha')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (52, N'chk_Cliente')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (53, N'btn_Filtrar')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (54, N'lbl_Forma_Pago')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (55, N'msg_Instancia')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (56, N'msg_CamposVacios')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (57, N'msg_UsuarioBloqueado')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (58, N'msg_ContraseñaIncorrecta')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (59, N'msg_UsuarioNoExiste')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (60, N'msg_ErrorDeslogeo')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (61, N'msg_ValidacionNombre')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (62, N'msg_ValidacionApellido')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (63, N'msg_ValidacionDni')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (64, N'msg_ValidacionPassword')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (65, N'msg_PasswordNoCoincide')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (66, N'msg_ErrorListar')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (67, N'msg_ErrorObtenerUsuarios')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (68, N'msg_ErrorObtenerCanchas')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (69, N'msg_ErrorObtenerComponentes')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (70, N'msg_ErrorObtenerFamilias')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (71, N'msg_ErrorObtenerPatentes')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (72, N'msg_ErrorObtenerPermisos')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (73, N'msg_ErrorCalculo')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (74, N'menu_Recalcular_DV')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (75, N'menu_Bitacora')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (76, N'menu_Backup')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (77, N'menu_Restore')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (78, N'menu_Roles')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (79, N'menu_Seguridad_Usuarios')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (82, N'menu_Usuarios_Bloqueados')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (83, N'menu_Cambiar_Contraseña')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (85, N'menu_Control_Cliente')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (86, N'msg_UsuarioDesbloqueado')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (87, N'Usuarios_Bloqueados')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (88, N'lbl_Cliente')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (89, N'lbl_Usuario')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (90, N'lbl_ContraseñaActual')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (91, N'lbl_NuevaContraseña')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (92, N'lbl_Confirmar_NuevaContraseña')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (93, N'msg_BitacoraBaja')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (94, N'lbl_FechaDesde')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (95, N'lbl_FechaHasta')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (96, N'chk_Criticidad')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (97, N'lbl_EliminarBitacora')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (98, N'btn_Eliminar')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (99, N'btn_Aceptar')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (100, N'msg_BackupRealizado')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (101, N'msg_RestoreRealizado')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (102, N'msg_ClienteAlta')
GO
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (103, N'msg_ClienteModificado')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (104, N'msg_ClienteBaja')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (105, N'msg_ClienteNoSeleccionado')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (106, N'msg_RestaurarCliente')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (107, N'btn_Mostrar')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (108, N'lbl_Patente')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (109, N'lbl_Familia')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (110, N'btn_Agregar')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (111, N'btn_Guardar')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (112, N'msg_UsuarioNoSeleccionado')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (113, N'msg_ErrorCargarArbol')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (114, N'msg_ErrorPermisosGuardados')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (115, N'msg_PatenteYaAsociada')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (116, N'msg_PermisosGuardados')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (117, N'Permisos_Usuarios')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (118, N'lbl_Pagado')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (119, N'msg_ClienteTieneDeudas')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (120, N'menu_Deudas_Pendientes')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1119, N'msg_ReservaAlta')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1120, N'msg_ReservaNoSeleccionada')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1121, N'msg_ReservaModificada')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1122, N'msg_ReservaBaja')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1123, N'msg_ReservaVencida')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1124, N'msg_SeñaMayorTotal')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1125, N'msg_CambioContraseña')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1126, N'msg_PasswordNoCoindice')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1127, N'msg_ErrorPrecio')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1128, N'msg_UsuarioAlta')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1129, N'msg_UsuarioModificado')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1130, N'msg_UsuarioBaja')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1131, N'msg_DeudaPagada')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1132, N'msg_ErrorPagarDeuda')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1133, N'msg_FamiliaExiste')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1134, N'msg_FamiliaCreada')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1135, N'msg_CanchaNoSeleccionada')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1136, N'msg_CanchaAlta')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1137, N'msg_CanchaModificada')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1138, N'msg_CanchaBaja')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1139, N'msg_PatenteYaCargada')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1140, N'msg_ErrorCargarPatente')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1141, N'msg_FamiliaGuardadaExito')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1142, N'msg_PatenteEliminada')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1143, N'msg_DebeGuardarCambios')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1144, N'msg_Recursividad')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1145, N'msg_IdiomaAlta')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1146, N'msg_IdiomaNoSeleccionado')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1147, N'msg_UsuarioFamiliaAsociada')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1148, N'msg_ReservaClienteHoraDuplicada')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1149, N'msg_ErrorReservaClienteHora')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1150, N'msg_RestauracionProhibida')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1151, N'chk_Semana')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1152, N'msg_ReservaAltaSemana')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1153, N'rdb_Si')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1154, N'rdb_No')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1155, N'msg_ErrorTimerDeuda')
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (1156, N'menu_Help')
SET IDENTITY_INSERT [dbo].[Etiqueta] OFF
GO
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1022, 10)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 1020)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 1013)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 1019)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 1018)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 10)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 1015)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 1012)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 7)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 9)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 8)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 1016)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 1017)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 1024)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 1025)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 1026)
INSERT [dbo].[FamiliaPatente] ([PadreId], [HijoId]) VALUES (1, 1027)
GO
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([Id], [Nombre], [Default]) VALUES (1, N'Español', 1)
INSERT [dbo].[Idioma] ([Id], [Nombre], [Default]) VALUES (2, N'English', 0)
SET IDENTITY_INSERT [dbo].[Idioma] OFF
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON 

INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1, N'Administrador', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (7, N'Gestion de Usuarios', N'Gestion_Usuarios')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (8, N'Gestion de Canchas', N'Gestion_Canchas')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (9, N'Gestion de Clientes', N'Gestion_Clientes')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (10, N'Reserva', N'Reserva')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1012, N'Informes', N'Informes')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1013, N'Seguridad', N'Seguridad')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1015, N'Recalcular DV', N'Recalcular_DV')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1016, N'Bitacora', N'Bitacora')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1017, N'Backup', N'Backup')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1018, N'Restore', N'Restore')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1019, N'Roles', N'Roles')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1020, N'Seguridad Usuarios', N'Seguridad_Usuarios')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1022, N'Empleado', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1024, N'Control Cliente', N'Control_Cliente')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1025, N'Deudas Pendientes', N'Deudas_Pendientes')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1026, N'Gestion de Idiomas', N'Gestion_Idioma')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1027, N'Help', N'Help')
SET IDENTITY_INSERT [dbo].[Permiso] OFF
GO
SET IDENTITY_INSERT [dbo].[Reserva] ON 

INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (106, 4, 1, CAST(N'2022-11-27' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19925)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (107, 4, 1, CAST(N'2022-12-04' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 18998)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (108, 4, 1, CAST(N'2022-12-11' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19923)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (109, 4, 1, CAST(N'2022-12-18' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19940)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (111, 4, 1, CAST(N'2023-01-01' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 18106)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (112, 4, 1, CAST(N'2023-01-08' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 18116)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (113, 4, 1, CAST(N'2023-01-15' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 18996)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (114, 4, 1, CAST(N'2023-01-22' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 18994)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (115, 4, 1, CAST(N'2023-01-29' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19011)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (116, 4, 1, CAST(N'2023-02-05' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 18128)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (117, 4, 1, CAST(N'2023-02-12' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19006)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (118, 4, 1, CAST(N'2023-02-19' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19023)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (119, 4, 1, CAST(N'2023-02-26' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19021)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (120, 4, 1, CAST(N'2023-03-05' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 18115)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (121, 4, 1, CAST(N'2023-03-12' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 18994)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (122, 4, 1, CAST(N'2023-03-19' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19011)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (123, 4, 1, CAST(N'2023-03-26' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19009)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (124, 4, 1, CAST(N'2023-04-02' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 18127)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (125, 4, 1, CAST(N'2023-04-09' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 18137)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (126, 4, 1, CAST(N'2023-04-16' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19021)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (127, 4, 1, CAST(N'2023-04-23' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19019)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (128, 4, 1, CAST(N'2023-04-30' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19017)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (129, 4, 1, CAST(N'2023-05-07' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 18150)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (130, 4, 1, CAST(N'2023-05-14' AS Date), N'12:00', 1, N'Tarjeta', 0, 8000, 8000, N'No pagado', 19005)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (131, 1, 1, CAST(N'2022-11-22' AS Date), N'19:00', 0, N'Efectivo', 3600, 3600, 0, N'Pagado', 19101)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (132, 4, 1, CAST(N'2022-11-22' AS Date), N'17:00', 0, N'Tarjeta', 8000, 8000, 0, N'Pagado', 18117)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (133, 3, 1, CAST(N'2022-11-22' AS Date), N'22:00', 0, N'Tarjeta', 3500, 3500, 0, N'Pagado', 18120)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (1132, 3, 1, CAST(N'2022-11-23' AS Date), N'18:00', 0, N'Efectivo', 2000, 2700, 700, N'No pagado', 21828)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Semana], [Forma_Pago], [Seña], [Total], [Pagar], [Pagado], [DVH]) VALUES (1133, 2, 1, CAST(N'2022-11-24' AS Date), N'18:00', 0, N'Tarjeta', 6000, 6000, 0, N'Pagado', 18320)
SET IDENTITY_INSERT [dbo].[Reserva] OFF
GO
SET IDENTITY_INSERT [dbo].[Traduccion] ON 

INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1, 1, 1, N'Menu')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (2, 2, 1, N'Main')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (3, 1, 2, N'Cancha')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (4, 1, 3, N'Gestion')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (5, 1, 4, N'Informes')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (6, 1, 5, N'Idioma')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (7, 1, 6, N'Seguridad')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (8, 1, 7, N'Cerrar Sesion')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (9, 1, 8, N'Reserva')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (10, 1, 9, N'Listado')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (11, 1, 10, N'Usuarios')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (12, 1, 11, N'Canchas')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (13, 1, 12, N'Clientes')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (14, 1, 13, N'Gestion idioma')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (15, 1, 14, N'Alta idioma')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (16, 1, 15, N'Cargar etiquetas')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (17, 1, 16, N'Modificar etiquetas')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (18, 1, 17, N'Gestión familia')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (19, 1, 18, N'Asignar permisos')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (20, 1, 19, N'Consultar permisos')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (21, 1, 20, N'Salir')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (22, 1, 21, N'Nombre')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (23, 1, 22, N'Apellido')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (24, 1, 23, N'Nombre Usuario')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (25, 1, 24, N'Contraseña')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (26, 1, 25, N'Puesto')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (27, 1, 26, N'Dni')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (28, 1, 27, N'Genero')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (29, 1, 28, N'Correo')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (30, 1, 29, N'Telefono')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (31, 1, 30, N'Tipo')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (32, 1, 31, N'Alta')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (33, 1, 32, N'Modificar')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (34, 1, 33, N'Baja')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (35, 1, 34, N'Cancelar')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (36, 1, 35, N'Material')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (37, 1, 36, N'Precio')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (38, 1, 37, N'Tipo de cancha')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (39, 1, 38, N'Cancha')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (40, 1, 39, N'Es cliente?')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (41, 1, 40, N'Alta cliente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (42, 1, 41, N'Fecha')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (43, 1, 42, N'Hora')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (44, 1, 43, N'Seña')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (45, 1, 44, N'Total')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (46, 1, 45, N'Debe')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (47, 1, 46, N'Calcular Deuda')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (48, 1, 47, N'Reservar')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (49, 1, 48, N'Modificar Reserva')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (50, 1, 49, N'Eliminar Reserva')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (51, 1, 50, N'Cancelar Reserva')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (52, 1, 51, N'Fecha')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (53, 1, 52, N'Cliente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (54, 1, 53, N'Filtrar')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (55, 1, 54, N'Forma de pago')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (57, 1, 55, N'Ya hay una instancia de un usuario creada.')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (58, 1, 56, N'Se deben completar los campos')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (60, 1, 57, N'El usuario está bloqueado')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (61, 1, 58, N'La contraseña ingresada es incorrecta.')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (62, 1, 59, N'No existe un usuario con ese nombre de usuario')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (63, 1, 60, N'Hubo un error al querer desloguear.')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (64, 1, 61, N'El nombre debe tener al menos 3 caracteres.')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (65, 1, 62, N'El apellido debe tener al menos 3 caracteres')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (66, 1, 63, N'Debe ingresar un DNI entre 6 y 10 digitos')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (67, 1, 64, N'La contraseña no es válida')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (68, 1, 65, N'La contraseña no coincide')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (69, 1, 66, N'Error al listar usuarios')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (70, 1, 67, N'Hubo un error al querer obtener los usuarios')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (71, 1, 68, N'Hubo un error al querer obtener las canchas')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (72, 1, 69, N'Hubo un error al querer obtener los componentes')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (73, 1, 70, N'Hubo un error al querer obtener las familias')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (74, 1, 71, N'Hubo un error al querer obtener las patentes')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (75, 1, 72, N'Hubo un error al querer obtener los permisos')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (76, 1, 73, N'Hubo un error al realizar el calculo')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (77, 1, 74, N'Recalcular Digito Verificador')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (78, 1, 75, N'Bitacora')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (79, 1, 76, N'Copia de seguridad')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (80, 1, 77, N'Restaurar')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (81, 1, 78, N'Roles')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (82, 1, 79, N'Usuarios')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (83, 1, 82, N'Bloqueados')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (84, 1, 83, N'Cambiar contraseña')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (85, 2, 2, N'Soccer field')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (86, 2, 3, N'Managment')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (87, 2, 4, N'Reports')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (88, 2, 5, N'Language')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (89, 2, 6, N'Security')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (90, 2, 7, N'Sign off')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (91, 2, 8, N'Booking')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (92, 2, 9, N'List')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (93, 2, 10, N'Users')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (94, 2, 11, N'Soccer field')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (95, 2, 12, N'Clients')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (96, 2, 13, N'Language mangement')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (97, 2, 14, N'Register language')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (98, 2, 15, N'Upload labels')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (99, 2, 16, N'Modify labels')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (100, 2, 17, N'Family managment')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (101, 2, 18, N'Assign permissions
')
GO
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (102, 2, 19, N'Check permissions')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (103, 2, 20, N'Close')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (104, 2, 21, N'Forename')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (106, 2, 22, N'Surname')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (107, 2, 23, N'Username')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (108, 2, 24, N'Password')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (109, 2, 25, N'Job')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (110, 2, 26, N'NID')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (111, 2, 27, N'Gender')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (114, 2, 28, N'Mail')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (115, 2, 29, N'Phone')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (116, 2, 30, N'Type')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (117, 2, 31, N'Register')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (118, 2, 32, N'Update')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (120, 2, 33, N'Remove')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (121, 2, 34, N'Cancel')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (122, 2, 35, N'Material')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (123, 2, 36, N'Price')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (124, 2, 37, N'Kind of field')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (125, 2, 38, N'Field')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (127, 2, 39, N'Are you a customer?')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (128, 2, 40, N'Register client')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (129, 2, 41, N'Enter date')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (130, 2, 42, N'Hour')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (131, 2, 43, N'Advance deposit')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (132, 2, 44, N'Total')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (133, 2, 45, N'Debt')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (134, 2, 46, N'Calculate')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (135, 2, 47, N'Book')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (136, 2, 48, N'Update booking')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (137, 2, 49, N'Remove booking')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (138, 2, 50, N'Cancel booking')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (139, 2, 51, N'Date')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (140, 2, 52, N'Client')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (141, 2, 53, N'Filter')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (142, 2, 54, N'Method of payment')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (145, 2, 55, N'There is already an instance of a user created')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (146, 2, 56, N'Fields must be completed')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (149, 2, 57, N'The user is blocked')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (151, 2, 58, N'Password is incorrect')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (152, 2, 59, N'There is no user with that username')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (153, 2, 60, N'There was an error trying to log out')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (154, 2, 61, N'The forename must have at least 3 characters')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (155, 2, 62, N'The surname must have at least 3 characters')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (156, 2, 63, N'You must enter a NID between 6 and 10 digits')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (157, 2, 64, N'The password is invalid')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (158, 2, 65, N'The password does not match')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (159, 2, 66, N'Error listing users')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (161, 2, 67, N'There was an error trying to get the users')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (162, 2, 68, N'There was an error trying to get the soccer fields')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (163, 2, 69, N'There was an error trying to get the components')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (164, 2, 70, N'There was an error trying to get the families')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (165, 2, 71, N'There was an error trying to get the patents')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (166, 2, 72, N'There was an error trying to get the permissions')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (167, 2, 73, N'There was an error when performing the calculation')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (168, 2, 74, N'Recalculate Check Digit')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (169, 2, 75, N'Logbook')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (170, 2, 76, N'Backup')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (171, 2, 77, N'Restore')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (172, 2, 78, N'Roles')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (173, 2, 79, N'Users')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (174, 2, 82, N'Blocked')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (176, 2, 83, N'Change password')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (179, 1, 85, N'Control de cambios de cliente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (180, 2, 85, N'Control of client changes')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (183, 1, 86, N'Se desbloqueó el usuario correctamente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (185, 2, 86, N'User successfully unlocked')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (186, 2, 87, N'Blocked users')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (187, 1, 87, N'Usuarios bloqueados')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (188, 1, 88, N'Cliente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (189, 2, 88, N'Client')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (190, 1, 89, N'Usuario')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (191, 2, 89, N'Username')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (192, 1, 90, N'Contraseña actual')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (193, 2, 90, N'Actual password')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (194, 1, 91, N'Nueva contraseña')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (195, 2, 91, N'New password')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (196, 1, 92, N'Confirmar nueva contraseña')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (197, 2, 92, N'Confirm new password')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (198, 1, 93, N'Se dió de baja la bitacora de manera correcta')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (199, 2, 93, N'The log was deleted correctly')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (200, 1, 94, N'Fecha desde')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (201, 2, 94, N'Date from')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (202, 1, 95, N'Fecha hasta')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (203, 2, 95, N'Date to')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (204, 1, 96, N'Criticidad')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (205, 2, 96, N'Criticality')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (206, 1, 97, N'Eliminar bitacora')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (207, 2, 97, N'Delete log')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (208, 1, 98, N'Eliminar')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (209, 2, 98, N'Delete')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (210, 1, 99, N'Aceptar')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (211, 2, 99, N'Accept')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (212, 1, 100, N'Copia de seguridad realizada correctamente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (213, 2, 100, N'Backup successful')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (214, 1, 101, N'Restauración realizada de manera correcta')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (215, 2, 101, N'Restore successful')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (216, 1, 102, N'Se dió de alta el cliente exitosamente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (217, 1, 103, N'Se modificó el cliente exitosamente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (218, 1, 104, N'Se dió de baja el cliente exitosamente')
GO
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (219, 1, 105, N'Por favor, seleccione un cliente de la lista')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (223, 2, 103, N'Modified client successfully')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (224, 2, 104, N'Client was successfully unsubscribed')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (225, 2, 105, N'Please, select a client from the list')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (231, 1, 106, N'Se restauró el cliente de manera correcta')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (236, 2, 102, N'The client was successfully registered')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (237, 2, 106, N'The client was successfully restored')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (238, 1, 107, N'Mostrar')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (239, 2, 107, N'Show')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (240, 1, 108, N'Patente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (241, 2, 108, N'Patent')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (242, 1, 109, N'Familia')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (243, 2, 109, N'Family')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (244, 1, 110, N'Agregar')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (245, 2, 110, N'Add')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (246, 1, 111, N'Guardar')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (247, 2, 111, N'Save')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (248, 1, 112, N'Debe seleccionar un usuario')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (249, 2, 112, N'You must select a user')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (250, 1, 113, N'Error al cargar el árbol')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (251, 2, 113, N'Error loading tree')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (252, 1, 114, N'Error al guardar los permisos')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (253, 2, 114, N'Error saving permissions')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (254, 1, 115, N'La patente ya fue asociada')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (255, 2, 115, N'The patent was already associated')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (256, 1, 116, N'Se guardaron los permisos al usuario')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (257, 2, 116, N'User permissions saved')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (258, 1, 117, N'Permisos de usuario')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (259, 1, 118, N'Pagado')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (260, 2, 118, N'Paid out')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (261, 1, 119, N'El cliente no puede realizar reservas, ya que tiene deudas pendientes.')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (262, 2, 119, N'The client cannot make reservations, because he has pending debts.')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (263, 1, 120, N'Deudas Pendientes')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (264, 2, 120, N'Outstanding debts')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1261, 1, 1119, N'Se dió de alta la reserva de manera correcta')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1262, 2, 1119, N'The reservation was registered correctly')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1263, 1, 1120, N'Seleccione una reserva')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1264, 1, 1121, N'Se modificó la reserva correctamente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1265, 1, 1122, N'Se dió de baja la reserva correctamente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1266, 1, 1123, N'La fecha que ingresó ya pasó')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1267, 1, 1124, N'La seña es mayor que el total a pagar')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1268, 1, 1125, N'Se cambió la contraseña correctamente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1269, 1, 1126, N'Las contraseñas no coinciden')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1270, 1, 1127, N'Hubo un error al obtener el precio de la cancha')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1271, 1, 1128, N'Se dió de alta el usuario de manera correcta')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1272, 1, 1129, N'Se modificó el usuario de manera correcta')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1273, 1, 1130, N'Se dió de baja el usuario de manera correcta')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1274, 1, 1131, N'Se pagó la deuda para el cliente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1275, 1, 1132, N'Hubo un error al pagar la deuda')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1276, 1, 1133, N'La familia ya existe')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1277, 1, 1134, N'Familia creada exitosamente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1279, 1, 1135, N'Seleccione una cancha')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1280, 1, 1136, N'Se dió de alta la cancha correctamente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1281, 1, 1137, N'Se modificó la cancha correctamente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1282, 1, 1138, N'Se dió de baja la cancha correctamente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1283, 1, 1139, N'La patente ya está cargada')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1284, 1, 1140, N'Hubo un error al cargar las patentes')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1285, 1, 1141, N'Se guardó la familia con éxito')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1286, 1, 1142, N'La patente fue eliminada')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1287, 1, 1143, N'Debe guardar los cambios')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1288, 1, 1144, N'Error de recursividad. No se pudo añadir.')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1289, 1, 1145, N'Se dió de alta el idioma correctamente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1290, 1, 1146, N'Seleccione un idioma')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1291, 1, 1147, N'Ese usuario ya tiene esa familia asociada')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1292, 2, 1120, N'Select a reservation')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1294, 2, 1121, N'The reservation was modified successfully
')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1295, 2, 1122, N'The reservation was successfully canceled')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1296, 2, 1123, N'The date you entered has passed')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1297, 2, 1124, N'The deposit is greater than the total to pay')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1298, 2, 1125, N'Password changed successfully')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1299, 2, 1126, N'Passwords do not match')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1300, 2, 1127, N'There was an error getting the price of the court')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1301, 2, 1128, N'The user was successfully registered')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1302, 2, 1129, N'The user was successfully modified')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1303, 2, 1130, N'The user was successfully unsubscribed')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1304, 2, 1131, N'The debt for the client was paid')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1305, 2, 1132, N'There was an error paying the debt')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1306, 2, 1133, N'The family already exists
')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1307, 2, 1134, N'Family successfully created')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1308, 2, 1135, N'Select a court')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1309, 2, 1136, N'The field was registered correctly')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1310, 2, 1137, N'The field was successfully modified')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1311, 2, 1138, N'The field was successfully discharged')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1313, 2, 1139, N'The patent is already loaded')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1314, 2, 1140, N'There was an error loading the patents')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1315, 2, 1141, N'Family saved successfully')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1316, 2, 1142, N'The patent was removed')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1317, 2, 1143, N'You must save the changes')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1318, 2, 1144, N'Cannot be added as it will generate recursion')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1319, 2, 1145, N'
The language was registered correctly')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1320, 2, 1146, N'Select a language')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1321, 2, 1147, N'That user already has that associated family')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1322, 1, 1148, N'El cliente ya tiene una reserva para ese horario')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1323, 2, 1148, N'The client already has a reservation for that time')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1324, 1, 1149, N'Error al obtener datos de la reserva y la hora')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1325, 2, 1149, N'Error getting reservation data and time')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1326, 1, 1150, N'No se puede realizar esta restauración')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1327, 2, 1150, N'Unable to perform this restore')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1328, 1, 1151, N'Semanalmente')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1329, 2, 1151, N'Weekly')
GO
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1330, 1, 1152, N'Se dió de alta la reserva por semana')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1331, 2, 1152, N'The reservation was registered per week')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1332, 1, 1153, N'Si')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1333, 1, 1154, N'No')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1334, 2, 1153, N'Yes')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1335, 2, 1154, N'No')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1336, 1, 1155, N'Error al querer cargar las alertas de deudas de reserva')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1337, 2, 1155, N'Error when trying to load reserve debt alerts')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1338, 1, 1156, N'Ayuda')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (1339, 2, 1156, N'Help')
SET IDENTITY_INSERT [dbo].[Traduccion] OFF
GO
SET IDENTITY_INSERT [dbo].[UsuarioPermiso] ON 

INSERT [dbo].[UsuarioPermiso] ([Id_UsuarioPermiso], [UsuarioId], [PatenteId], [DVH]) VALUES (1, 2, 1, 148)
INSERT [dbo].[UsuarioPermiso] ([Id_UsuarioPermiso], [UsuarioId], [PatenteId], [DVH]) VALUES (2, 4, 1, 151)
SET IDENTITY_INSERT [dbo].[UsuarioPermiso] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Nombre], [Apellido], [Nombre_Usuario], [Contraseña], [Puesto], [Dni], [Sexo], [Mail], [Telefono], [Tipo], [Estado], [DVH]) VALUES (2, N'qO5+kqBvJk0VglIuQENyAA==', N'FpIlz41KyvtcmpjBB/UvpA==', N'bhs9QjaREqSMQPPzGSDEmA==', N'7B93BC9E19F7023489BB784CC364D67B', N'Administrador', 39810500, N'Masculino', N'ramiro.itokazu@gmail.com', 1158174329, N'Celular', 0, 157409)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Apellido], [Nombre_Usuario], [Contraseña], [Puesto], [Dni], [Sexo], [Mail], [Telefono], [Tipo], [Estado], [DVH]) VALUES (4, N'i1/bHyX9UKBkLQ+85EuR0A==', N'l/X97UzEyqkhO9WCCSv5zA==', N'/G2ezJI6pMZHie++LJ7SSA==', N'A94652AA97C7211BA8954DD15A3CF838', N'Administrador', 39810500, N'Masculino', N'juan.perez@gmail.com', 1158174329, N'Celular', 0, 141455)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
USE [master]
GO
ALTER DATABASE [Canchas_2022] SET  READ_WRITE 
GO
