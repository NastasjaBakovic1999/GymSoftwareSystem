USE [master]
GO
/****** Object:  Database [PSofProjekat]    Script Date: 1/30/2022 4:24:43 PM ******/
CREATE DATABASE [PSofProjekat]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PSofProjekta', FILENAME = N'C:\Users\ASUS\PSofProjekta.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PSofProjekta_log', FILENAME = N'C:\Users\ASUS\PSofProjekta_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PSofProjekat] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PSofProjekat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PSofProjekat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PSofProjekat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PSofProjekat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PSofProjekat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PSofProjekat] SET ARITHABORT OFF 
GO
ALTER DATABASE [PSofProjekat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PSofProjekat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PSofProjekat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PSofProjekat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PSofProjekat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PSofProjekat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PSofProjekat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PSofProjekat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PSofProjekat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PSofProjekat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PSofProjekat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PSofProjekat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PSofProjekat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PSofProjekat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PSofProjekat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PSofProjekat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PSofProjekat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PSofProjekat] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PSofProjekat] SET  MULTI_USER 
GO
ALTER DATABASE [PSofProjekat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PSofProjekat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PSofProjekat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PSofProjekat] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PSofProjekat] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PSofProjekat] SET QUERY_STORE = OFF
GO
USE [PSofProjekat]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [PSofProjekat]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 1/30/2022 4:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[AdministratorId] [int] IDENTITY(1,1) NOT NULL,
	[KorisnickoIme] [varchar](50) NOT NULL,
	[Sifra] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[AdministratorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 1/30/2022 4:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[KorisnikId] [int] IDENTITY(1,1) NOT NULL,
	[JMBG] [varchar](50) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[DatumRodjenja] [date] NOT NULL,
	[Adresa] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED 
(
	[KorisnikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervacija]    Script Date: 1/30/2022 4:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervacija](
	[KorisnikId] [int] NOT NULL,
	[TerminId] [int] NOT NULL,
 CONSTRAINT [PK_Rezervacija] PRIMARY KEY CLUSTERED 
(
	[KorisnikId] ASC,
	[TerminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 1/30/2022 4:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala](
	[SalaId] [int] IDENTITY(1,1) NOT NULL,
	[BrojSale] [varchar](50) NULL,
 CONSTRAINT [PK_Sala] PRIMARY KEY CLUSTERED 
(
	[SalaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Termin]    Script Date: 1/30/2022 4:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Termin](
	[TerminId] [int] IDENTITY(1,1) NOT NULL,
	[Datum] [date] NOT NULL,
	[Vreme] [time](7) NOT NULL,
	[Kapacitet] [int] NOT NULL,
	[UslugaId] [int] NOT NULL,
	[SalaId] [int] NOT NULL,
 CONSTRAINT [PK_Termin] PRIMARY KEY CLUSTERED 
(
	[TerminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trener]    Script Date: 1/30/2022 4:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trener](
	[TrenerId] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Trener] PRIMARY KEY CLUSTERED 
(
	[TrenerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usluga]    Script Date: 1/30/2022 4:24:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usluga](
	[UslugaId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
	[TrenerId] [int] NOT NULL,
 CONSTRAINT [PK_Usluga] PRIMARY KEY CLUSTERED 
(
	[UslugaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrator] ON 

INSERT [dbo].[Administrator] ([AdministratorId], [KorisnickoIme], [Sifra]) VALUES (2, N'Nastasja', N'naca123')
INSERT [dbo].[Administrator] ([AdministratorId], [KorisnickoIme], [Sifra]) VALUES (3, N'Ante', N'ante345')
INSERT [dbo].[Administrator] ([AdministratorId], [KorisnickoIme], [Sifra]) VALUES (4, N'Andrea', N'fiki789')
INSERT [dbo].[Administrator] ([AdministratorId], [KorisnickoIme], [Sifra]) VALUES (5, N'Nadja', N'nale999')
INSERT [dbo].[Administrator] ([AdministratorId], [KorisnickoIme], [Sifra]) VALUES (6, N'Marija', N'maja000')
INSERT [dbo].[Administrator] ([AdministratorId], [KorisnickoIme], [Sifra]) VALUES (7, N'Milos', N'somi666')
INSERT [dbo].[Administrator] ([AdministratorId], [KorisnickoIme], [Sifra]) VALUES (8, N'Luka', N'lule123')
INSERT [dbo].[Administrator] ([AdministratorId], [KorisnickoIme], [Sifra]) VALUES (9, N'Mihailo', N'mica567')
SET IDENTITY_INSERT [dbo].[Administrator] OFF
GO
SET IDENTITY_INSERT [dbo].[Korisnik] ON 

INSERT [dbo].[Korisnik] ([KorisnikId], [JMBG], [Ime], [Prezime], [DatumRodjenja], [Adresa]) VALUES (1, N'0411996787654', N'Stefan', N'Antic', CAST(N'1996-11-04' AS Date), N'Mije Kovacevica 11')
INSERT [dbo].[Korisnik] ([KorisnikId], [JMBG], [Ime], [Prezime], [DatumRodjenja], [Adresa]) VALUES (2, N'0111999090909', N'Nastasja', N'Bakovic', CAST(N'1999-11-01' AS Date), N'Mije Kovacevica 7b')
INSERT [dbo].[Korisnik] ([KorisnikId], [JMBG], [Ime], [Prezime], [DatumRodjenja], [Adresa]) VALUES (3, N'1902999767543', N'Andjela', N'Stefanovic', CAST(N'1999-02-19' AS Date), N'Topolska 18')
INSERT [dbo].[Korisnik] ([KorisnikId], [JMBG], [Ime], [Prezime], [DatumRodjenja], [Adresa]) VALUES (4, N'0101999786543', N'Jovana', N'Jovanovic', CAST(N'1999-01-01' AS Date), N'Mije Kovacevica 17')
INSERT [dbo].[Korisnik] ([KorisnikId], [JMBG], [Ime], [Prezime], [DatumRodjenja], [Adresa]) VALUES (1008, N'1234757355373', N'Mika', N'Mikic', CAST(N'2021-12-29' AS Date), N'Neka')
SET IDENTITY_INSERT [dbo].[Korisnik] OFF
GO
INSERT [dbo].[Rezervacija] ([KorisnikId], [TerminId]) VALUES (1, 1)
INSERT [dbo].[Rezervacija] ([KorisnikId], [TerminId]) VALUES (1, 2)
INSERT [dbo].[Rezervacija] ([KorisnikId], [TerminId]) VALUES (1, 7)
INSERT [dbo].[Rezervacija] ([KorisnikId], [TerminId]) VALUES (2, 2)
INSERT [dbo].[Rezervacija] ([KorisnikId], [TerminId]) VALUES (2, 6)
INSERT [dbo].[Rezervacija] ([KorisnikId], [TerminId]) VALUES (2, 8)
INSERT [dbo].[Rezervacija] ([KorisnikId], [TerminId]) VALUES (3, 4)
INSERT [dbo].[Rezervacija] ([KorisnikId], [TerminId]) VALUES (3, 11)
INSERT [dbo].[Rezervacija] ([KorisnikId], [TerminId]) VALUES (4, 3)
INSERT [dbo].[Rezervacija] ([KorisnikId], [TerminId]) VALUES (4, 5)
INSERT [dbo].[Rezervacija] ([KorisnikId], [TerminId]) VALUES (4, 8)
INSERT [dbo].[Rezervacija] ([KorisnikId], [TerminId]) VALUES (1008, 7)
GO
SET IDENTITY_INSERT [dbo].[Sala] ON 

INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (1, N'100')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (2, N'100a')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (3, N'100b')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (4, N'101')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (5, N'102')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (6, N'103')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (7, N'200')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (8, N'201')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (9, N'201a')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (10, N'202')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (11, N'202a')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (12, N'202b')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (13, N'300')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (14, N'301')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (15, N'302')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (16, N'303')
INSERT [dbo].[Sala] ([SalaId], [BrojSale]) VALUES (17, N'304')
SET IDENTITY_INSERT [dbo].[Sala] OFF
GO
SET IDENTITY_INSERT [dbo].[Termin] ON 

INSERT [dbo].[Termin] ([TerminId], [Datum], [Vreme], [Kapacitet], [UslugaId], [SalaId]) VALUES (1, CAST(N'2022-01-02' AS Date), CAST(N'10:00:00' AS Time), 20, 3, 1)
INSERT [dbo].[Termin] ([TerminId], [Datum], [Vreme], [Kapacitet], [UslugaId], [SalaId]) VALUES (2, CAST(N'2022-01-02' AS Date), CAST(N'11:00:00' AS Time), 25, 4, 2)
INSERT [dbo].[Termin] ([TerminId], [Datum], [Vreme], [Kapacitet], [UslugaId], [SalaId]) VALUES (3, CAST(N'2022-01-02' AS Date), CAST(N'18:00:00' AS Time), 40, 8, 3)
INSERT [dbo].[Termin] ([TerminId], [Datum], [Vreme], [Kapacitet], [UslugaId], [SalaId]) VALUES (4, CAST(N'2022-02-02' AS Date), CAST(N'18:00:00' AS Time), 20, 19, 7)
INSERT [dbo].[Termin] ([TerminId], [Datum], [Vreme], [Kapacitet], [UslugaId], [SalaId]) VALUES (5, CAST(N'2022-03-02' AS Date), CAST(N'17:00:00' AS Time), 20, 7, 10)
INSERT [dbo].[Termin] ([TerminId], [Datum], [Vreme], [Kapacitet], [UslugaId], [SalaId]) VALUES (6, CAST(N'2022-04-02' AS Date), CAST(N'10:00:00' AS Time), 20, 9, 7)
INSERT [dbo].[Termin] ([TerminId], [Datum], [Vreme], [Kapacitet], [UslugaId], [SalaId]) VALUES (7, CAST(N'2022-01-02' AS Date), CAST(N'10:00:00' AS Time), 20, 3, 1)
INSERT [dbo].[Termin] ([TerminId], [Datum], [Vreme], [Kapacitet], [UslugaId], [SalaId]) VALUES (8, CAST(N'2022-01-02' AS Date), CAST(N'10:00:00' AS Time), 20, 13, 1)
INSERT [dbo].[Termin] ([TerminId], [Datum], [Vreme], [Kapacitet], [UslugaId], [SalaId]) VALUES (9, CAST(N'2022-01-02' AS Date), CAST(N'10:00:00' AS Time), 30, 14, 2)
INSERT [dbo].[Termin] ([TerminId], [Datum], [Vreme], [Kapacitet], [UslugaId], [SalaId]) VALUES (10, CAST(N'2022-10-02' AS Date), CAST(N'10:00:00' AS Time), 20, 3, 1)
INSERT [dbo].[Termin] ([TerminId], [Datum], [Vreme], [Kapacitet], [UslugaId], [SalaId]) VALUES (11, CAST(N'2022-02-10' AS Date), CAST(N'10:00:00' AS Time), 20, 13, 1)
INSERT [dbo].[Termin] ([TerminId], [Datum], [Vreme], [Kapacitet], [UslugaId], [SalaId]) VALUES (1003, CAST(N'2022-01-30' AS Date), CAST(N'16:00:00' AS Time), 30, 6, 10)
SET IDENTITY_INSERT [dbo].[Termin] OFF
GO
SET IDENTITY_INSERT [dbo].[Trener] ON 

INSERT [dbo].[Trener] ([TrenerId], [Ime], [Prezime]) VALUES (2, N'Marko', N'Markovic')
INSERT [dbo].[Trener] ([TrenerId], [Ime], [Prezime]) VALUES (3, N'Janko', N'Jankovic')
INSERT [dbo].[Trener] ([TrenerId], [Ime], [Prezime]) VALUES (4, N'Petar', N'Petrovic')
INSERT [dbo].[Trener] ([TrenerId], [Ime], [Prezime]) VALUES (5, N'Zivojin', N'Zikic')
INSERT [dbo].[Trener] ([TrenerId], [Ime], [Prezime]) VALUES (6, N'Milivoje', N'Mikic')
INSERT [dbo].[Trener] ([TrenerId], [Ime], [Prezime]) VALUES (7, N'Srdjan', N'Cmiljanic')
INSERT [dbo].[Trener] ([TrenerId], [Ime], [Prezime]) VALUES (8, N'Anica', N'Boskovic')
INSERT [dbo].[Trener] ([TrenerId], [Ime], [Prezime]) VALUES (9, N'Svetlana', N'Milicevic')
INSERT [dbo].[Trener] ([TrenerId], [Ime], [Prezime]) VALUES (10, N'Milica', N'Bikovic')
INSERT [dbo].[Trener] ([TrenerId], [Ime], [Prezime]) VALUES (11, N'Jovan', N'Grkovic')
INSERT [dbo].[Trener] ([TrenerId], [Ime], [Prezime]) VALUES (12, N'Jelena', N'Djokic')
INSERT [dbo].[Trener] ([TrenerId], [Ime], [Prezime]) VALUES (13, N'Nikolina', N'Velickovic')
SET IDENTITY_INSERT [dbo].[Trener] OFF
GO
SET IDENTITY_INSERT [dbo].[Usluga] ON 

INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (3, N'Glute&Core', 2)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (4, N'Pilates', 3)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (5, N'Salsa', 4)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (6, N'Tone Up', 2)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (7, N'Firestep', 5)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (8, N'Aerobic Classic', 10)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (9, N'Cardio Boxing', 8)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (10, N'Cardio Pilates', 6)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (11, N'Fit Body Training', 5)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (13, N'Power Core ', 7)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (14, N'Power Pilates', 6)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (15, N'Power Pump', 4)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (16, N'Spinn', 11)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (17, N'Step Up', 12)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (18, N'Wake Up Yoga', 7)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (19, N'BadAss', 12)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (20, N'Cardio Combat', 10)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (21, N'Fat Burning', 9)
INSERT [dbo].[Usluga] ([UslugaId], [Naziv], [TrenerId]) VALUES (22, N'CrossFit', 9)
SET IDENTITY_INSERT [dbo].[Usluga] OFF
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Korisnik] FOREIGN KEY([KorisnikId])
REFERENCES [dbo].[Korisnik] ([KorisnikId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Korisnik]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Termin] FOREIGN KEY([TerminId])
REFERENCES [dbo].[Termin] ([TerminId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Termin]
GO
ALTER TABLE [dbo].[Termin]  WITH CHECK ADD  CONSTRAINT [FK_Termin_Sala] FOREIGN KEY([SalaId])
REFERENCES [dbo].[Sala] ([SalaId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Termin] CHECK CONSTRAINT [FK_Termin_Sala]
GO
ALTER TABLE [dbo].[Termin]  WITH CHECK ADD  CONSTRAINT [FK_Termin_Usluga] FOREIGN KEY([UslugaId])
REFERENCES [dbo].[Usluga] ([UslugaId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Termin] CHECK CONSTRAINT [FK_Termin_Usluga]
GO
ALTER TABLE [dbo].[Usluga]  WITH CHECK ADD  CONSTRAINT [FK_Usluga_Trener] FOREIGN KEY([TrenerId])
REFERENCES [dbo].[Trener] ([TrenerId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Usluga] CHECK CONSTRAINT [FK_Usluga_Trener]
GO
USE [master]
GO
ALTER DATABASE [PSofProjekat] SET  READ_WRITE 
GO
