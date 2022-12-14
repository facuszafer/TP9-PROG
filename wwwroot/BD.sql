USE [master]
GO
/****** Object:  Database [TP9]    Script Date: 15/11/2022 10:42:36 ******/
CREATE DATABASE [TP9]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP9', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TP9.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP9_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TP9_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TP9] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP9].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP9] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP9] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP9] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP9] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP9] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP9] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP9] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP9] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP9] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP9] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP9] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP9] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP9] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP9] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP9] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP9] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP9] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP9] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP9] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP9] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP9] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP9] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP9] SET RECOVERY FULL 
GO
ALTER DATABASE [TP9] SET  MULTI_USER 
GO
ALTER DATABASE [TP9] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP9] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP9] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP9] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP9] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP9', N'ON'
GO
ALTER DATABASE [TP9] SET QUERY_STORE = OFF
GO
USE [TP9]
GO
/****** Object:  User [alumno]    Script Date: 15/11/2022 10:42:36 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[marca]    Script Date: 15/11/2022 10:42:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marca](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Logo] [varchar](max) NOT NULL,
	[Foto] [varchar](max) NOT NULL,
 CONSTRAINT [PK_marca] PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ropa]    Script Date: 15/11/2022 10:42:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ropa](
	[IdRopa] [int] IDENTITY(1,1) NOT NULL,
	[IdMarca] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Foto] [varchar](max) NOT NULL,
	[precio] [int] NOT NULL,
	[descripcion] [varchar](500) NOT NULL,
	[cantLikes] [int] NULL,
 CONSTRAINT [PK_ropa] PRIMARY KEY CLUSTERED 
(
	[IdRopa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[marca] ON 

INSERT [dbo].[marca] ([IdMarca], [Nombre], [Logo], [Foto]) VALUES (1, N'balenciaga ', N'https://o.remove.bg/downloads/0480d78e-28d1-4458-ab17-ffab6a5a8574/820a8ed207650cbcfb58bbb7298b6903-removebg-preview.png', N'https://purodiseno.lat/wp-content/uploads/2022/04/BALENCIAGA-LONDRES-6-1024x768.jpg')
INSERT [dbo].[marca] ([IdMarca], [Nombre], [Logo], [Foto]) VALUES (2, N'Louis Vuitton', N'https://o.remove.bg/downloads/fd39636b-90e8-4cae-960e-3e1d7b085291/Louis_Vuitton_Drip-removebg-preview.png', N'https://hilnethcorreia.com.br/wp-content/uploads/2019/07/louis-vuitton-1013_Lv_Now_CandC_Sao_Paulo_Cidade_Jardim_DI3.jpg')
INSERT [dbo].[marca] ([IdMarca], [Nombre], [Logo], [Foto]) VALUES (3, N'Yves Saint Laurent', N'https://o.remove.bg/downloads/715a306c-19f0-4040-971b-cae1b2adb30b/Saint-Laurent-s%C3%ADmbolo-removebg-preview.png', N'https://www.antefixe.fr/media/galerie_photo/galerie-36/CaptureST2.jpg')
INSERT [dbo].[marca] ([IdMarca], [Nombre], [Logo], [Foto]) VALUES (4, N'versacce', N'https://o.remove.bg/downloads/59f63490-622b-4c88-ae3d-86a569683be1/43b4a9630e78f1aa01d1fddfb2bb6e8a-removebg-preview.png', N'https://www.modaes.es/files/000_2016/versace/Versace%20tienda%20exterior%20948.png')
SET IDENTITY_INSERT [dbo].[marca] OFF
GO
SET IDENTITY_INSERT [dbo].[ropa] ON 

INSERT [dbo].[ropa] ([IdRopa], [IdMarca], [Nombre], [Foto], [precio], [descripcion], [cantLikes]) VALUES (1, 1, N'Buzo', N'https://balenciaga.dam.kering.com/m/509d85344d549ec/Large-697971TMVO19800_GR.jpg?v=1', 850, N'Hoodie con Dobladillo Elástico Balenciaga Music Pink Martini Merch Oversized de vellón mediano en blanco roto', 8)
INSERT [dbo].[ropa] ([IdRopa], [IdMarca], [Nombre], [Foto], [precio], [descripcion], [cantLikes]) VALUES (2, 1, N'Remera', N'https://balenciaga.dam.kering.com/m/9c147468ba849c/Large-694576TMVJ61023_D.jpg?v=3', 500, N'Camiseta Strike 1917 Oversized de jersey «vintage» en gris

', 11)
INSERT [dbo].[ropa] ([IdRopa], [IdMarca], [Nombre], [Foto], [precio], [descripcion], [cantLikes]) VALUES (3, 2, N'Anteojos ', N'https://it.louisvuitton.com/images/is/image/louis-vuitton-occhiali-da-sole-cyclone-s00-novit%C3%A0--Z1700U_PM2_Front%20view.png?wid=1080&hei=1080', 625, N'Las gafas de sol Cyclone destacan por su forma cuadrada oversize y su montura fina. El diseño renovado y la estructura ligera revisitan el modelo original de Louis Vuitton del mismo nombre. El accesorio ingeniosamente diseñado celebra los motivos icónicos de la Maison con una flor Monogram de cristal brillante en el puente.
', 0)
INSERT [dbo].[ropa] ([IdRopa], [IdMarca], [Nombre], [Foto], [precio], [descripcion], [cantLikes]) VALUES (4, 2, N'Zapatillas', N'https://it.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-sneaker-lv-trainer-calzature--BO9U2PMI45_PM2_Front%20view.png?wid=2048&hei=2048', 1012, N'La zapatilla LV Trainer destaca por la combinación de piel con el emblemático adorno de la Maison y piel de becerro con el motivo Mini Monogram en relieve. La creación icónica, diseñada por Virgil Abloh, está inspirada en modelos de baloncesto antiguos. La parte superior original, cuya creación lleva siete horas, está adornada con detalles exclusivos y firmas de Louis Vuitton.
', 0)
INSERT [dbo].[ropa] ([IdRopa], [IdMarca], [Nombre], [Foto], [precio], [descripcion], [cantLikes]) VALUES (5, 3, N'Zapatillas', N'https://saint-laurent.dam.kering.com/m/4669b8b2843b0b5b/Medium2-713857AAAXE2039_D.jpg?v=1', 1000, N'SNEAKERS DE MEDIA CAÑA CON CORDONES, ADORNADAS CON FIRMA SAINT LAURENT DE COLOR DORADO EN EL LATERAL E INSCRIPCIÓN SAINT LAURENT PARIS DEL MISMO COLOR EN LA PARTE TRASERA.', 0)
INSERT [dbo].[ropa] ([IdRopa], [IdMarca], [Nombre], [Foto], [precio], [descripcion], [cantLikes]) VALUES (6, 3, N'Perfume', N'https://image.tfgmedia.co.za/image/1/process/750x750?source=https://cdn.tfgmedia.co.za/00/ProductImages/58958851.jpg', 200, N' La Nariz detrás de esta fragrancia es Dominique Ropion. Las Notas de Salida son manzana, jengibre y bergamota; las Notas de Corazón son salvia, bayas de enebro y geranio; las Notas de Fondo son Amberwood, haba tonka, cedro, vetiver y incienso de olíbano 
', 0)
INSERT [dbo].[ropa] ([IdRopa], [IdMarca], [Nombre], [Foto], [precio], [descripcion], [cantLikes]) VALUES (7, 4, N'Remera ', N'https://www.versace.com/dw/image/v2/ABAO_PRD/on/demandware.static/-/Sites-ver-master-catalog/default/dwa6391c85/original/90_1006067-1A04162_5B040_16_SilverBaroqueLogoShirt-Shirts-versace-online-store_0_0.jpg?sw=748&sh=1050&sm=fit', 1000, N'Esta camisa de algodón de manga corta incluye el estampado Silver Baroque y un sello con logotipo en contraste. El estilo con cierre de botones se completa con un cuello camp y mangas anchas.', 0)
INSERT [dbo].[ropa] ([IdRopa], [IdMarca], [Nombre], [Foto], [precio], [descripcion], [cantLikes]) VALUES (8, 4, N'Chaqueta', N'https://www.versace.com/dw/image/v2/ABAO_PRD/on/demandware.static/-/Sites-ver-master-catalog/default/dwc662af18/original/90_1006018-1A04128_1PF00_16_MedusaJacket-Jackets-versace-online-store_0_0.jpg?sw=748&sh=1050&sm=fit', 2070, N'Esta chaqueta de diseño ligero cuenta con botones Medusa Tribute y dos bolsillos grandes, así como el logotipo de Versace en el pecho.', 0)

SET IDENTITY_INSERT [dbo].[ropa] OFF
GO
USE [master]
GO
ALTER DATABASE [TP9] SET  READ_WRITE 
GO
