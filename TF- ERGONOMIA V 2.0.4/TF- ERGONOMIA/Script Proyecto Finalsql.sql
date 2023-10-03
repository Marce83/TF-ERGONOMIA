create database ProyectoFinal
go
use ProyectoFinal
go
Create table Usuarios(
IdUsuario int NOT NULL Primary Key identity(1,1),
Usuario nvarchar(15) NOT NULL unique,
Clave nvarchar(10) NOT NULL,
Nombre nvarchar(20),
Apellido nvarchar(20),
Cargo NVARCHAR(20),
Correo NVARCHAR(30))
GO

use ProyectoFinal
go
Create TABLE Empresas(
IdEmpresa INT NOT NULL Primary Key identity(1,1), 
CUIT nvarchar(11), 
Nombre nvarchar(30),
Condicion_Fiscal nvarchar(30),
Actividad_Empresarial nvarchar(30),
Direccion nvarchar(20),
Localidad nvarchar(20),
Provincia nvarchar(20),
Telefono nvarchar(10),
Correo nvarchar(30),
Web nvarchar(30))
GO

--CREATE TABLE PuestoDeTrabajo(
--IdPuesto INT NOT NULL PRIMARY KEY IDENTITY(1,1),
--Nombre NVARCHAR(20),
--Departamento NVARCHAR(20),
--Ubicacion NVARCHAR(20),
--Horas INT,
--IdEmpresa INT)
--GO

CREATE TABLE Empleados(
IdEmpleado INT NOT NULL PRIMARY KEY IDENTITY (1,1),
Nombre NVARCHAR(20),
Apellido NVARCHAR(20),
DNI nvarchar(8),
Genero NVARCHAR(20),
PuestoDeTrabajo NVARCHAR(20),
Peso FLOAT,
Altura FLOAT,
FechaNacimiento DATE,
FechaIngreso DATE,
FechaEgreso DATE,
IdEmpresa INT NOT NULL)
GO 

--RELACIONES
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Empresas] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresas] ([IdEmpresa])
GO

ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Empresas]
GO


insert into Usuarios values ('MLEON','Abc123','Marco','Leon','Administrador','marcodarioleon@hotmail.com')

go

CREATE PROCEDURE SP_Login
@Usuario nvarchar(15),
@Clave nvarchar(10)
AS
BEGIN
	select * from Usuarios
	where Usuario = @Usuario
	and Clave = @Clave
END
GO

CREATE PROCEDURE SP_ExisteUsr
@Usuario NVARCHAR(15)
AS
BEGIN
SELECT COUNT(*) FROM Usuarios
WHERE Usuario LIKE @Usuario
END
GO

CREATE PROCEDURE SP_ExisteCorreo
@Correo NVARCHAR(20)
AS
BEGIN
SELECT COUNT(*) FROM Usuarios
WHERE Correo LIKE @Correo
END
GO

CREATE OR ALTER PROCEDURE SP_makeLogin
@Usuario nvarchar(15),
@Clave nvarchar(10),
@Nombre nvarchar(20),
@Apellido nvarchar(20),
@Cargo NVARCHAR(20),
@Correo NVARCHAR(30)
AS
BEGIN
	insert into Usuarios (Usuario, Clave, Nombre, Apellido, Cargo, Correo) values(@Usuario,@Clave,@Nombre,@Apellido,@Cargo,@Correo)
END
GO

use ProyectoFinal
go
CREATE OR ALTER PROCEDURE SP_Empresas_Insert
@CUIT nvarchar(11),
@Nombre nvarchar(30),
@Condicion_Fiscal nvarchar(30),
@Actividad_Empresarial nvarchar(30),
@Direccion nvarchar(20),
@Localidad nvarchar(20),
@Provincia nvarchar(20),
@Telefono nvarchar(10),
@Correo nvarchar(30),
@Web nvarchar(30)
AS
BEGIN
	insert into Empresas (CUIT, Nombre, Condicion_Fiscal,Actividad_Empresarial, Direccion,Localidad, Provincia, Telefono, Correo, Web) 
	VALUES(@CUIT,@Nombre,@Condicion_Fiscal,@Actividad_Empresarial,@Direccion,@Localidad,@Provincia,@Telefono,@Correo,@Web)
END
GO

use ProyectoFinal
go

CREATE OR ALTER PROCEDURE SP_Empresas_Update
@CUIT nvarchar(11),
@Nombre nvarchar(30),
@Condicion_Fiscal nvarchar(30),
@Actividad_Empresarial nvarchar(30),
@Direccion nvarchar(20),
@Localidad nvarchar(20),
@Provincia nvarchar(20),
@Telefono nvarchar(10),
@Correo nvarchar(30),
@Web nvarchar(30)
AS
BEGIN
	update Empresas set CUIT=@CUIT, Nombre=@Nombre, Condicion_Fiscal=@Condicion_Fiscal ,Actividad_Empresarial=@Actividad_Empresarial , Direccion=@Direccion, Localidad=@Localidad, Provincia=@Provincia, Telefono=@Telefono, Correo=@Correo, Web=@Web
	where CUIT=@CUIT
END
GO

CREATE PROCEDURE SP_Empresas_Delete
	@CUIT nvarchar(11)
AS
BEGIN

	SET NOCOUNT ON;

	DELETE FROM Empresas WHERE CUIT = @CUIT
END
GO


use ProyectoFinal
go

CREATE OR ALTER PROCEDURE SP_Empresas_GetAll
AS
BEGIN
	SELECT CUIT, Nombre, Condicion_Fiscal 'Condicion Fiscal', Actividad_Empresarial 'Actividad Empresarial', Direccion, Localidad, Provincia, Telefono, Correo, Web
	FROM Empresas
END
GO

use ProyectoFinal
go
CREATE OR ALTER PROCEDURE SP_Empresas_GetId
@CUIT nvarchar(11)
AS
BEGIN
	SELECT CUIT, Nombre, Condicion_Fiscal 'Condicion Fiscal', Actividad_Empresarial 'Actividad Empresarial', Direccion, Localidad, Provincia, Telefono, Correo, Web 
	FROM Empresas
	WHERE CUIT = @CUIT
END
GO

CREATE PROCEDURE SP_Empresas_Solo_GetId
@CUIT NVARCHAR(11)
AS
BEGIN
	SELECT IdEmpresa FROM Empresas
	WHERE CUIT = @CUIT
END
GO
use ProyectoFinal
go
CREATE OR ALTER PROCEDURE SP_Empleados_GetAll
AS
BEGIN

	SELECT Nombre, Apellido, DNI, Genero,Peso,PuestoDeTrabajo, Altura, FechaNacimiento 'Fecha de Nacimiento', FechaIngreso 'Fecha de Ingreso', FechaEgreso 'Fecha de Egreso' 
	FROM Empleados
	WHERE FechaEgreso IS NULL
END
GO
use ProyectoFinal
go
CREATE OR ALTER PROCEDURE SP_Empleados_Insert
@Nombre NVARCHAR(20),
@Apellido NVARCHAR(20),
@DNI nvarchar(8),
@Genero NVARCHAR(20),
@PuestoDeTrabajo NVARCHAR(20),
@Peso FLOAT,
@Altura FLOAT,
@FechaNacimiento DATE,
@FechaIngreso DATE,
@FechaEgreso DATE,
@IdEmpresa INT
AS
BEGIN
	insert into Empleados (Nombre, Apellido, DNI,Genero,PuestoDeTrabajo,Peso,Altura,FechaNacimiento, FechaIngreso, FechaEgreso,IdEmpresa) 
	VALUES(@Nombre,@Apellido,@DNI,@Genero,@PuestoDeTrabajo,@Peso,@Altura,@FechaNacimiento,@FechaIngreso,@FechaEgreso,@IdEmpresa)
END
GO

use ProyectoFinal
go
CREATE PROCEDURE SP_Empleados_DNI
@DNI nvarchar(8)
AS
BEGIN
	SELECT * FROM Empleados
	WHERE DNI = @DNI
END
GO

use ProyectoFinal
go
CREATE PROCEDURE SP_Empleados_Update
@Nombre nvarchar(20),
@Apellido nvarchar(20),
@DNI nvarchar(8),
@Genero nvarchar(20),
@PuestoDeTrabajo nvarchar(20),
@Peso float,
@Altura float,
@FechaNacimiento DATE,
@FechaIngreso DATE,
@FechaEgreso DATE
AS
BEGIN
	update Empleados set Nombre=@Nombre, Apellido=@Apellido, DNI=@DNI ,Genero=@Genero, PuestoDeTrabajo=@PuestoDeTrabajo, Peso=@Peso, Altura=@Altura, FechaNacimiento=@FechaNacimiento, FechaIngreso = @FechaIngreso, FechaEgreso = @FechaEgreso
	where DNI=@DNI
END
GO

use ProyectoFinal
go
CREATE PROCEDURE SP_Empleados_GetId
@DNI nvarchar(8)
AS
BEGIN
	SELECT Nombre, Apellido, DNI, Genero, PuestoDeTrabajo
	FROM Empleados
	WHERE DNI = @DNI
END
GO


use ProyectoFinal
go
CREATE PROCEDURE SP_Empleados_Puestotrabajo
@DNI nvarchar(8)
AS
BEGIN
	SELECT PuestoDeTrabajo
	FROM Empleados
	WHERE DNI = @DNI
END
GO

use ProyectoFinal
go
CREATE TABLE RulaTablaCompleta(
cargaId INT NOT NULL PRIMARY KEY IDENTITY (1,1),
CUIT nvarchar(11),
PuestoDeTrabajo NVARCHAR(20),
Brazo INT,
Antebrazo INT, 
Muneca INT, 
Giro INT,
Actividadmusculara INT,
Cargafuerzaa INT,
Cuellob INT,
Tronco INT,
Piernas INT,
Actividadmuscularb INT,
Cargafuerzab INT,
)
GO	


use ProyectoFinal
go
CREATE PROCEDURE SP_Rula_Insert
@CUIT nvarchar(11),
@PuestoDeTrabajo NVARCHAR(20)
AS
BEGIN
	insert into RulaTablaCompleta (CUIT,PuestoDeTrabajo) 
	VALUES(@CUIT,@PuestoDeTrabajo)
END
GO


use ProyectoFinal
go
CREATE PROCEDURE SP_Rula_updateRula2
@cargaId Int,
@Actividadmusculara int,
@Cargafuerzaa int,
@Cuellob int
AS
BEGIN
	update RulaTablaCompleta set Actividadmusculara=@Actividadmusculara , Cargafuerzaa  =@Cargafuerzaa , Cuellob = @Cuellob
	where cargaId=@cargaId
END
GO

use ProyectoFinal
go
CREATE PROCEDURE SP_Rula_updateRula3
@cargaId Int,
@Tronco int,
@Piernas int,
@Actividadmuscularb int,
@Cargafuerzab int

AS
BEGIN
	update RulaTablaCompleta set Tronco=@Tronco , Piernas=@Piernas , Actividadmuscularb=@Actividadmuscularb, Cargafuerzab=@Cargafuerzab
	where cargaId=@cargaId
END
GO

use ProyectoFinal
go

CREATE or Alter PROCEDURE SP_Rula_updateRula1
@cargaId Int,
@Brazo int,
@Antebrazo int,
@Muneca  INT,
@Giro INT,
@Actividadmusculara int,
@Cargafuerzaa int,
@Cuellob int,
@Tronco int,
@Piernas int,
@Actividadmuscularb int,
@Cargafuerzab int
AS
BEGIN
	update RulaTablaCompleta set Brazo=@Brazo, Antebrazo=@Antebrazo, Muneca=@Muneca ,Giro=@Giro, Actividadmusculara=@Actividadmusculara , Cargafuerzaa  =@Cargafuerzaa , Cuellob = @Cuellob, Tronco=@Tronco , Piernas=@Piernas , Actividadmuscularb=@Actividadmuscularb, Cargafuerzab=@Cargafuerzab
	where cargaId=@cargaId
END
GO

use ProyectoFinal
go

CREATE PROCEDURE SP_Rula_Resultado
@cargaId int
AS
BEGIN
	select * from RulaTablaCompleta
	where cargaId=@cargaId
END
GO

use ProyectoFinal
go
CREATE OR ALTER PROCEDURE SP_Rula_ResultadoTablaA
@cargaId int
AS 
BEGIn
SELECT rta.Brazo,rta.Antebrazo,rta.Giro,rta.Muneca,rta.Valor FROM rulaTablaA rta
INNER JOIN dbo.RulaTablaCompleta rtc ON rtc.Brazo = rta.Brazo
AND rtc.Antebrazo = rta.Antebrazo
AND	rtc.Muneca = rta.Muneca
AND rtc.Giro = rta.Giro
WHERE rtc.cargaId = @cargaId
END
GO

use ProyectoFinal
go
CREATE OR ALTER PROCEDURE SP_Rula_ResultadoTablaB
@cargaId int
AS 
BEGIn
SELECT rtb.Cuello,rtb.Tronco,rtb.Piernas,rtb.Valor FROM RulaTablaB rtb
INNER JOIN dbo.RulaTablaCompleta rtc ON rtc.Cuellob = rtb.Cuello
AND rtc.Tronco = rtb.Tronco
AND	rtc.Piernas = rtb.Piernas
WHERE rtc.cargaId = @cargaId
END
GO

use ProyectoFinal
go
CREATE OR ALTER PROCEDURE SP_Rula_ResultadoTablaC
@ValorTablaA int,
@ValorTablaB int
AS 
BEGIn
SELECT Valor FROM dbo.RulaTablaC
WHERE  TablaA =@ValorTablaA
and TablaB =@ValorTablaB
END
GO

select*from RulaTablaC




use ProyectoFinal
go
CREATE OR ALTER PROCEDURE SP_RULA_GetAll
AS
BEGIN
	SELECT * FROM RulaTablaCompleta

END
GO

use ProyectoFinal
go
CREATE OR ALTER PROCEDURE SP_RULA_SoloId
@CUIT Nvarchar(11)

AS
BEGIN
	SELECT cargaId, CUIT, PuestoDeTrabajo FROM RulaTablaCompleta
	WHERE CUIT = @CUIT

END
GO

use ProyectoFinal
go
CREATE PROCEDURE SP_Rula_Eliminar
@CUIT nvarchar(11)
AS
BEGIN
	DELETE FROM RulaTablaCompleta WHERE CUIT = @CUIT
END
GO

use ProyectoFinal
go
CREATE PROCEDURE SP_Rula_maxidrulacarga
AS
BEGIN
	select max(cargaId)as cargaId from RulaTablaCompleta
END
GO

CREATE TABLE RulaTablaA(
Brazo INT, 
Antebrazo INT, 
Muneca INT, 
Giro INT, 
Valor INT)
GO
insert into RulaTablaA values (1,1,1,1,1)
insert into RulaTablaA values (1,1,1,2,2)
insert into RulaTablaA values (1,1,2,1,2)
insert into RulaTablaA values (1,1,2,2,2)
insert into RulaTablaA values (1,1,3,1,2)
insert into RulaTablaA values (1,1,3,2,3)
insert into RulaTablaA values (1,1,4,1,3)
insert into RulaTablaA values (1,1,4,2,3)
insert into RulaTablaA values (1,2,1,1,2)
insert into RulaTablaA values (1,2,1,2,2)
insert into RulaTablaA values (1,2,2,1,2)
insert into RulaTablaA values (1,2,2,2,2)
insert into RulaTablaA values (1,2,3,1,3)
insert into RulaTablaA values (1,2,3,2,3)
insert into RulaTablaA values (1,2,4,1,3)
insert into RulaTablaA values (1,2,4,2,3)
insert into RulaTablaA values (1,3,1,1,2)
insert into RulaTablaA values (1,3,1,2,3)
insert into RulaTablaA values (1,3,2,1,3)
insert into RulaTablaA values (1,3,2,2,3)
insert into RulaTablaA values (1,3,3,1,3)
insert into RulaTablaA values (1,3,3,2,3)
insert into RulaTablaA values (1,3,4,1,4)
insert into RulaTablaA values (1,3,4,2,4)
insert into RulaTablaA values (2,1,1,1,2)
insert into RulaTablaA values (2,1,1,2,3)
insert into RulaTablaA values (2,1,2,1,3)
insert into RulaTablaA values (2,1,2,2,3)
insert into RulaTablaA values (2,1,3,1,3)
insert into RulaTablaA values (2,1,3,2,4)
insert into RulaTablaA values (2,1,4,1,4)
insert into RulaTablaA values (2,1,4,2,4)
insert into RulaTablaA values (2,2,1,1,3)
insert into RulaTablaA values (2,2,1,2,3)
insert into RulaTablaA values (2,2,2,1,3)
insert into RulaTablaA values (2,2,2,2,3)
insert into RulaTablaA values (2,2,3,1,3)
insert into RulaTablaA values (2,2,3,2,4)
insert into RulaTablaA values (2,2,4,1,4)
insert into RulaTablaA values (2,2,4,2,4)
insert into RulaTablaA values (2,3,1,1,3)
insert into RulaTablaA values (2,3,1,2,4)
insert into RulaTablaA values (2,3,2,1,4)
insert into RulaTablaA values (2,3,2,2,4)
insert into RulaTablaA values (2,3,3,1,4)
insert into RulaTablaA values (2,3,3,2,4)
insert into RulaTablaA values (2,3,4,1,5)
insert into RulaTablaA values (2,3,4,2,5)
insert into RulaTablaA values (3,1,1,1,3)
insert into RulaTablaA values (3,1,1,2,3)
insert into RulaTablaA values (3,1,2,1,4)
insert into RulaTablaA values (3,1,2,2,4)
insert into RulaTablaA values (3,1,3,1,4)
insert into RulaTablaA values (3,1,3,2,4)
insert into RulaTablaA values (3,1,4,1,5)
insert into RulaTablaA values (3,1,4,2,5)
insert into RulaTablaA values (3,2,1,1,3)
insert into RulaTablaA values (3,2,1,2,4)
insert into RulaTablaA values (3,2,2,1,4)
insert into RulaTablaA values (3,2,2,2,4)
insert into RulaTablaA values (3,2,3,1,4)
insert into RulaTablaA values (3,2,3,2,4)
insert into RulaTablaA values (3,2,4,1,5)
insert into RulaTablaA values (3,2,4,2,5)
insert into RulaTablaA values (3,3,1,1,4)
insert into RulaTablaA values (3,3,1,2,4)
insert into RulaTablaA values (3,3,2,1,4)
insert into RulaTablaA values (3,3,2,2,4)
insert into RulaTablaA values (3,3,3,1,4)
insert into RulaTablaA values (3,3,3,2,5)
insert into RulaTablaA values (3,3,4,1,5)
insert into RulaTablaA values (3,3,4,2,5)
insert into RulaTablaA values (4,1,1,1,4)
insert into RulaTablaA values (4,1,1,2,4)
insert into RulaTablaA values (4,1,2,1,4)
insert into RulaTablaA values (4,1,2,2,4)
insert into RulaTablaA values (4,1,3,1,4)
insert into RulaTablaA values (4,1,3,2,5)
insert into RulaTablaA values (4,1,4,1,5)
insert into RulaTablaA values (4,1,4,2,4)
insert into RulaTablaA values (4,2,1,1,4)
insert into RulaTablaA values (4,2,1,2,4)
insert into RulaTablaA values (4,2,2,1,4)
insert into RulaTablaA values (4,2,2,2,4)
insert into RulaTablaA values (4,2,3,1,4)
insert into RulaTablaA values (4,2,3,2,5)
insert into RulaTablaA values (4,2,4,1,5)
insert into RulaTablaA values (4,2,4,2,5)
insert into RulaTablaA values (4,3,1,1,4)
insert into RulaTablaA values (4,3,1,2,4)
insert into RulaTablaA values (4,3,2,1,4)
insert into RulaTablaA values (4,3,2,2,5)
insert into RulaTablaA values (4,3,3,1,5)
insert into RulaTablaA values (4,3,3,2,5)
insert into RulaTablaA values (4,3,4,1,6)
insert into RulaTablaA values (4,3,4,2,6)
insert into RulaTablaA values (5,1,1,1,5)
insert into RulaTablaA values (5,1,1,2,5)
insert into RulaTablaA values (5,1,2,1,5)
insert into RulaTablaA values (5,1,2,2,5)
insert into RulaTablaA values (5,1,3,1,5)
insert into RulaTablaA values (5,1,3,2,6)
insert into RulaTablaA values (5,1,4,1,6)
insert into RulaTablaA values (5,1,4,2,7)
insert into RulaTablaA values (5,2,1,1,5)
insert into RulaTablaA values (5,2,1,2,6)
insert into RulaTablaA values (5,2,2,1,6)
insert into RulaTablaA values (5,2,2,2,6)
insert into RulaTablaA values (5,2,3,1,6)
insert into RulaTablaA values (5,2,3,2,6)
insert into RulaTablaA values (5,2,4,1,7)
insert into RulaTablaA values (5,2,4,2,7)
insert into RulaTablaA values (5,3,1,1,6)
insert into RulaTablaA values (5,3,1,2,6)
insert into RulaTablaA values (5,3,2,1,6)
insert into RulaTablaA values (5,3,2,2,7)
insert into RulaTablaA values (5,3,3,1,7)
insert into RulaTablaA values (5,3,3,2,7)
insert into RulaTablaA values (5,3,4,1,7)
insert into RulaTablaA values (5,3,4,2,8)
insert into RulaTablaA values (6,1,1,1,7)
insert into RulaTablaA values (6,1,1,2,7)
insert into RulaTablaA values (6,1,2,1,7)
insert into RulaTablaA values (6,1,2,2,7)
insert into RulaTablaA values (6,1,3,1,7)
insert into RulaTablaA values (6,1,3,2,8)
insert into RulaTablaA values (6,1,4,1,8)
insert into RulaTablaA values (6,1,4,2,9)
insert into RulaTablaA values (6,2,1,1,8)
insert into RulaTablaA values (6,2,1,2,8)
insert into RulaTablaA values (6,2,2,1,8)
insert into RulaTablaA values (6,2,2,2,8)
insert into RulaTablaA values (6,2,3,1,8)
insert into RulaTablaA values (6,2,3,2,9)
insert into RulaTablaA values (6,2,4,1,9)
insert into RulaTablaA values (6,2,4,2,9)
insert into RulaTablaA values (6,3,1,1,9)
insert into RulaTablaA values (6,3,1,2,9)
insert into RulaTablaA values (6,3,2,1,9)
insert into RulaTablaA values (6,3,2,2,9)
insert into RulaTablaA values (6,3,3,1,9)
insert into RulaTablaA values (6,3,3,2,9)
insert into RulaTablaA values (6,3,4,1,9)
insert into RulaTablaA values (6,3,4,2,9)
GO

use ProyectoFinal
go
CREATE TABLE RulaTablaB(
Cuello INT,
Tronco INT,
Piernas INT,
Valor INT)
GO	

insert into RulaTablaB values (1,1,1,1)
insert into RulaTablaB values (1,1,2,3)
insert into RulaTablaB values (1,2,1,2)
insert into RulaTablaB values (1,2,2,3)
insert into RulaTablaB values (1,3,1,3)
insert into RulaTablaB values (1,3,2,4)
insert into RulaTablaB values (1,4,1,5)
insert into RulaTablaB values (1,4,2,5)
insert into RulaTablaB values (1,5,1,6)
insert into RulaTablaB values (1,5,2,6)
insert into RulaTablaB values (1,6,1,7)
insert into RulaTablaB values (1,6,2,7)
insert into RulaTablaB values (2,1,1,2)
insert into RulaTablaB values (2,1,2,3)
insert into RulaTablaB values (2,2,1,2)
insert into RulaTablaB values (2,2,2,3)
insert into RulaTablaB values (2,3,1,4)
insert into RulaTablaB values (2,3,2,5)
insert into RulaTablaB values (2,4,1,5)
insert into RulaTablaB values (2,4,2,5)
insert into RulaTablaB values (2,5,1,6)
insert into RulaTablaB values (2,5,2,7)
insert into RulaTablaB values (2,6,1,7)
insert into RulaTablaB values (2,6,2,7)
insert into RulaTablaB values (3,1,1,3)
insert into RulaTablaB values (3,1,2,3)
insert into RulaTablaB values (3,2,1,3)
insert into RulaTablaB values (3,2,2,4)
insert into RulaTablaB values (3,3,1,4)
insert into RulaTablaB values (3,3,2,5)
insert into RulaTablaB values (3,4,1,5)
insert into RulaTablaB values (3,4,2,6)
insert into RulaTablaB values (3,5,1,6)
insert into RulaTablaB values (3,5,2,7)
insert into RulaTablaB values (3,6,1,7)
insert into RulaTablaB values (3,6,2,7)
insert into RulaTablaB values (4,1,1,5)
insert into RulaTablaB values (4,1,2,5)
insert into RulaTablaB values (4,2,1,5)
insert into RulaTablaB values (4,2,2,6)
insert into RulaTablaB values (4,3,1,6)
insert into RulaTablaB values (4,3,2,7)
insert into RulaTablaB values (4,4,1,7)
insert into RulaTablaB values (4,4,2,7)
insert into RulaTablaB values (4,5,1,7)
insert into RulaTablaB values (4,5,2,7)
insert into RulaTablaB values (4,6,1,8)
insert into RulaTablaB values (4,6,2,8)
insert into RulaTablaB values (5,1,1,7)
insert into RulaTablaB values (5,1,2,7)
insert into RulaTablaB values (5,2,1,7)
insert into RulaTablaB values (5,2,2,7)
insert into RulaTablaB values (5,3,1,7)
insert into RulaTablaB values (5,3,2,8)
insert into RulaTablaB values (5,4,1,8)
insert into RulaTablaB values (5,4,2,8)
insert into RulaTablaB values (5,5,1,8)
insert into RulaTablaB values (5,5,2,8)
insert into RulaTablaB values (5,6,1,8)
insert into RulaTablaB values (6,1,1,8)
insert into RulaTablaB values (6,1,2,8)
insert into RulaTablaB values (6,2,1,8)
insert into RulaTablaB values (6,2,2,8)
insert into RulaTablaB values (6,3,1,8)
insert into RulaTablaB values (6,3,2,8)
insert into RulaTablaB values (6,4,1,8)
insert into RulaTablaB values (6,4,2,9)
insert into RulaTablaB values (6,5,1,9)
insert into RulaTablaB values (6,5,2,9)
insert into RulaTablaB values (6,6,1,9)
insert into RulaTablaB values (6,6,2,9)
GO	

use ProyectoFinal
go
CREATE TABLE RulaTablaC(
TablaA INT,
TablaB INT,
Valor INT)
GO	

insert into RulaTablaC values (1,1,1)
insert into RulaTablaC values (1,2,2)
insert into RulaTablaC values (1,3,3)
insert into RulaTablaC values (1,4,3)
insert into RulaTablaC values (1,5,4)
insert into RulaTablaC values (1,6,5)
insert into RulaTablaC values (1,7,5)
insert into RulaTablaC values (2,1,2)
insert into RulaTablaC values (2,2,2)
insert into RulaTablaC values (2,3,3)
insert into RulaTablaC values (2,4,4)
insert into RulaTablaC values (2,5,4)
insert into RulaTablaC values (2,6,5)
insert into RulaTablaC values (2,7,5)
insert into RulaTablaC values (3,1,3)
insert into RulaTablaC values (3,2,3)
insert into RulaTablaC values (3,3,3)
insert into RulaTablaC values (3,4,4)
insert into RulaTablaC values (3,5,4)
insert into RulaTablaC values (3,6,5)
insert into RulaTablaC values (3,7,6)
insert into RulaTablaC values (4,1,3)
insert into RulaTablaC values (4,2,3)
insert into RulaTablaC values (4,3,3)
insert into RulaTablaC values (4,4,4)
insert into RulaTablaC values (4,5,5)
insert into RulaTablaC values (4,6,6)
insert into RulaTablaC values (4,7,6)
insert into RulaTablaC values (5,1,4)
insert into RulaTablaC values (5,2,4)
insert into RulaTablaC values (5,3,4)
insert into RulaTablaC values (5,4,5)
insert into RulaTablaC values (5,5,6)
insert into RulaTablaC values (5,6,7)
insert into RulaTablaC values (5,7,7)
insert into RulaTablaC values (6,1,4)
insert into RulaTablaC values (6,2,4)
insert into RulaTablaC values (6,3,5)
insert into RulaTablaC values (6,4,6)
insert into RulaTablaC values (6,5,6)
insert into RulaTablaC values (6,6,7)
insert into RulaTablaC values (6,7,7)
insert into RulaTablaC values (7,1,5)
insert into RulaTablaC values (7,2,5)
insert into RulaTablaC values (7,3,6)
insert into RulaTablaC values (7,4,6)
insert into RulaTablaC values (7,5,7)
insert into RulaTablaC values (7,6,7)
insert into RulaTablaC values (7,7,7)
insert into RulaTablaC values (8,1,5)
insert into RulaTablaC values (8,2,5)
insert into RulaTablaC values (8,3,6)
insert into RulaTablaC values (8,4,7)
insert into RulaTablaC values (8,5,7)
insert into RulaTablaC values (8,6,7)
insert into RulaTablaC values (8,7,7)



---------------------------------------REBA TABLA ------------------------------------------------

use ProyectoFinal
go
CREATE TABLE RebaTablaCompleta(
cargaIdReba INT NOT NULL PRIMARY KEY IDENTITY (1,1),
CUITReba nvarchar(11),
PuestoDeTrabajoReba NVARCHAR(20),
DniEmpleadoReba nvarchar(11),
EmpleadoReba nvarchar(30),
EmpresaReba nvarchar(30),
TroncoReba INT,
CuelloReba INT,
PiernaReba INT,
CargaFuerzaAReba INT,
AntebrazoReba INT,
MunecaReba INT,
BrazoReba INT,
AgarreReba INT,
ActividadReba INT)
GO	

use ProyectoFinal
go
CREATE or Alter PROCEDURE SP_Reba_Insert
@CUITReba nvarchar(11),
@PuestoDeTrabajoReba NVARCHAR(20),
@DniEmpleadoReba nvarchar(11),
@EmpleadoReba NVARCHAR(30),
@EmpresaReba nvarchar(30)
AS
BEGIN
	insert into RebaTablaCompleta (CUITReba,PuestoDeTrabajoReba,DniEmpleadoReba,EmpleadoReba,EmpresaReba) 
	VALUES(@CUITReba,@PuestoDeTrabajoReba,@DniEmpleadoReba,@EmpleadoReba,@EmpresaReba)
END
GO

use ProyectoFinal
go
CREATE or Alter PROCEDURE SP_Reba_MaxID
AS
BEGIN
	select max(cargaIdReba)as cargaIdReba from RebaTablaCompleta
END
GO

use ProyectoFinal
go
CREATE or Alter PROCEDURE SP_Reba_updateReba1
@cargaIdReba Int,
@TroncoReba int,
@CuelloReba int,
@PiernaReba  int,
@CargaFuerzaAReba int,
@AntebrazoReba int,
@MunecaReba int,
@BrazoReba int,
@AgarreReba int,
@ActividadReba int
AS
BEGIN
	update RebaTablaCompleta set TroncoReba=@TroncoReba, CuelloReba=@CuelloReba, PiernaReba=@PiernaReba ,CargaFuerzaAReba=@CargaFuerzaAReba, AntebrazoReba=@AntebrazoReba, MunecaReba=@MunecaReba, BrazoReba=@BrazoReba, AgarreReba=@AgarreReba , ActividadReba=@ActividadReba
	where cargaIdReba=@cargaIdReba
END
GO

use ProyectoFinal
go

CREATE or Alter PROCEDURE SP_Reba_Resultado
@cargaIdReba int
AS
BEGIN
	select * from RebaTablaCompleta
	where cargaIdReba=@cargaIdReba
END
GO

use ProyectoFinal
go
CREATE TABLE TablaAReba(
TroncoReba INT, 
CuelloReba INT, 
PiernasReba INT, 
ValorTablaAReba INT)
GO


insert into TablaAReba values (1,1,1,1)
insert into TablaAReba values (2,1,1,2)
insert into TablaAReba values (3,1,1,2)
insert into TablaAReba values (4,1,1,3)
insert into TablaAReba values (5,1,1,4)
insert into TablaAReba values (1,1,2,2)
insert into TablaAReba values (2,1,2,3)
insert into TablaAReba values (3,1,2,4)
insert into TablaAReba values (4,1,2,5)
insert into TablaAReba values (5,1,2,6)
insert into TablaAReba values (1,1,3,3)
insert into TablaAReba values (2,1,3,4)
insert into TablaAReba values (3,1,3,5)
insert into TablaAReba values (4,1,3,6)
insert into TablaAReba values (5,1,3,7)
insert into TablaAReba values (1,1,4,4)
insert into TablaAReba values (2,1,4,5)
insert into TablaAReba values (3,1,4,6)
insert into TablaAReba values (4,1,4,7)
insert into TablaAReba values (5,1,4,8)
insert into TablaAReba values (1,2,1,1)
insert into TablaAReba values (2,2,1,3)
insert into TablaAReba values (3,2,1,4)
insert into TablaAReba values (4,2,1,5)
insert into TablaAReba values (5,2,1,6)
insert into TablaAReba values (1,2,2,2)
insert into TablaAReba values (2,2,2,4)
insert into TablaAReba values (3,2,2,5)
insert into TablaAReba values (4,2,2,6)
insert into TablaAReba values (5,2,2,7)
insert into TablaAReba values (1,2,3,3)
insert into TablaAReba values (2,2,3,5)
insert into TablaAReba values (3,2,3,6)
insert into TablaAReba values (4,2,3,7)
insert into TablaAReba values (5,2,3,8)
insert into TablaAReba values (1,2,4,4)
insert into TablaAReba values (2,2,4,6)
insert into TablaAReba values (3,2,4,7)
insert into TablaAReba values (4,2,4,8)
insert into TablaAReba values (5,2,4,9)
insert into TablaAReba values (1,3,1,3)
insert into TablaAReba values (2,3,1,4)
insert into TablaAReba values (3,3,1,5)
insert into TablaAReba values (4,3,1,6)
insert into TablaAReba values (5,3,1,7)
insert into TablaAReba values (1,3,2,3)
insert into TablaAReba values (2,3,2,5)
insert into TablaAReba values (3,3,2,6)
insert into TablaAReba values (4,3,2,7)
insert into TablaAReba values (5,3,2,8)
insert into TablaAReba values (1,3,3,5)
insert into TablaAReba values (2,3,3,6)
insert into TablaAReba values (3,3,3,7)
insert into TablaAReba values (4,3,3,8)
insert into TablaAReba values (5,3,3,9)
insert into TablaAReba values (1,3,4,6)
insert into TablaAReba values (2,3,4,7)
insert into TablaAReba values (3,3,4,8)
insert into TablaAReba values (4,3,4,9)
insert into TablaAReba values (5,3,4,9)

use ProyectoFinal
go
CREATE OR ALTER PROCEDURE SP_Reba_TablaA
@cargaIdReba int
AS 
BEGIn
SELECT rta.TroncoReba,rta.CuelloReba,rta.PiernasReba,rta.ValorTablaAReba FROM TablaAReba rta
INNER JOIN dbo.RebaTablaCompleta rtc ON rtc.TroncoReba = rta.TroncoReba
AND rtc.CuelloReba = rta.CuelloReba
AND	rtc.PiernaReba = rta.PiernasReba
WHERE rtc.cargaIdReba = @cargaIdReba
END
GO



use ProyectoFinal
go
CREATE TABLE TablabReba(
BRAZOReba INT, 
MUNECAReba INT, 
ANTEBRAZOReba INT, 
ValorTablaB INT)
GO

insert into TablaBReba values (1,1,1,1)
insert into TablaBReba values (2,1,1,1)
insert into TablaBReba values (3,1,1,3)
insert into TablaBReba values (4,1,1,4)
insert into TablaBReba values (5,1,1,6)
insert into TablaBReba values (6,1,1,7)
insert into TablaBReba values (1,2,1,2)
insert into TablaBReba values (2,2,1,2)
insert into TablaBReba values (3,2,1,4)
insert into TablaBReba values (4,2,1,5)
insert into TablaBReba values (5,2,1,7)
insert into TablaBReba values (6,2,1,8)
insert into TablaBReba values (1,3,1,2)
insert into TablaBReba values (2,3,1,3)
insert into TablaBReba values (3,3,1,5)
insert into TablaBReba values (4,3,1,5)
insert into TablaBReba values (5,3,1,8)
insert into TablaBReba values (6,3,1,8)
insert into TablaBReba values (1,1,2,1)
insert into TablaBReba values (2,1,2,2)
insert into TablaBReba values (3,1,2,4)
insert into TablaBReba values (4,1,2,5)
insert into TablaBReba values (5,1,2,7)
insert into TablaBReba values (6,1,2,8)
insert into TablaBReba values (1,2,2,2)
insert into TablaBReba values (2,2,2,3)
insert into TablaBReba values (3,2,2,5)
insert into TablaBReba values (4,2,2,6)
insert into TablaBReba values (5,2,2,8)
insert into TablaBReba values (6,2,2,9)
insert into TablaBReba values (1,3,2,3)
insert into TablaBReba values (2,3,2,4)
insert into TablaBReba values (3,3,2,5)
insert into TablaBReba values (4,3,2,7)
insert into TablaBReba values (5,3,2,8)
insert into TablaBReba values (6,3,2,9)

use ProyectoFinal
go
CREATE OR ALTER PROCEDURE SP_Reba_TablaB
@cargaIdReba int
AS 
BEGIn
SELECT rta.BRAZOReba,rta.MUNECAReba,rta.ANTEBRAZOReba,rta.ValorTablaB FROM TablaBReba rta
INNER JOIN dbo.RebaTablaCompleta rtc ON rtc.BRAZOReba = rta.BrazoReba
AND rtc.MunecaReba = rta.MUNECAReba
AND	rtc.AntebrazoReba = rta.ANTEBRAZOReba
WHERE rtc.cargaIdReba = @cargaIdReba
END
GO

use ProyectoFinal
go
CREATE TABLE TablaCReba(
PuntuacionB INT, 
PuntuacionA INT, 
ValorTablaC INT)
GO

insert into TablaCReba values (1,1,1)
insert into TablaCReba values (1,2,1)
insert into TablaCReba values (1,3,2)
insert into TablaCReba values (1,4,3)
insert into TablaCReba values (1,5,4)
insert into TablaCReba values (1,6,6)
insert into TablaCReba values (1,7,7)
insert into TablaCReba values (1,8,8)
insert into TablaCReba values (1,9,9)
insert into TablaCReba values (1,10,10)
insert into TablaCReba values (1,11,11)
insert into TablaCReba values (1,12,12)
insert into TablaCReba values (2,1,1)
insert into TablaCReba values (2,2,2)
insert into TablaCReba values (2,3,3)
insert into TablaCReba values (2,4,4)
insert into TablaCReba values (2,5,4)
insert into TablaCReba values (2,6,6)
insert into TablaCReba values (2,7,7)
insert into TablaCReba values (2,8,8)
insert into TablaCReba values (2,9,9)
insert into TablaCReba values (2,10,10)
insert into TablaCReba values (2,11,11)
insert into TablaCReba values (2,12,12)
insert into TablaCReba values (3,1,1)
insert into TablaCReba values (3,2,2)
insert into TablaCReba values (3,3,3)
insert into TablaCReba values (3,4,4)
insert into TablaCReba values (3,5,4)
insert into TablaCReba values (3,6,6)
insert into TablaCReba values (3,7,7)
insert into TablaCReba values (3,8,8)
insert into TablaCReba values (3,9,9)
insert into TablaCReba values (3,10,10)
insert into TablaCReba values (3,11,11)
insert into TablaCReba values (3,12,12)
insert into TablaCReba values (4,1,2)
insert into TablaCReba values (4,2,3)
insert into TablaCReba values (4,3,3)
insert into TablaCReba values (4,4,4)
insert into TablaCReba values (4,5,5)
insert into TablaCReba values (4,6,7)
insert into TablaCReba values (4,7,8)
insert into TablaCReba values (4,8,9)
insert into TablaCReba values (4,9,10)
insert into TablaCReba values (4,10,11)
insert into TablaCReba values (4,11,11)
insert into TablaCReba values (4,12,12)
insert into TablaCReba values (5,1,3)
insert into TablaCReba values (5,2,4)
insert into TablaCReba values (5,3,4)
insert into TablaCReba values (5,4,5)
insert into TablaCReba values (5,5,6)
insert into TablaCReba values (5,6,8)
insert into TablaCReba values (5,7,9)
insert into TablaCReba values (5,8,10)
insert into TablaCReba values (5,9,10)
insert into TablaCReba values (5,10,11)
insert into TablaCReba values (5,11,12)
insert into TablaCReba values (5,12,12)
insert into TablaCReba values (6,1,3)
insert into TablaCReba values (6,2,4)
insert into TablaCReba values (6,3,5)
insert into TablaCReba values (6,4,6)
insert into TablaCReba values (6,5,7)
insert into TablaCReba values (6,6,8)
insert into TablaCReba values (6,7,9)
insert into TablaCReba values (6,8,10)
insert into TablaCReba values (6,9,10)
insert into TablaCReba values (6,10,11)
insert into TablaCReba values (6,11,12)
insert into TablaCReba values (6,12,12)
insert into TablaCReba values (7,1,4)
insert into TablaCReba values (7,2,5)
insert into TablaCReba values (7,3,6)
insert into TablaCReba values (7,4,7)
insert into TablaCReba values (7,5,8)
insert into TablaCReba values (7,6,9)
insert into TablaCReba values (7,7,9)
insert into TablaCReba values (7,8,10)
insert into TablaCReba values (7,9,11)
insert into TablaCReba values (7,10,11)
insert into TablaCReba values (7,11,12)
insert into TablaCReba values (7,12,12)
insert into TablaCReba values (8,1,5)
insert into TablaCReba values (8,2,6)
insert into TablaCReba values (8,3,7)
insert into TablaCReba values (8,4,8)
insert into TablaCReba values (8,5,8)
insert into TablaCReba values (8,6,9)
insert into TablaCReba values (8,7,10)
insert into TablaCReba values (8,8,10)
insert into TablaCReba values (8,9,11)
insert into TablaCReba values (8,10,12)
insert into TablaCReba values (8,11,12)
insert into TablaCReba values (8,12,12)
insert into TablaCReba values (9,1,6)
insert into TablaCReba values (9,2,6)
insert into TablaCReba values (9,3,7)
insert into TablaCReba values (9,4,8)
insert into TablaCReba values (9,5,9)
insert into TablaCReba values (9,6,10)
insert into TablaCReba values (9,7,10)
insert into TablaCReba values (9,8,10)
insert into TablaCReba values (9,9,11)
insert into TablaCReba values (9,10,12)
insert into TablaCReba values (9,11,12)
insert into TablaCReba values (9,12,12)
insert into TablaCReba values (10,1,7)
insert into TablaCReba values (10,2,7)
insert into TablaCReba values (10,3,8)
insert into TablaCReba values (10,4,9)
insert into TablaCReba values (10,5,9)
insert into TablaCReba values (10,6,10)
insert into TablaCReba values (10,7,11)
insert into TablaCReba values (10,8,11)
insert into TablaCReba values (10,9,12)
insert into TablaCReba values (10,10,12)
insert into TablaCReba values (10,11,12)
insert into TablaCReba values (10,12,12)
insert into TablaCReba values (11,1,7)
insert into TablaCReba values (11,2,7)
insert into TablaCReba values (11,3,8)
insert into TablaCReba values (11,4,9)
insert into TablaCReba values (11,5,9)
insert into TablaCReba values (11,6,10)
insert into TablaCReba values (11,7,11)
insert into TablaCReba values (11,8,11)
insert into TablaCReba values (11,9,12)
insert into TablaCReba values (11,10,12)
insert into TablaCReba values (11,11,12)
insert into TablaCReba values (11,12,12)
insert into TablaCReba values (12,1,7)
insert into TablaCReba values (12,2,8)
insert into TablaCReba values (12,3,8)
insert into TablaCReba values (12,4,9)
insert into TablaCReba values (12,5,9)
insert into TablaCReba values (12,6,10)
insert into TablaCReba values (12,7,11)
insert into TablaCReba values (12,8,11)
insert into TablaCReba values (12,9,12)
insert into TablaCReba values (12,10,12)
insert into TablaCReba values (12,11,12)
insert into TablaCReba values (12,12,12)

use ProyectoFinal
go
CREATE OR ALTER PROCEDURE SP_Reba_TablaC
@ValorA int,
@ValorB int
AS 
BEGIn
SELECT ValorTablaC FROM dbo.TablaCReba
WHERE  PuntuacionA =@ValorA
and PuntuacionB =@ValorB
END
GO


------------------------------------------ Niosh --------------------------------------------------

use ProyectoFinal
go
CREATE TABLE NioshTablaCompleta(
cargaIdNiosh INT NOT NULL PRIMARY KEY IDENTITY (1,1),
CUITNiosh nvarchar(11),
PuestoDeTrabajoNiosh NVARCHAR(20),
DniEmpleadoNiosh nvarchar(11),
EmpleadoNiosh nvarchar(30),
EmpresaNiosh nvarchar(30),
LCNiosh INT,
HMNiosh INT,
VMNiosh INT,
DMNiosh INT,
AMNiosh INT,
FMNiosh INT,
CMRNiosh INT,
Duraciontarea nvarchar(11),
FrecuenciaNiosh INT,
CADNiosh nvarchar(11),
PesoCargaNiosh INT)
GO	

use ProyectoFinal
go
CREATE or Alter PROCEDURE SP_Niosh_Insert
@CUITNiosh nvarchar(11),
@PuestoDeTrabajoNiosh NVARCHAR(20),
@DniEmpleadoNiosh nvarchar(11),
@EmpleadoNiosh nvarchar(30),
@EmpresaNiosh nvarchar(30)
AS
BEGIN
	insert into NioshTablaCompleta (CUITNiosh,PuestoDeTrabajoNiosh,DniEmpleadoNiosh,EmpleadoNiosh,EmpresaNiosh) 
	VALUES(@CUITNiosh,@PuestoDeTrabajoNiosh,@DniEmpleadoNiosh,@EmpleadoNiosh,@EmpresaNiosh)
END
GO

use ProyectoFinal
go
CREATE or Alter PROCEDURE SP_Niosh_MaxID
AS
BEGIN
	select max(cargaIdNiosh)as cargaIdNiosh from NioshTablaCompleta
END
GO

use ProyectoFinal
go
CREATE or Alter PROCEDURE SP_Niosh_updateNiosh1
@cargaIdNiosh Int,
@LCNiosh int,
@HMNiosh int,
@VMNiosh  int,
@DMNiosh int,
@AMNiosh int,
@FMNiosh int,
@CMRNiosh int,
@Duraciontarea int,
@FrecuenciaNiosh INT,
@CADNiosh nvarchar,
@PesoCargaNiosh INT

AS
BEGIN
	update NioshTablaCompleta set LCNiosh=@LCNiosh, HMNiosh=@HMNiosh, VMNiosh=@VMNiosh ,DMNiosh=@DMNiosh, AMNiosh=@AMNiosh, FMNiosh=@FMNiosh, CMRNiosh=@CMRNiosh, Duraciontarea=@Duraciontarea , FrecuenciaNiosh=@FrecuenciaNiosh,CADNiosh=@CADNiosh , PesoCargaNiosh=@PesoCargaNiosh 
	where cargaIdNiosh=@cargaIdNiosh
END
GO




