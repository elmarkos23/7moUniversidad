--1 Crear una base de datos llamada NombreApellidoT15
create database MarcoAyalaT15
go
use MarcoAyalaT15
go
--2 Generar el script para la creación de las tablas en la base del punto 1, tomar en cuenta las constraint de primary key y foreign key.
--Creación Tabla Equipo
create table Equipo(
IdEquipo varchar (10) not null,
NomEquipo varchar(50) not null,
FecCreEquipo date ,
EstEquipo bit ,
EmaEquipo varchar(50),
constraint PK_IdEquipo primary key clustered(IdEquipo)
)
go

--Creación Tabla Jugador
create table Jugador(
IdJugador int not null,
IdEquipo varchar(10) not null,
NomJugador varchar(60) not null,
FecNacJugador date not null,
CedJugador varchar(10) not null,
CiuJugador varchar(10),
EstJugador bit,
EmaJugador varchar(50),
constraint PK_IdJugador primary key clustered(IdJugador),
constraint FK_Jugador_Equipo foreign key (IdEquipo) references Equipo(IdEquipo)
)
go
--3 Agregar una columna edad de tipo tinyint.
alter table Jugador
add EdaJugador tinyint;

--4 Realizar una funcion que calcule la edad del jugador de acuerdo a las siguientes condiciones:
--calcular la edad en base a la fecha de nacimiento y la fecha de hoy.
--si la fecha es mayor a la de hoy, deberá calcular como 0.
create function CalcularEdad(@EdaJugador date)
returns int
as
begin
	declare @Edad int
	set @Edad=DATEPART(YEAR,cast(GETDATE() as date)) - DATEPART(YEAR,@EdaJugador)
	if(@Edad<0)
		set @Edad=0;
	
	return @edad
	end 
go

--5 Crear procedimientos para insertar, actualizar y borrar.
--Tabla Equipo
create procedure sp_crud_Equipo
	@Transaccion varchar(20),
	@IdEquipo varchar (10) =null,
	@NomEquipo varchar(50) =null,
	@FecCreEquipo date =null,
	@EstEquipo bit =null,
	@EmaEquipo varchar(50)=null	
as
begin
	if(@Transaccion='INSERTAR')
	begin
	insert into Equipo(IdEquipo,NomEquipo,FecCreEquipo,EstEquipo,EmaEquipo)
	values (@IdEquipo,@NomEquipo,@FecCreEquipo,@EstEquipo,@EmaEquipo)
	end
	if(@Transaccion='ACTUALIZAR')
	begin
		update Equipo set 
			NomEquipo=@NomEquipo,
			FecCreEquipo=@FecCreEquipo,
			EstEquipo=@EstEquipo,
			EmaEquipo=@EmaEquipo
		where IdEquipo=@IdEquipo
	end
	if(@Transaccion='BORRAR')
	begin
		delete from Equipo
		where IdEquipo=@IdEquipo
	end
end
go
--Tabla Jugador
create procedure sp_crud_Jugador
	@Transaccion varchar(20),
	@IdJugador int = null,
	@IdEquipo varchar(10) = null,
	@NomJugador varchar(60) = null,
	@FecNacJugador date = null,
	@CedJugador varchar(10) =null,
	@CiuJugador varchar(10)=null,
	@EstJugador bit = null,
	@EmaJugador varchar(50) = null,
	@EdaJugador tinyint = null
as
begin
	if(@Transaccion='INSERTAR')
	begin
		set @EdaJugador=dbo.CalcularEdad(@FecNacJugador)
		insert into Jugador(IdJugador,IdEquipo,NomJugador,FecNacJugador,CedJugador,CiuJugador,EstJugador,EmaJugador,EdaJugador)
		values (@IdJugador,@IdEquipo,@NomJugador,@FecNacJugador,@CedJugador,@CiuJugador,@EstJugador,@EmaJugador,@EdaJugador)
	end
	if(@Transaccion='ACTUALIZAR')
	begin
		set @EdaJugador=dbo.CalcularEdad(@FecNacJugador)
		update Jugador set 
		NomJugador=@NomJugador,
		FecNacJugador=@FecNacJugador,
		CedJugador=@CedJugador,
		CiuJugador=@CiuJugador,
		EstJugador=@EstJugador,
		EmaJugador=@EmaJugador,
		EdaJugador=@EdaJugador
		where IdJugador=@IdJugador and IdEquipo=@IdEquipo
	end
	if(@Transaccion='BORRAR')
	begin
		delete from Jugador
		where IdJugador = @IdJugador and IdEquipo=@IdEquipo
	end
end
go

--6 Realizar auditoria para la tabla de jugador para la inserción, borrado y actualización.
--Tabla LogJugador
create table LogJugador(
IdJugador int,
IdEquipo varchar(10),
NomJugador varchar(60),
FecNacJugador date,
CedJugador varchar(10),
CiuJugador varchar(10),
EstJugador bit,
EmaJugador varchar(50),
EdaJugador tinyint,
FechaRegistro datetime NULL,
UsuarioBaseDatos varchar(80) NULL,
Host varchar(80) NULL,
Transaccion char(1) NULL
)
go
--7 Tomar en cuenta los datos del fecha, usuario, host o ubicación de donde realizo el cambio, el tipo de transacción para la tabla de log o auditoria.
IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_insert_Jugador]'))
	DROP TRIGGER [tr_insert_Jugador]
GO
CREATE TRIGGER tr_insert_Jugador
ON Jugador
AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO LogJugador(IdJugador,IdEquipo,NomJugador,FecNacJugador,CedJugador,CiuJugador,EstJugador,EdaJugador,EmaJugador, FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	SELECT IdJugador,IdEquipo,NomJugador,FecNacJugador,CedJugador,CiuJugador,EstJugador,EdaJugador,EmaJugador,GETDATE(), SUSER_NAME(), HOST_NAME(),'I' FROM inserted
END
GO


IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_delete_Jugador]'))
	DROP TRIGGER [tr_delete_Jugador]
GO
CREATE TRIGGER tr_delete_Jugador
ON Jugador
AFTER DELETE
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO LogJugador(IdJugador,IdEquipo,NomJugador,FecNacJugador,CedJugador,CiuJugador,EstJugador,EdaJugador,EmaJugador, FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	SELECT IdJugador,IdEquipo,NomJugador,FecNacJugador,CedJugador,CiuJugador,EstJugador,EdaJugador,EmaJugador,GETDATE(), SUSER_NAME(), HOST_NAME(),'D' FROM deleted
END
GO

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_update_Jugador]'))
	DROP TRIGGER [tr_update_Jugador]
GO
CREATE TRIGGER tr_update_Jugador
ON Jugador
AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO LogJugador(IdJugador,IdEquipo,NomJugador,FecNacJugador,CedJugador,CiuJugador,EstJugador,EdaJugador,EmaJugador, FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	SELECT IdJugador,IdEquipo,NomJugador,FecNacJugador,CedJugador,CiuJugador,EstJugador,EdaJugador,EmaJugador,GETDATE(), SUSER_NAME(), HOST_NAME(),'U' FROM deleted
END
GO
--8 insertar por lo menos un valor cada tabla y verificar los resultados.
exec dbo.sp_crud_Equipo @Transaccion='INSERTAR',@IdEquipo='E001',@NomEquipo='LIGA',@FecCreEquipo='1922-01-23',@EstEquipo=1,@EmaEquipo='info.liga@gmail.com'
exec dbo.sp_crud_Equipo @Transaccion='INSERTAR',@IdEquipo='E002',@NomEquipo='AUCAS',@FecCreEquipo='1922-01-23',@EstEquipo=0,@EmaEquipo='info.aucas@gmail.com'
exec dbo.sp_crud_Equipo @Transaccion='INSERTAR',@IdEquipo='E003',@NomEquipo='INDEPENDIENTE',@FecCreEquipo='1922-01-23',@EstEquipo=1,@EmaEquipo='info.independiente@gmail.com'
go
exec dbo.sp_crud_Equipo @Transaccion='ACTUALIZAR',@IdEquipo='E002',@NomEquipo='AUCAS',@FecCreEquipo='1945-09-12',@EstEquipo=1,@EmaEquipo='info.aucas@gmail.com'
go
exec dbo.sp_crud_Equipo @Transaccion='BORRAR',@IdEquipo='E003'
go
select * from Equipo

exec sp_crud_Jugador @Transaccion = N'INSERTAR',@IdJugador = 5000,@IdEquipo = N'E001',@NomJugador = N'MARCO AYALA',@FecNacJugador = '19900323',@CedJugador = N'1721481586',@CiuJugador = N'QUITO',@EstJugador = 1,@EmaJugador = N'elmarkos23@gmail.com',@EdaJugador = 0
exec sp_crud_Jugador @Transaccion = N'INSERTAR',@IdJugador = 5001,@IdEquipo = N'E002',@NomJugador = N'FRANKLIN SALAS',@FecNacJugador = '19830120',@CedJugador = N'1706067426',@CiuJugador = N'IBARRA',@EstJugador = 0,@EmaJugador = N'fra.salas@gmail.com',@EdaJugador = 0
go
exec sp_crud_Jugador @Transaccion = N'ACTUALIZAR',@IdJugador = 5001,@IdEquipo = N'E002',@NomJugador = N'PATRICIO MARMOL',@FecNacJugador = '19921121',@CedJugador = N'1719343030',@CiuJugador = N'IBARRA',@EstJugador = 1,@EmaJugador = N'fra.salas@gmail.com',@EdaJugador = 0
go
exec sp_crud_Jugador @Transaccion = N'BORRAR',@IdJugador = 5001,@IdEquipo = N'E002'
go
select * from Jugador
go
select * from LogJugador
go

