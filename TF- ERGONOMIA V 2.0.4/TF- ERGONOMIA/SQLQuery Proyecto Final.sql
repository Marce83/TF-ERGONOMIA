SELECT * FROM dbo.Usuarios
SELECT * FROM Empresas
SELECT * FROM Empleados

DROP TABLE RulaTablaC

DELETE FROM dbo.Empresas WHERE idEmpresa = 10

SELECT Clave, Usuario, Nombre, Apellido, Cargo, Correo FROM Usuarios

SELECT * FROM dbo.Usuarios WHERE Usuario = @Usuario AND Nombre = @Nombre AND Apellido = @Apellido

UPDATE Usuarios SET Usuario = @Usuario, Clave = @Clave, Nombre = @Nombre, Apellido = @Apellido, Cargo = @Cargo, Correo = @Correo WHERE IdUsuario = @IdUsuario

UPDATE dbo.Empresas 
SET CUIT = 20306358342
WHERE IdEmpresa = 2

UPDATE dbo.Usuarios
SET Cargo = 'Administrador', Correo = 'mazurita83@outlook.com'
WHERE IdUsuario = 1;

DECLARE @cadena VARCHAR(MAX) = 'Cervantes1#'
SELECT LEN(@cadena)

SELECT * FROM Usuarios
WHERE Usuario = 'mzurita'--@Usuario
OR	Correo = 'mazurita83@outlook.com'--@Correo;

insert into Usuarios values ('FBRAIDA','Bac123','Franco','Braida','Usuario','francobraida91@gmail.com')

SELECT COUNT(*) FROM Usuarios
WHERE Correo LIKE 'mazurita83@outlook.com';

UPDATE Usuarios SET Usuario = @Usuario, Clave = @Clave, Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo
WHERE IdUsuario = @IdUsuario

DELETE FROM dbo.Usuarios
WHERE IdUsuario = 5;

SELECT Nombre, Apellido, DNI, Genero, Altura, PuestoDeTrabajo 'Puesto', Peso, Altura, FechaNacimiento 'Fecha de Nacimiento', FechaIngreso 'Fecha de Ingreso'
FROM Empleados

UPDATE dbo.Empleados SET FechaEgreso = NULL, Estado = 'A' WHERE IdEmpleado = 2
UPDATE dbo.Empleados SET IdEmpresa = 9 WHERE IdEmpleado = 3

ALTER TABLE dbo.Empresas
ADD Localidad nvarchar(20), Provincia nvarchar(20);

SELECT * FROM dbo.Empresas

UPDATE dbo.Empresas
SET Provincia = 'Salta', Localidad = 'Capital'
WHERE IdEmpresa = 1;

SELECT * FROM dbo.RulaTablaCompleta

SELECT * FROM rulaTablaA rta
INNER JOIN dbo.RulaTablaCompleta rtc ON rtc.Brazo = rta.Brazo
AND rtc.Antebrazo = rta.Antebrazo
AND	rtc.Muneca = rta.Muneca
AND rtc.Giro = rta.Giro
AND rtc.cargaId = 3

SELECT * FROM dbo.RulaTablaC rtc
INNER JOIN	dbo.RulaTablaA rta ON rta.Valor = rtc.TablaA
INNER JOIN	dbo.RulaTablaB rtb ON rtb.Valor = rtc.TablaB
INNER JOIN dbo.RulaTablaCompleta rto ON rto.Brazo = rta.Brazo
WHERE rto.cargaId = @cargaId

SELECT * FROM dbo.RulaTablaC
WHERE TablaA = 6
AND TablaB = 5

SELECT * FROM dbo.Empresas
WHERE CUIT LIKE '%20%'

	SELECT CUIT, Nombre, Condicion_Fiscal 'Condicion Fiscal', Actividad_Empresarial 'Actividad Empresarial', Direccion, Localidad, Provincia, Telefono, Correo, Web, FechaIngreso 'Fecha de Ingreso', Estado
	FROM Empresas
	WHERE CUIT LIKE '%123%'

		SELECT * FROM Empleados WHERE Nombre LIKE '%joa%' AND Estado = 'A'

SELECT Nombre, Apellido, DNI, Genero, Peso, Altura, FechaNacimiento 'Fecha de Nacimiento', FechaIngreso 'Fecha de Ingreso', Estado 
FROM Empleados 
WHERE Apellido LIKE '%zur%'--'"+"%"+oempl.Apellido+"%"+"'   '"+"%"+oempl.Nombre+"%"+"'
AND Estado = 'A'
SELECT Nombre, Apellido, DNI, Genero, Peso, Altura, FechaNacimiento 'Fecha de Nacimiento', FechaIngreso 'Fecha de Ingreso', Estado 
FROM Empleados WHERE Genero = 'Masculino' AND Estado = 'A'

SELECT COUNT(*) FROM dbo.Empresas
WHERE CUIT = '20306358341'

SELECT COUNT(*) FROM dbo.Empleados
WHERE DNI = '30635839'

	SELECT CUIT, Nombre, Condicion_Fiscal 'Condicion Fiscal', Actividad_Empresarial 'Actividad Empresarial', Tipo, Direccion, Localidad, Provincia, Telefono, Correo, Web
	FROM Empresas
	WHERE CUIT LIKE '%2325%'

SELECT Em.Nombre, Em.Apellido, Em.DNI, Em.Genero, Em.Peso, Em.Altura, Em.FechaNacimiento 'Fecha de Nacimiento', Em.FechaIngreso 'Fecha de Ingreso', Em.Estado, empr.Nombre
FROM dbo.Empleados Em
INNER JOIN dbo.Empresas empr ON empr.IdEmpresa = Em.IdEmpresa 
WHERE Em.FechaEgreso IS NULL
AND Em.Estado = 'A'