Use BDClinicaPet
Go
--drop View V_Usuarios_Roles
Create View V_Usuarios_Roles
As
Select Id_Usu,Nombres,Apellidos,Usuario,Contrasena,
Ubicacion_Foto,U.Id_Rol,R.Rol,U.Estado
From Usuarios U, Roles R
Where U.Id_Rol=R.Id_Rol
Go
                
Select * from V_Usuarios_Roles
Go


---------Procedimiento--------------
Create Procedure Sp_Login
@Usuario nvarchar(50),
@Contrasena nvarchar(50)
As
	Select Count(*) from V_Usuarios_Roles
	Where Usuario=@Usuario and Contrasena=@Contrasena
Go

EXECUTE Sp_Login 'imorales','1234'
Go
EXECUTE Sp_Login 'dcampos','1111'
Go


Create Procedure Sp_Usuario_Login(
	@Usuario nvarchar(50)=''
)
As
	Select * from V_Usuarios_Roles
	Where Usuario=@Usuario
Go

Execute Sp_Usuario_Login 'dcampos'
Go