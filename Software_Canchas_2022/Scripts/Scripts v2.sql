USE [master]
GO
/****** Object:  Database [Canchas_2022]    Script Date: 13/10/2022 15:25:31 ******/
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
/****** Object:  Table [dbo].[Bitacora]    Script Date: 13/10/2022 15:25:32 ******/
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
/****** Object:  Table [dbo].[Cancha]    Script Date: 13/10/2022 15:25:32 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 13/10/2022 15:25:32 ******/
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
/****** Object:  Table [dbo].[ControlReserva]    Script Date: 13/10/2022 15:25:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlReserva](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cancha] [int] NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [nvarchar](5) NOT NULL,
	[Forma_Pago] [nvarchar](50) NOT NULL,
	[Seña] [float] NOT NULL,
	[Total] [float] NOT NULL,
	[Deuda] [float] NOT NULL,
	[Fecha_Modificacion] [datetime] NOT NULL,
	[Id_Usuario] [int] NOT NULL,
	[Descripcion] [nvarchar](100) NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_ControlReserva] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DigitoVerificador]    Script Date: 13/10/2022 15:25:32 ******/
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
/****** Object:  Table [dbo].[Etiqueta]    Script Date: 13/10/2022 15:25:32 ******/
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
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 13/10/2022 15:25:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamiliaPatente](
	[PadreId] [int] NOT NULL,
	[HijoId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 13/10/2022 15:25:32 ******/
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
/****** Object:  Table [dbo].[Permiso]    Script Date: 13/10/2022 15:25:32 ******/
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
/****** Object:  Table [dbo].[Reserva]    Script Date: 13/10/2022 15:25:32 ******/
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
	[Forma_Pago] [nvarchar](50) NOT NULL,
	[Seña] [float] NOT NULL,
	[Total] [float] NOT NULL,
	[Deuda] [float] NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 13/10/2022 15:25:32 ******/
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
/****** Object:  Table [dbo].[UsuarioPermiso]    Script Date: 13/10/2022 15:25:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPermiso](
	[UsuarioId] [int] NOT NULL,
	[PatenteId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/10/2022 15:25:32 ******/
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

INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (32, N'ramiro', N'Se eliminaron las bitacoras desde el día 21/9/2022  hasta el día 21/9/2022 .', CAST(N'2022-09-21T10:01:00.000' AS DateTime), N'MEDIA', 212583)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (33, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T10:02:00.000' AS DateTime), N'ALTA', 31537)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (34, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T10:02:00.000' AS DateTime), N'ALTA', 30994)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (35, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T10:06:00.000' AS DateTime), N'ALTA', 31601)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (36, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T10:08:08.770' AS DateTime), N'ALTA', 31232)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (37, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T10:09:35.160' AS DateTime), N'ALTA', 31246)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (38, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T10:12:06.260' AS DateTime), N'ALTA', 31124)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (39, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T10:13:09.573' AS DateTime), N'ALTA', 31195)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (40, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T11:57:27.520' AS DateTime), N'ALTA', 31304)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (41, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T11:58:19.507' AS DateTime), N'ALTA', 31340)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (42, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T11:59:41.227' AS DateTime), N'ALTA', 31264)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (43, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T12:21:47.260' AS DateTime), N'ALTA', 31224)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (44, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T12:22:42.133' AS DateTime), N'ALTA', 31151)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (45, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T12:23:33.643' AS DateTime), N'ALTA', 31169)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (46, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T13:50:58.140' AS DateTime), N'ALTA', 31304)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (47, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T14:11:14.513' AS DateTime), N'ALTA', 31137)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (48, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T15:11:23.513' AS DateTime), N'ALTA', 31150)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (49, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T17:41:55.000' AS DateTime), N'ALTA', 31305)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (50, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T17:42:37.873' AS DateTime), N'ALTA', 31305)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (51, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T17:45:29.720' AS DateTime), N'ALTA', 31371)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (52, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T17:46:57.837' AS DateTime), N'ALTA', 31403)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (53, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T17:47:21.087' AS DateTime), N'ALTA', 31261)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (54, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T17:48:46.093' AS DateTime), N'ALTA', 31402)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (55, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T17:49:08.230' AS DateTime), N'ALTA', 31387)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (56, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T17:49:45.373' AS DateTime), N'ALTA', 31403)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (57, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T17:51:01.123' AS DateTime), N'ALTA', 31159)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (58, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T17:52:01.617' AS DateTime), N'ALTA', 31176)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (59, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T17:58:33.313' AS DateTime), N'ALTA', 31900)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (60, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:01:57.260' AS DateTime), N'ALTA', 31281)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (61, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:05:05.470' AS DateTime), N'ALTA', 31222)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (62, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:07:18.180' AS DateTime), N'ALTA', 31325)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (63, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T18:07:28.497' AS DateTime), N'ALTA', 31889)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (64, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:09:34.683' AS DateTime), N'ALTA', 31321)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (65, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:10:01.270' AS DateTime), N'ALTA', 31097)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (66, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:13:12.417' AS DateTime), N'ALTA', 31179)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (67, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T18:14:10.570' AS DateTime), N'ALTA', 31705)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (68, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T18:16:08.023' AS DateTime), N'ALTA', 31864)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (69, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:17:09.703' AS DateTime), N'ALTA', 31354)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (70, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T18:17:36.963' AS DateTime), N'ALTA', 31879)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (71, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T18:19:54.910' AS DateTime), N'ALTA', 31909)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (72, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:20:49.407' AS DateTime), N'ALTA', 31318)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (73, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:23:53.423' AS DateTime), N'ALTA', 31274)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (74, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:24:23.067' AS DateTime), N'ALTA', 31240)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (75, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:25:02.727' AS DateTime), N'ALTA', 31205)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (76, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:33:37.077' AS DateTime), N'ALTA', 31332)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (77, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:34:12.437' AS DateTime), N'ALTA', 31225)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (78, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:34:54.803' AS DateTime), N'ALTA', 31331)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (79, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:35:16.547' AS DateTime), N'ALTA', 31316)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (80, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:35:36.330' AS DateTime), N'ALTA', 31333)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (81, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:36:11.360' AS DateTime), N'ALTA', 31226)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (82, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T18:36:27.703' AS DateTime), N'ALTA', 31898)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (83, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:36:49.863' AS DateTime), N'ALTA', 31425)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (84, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T18:36:56.963' AS DateTime), N'ALTA', 31935)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (85, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T18:39:01.417' AS DateTime), N'ALTA', 31807)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (86, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:39:44.830' AS DateTime), N'ALTA', 31386)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (87, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:40:25.867' AS DateTime), N'ALTA', 31251)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (88, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:41:49.440' AS DateTime), N'ALTA', 31374)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (89, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:41:59.223' AS DateTime), N'ALTA', 31393)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (90, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T18:54:34.860' AS DateTime), N'ALTA', 31311)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (91, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:00:34.210' AS DateTime), N'ALTA', 31195)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (92, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:08:36.723' AS DateTime), N'ALTA', 31353)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (93, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:08:51.693' AS DateTime), N'ALTA', 31844)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (94, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:09:10.043' AS DateTime), N'ALTA', 31230)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (95, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:09:43.637' AS DateTime), N'ALTA', 31882)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (96, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:10:02.483' AS DateTime), N'ALTA', 31132)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (97, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:12:28.500' AS DateTime), N'ALTA', 31306)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (98, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:12:52.493' AS DateTime), N'ALTA', 31251)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (99, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:15:46.297' AS DateTime), N'ALTA', 31353)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (100, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:16:47.857' AS DateTime), N'ALTA', 31504)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (101, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:18:35.657' AS DateTime), N'ALTA', 31484)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (102, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:19:13.387' AS DateTime), N'ALTA', 31432)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (103, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:19:30.583' AS DateTime), N'ALTA', 31415)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (104, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:19:46.940' AS DateTime), N'ALTA', 31543)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (105, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:20:31.593' AS DateTime), N'ALTA', 31318)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (106, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:24:24.030' AS DateTime), N'ALTA', 31963)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (107, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:24:54.603' AS DateTime), N'ALTA', 32017)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (108, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:26:09.593' AS DateTime), N'ALTA', 31510)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (109, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:28:04.047' AS DateTime), N'ALTA', 31453)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (110, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:28:49.130' AS DateTime), N'ALTA', 31586)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (111, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:28:59.157' AS DateTime), N'ALTA', 32151)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (112, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:29:13.633' AS DateTime), N'ALTA', 31993)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (113, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:30:36.767' AS DateTime), N'ALTA', 31418)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (114, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:30:45.233' AS DateTime), N'ALTA', 31965)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (115, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:30:55.687' AS DateTime), N'ALTA', 31440)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (116, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:31:58.440' AS DateTime), N'ALTA', 31512)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (117, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:32:26.340' AS DateTime), N'ALTA', 31988)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (118, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:33:56.877' AS DateTime), N'ALTA', 31512)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (119, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:36:21.753' AS DateTime), N'ALTA', 31964)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (120, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:37:35.153' AS DateTime), N'ALTA', 32043)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (121, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:38:11.617' AS DateTime), N'ALTA', 31955)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (122, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:38:19.620' AS DateTime), N'ALTA', 31557)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (123, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:38:44.200' AS DateTime), N'ALTA', 32066)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (124, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:38:52.210' AS DateTime), N'ALTA', 31505)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (125, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:39:14.347' AS DateTime), N'ALTA', 31491)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (126, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:39:37.383' AS DateTime), N'ALTA', 31582)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (127, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-21T19:40:03.847' AS DateTime), N'ALTA', 31886)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (128, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T19:40:10.610' AS DateTime), N'ALTA', 31307)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (129, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:24:16.947' AS DateTime), N'ALTA', 31365)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (130, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:27:29.977' AS DateTime), N'ALTA', 31456)
GO
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (131, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:39:13.493' AS DateTime), N'ALTA', 31378)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (132, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:40:35.957' AS DateTime), N'ALTA', 31330)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (133, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:44:49.510' AS DateTime), N'ALTA', 31482)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (134, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:45:05.880' AS DateTime), N'ALTA', 31360)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (135, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:46:17.417' AS DateTime), N'ALTA', 31431)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (136, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:47:17.350' AS DateTime), N'ALTA', 31449)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (137, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:47:48.390' AS DateTime), N'ALTA', 31521)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (138, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:48:42.017' AS DateTime), N'ALTA', 31431)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (139, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:50:42.713' AS DateTime), N'ALTA', 31328)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (140, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:51:53.040' AS DateTime), N'ALTA', 31353)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (141, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:53:34.497' AS DateTime), N'ALTA', 31370)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (142, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:57:38.710' AS DateTime), N'ALTA', 31505)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (143, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T21:59:14.123' AS DateTime), N'ALTA', 31432)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (144, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:04:22.063' AS DateTime), N'ALTA', 31283)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (145, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:05:19.563' AS DateTime), N'ALTA', 31410)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (146, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:06:45.717' AS DateTime), N'ALTA', 31407)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (147, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:07:19.457' AS DateTime), N'ALTA', 31446)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (148, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:08:35.987' AS DateTime), N'ALTA', 31426)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (149, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:10:32.527' AS DateTime), N'ALTA', 31269)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (150, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:11:24.177' AS DateTime), N'ALTA', 31278)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (151, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:12:29.817' AS DateTime), N'ALTA', 31386)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (152, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:19:01.883' AS DateTime), N'ALTA', 31316)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (153, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:19:35.187' AS DateTime), N'ALTA', 31442)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (154, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:20:27.190' AS DateTime), N'ALTA', 31343)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (155, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:22:35.360' AS DateTime), N'ALTA', 31357)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (156, N'ramiro', N'Se realizó una copia de seguridad.', CAST(N'2022-09-21T22:22:46.137' AS DateTime), N'ALTA', 66772)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (157, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:23:33.097' AS DateTime), N'ALTA', 31342)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (158, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T22:24:24.063' AS DateTime), N'ALTA', 31361)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (159, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-21T23:46:50.253' AS DateTime), N'ALTA', 31413)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (160, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T00:00:09.870' AS DateTime), N'ALTA', 31263)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (161, N'ramiro', N'Se realizó un restore.', CAST(N'2022-09-22T00:18:36.767' AS DateTime), N'ALTA', 35808)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (162, N'ramiro', N'Se dió de alta el usuario 1004.', CAST(N'2022-09-22T00:19:39.667' AS DateTime), N'ALTA', 50689)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (163, N'ramiro', N'Se realizó un restore.', CAST(N'2022-09-22T00:27:43.963' AS DateTime), N'ALTA', 35776)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (164, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T10:47:57.697' AS DateTime), N'ALTA', 31496)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (165, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T10:48:28.400' AS DateTime), N'ALTA', 31481)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (166, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T10:48:46.310' AS DateTime), N'ALTA', 31482)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (167, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T10:56:13.697' AS DateTime), N'ALTA', 31364)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (168, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T11:03:44.473' AS DateTime), N'ALTA', 31333)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (169, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T11:04:33.610' AS DateTime), N'ALTA', 31316)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (170, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T11:24:52.183' AS DateTime), N'ALTA', 31335)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (171, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T11:27:47.430' AS DateTime), N'ALTA', 31456)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (172, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T11:38:39.987' AS DateTime), N'ALTA', 31507)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (173, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T11:40:26.830' AS DateTime), N'ALTA', 31333)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (174, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T11:42:44.290' AS DateTime), N'ALTA', 31364)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (175, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T13:31:27.387' AS DateTime), N'ALTA', 31382)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (176, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T13:32:26.403' AS DateTime), N'ALTA', 31382)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (177, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T13:34:05.440' AS DateTime), N'ALTA', 31363)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (178, N'micaela', N'Se logeó el usuario.', CAST(N'2022-09-22T13:34:24.780' AS DateTime), N'ALTA', 31927)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (179, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T13:36:04.223' AS DateTime), N'ALTA', 31381)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (180, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T13:37:11.550' AS DateTime), N'ALTA', 31334)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (181, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T13:40:36.213' AS DateTime), N'ALTA', 31370)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (182, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T13:46:04.090' AS DateTime), N'ALTA', 31376)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (183, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T13:46:46.387' AS DateTime), N'ALTA', 31483)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (184, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T13:50:29.420' AS DateTime), N'ALTA', 31430)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (185, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T13:53:52.617' AS DateTime), N'ALTA', 31403)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (186, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T13:55:48.493' AS DateTime), N'ALTA', 31527)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (187, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T13:56:52.290' AS DateTime), N'ALTA', 31454)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (188, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T14:21:07.220' AS DateTime), N'ALTA', 31357)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (189, N'ramiro', N'Se creó la familia Empleado.', CAST(N'2022-09-22T14:22:04.430' AS DateTime), N'ALTA', 48707)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (190, N'ramiro', N'Se creó la familia Empleado.', CAST(N'2022-09-22T14:22:18.520' AS DateTime), N'ALTA', 48771)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (191, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T14:23:55.323' AS DateTime), N'ALTA', 31417)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (192, N'ramiro', N'Se creó la familia Empleado.', CAST(N'2022-09-22T14:24:06.877' AS DateTime), N'ALTA', 48754)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (193, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T14:25:32.313' AS DateTime), N'ALTA', 31365)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (194, N'ramiro', N'Se creó la familia en Empleado.', CAST(N'2022-09-22T14:25:57.510' AS DateTime), N'ALTA', 56471)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (195, N'ramiro', N'Se creó la familia en Empleado.', CAST(N'2022-09-22T14:26:44.297' AS DateTime), N'ALTA', 56418)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (196, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T19:24:34.490' AS DateTime), N'ALTA', 31455)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (197, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T19:25:38.277' AS DateTime), N'ALTA', 31545)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (198, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T19:30:18.390' AS DateTime), N'ALTA', 31453)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (199, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T19:35:29.907' AS DateTime), N'ALTA', 31566)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (200, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T19:38:08.110' AS DateTime), N'ALTA', 31515)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (201, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T19:39:39.287' AS DateTime), N'ALTA', 31602)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (202, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T19:40:05.367' AS DateTime), N'ALTA', 31361)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (203, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T20:28:38.903' AS DateTime), N'ALTA', 31464)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (204, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T20:34:57.130' AS DateTime), N'BAJA', 31386)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (205, N'ramiro', N'Se desbloqueó el usuario 0.', CAST(N'2022-09-22T20:35:51.433' AS DateTime), N'ALTA', 44738)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (206, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-22T20:36:16.443' AS DateTime), N'BAJA', 23642)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (207, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T20:54:50.610' AS DateTime), N'BAJA', 31297)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (208, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T20:56:14.023' AS DateTime), N'BAJA', 31334)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (209, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:08:22.103' AS DateTime), N'BAJA', 31290)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (210, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:09:20.223' AS DateTime), N'BAJA', 31244)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (211, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:10:18.227' AS DateTime), N'BAJA', 31253)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (212, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:11:45.710' AS DateTime), N'BAJA', 31268)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (213, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:12:57.127' AS DateTime), N'BAJA', 31339)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (214, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:13:23.093' AS DateTime), N'BAJA', 31234)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (215, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:13:40.270' AS DateTime), N'BAJA', 31217)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (216, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:13:57.013' AS DateTime), N'BAJA', 31363)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (217, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:14:46.730' AS DateTime), N'BAJA', 31346)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (218, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:14:58.433' AS DateTime), N'BAJA', 31402)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (219, N'ramiro', N'Se cambió la contraseña para el usuario 2.', CAST(N'2022-09-22T21:16:04.127' AS DateTime), N'ALTA', 91151)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (220, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:16:44.023' AS DateTime), N'BAJA', 31321)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (221, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:18:03.490' AS DateTime), N'BAJA', 31268)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (222, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:20:19.003' AS DateTime), N'BAJA', 31290)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (223, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:21:28.603' AS DateTime), N'BAJA', 31307)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (224, N'ramiro', N'Se cambió la contraseña para el usuario 2.', CAST(N'2022-09-22T21:22:03.637' AS DateTime), N'ALTA', 91074)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (225, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-22T21:22:22.107' AS DateTime), N'BAJA', 23526)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (226, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:27:00.543' AS DateTime), N'BAJA', 31228)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (227, N'ramiro', N'Se cambió la contraseña para el usuario 2.', CAST(N'2022-09-22T21:27:52.747' AS DateTime), N'ALTA', 91225)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (228, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-22T21:27:56.110' AS DateTime), N'BAJA', 23733)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (229, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T21:28:24.797' AS DateTime), N'BAJA', 31358)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (230, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-22T23:57:37.667' AS DateTime), N'BAJA', 31455)
GO
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (231, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-23T00:02:57.937' AS DateTime), N'BAJA', 31291)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (232, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-23T00:03:00.697' AS DateTime), N'BAJA', 23404)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (233, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-23T00:03:21.857' AS DateTime), N'BAJA', 31153)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (234, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-23T00:03:24.500' AS DateTime), N'BAJA', 23516)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (235, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-23T00:05:51.307' AS DateTime), N'BAJA', 31240)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (236, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-23T00:07:22.977' AS DateTime), N'BAJA', 31240)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (237, N'ramiro', N'Se desbloqueó el usuario 0.', CAST(N'2022-09-23T00:07:30.193' AS DateTime), N'ALTA', 44666)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (238, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-23T00:07:33.713' AS DateTime), N'BAJA', 23587)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (239, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-23T18:36:31.950' AS DateTime), N'BAJA', 31382)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (240, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-23T18:36:56.540' AS DateTime), N'BAJA', 23787)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (241, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T21:16:18.763' AS DateTime), N'BAJA', 31359)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (242, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T21:16:26.923' AS DateTime), N'BAJA', 31343)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (243, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T21:17:32.887' AS DateTime), N'BAJA', 31306)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (244, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T21:19:33.137' AS DateTime), N'BAJA', 31357)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (245, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T21:56:16.140' AS DateTime), N'BAJA', 31391)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (246, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T21:56:45.643' AS DateTime), N'BAJA', 31427)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (247, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T21:58:52.230' AS DateTime), N'BAJA', 31423)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (248, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:14:22.740' AS DateTime), N'BAJA', 31283)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (249, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:18:55.040' AS DateTime), N'BAJA', 31451)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (250, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:22:06.797' AS DateTime), N'BAJA', 31283)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (251, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:22:47.273' AS DateTime), N'BAJA', 31372)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (252, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:24:30.017' AS DateTime), N'BAJA', 31262)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (253, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:25:29.963' AS DateTime), N'BAJA', 31425)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (254, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:28:02.900' AS DateTime), N'BAJA', 31313)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (255, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:32:58.017' AS DateTime), N'BAJA', 31433)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (256, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-27T23:33:40.083' AS DateTime), N'BAJA', 23596)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (257, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:46:10.520' AS DateTime), N'BAJA', 31301)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (258, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:47:48.343' AS DateTime), N'BAJA', 31514)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (259, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:48:42.100' AS DateTime), N'BAJA', 31424)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (260, N'ramiro', N'Se realizaron modificaciones en la familia Administrador.', CAST(N'2022-09-27T23:49:05.447' AS DateTime), N'ALTA', 170699)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (261, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-27T23:49:14.770' AS DateTime), N'BAJA', 23708)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (262, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:49:18.260' AS DateTime), N'BAJA', 31477)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (263, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:52:17.293' AS DateTime), N'BAJA', 31371)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (264, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:54:43.657' AS DateTime), N'BAJA', 31383)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (265, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-27T23:55:11.693' AS DateTime), N'BAJA', 31314)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (266, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T00:02:05.737' AS DateTime), N'BAJA', 31201)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (267, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T00:03:23.967' AS DateTime), N'BAJA', 31217)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (268, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T00:03:41.047' AS DateTime), N'BAJA', 31218)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (269, N'sistema', N'Se logeó el usuario.', CAST(N'2022-09-28T15:08:36.490' AS DateTime), N'BAJA', 32121)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (270, N'sistema', N'Cerró la sesión.', CAST(N'2022-09-28T15:09:19.660' AS DateTime), N'BAJA', 24437)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (271, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T15:28:52.217' AS DateTime), N'BAJA', 31408)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (272, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T17:13:33.400' AS DateTime), N'BAJA', 31330)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (273, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-28T17:13:35.680' AS DateTime), N'BAJA', 23675)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (274, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T17:17:52.043' AS DateTime), N'BAJA', 31412)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (275, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-28T17:17:54.533' AS DateTime), N'BAJA', 23757)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (276, N'sistema', N'Se recalcularon los digitos verificadores', CAST(N'2022-09-28T17:18:16.840' AS DateTime), N'ALTA', 100000)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (277, N'sistema', N'Se recalcularon los digitos verificadores', CAST(N'2022-09-28T17:20:27.600' AS DateTime), N'ALTA', 99932)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (278, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T17:20:37.737' AS DateTime), N'BAJA', 31389)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (279, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-28T17:20:47.767' AS DateTime), N'BAJA', 23715)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (280, N'sistema', N'Se recalcularon los digitos verificadores', CAST(N'2022-09-28T17:21:31.843' AS DateTime), N'ALTA', 99837)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (281, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T17:21:42.790' AS DateTime), N'BAJA', 31312)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (282, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-28T17:21:44.977' AS DateTime), N'BAJA', 23657)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (283, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T17:21:47.350' AS DateTime), N'BAJA', 31408)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (284, N'sistema', N'Se recalcularon los digitos verificadores', CAST(N'2022-09-28T17:23:07.837' AS DateTime), N'ALTA', 99936)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (285, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T17:23:20.100' AS DateTime), N'BAJA', 31284)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (286, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T17:24:21.947' AS DateTime), N'BAJA', 31320)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (287, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T17:25:49.007' AS DateTime), N'BAJA', 31516)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (288, N'sistema', N'Se realizó un restore.', CAST(N'2022-09-28T17:29:23.077' AS DateTime), N'ALTA', 36580)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (289, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T17:29:32.333' AS DateTime), N'BAJA', 31439)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (290, N'sistema', N'Se recalcularon los digitos verificadores', CAST(N'2022-09-28T17:31:20.517' AS DateTime), N'ALTA', 99818)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (291, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-28T17:31:40.627' AS DateTime), N'BAJA', 31292)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (1288, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-09-30T09:23:59.500' AS DateTime), N'BAJA', 31715)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (1289, N'ramiro', N'Cerró la sesión.', CAST(N'2022-09-30T09:24:02.040' AS DateTime), N'BAJA', 23829)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (1290, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-10-03T21:17:58.253' AS DateTime), N'BAJA', 31608)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (1367, N'ramiro', N'Se eliminaron las bitacoras desde el día 13/10/2022 hasta el día 13/10/2022.', CAST(N'2022-10-13T11:47:14.840' AS DateTime), N'ALTA', 215041)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (1368, N'ramiro', N'Cerró la sesión.', CAST(N'2022-10-13T11:47:21.240' AS DateTime), N'BAJA', 24734)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (1369, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-10-13T15:15:51.287' AS DateTime), N'BAJA', 32461)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (1370, N'ramiro', N'Se realizó una copia de seguridad.', CAST(N'2022-10-13T15:16:05.830' AS DateTime), N'ALTA', 67858)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (1371, N'ramiro', N'Cerró la sesión.', CAST(N'2022-10-13T15:16:11.597' AS DateTime), N'BAJA', 24682)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (1372, N'ramiro', N'Se logeó el usuario.', CAST(N'2022-10-13T15:18:24.280' AS DateTime), N'BAJA', 32487)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (1373, N'ramiro', N'Se realizó un restore.', CAST(N'2022-10-13T15:19:19.763' AS DateTime), N'ALTA', 37046)
INSERT [dbo].[Bitacora] ([Id], [Nombre_Usuario], [Descripcion], [Fecha], [Criticidad], [DVH]) VALUES (1374, N'ramiro', N'Cerró la sesión.', CAST(N'2022-10-13T15:19:36.657' AS DateTime), N'BAJA', 24873)
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

INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Telefono]) VALUES (1, N'Pepe', N'Lopez', 1165485021)
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Telefono]) VALUES (3, N'Lucas', N'Rodriguez', 1158174329)
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Telefono]) VALUES (4, N'Juliana', N'Vazquez', 42468561)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[ControlReserva] ON 

INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (1, 4, 1, CAST(N'2022-09-28' AS Date), N'15:00', N'Efectivo', 500, 8000, 7500, CAST(N'2022-09-27T23:14:31.240' AS DateTime), 2, N'Se realizaron modificaciones en la reserva', 110873)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (2, 3, 3, CAST(N'2022-09-28' AS Date), N'12:00', N'Tarjeta', 3000, 3000, 0, CAST(N'2022-09-27T23:15:29.010' AS DateTime), 2, N'Se dió de alta la reserva', 52397)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (3, 4, 4, CAST(N'2022-09-28' AS Date), N'21:00', N'Efectivo', 4000, 8500, 4500, CAST(N'2022-09-27T23:19:13.387' AS DateTime), 2, N'Se realizaron modificaciones en la reserva', 111146)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (4, 3, 3, CAST(N'2022-09-28' AS Date), N'12:00', N'Tarjeta', 2000, 3000, 1000, CAST(N'2022-09-27T23:22:18.310' AS DateTime), 2, N'Se realizaron modificaciones en la reserva', 110143)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (5, 4, 4, CAST(N'2022-09-28' AS Date), N'21:00', N'Efectivo', 5000, 8500, 3500, CAST(N'2022-09-27T23:23:03.170' AS DateTime), 2, N'Se realizaron modificaciones en la reserva', 111055)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (6, 3, 1, CAST(N'2022-09-27' AS Date), N'23:00', N'Efectivo', 3500, 3500, 0, CAST(N'2022-09-27T23:28:15.277' AS DateTime), 2, N'Se realizaron modificaciones en la reserva', 110740)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (7, 4, 1, CAST(N'2022-09-28' AS Date), N'15:00', N'Efectivo', 500, 8000, 7500, CAST(N'2022-09-27T23:33:04.277' AS DateTime), 2, N'Se dió de baja la reserva', 53266)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (8, 1, 1, CAST(N'2022-10-12' AS Date), N'23:00', N'Efectivo', 4000, 4000, 0, CAST(N'2022-10-12T19:27:48.860' AS DateTime), 2, N'Se dió de alta la reserva', 55282)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (9, 3, 3, CAST(N'2022-10-14' AS Date), N'17:00', N'Efectivo', 3000, 3000, 0, CAST(N'2022-10-13T11:43:45.897' AS DateTime), 2, N'Se dió de alta la reserva', 55103)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (10, 4, 4, CAST(N'2022-10-13' AS Date), N'12:00', N'Tarjeta', 7500, 8000, 500, CAST(N'2022-10-13T11:46:22.883' AS DateTime), 2, N'Se dió de alta la reserva', 54428)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (11, 4, 4, CAST(N'2022-10-13' AS Date), N'16:00', N'Tarjeta', 7500, 8000, 500, CAST(N'2022-10-13T11:46:31.500' AS DateTime), 2, N'Se dió de alta la reserva', 54437)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (12, 4, 4, CAST(N'2022-10-13' AS Date), N'12:00', N'Tarjeta', 7500, 8000, 500, CAST(N'2022-10-13T11:46:36.103' AS DateTime), 2, N'Se dió de baja la reserva', 54275)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (13, 4, 4, CAST(N'2022-10-13' AS Date), N'17:00', N'Tarjeta', 7500, 8000, 500, CAST(N'2022-10-13T11:46:41.750' AS DateTime), 2, N'Se realizaron modificaciones en la reserva', 111839)
INSERT [dbo].[ControlReserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [Fecha_Modificacion], [Id_Usuario], [Descripcion], [DVH]) VALUES (14, 4, 4, CAST(N'2022-10-13' AS Date), N'23:00', N'Tarjeta', 7500, 8500, 500, CAST(N'2022-10-13T11:46:48.250' AS DateTime), 2, N'Se realizaron modificaciones en la reserva', 111977)
SET IDENTITY_INSERT [dbo].[ControlReserva] OFF
GO
SET IDENTITY_INSERT [dbo].[DigitoVerificador] ON 

INSERT [dbo].[DigitoVerificador] ([Id_Tabla], [Nombre_Tabla], [DV]) VALUES (1, N'Usuarios', 1095970)
INSERT [dbo].[DigitoVerificador] ([Id_Tabla], [Nombre_Tabla], [DV]) VALUES (2, N'Bitacora', 9646131)
INSERT [dbo].[DigitoVerificador] ([Id_Tabla], [Nombre_Tabla], [DV]) VALUES (4, N'Reserva', 119237)
INSERT [dbo].[DigitoVerificador] ([Id_Tabla], [Nombre_Tabla], [DV]) VALUES (6, N'ControlReserva', 1156961)
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
INSERT [dbo].[Etiqueta] ([Id], [Nombre]) VALUES (85, N'menu_Control_Reserva')
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
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1015, N'Recalcular_DV', N'Recalcular_DV')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1016, N'Bitacora', N'Bitacora')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1017, N'Backup', N'Backup')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1018, N'Restore', N'Restore')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1019, N'Roles', N'Roles')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1020, N'Seguridad_Usuarios', N'Seguridad_Usuarios')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1022, N'Empleado', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1024, N'Control_Reserva', N'Control_Reserva')
SET IDENTITY_INSERT [dbo].[Permiso] OFF
GO
SET IDENTITY_INSERT [dbo].[Reserva] ON 

INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [DVH]) VALUES (14, 1, 3, CAST(N'2022-09-22' AS Date), N'20:00', N'Efectivo', 4000, 4000, 0, 14335)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [DVH]) VALUES (1016, 2, 1, CAST(N'2022-09-22' AS Date), N'19:00', N'Efectivo', 4000, 6500, 2500, 15162)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [DVH]) VALUES (1017, 4, 1, CAST(N'2022-09-19' AS Date), N'19:00', N'Efectivo', 8500, 8500, 0, 14753)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [DVH]) VALUES (1019, 4, 4, CAST(N'2022-09-19' AS Date), N'20:00', N'Efectivo', 8500, 8500, 0, 14747)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [DVH]) VALUES (1024, 3, 3, CAST(N'2022-09-28' AS Date), N'12:00', N'Tarjeta', 2000, 3000, 1000, 14160)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [DVH]) VALUES (1025, 1, 1, CAST(N'2022-10-12' AS Date), N'23:00', N'Efectivo', 4000, 4000, 0, 15581)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [DVH]) VALUES (1026, 3, 3, CAST(N'2022-10-14' AS Date), N'17:00', N'Efectivo', 3000, 3000, 0, 15598)
INSERT [dbo].[Reserva] ([Id], [Id_Cancha], [Id_Cliente], [Fecha], [Hora], [Forma_Pago], [Seña], [Total], [Deuda], [DVH]) VALUES (1028, 4, 4, CAST(N'2022-10-13' AS Date), N'23:00', N'Tarjeta', 7500, 8500, 500, 14901)
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
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (179, 1, 85, N'Control de cambios de reserva')
INSERT [dbo].[Traduccion] ([Id], [IdiomaId], [EtiquetaId], [Traduccion]) VALUES (180, 2, 85, N'Control of reservation changes')
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
SET IDENTITY_INSERT [dbo].[Traduccion] OFF
GO
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PatenteId]) VALUES (2, 1)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PatenteId]) VALUES (4, 1022)
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Nombre], [Apellido], [Nombre_Usuario], [Contraseña], [Puesto], [Dni], [Sexo], [Mail], [Telefono], [Tipo], [Estado], [DVH]) VALUES (2, N'qO5+kqBvJk0VglIuQENyAA==', N'FpIlz41KyvtcmpjBB/UvpA==', N'bhs9QjaREqSMQPPzGSDEmA==', N'7B93BC9E19F7023489BB784CC364D67B', N'Administrador', 39810500, N'Masculino', N'ramiro.itokazu@gmail.com', 1158174329, N'Celular', 0, 157409)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Apellido], [Nombre_Usuario], [Contraseña], [Puesto], [Dni], [Sexo], [Mail], [Telefono], [Tipo], [Estado], [DVH]) VALUES (4, N'CnW9f+n8a242EZqhG4JIqg==', N'0EV76yHF70vIQzI99vgq7w==', N'4bORE05xueyGIk4+ruMfyg==', N'73188D55AFC05B6389BDBEA6A55A9F4B', N'Administrador', 38462154, N'Femenino', N'micaela@gmail.com', 467812341, N'Fijo', 0, 139800)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Apellido], [Nombre_Usuario], [Contraseña], [Puesto], [Dni], [Sexo], [Mail], [Telefono], [Tipo], [Estado], [DVH]) VALUES (1004, N'7yfAI+fmL4UwZKZYx/zY5Q==', N'lmIUUaC0bq0ve5f0sIvsBA==', N'nFTHUmtIfJmHHQwCbB62Nw==', N'202CB962AC59075B964B07152D234B70', N'Empleado', 123123, N'Masculino', N'rober@gmaiil.com', 2134234, N'Celular', 0, 129961)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Apellido], [Nombre_Usuario], [Contraseña], [Puesto], [Dni], [Sexo], [Mail], [Telefono], [Tipo], [Estado], [DVH]) VALUES (1006, N'Vi07r+B6CowP8KrHDDAksw==', N'l/X97UzEyqkhO9WCCSv5zA==', N'SzR3BkQtiERfPMxfkq71Qw==', N'4C37DBFAE76A9A48544D7248127D2D29', N'empleado', 2134234, N'Masculino', N'julian@gmail.com', 21421312, N'Celular', 0, 133416)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Apellido], [Nombre_Usuario], [Contraseña], [Puesto], [Dni], [Sexo], [Mail], [Telefono], [Tipo], [Estado], [DVH]) VALUES (1007, N'cvJTsFQt9NjVwQ0Qf5T3sg==', N'FpIlz41KyvtcmpjBB/UvpA==', N'YQFFfC5+TlPMmqbu3PLByA==', N'12B41C761B41698D39EF68FDD9429578', N'empleado', 234234, N'Masculino', N'emi@gmail.com', 346465, N'Celular', 0, 128288)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Apellido], [Nombre_Usuario], [Contraseña], [Puesto], [Dni], [Sexo], [Mail], [Telefono], [Tipo], [Estado], [DVH]) VALUES (1008, N'brhXDbtqO/6RbeaPPcAYHw==', N'IyqT4Xj21XG8KHLb7YifmA==', N'brhXDbtqO/6RbeaPPcAYHw==', N'DF2139F66DE839C4D8B6F605B7A99E20', N'empleado', 5464564, N'Masculino', N'jkalskdka', 3453253, N'Celular', 0, 123998)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Apellido], [Nombre_Usuario], [Contraseña], [Puesto], [Dni], [Sexo], [Mail], [Telefono], [Tipo], [Estado], [DVH]) VALUES (1009, N'qlWzu3qz0Obt+Mundtru5g==', N'FpIlz41KyvtcmpjBB/UvpA==', N'fC6j8EahvQ/W50vlHBQUeQ==', N'47AEC5568CC7D8FAA39915F3EEEF3D10', N'Administrador', 394584, N'Masculino', N'leku@gmail.com', 934085, N'Celular', 0, 138969)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Apellido], [Nombre_Usuario], [Contraseña], [Puesto], [Dni], [Sexo], [Mail], [Telefono], [Tipo], [Estado], [DVH]) VALUES (1010, N'XFQ/StbX5f7C14t9hMQPLw==', N'AQwFLsMaBddLqujJD1tfYw==', N'AQwFLsMaBddLqujJD1tfYw==', N'8816314202D8FD95C8D2A91D829C12FB', N'Administrador', 38546542, N'Masculino', N'kasdjk@olaksd.com', 42424242, N'Celular', 0, 144129)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
USE [master]
GO
ALTER DATABASE [Canchas_2022] SET  READ_WRITE 
GO
