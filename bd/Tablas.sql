USE MASTER
GO

--DROP DATABASE BDClinicaPet

CREATE DATABASE BDClinicaPet
GO

USE BDClinicaPet
GO

-- Rol (Funciones o Cargo)
CREATE TABLE [dbo].[Roles] (
	[Id_Rol] [int] NOT NULL,
	[Rol] [nvarchar] (50) NULL,
	[Estado] [bit] NULL
) ON [PRIMARY]
GO

-- Usuarios del Sistema
CREATE TABLE [dbo].[Usuarios] (
    [Id_Usu] [Int] IDENTITY(1,1) NOT NULL,	
	[Nombres] [nvarchar] (50)  NULL ,
	[Apellidos] [nvarchar] (50)  NULL ,
	[Usuario] [nvarchar] (20)  NULL ,
	[Contrasena] [nvarchar] (15)  NULL ,
	[Ubicacion_Foto] [nvarchar] (200) NULL,
	[Id_Rol] [int] NOT NULL,
	[Estado] [bit] NULL 
) ON [PRIMARY]
GO

-- Menu Principal del Software
CREATE TABLE [dbo].[SysMenu] (
	[Id_Menu] [Int] NOT NULL ,
	[Nombre_Menu] [Nvarchar] (50)  NULL ,
	[Padre_Id] [Int] NOT NULL,
	[Posicion] [Int],
	[Iconos] [Nvarchar] (20) NULL,
	[Mensaje] [nvarchar] (50) NULL,
	[Habilitado] [Bit]
) ON [PRIMARY]
GO

-- Menu x Roles 
CREATE TABLE [dbo].[Rol_Sys_Menu] (
	[Id_Menu] [Int] NOT NULL ,
	[Id_Rol] [Int] NOT NULL
) ON [PRIMARY]
GO



ALTER TABLE [dbo].[Roles] WITH NOCHECK ADD 
	CONSTRAINT [PK_Roles] PRIMARY KEY  CLUSTERED 
	(
		[Id_Rol]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Usuarios] WITH NOCHECK ADD 
	CONSTRAINT [PK_Usuarios] PRIMARY KEY  CLUSTERED 
	(
		[Id_Usu]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[SysMenu] WITH NOCHECK ADD 
	CONSTRAINT [PK_SysMenu] PRIMARY KEY  CLUSTERED 
	(
		[Id_Menu]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Rol_Sys_Menu] WITH NOCHECK ADD 
	CONSTRAINT [PK_Rol_Sys_Menu] PRIMARY KEY  CLUSTERED 
	(
		[Id_Menu],
		[Id_Rol]
	)  ON [PRIMARY] 
GO
-------------------------------------------------------------
ALTER TABLE [dbo].[Usuarios] ADD 
	CONSTRAINT [FK_Usuarios_Roles] FOREIGN KEY 
	(
		[Id_Rol]
	) REFERENCES [dbo].[Roles] (
		[Id_Rol]
	)
GO

ALTER TABLE [dbo].[Rol_Sys_Menu] ADD 
	CONSTRAINT [FK_Rol_Sys_Menu_Roles] FOREIGN KEY 
	(
		[Id_Rol]
	) REFERENCES [dbo].[Roles] (
		[Id_Rol]
	),
	CONSTRAINT [FK_Rol_Sys_Menu_SysMenu] FOREIGN KEY 
	(
		[Id_Menu]
	) REFERENCES [dbo].[SysMenu] (
		[Id_Menu]
	)
GO

-------------------------------------------------------------
---1
INSERT INTO ROLES(Id_Rol,Rol,Estado)
VALUES(1,'Adm. Sistemas',0)
GO
---2
INSERT INTO ROLES(Id_Rol,Rol,Estado)
VALUES(2,'Med. Veterinario',0)
GO
---3
INSERT INTO ROLES(Id_Rol,Rol,Estado)
VALUES(3,'Recepcionista',0)
GO

SELECT * FROM ROLES
Go
--------------------------------
--------------Tabla usuarios--------------------------
---1
INSERT INTO USUARIOS(Nombres,Apellidos,Usuario,Contrasena,
Ubicacion_Foto,Id_Rol,Estado)
VALUES ('Jorge','Manrique','jmanri','1234',
'D:\Fotos_Usuarios\Jeins.png',1,0)
Go
---2
INSERT INTO USUARIOS(Nombres,Apellidos,Usuario,Contrasena,
Ubicacion_Foto,Id_Rol,Estado)
VALUES ('Diana Luz','Campos Vega','Dcampos','1111',
'D:\Fotos_Usuarios\Marilyn.png',2,0)
Go
---3
INSERT INTO USUARIOS(Nombres,Apellidos,Usuario,Contrasena,
Ubicacion_Foto,Id_Rol,Estado)
VALUES ('Paco','Taype','zaza','2222',
'D:\Fotos_Usuarios\Marilyn.png',3,0)
Go

SELECT * FROM USUARIOS
Go

---------------------------------------------------------------