--Autor: Marco Ayala
--Curso: 7mo Ingenieria Sistemas
--Materia: Base de Datos II
-- Paralelo: A

create database Escuela
go
use Escuela
go
create table Estudiante(
IdEstudiante int not null,
Cedula nchar(10) not null,
Nombre varchar(20) not null,
Apellido varchar(20) not null,
FecNacimiento date not null,
Direccion nchar(50),
constraint PK_IdEstudiante primary key clustered(idEstudiante),
);
go
create table Materia(
IdMateria nchar(5)  not null,
Nombre nchar(10)  not null,
Descripcion nchar(10),
Activa bit not null,
constraint PK_Materia primary key clustered(IdMateria)
);
go
create table Notas(
IdNota bigint not null,
IdEstudiante int not null,
IdMateria nchar(5) not null, 
NumNota tinyint not null,
ValNota decimal(5,2) not null,
AsiNota decimal(5,2) not null,
EstNota varchar(15) not null,
constraint PK_Nota primary key clustered(IdNota),
constraint FK_Estudiante foreign key(IdEstudiante) references Estudiante(IdEstudiante),
constraint FK_Materia foreign key(IdMateria) references Materia(IdMateria)
);
go

--Funcion para la Nota

create function ValorNotaCualitativa
(
  @ValNota decimal(5,2),
  @AsiNota decimal(5,2)
)
returns varchar(20) 
as
begin
declare @resultado varchar(50)

	if(@ValNota>=7 AND @AsiNota>=80)
	begin
		set @resultado='Aprobado'
	end
	else if((@ValNota >= 5 AND @ValNota < 7) AND @AsiNota > 80)
	begin
		set @resultado='Suspenso'
	end
	else if(@AsiNota < 80)
	begin
		set @resultado='Reprobado'
	end
	else
	begin
		set @resultado = 'Reprobado'
	end
	return @resultado
end
go
--procedimiento crud para estudiante
create procedure sp_crud_Estudiante
	@Transaccion varchar(20),
	@IdEstudiante int = null,
	@Cedula nchar(10) = null,
	@Nombre varchar(20) = null,
	@Apellido varchar(20) = null,
	@FecNacimiento date = null,
	@Direccion nchar(50) = null
as
begin
	if(@Transaccion='INSERTAR')
	begin
		insert into Estudiante
           (IdEstudiante,Cedula,Nombre,Apellido,FecNacimiento,Direccion)
		values
		   (@IdEstudiante,@Cedula,@Nombre,@Apellido,@FecNacimiento,@Direccion)
	end
	if(@Transaccion='ACTUALIZAR')
	begin
		update Estudiante set
			Cedula = @Cedula,Nombre = @Nombre,Apellido = @Apellido,FecNacimiento = @FecNacimiento,Direccion = @Direccion
		where IdEstudiante = @IdEstudiante
	end
	if(@Transaccion='BORRAR')
	begin
		delete from Estudiante
		where IdEstudiante = @IdEstudiante
	end
end
go
create procedure sp_crud_Materia
	@Transaccion varchar(20),
	@IdMateria nchar(5) =null,
	@Nombre nchar(10) =null,
	@Descripcion nchar(10) = null,
	@Activa bit = null
as
begin
	if(@Transaccion='INSERTAR')
	begin
	insert 
		into Materia (IdMateria,Nombre,Descripcion,Activa)
     values
		(@IdMateria,@Nombre,@Descripcion,@Activa)
	end
	if(@Transaccion='ACTUALIZAR')
	begin
		update Materia set 
		Nombre = @Nombre, Descripcion = @Descripcion, Activa = @Activa
		where IdMateria = @IdMateria
	end
	if(@Transaccion='BORRAR')
	begin
		delete from Materia
		where IdMateria = @IdMateria
	end
end
go
create procedure sp_crud_Notas
	@Transaccion varchar(20),
	@IdNota bigint =null,
	@IdEstudiante int = null,
	@IdMateria nchar(5) = null,
	@NumNota tinyint = null,
	@ValNota decimal(5, 2) = null,
	@AsiNota decimal(5, 2) = null,
	@EstNota varchar(15) = null
as
begin
	if(@Transaccion='INSERTAR')
	begin
	--tomamos la nota cualitativa
	set @EstNota=dbo.ValorNotaCualitativa(@ValNota,@AsiNota)
	--insertamos los datos de notas
	insert 
		into Notas(IdNota,IdEstudiante,IdMateria,NumNota,ValNota,AsiNota,EstNota)
     values
		(@IdNota,@IdEstudiante,@IdMateria,@NumNota,@ValNota,@AsiNota,@EstNota)
	end
	if(@Transaccion='ACTUALIZAR')
	begin
		--tomamos la nota cualitativa
		set @EstNota=dbo.ValorNotaCualitativa(@ValNota,@AsiNota)
		--actualiamos los datos de notas
		update Notas set 
		IdEstudiante=@IdEstudiante,IdMateria=@IdMateria,NumNota=@NumNota,ValNota=@ValNota,AsiNota=@AsiNota,EstNota=@EstNota
		where IdNota = @IdNota
	end
	if(@Transaccion='BORRAR')
	begin
		delete from Notas
		where IdNota = @IdNota
	end
end
go


--tablas log
create table LogEstudiante(
IdEstudiante int not null,
Cedula nchar(10) not null,
Nombre varchar(20) not null,
Apellido varchar(20) not null,
FecNacimiento date not null,
Direccion nchar(50),
FechaRegistro datetime NULL,
UsuarioBaseDatos varchar(80) NULL,
Host varchar(80) NULL,
Transaccion char(1) NULL
);
go
create table LogMateria(
IdMateria nchar(5)  not null,
Nombre nchar(10)  not null,
Descripcion nchar(10),
Activa bit not null,
FechaRegistro datetime NULL,
UsuarioBaseDatos varchar(80) NULL,
Host varchar(80) NULL,
Transaccion char(1) NULL
);
go
create table LogNotas(
IdNota bigint not null,
IdEstudiante int not null,
IdMateria nchar(5) not null, 
NumNota tinyint not null,
ValNota decimal(5,2) not null,
AsiNota decimal(5,2) not null,
EstNota varchar(15) not null,
FechaRegistro datetime NULL,
UsuarioBaseDatos varchar(80) NULL,
Host varchar(80) NULL,
Transaccion char(1) NULL
);

--5. Tomar en cuenta los datos del fecha, usuario, dirección, el tipo de transacción para la tabla de log o auditoria.
--Estudiante

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_insert_Estudiante]'))
	DROP TRIGGER [tr_insert_Estudiante]
GO
CREATE TRIGGER tr_insert_Estudiante
ON Estudiante
AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO LogEstudiante(IdEstudiante,Cedula,Nombre,Apellido,FecNacimiento,Direccion, FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	SELECT IdEstudiante,Cedula,Nombre,Apellido,FecNacimiento,Direccion,GETDATE(), SUSER_NAME(), HOST_NAME(),'I' FROM inserted
END
GO


IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_delete_Estudiante]'))
	DROP TRIGGER [tr_delete_Estudiante]
GO
CREATE TRIGGER tr_delete_Estudiante
ON Estudiante
AFTER DELETE
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO LogEstudiante(IdEstudiante,Cedula,Nombre,Apellido,FecNacimiento,Direccion, FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	SELECT IdEstudiante,Cedula,Nombre,Apellido,FecNacimiento,Direccion,GETDATE(), SUSER_NAME(), HOST_NAME(),'D' FROM deleted
END
GO

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_update_Estudiante]'))
	DROP TRIGGER [tr_update_Estudiante]
GO
CREATE TRIGGER tr_update_Estudiante
ON Estudiante
AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	insert into LogEstudiante(IdEstudiante,Cedula,Nombre,Apellido,FecNacimiento,Direccion, FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	select IdEstudiante,Cedula,Nombre,Apellido,FecNacimiento,Direccion,GETDATE(), SUSER_NAME(), HOST_NAME(),'U' FROM deleted
END
GO

--Materia

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_insert_Materia]'))
	DROP TRIGGER [tr_insert_Materia]
GO
CREATE TRIGGER tr_insert_Materia
ON Materia
AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;
	insert into LogMateria(IdMateria,Nombre,Descripcion,Activa,FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	select IdMateria,Nombre,Descripcion,Activa,GETDATE(), SUSER_NAME(), HOST_NAME(),'I' FROM inserted
END
GO


IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_delete_Materia]'))
	DROP TRIGGER [tr_delete_Materia]
GO
CREATE TRIGGER tr_delete_Materia
ON Materia
AFTER DELETE
AS 
BEGIN
	SET NOCOUNT ON;
	insert into LogMateria(IdMateria,Nombre,Descripcion,Activa,FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	select IdMateria,Nombre,Descripcion,Activa,GETDATE(), SUSER_NAME(), HOST_NAME(),'D' FROM deleted
END
GO

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_update_Materia]'))
	DROP TRIGGER [tr_update_Materia]
GO
CREATE TRIGGER tr_update_Materia
ON Materia
AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	insert into LogMateria(IdMateria,Nombre,Descripcion,Activa,FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	select IdMateria,Nombre,Descripcion,Activa,GETDATE(), SUSER_NAME(), HOST_NAME(),'U' FROM deleted
END
GO

--Notas
IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_insert_Notas]'))
	DROP TRIGGER [tr_insert_Notas]
GO
CREATE TRIGGER tr_insert_Notas
ON Notas
AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;
	insert into LogNotas(IdNota,IdEstudiante,IdMateria,NumNota,ValNota,AsiNota,EstNota,FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	select IdNota,IdEstudiante,IdMateria,NumNota,ValNota,AsiNota,EstNota,GETDATE(), SUSER_NAME(), HOST_NAME(),'I' FROM inserted
END
GO


IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_delete_Notas]'))
	DROP TRIGGER [tr_delete_Notas]
GO
CREATE TRIGGER tr_delete_Notas
ON Notas
AFTER DELETE
AS 
BEGIN
	SET NOCOUNT ON;
	insert into LogNotas(IdNota,IdEstudiante,IdMateria,NumNota,ValNota,AsiNota,EstNota,FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	select IdNota,IdEstudiante,IdMateria,NumNota,ValNota,AsiNota,EstNota,GETDATE(), SUSER_NAME(), HOST_NAME(),'D' FROM deleted
END
GO

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_update_Notas]'))
	DROP TRIGGER [tr_update_Notas]
GO
CREATE TRIGGER tr_update_Notas
ON Notas
AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	insert into LogNotas(IdNota,IdEstudiante,IdMateria,NumNota,ValNota,AsiNota,EstNota,FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	select IdNota,IdEstudiante,IdMateria,NumNota,ValNota,AsiNota,EstNota,GETDATE(), SUSER_NAME(), HOST_NAME(),'U' FROM deleted
END
GO

--insertamos Estudiantes
/*
exec sp_crud_Estudiante @Transaccion = N'INSERTAR', @IdEstudiante = 1, @Cedula = N'1721481586', @Nombre = N'MARCO', @Apellido = N'AYALA', @FecNacimiento = '1990-03-23', @Direccion = N'ZAMBIZA'
exec sp_crud_Estudiante @Transaccion = N'INSERTAR', @IdEstudiante = 2, @Cedula = N'1719343020', @Nombre = N'BELEN', @Apellido = N'NARVAEZ', @FecNacimiento = '1990-02-12', @Direccion = N'NAYON'
exec sp_crud_Estudiante @Transaccion = N'INSERTAR', @IdEstudiante = 3, @Cedula = N'1706067426', @Nombre = N'SALOME', @Apellido = N'CHICAIZA', @FecNacimiento = '1968-11-14', @Direccion = N'CALDERON'
*/
--borramos 1 Estudiante
--exec sp_crud_Estudiante @Transaccion = N'BORRAR', @IdEstudiante = 2

--actualizamos 1 Estudiante
--exec sp_crud_Estudiante @Transaccion = N'ACTUALIZAR', @IdEstudiante = 3, @Cedula = N'1706067426', @Nombre = N'SALOME', @Apellido = N'CHICAIZA', @FecNacimiento = '1968-11-14', @Direccion = N'CALACALI'

--revisamos la tabla y logs de Estudiantes
select * from Estudiante
select * from LogEstudiante
go
--insertamos datos en Materia
/*
exec sp_crud_Materia	@Transaccion = N'INSERTAR', @IdMateria = N'BDD', @Nombre = N'BASE DATOS', @Descripcion = N'NINGUNA', @Activa = 1
exec sp_crud_Materia	@Transaccion = N'INSERTAR', @IdMateria = N'RED', @Nombre = N'REDES', @Descripcion = N'NINGUNA', @Activa = 0
*/

--borrados 1 materia
--exec sp_crud_Materia	@Transaccion = N'BORRAR', @IdMateria = N'RED'
--actualziamos 1 materia
--exec sp_crud_Materia	@Transaccion = N'ACTUALIZAR', @IdMateria = N'BDD', @Nombre = N'BASE DATOS', @Descripcion = N'AREA II', @Activa = 1

select * from Materia
select * from LogMateria

--insertamos tabla Notas
/*
exec sp_crud_Notas @Transaccion = N'INSERTAR', @IdNota = 1, @IdEstudiante = 1, @IdMateria = N'BDD', @NumNota = 1, @ValNota = 8, @AsiNota = 90
exec sp_crud_Notas @Transaccion = N'INSERTAR', @IdNota = 2, @IdEstudiante = 1, @IdMateria = N'BDD', @NumNota = 2, @ValNota = 7, @AsiNota = 40
exec sp_crud_Notas @Transaccion = N'INSERTAR', @IdNota = 3, @IdEstudiante = 1, @IdMateria = N'BDD', @NumNota = 3, @ValNota = 5, @AsiNota = 80
exec sp_crud_Notas @Transaccion = N'INSERTAR', @IdNota = 4, @IdEstudiante = 1, @IdMateria = N'BDD', @NumNota = 4, @ValNota = 6, @AsiNota = 85
*/

--eliminamos 1 nota 
--exec sp_crud_Notas @Transaccion = N'BORRAR', @IdNota = 3

--actualizamos 1 nota
--exec sp_crud_Notas @Transaccion = N'ACTUALIZAR', @IdNota = 2, @IdEstudiante = 1, @IdMateria = N'BDD', @NumNota = 2, @ValNota = 9, @AsiNota = 90

--revisamos los datos de la tabla notas
select * from Notas
select * from LogNotas



