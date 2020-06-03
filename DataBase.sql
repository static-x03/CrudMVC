USE [Personas]
GO
/****** Object: Database [dbo].[Personas]
Table [dbo].[Peoples]   
Script Date: 02/06/2020 21:46:29 ******/


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peoples](
	[Id_person] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Peoples] PRIMARY KEY CLUSTERED 
(
	[Id_person] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Peoples] ON 

INSERT [dbo].[Peoples] ([Id_person], [Nombre], [Apellido], [Edad], [Sexo], [Correo]) VALUES (1, N'Janis', N'Bell', 23, N'F', N'janis@gmail.com')
INSERT [dbo].[Peoples] ([Id_person], [Nombre], [Apellido], [Edad], [Sexo], [Correo]) VALUES (2, N'Frank', N'Miles', 19, N'M', N'frank@gmail.com')
INSERT [dbo].[Peoples] ([Id_person], [Nombre], [Apellido], [Edad], [Sexo], [Correo]) VALUES (3, N'Clifton', N'Crawford', 56, N'M', N'clifton@gmail.com')
INSERT [dbo].[Peoples] ([Id_person], [Nombre], [Apellido], [Edad], [Sexo], [Correo]) VALUES (4, N'Cesar', N'Mckinney', 32, N'M', N'cesar@gmail.com')
INSERT [dbo].[Peoples] ([Id_person], [Nombre], [Apellido], [Edad], [Sexo], [Correo]) VALUES (5, N'Lorene', N'Dixon', 78, N'F', N'lorene@gmail.com')
INSERT [dbo].[Peoples] ([Id_person], [Nombre], [Apellido], [Edad], [Sexo], [Correo]) VALUES (6, N'Tommy', N'Pope', 65, N'M', N'tommy@gmail.com')
INSERT [dbo].[Peoples] ([Id_person], [Nombre], [Apellido], [Edad], [Sexo], [Correo]) VALUES (7, N'Rosemary', N'Jackson', 95, N'F', N'rosemary@gmail.com')
INSERT [dbo].[Peoples] ([Id_person], [Nombre], [Apellido], [Edad], [Sexo], [Correo]) VALUES (8, N'Willie', N'Dennis', 21, N'M', N'willie@gmail.com')
INSERT [dbo].[Peoples] ([Id_person], [Nombre], [Apellido], [Edad], [Sexo], [Correo]) VALUES (9, N'Winifred', N'Carrol', 23, N'M', N'winifrid@gmail.com')
INSERT [dbo].[Peoples] ([Id_person], [Nombre], [Apellido], [Edad], [Sexo], [Correo]) VALUES (10, N'Cynthia', N'Perkins', 71, N'F', N'cynthia@gmail.com')
INSERT [dbo].[Peoples] ([Id_person], [Nombre], [Apellido], [Edad], [Sexo], [Correo]) VALUES (11, N'Bryan', N'Vanegas', 27, N'M', N'static-x03@hotmail.com')
SET IDENTITY_INSERT [dbo].[Peoples] OFF
GO
