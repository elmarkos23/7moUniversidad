--1. Crear una base de datos con el nombre NombreApellidoEF.
create database MarcoAyalaEF
go
use MarcoAyalaEF
go
--Generar el script para la creación de base de datos, tomar en cuenta las constraint de primary key y foreign key.
CREATE TABLE Venta
( 
codigoVenta INT IDENTITY NOT NULL, 
cliente nvarchar (100) NULL, 
fecha date NULL
)

CREATE TABLE DetalleVenta
( 
codigoVenta INT NOT NULL, 
codigoProducto nvarchar (100) not NULL, 
cantidad decimal (18,2) NULL,
descuento decimal (18,2) null
)

CREATE TABLE PRODUCTO
( 
codigoProducto nvarchar (100) not NULL, 
nombre nvarchar (100) not NULL,
precio decimal (18,2) not null
)
alter table Venta
add
constraint PK_codigoVenta_Venta primary key clustered(codigoVenta)
go

alter table Producto
add
constraint PK_codigoProducto_Producto primary key clustered(codigoProducto)
go

alter table DetalleVenta
add
constraint PK_codigoVenta_codigoProducto primary key clustered(codigoVenta,codigoProducto),
constraint FK_codigoVenta foreign key(codigoVenta) references Venta(codigoVenta),
constraint FK_codigoProducto foreign key(codigoProducto ) references Producto(codigoProducto)
go

--3. Crear procedimientos para insertar, actualizar y borrar para la tabla de detalleventa.
create procedure sp_crud_DetalleVenta
	@Transaccion varchar(20),
	@codigoVenta int =null,
	@codigoProducto varchar(10)= null,
	@cantidad decimal(18,2)=null,
	@descuento decimal(18,2)=null
as
begin
	if(@Transaccion='INSERTAR')
	begin
	insert into DetalleVenta (codigoVenta, codigoProducto, cantidad, descuento)
	values (@codigoVenta, @codigoProducto, @cantidad, @descuento)
	end
	if(@Transaccion='ACTUALIZAR')
	begin
		update DetalleVenta set 
		cantidad=@cantidad, descuento=@descuento
		where codigoVenta = @codigoVenta and codigoProducto=@codigoProducto
	end
	if(@Transaccion='BORRAR')
	begin
		delete from DetalleVenta
		where codigoVenta = @codigoVenta and codigoProducto=@codigoProducto
	end
end
go


--4. Realizar auditoria para la tabla de detalleventa para la inserción, borrado y actualización.
create table LogDetalleVenta(
codigoVenta int,
codigoProducto varchar(10),
cantidad decimal(18,2),
descuento decimal (18,2),
FechaRegistro datetime NULL,
UsuarioBaseDatos varchar(80) NULL,
Host varchar(80) NULL,
Transaccion char(1) NULL
);

--5. Tomar en cuenta los datos del fecha, usuario, dirección, el tipo de transacción para la tabla de log o auditoria.
IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_insert_DetalleVenta]'))
	DROP TRIGGER [tr_insert_DetalleVenta]
GO
CREATE TRIGGER tr_insert_DetalleVenta
ON DetalleVenta
AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO LogDetalleVenta(codigoVenta,codigoProducto,cantidad,descuento, FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	SELECT codigoVenta,codigoProducto,cantidad,descuento,GETDATE(), SUSER_NAME(), HOST_NAME(),'I' FROM inserted
END
GO


IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_delete_DetalleVenta]'))
	DROP TRIGGER [tr_delete_DetalleVenta]
GO
CREATE TRIGGER tr_delete_DetalleVenta
ON DetalleVenta
AFTER DELETE
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO LogDetalleVenta(codigoVenta,codigoProducto,cantidad,descuento, FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	SELECT codigoVenta,codigoProducto,cantidad,descuento,GETDATE(), SUSER_NAME(), HOST_NAME(),'D' FROM deleted
END
GO

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[tr_update_DetalleVenta]'))
	DROP TRIGGER [tr_update_DetalleVenta]
GO
CREATE TRIGGER tr_update_DetalleVenta
ON DetalleVenta
AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	INSERT INTO LogDetalleVenta(codigoVenta,codigoProducto,cantidad,descuento, FechaRegistro,UsuarioBaseDatos,Host,Transaccion)
	SELECT codigoVenta,codigoProducto,cantidad,descuento,GETDATE(), SUSER_NAME(), HOST_NAME(),'U' FROM deleted
END
GO

--6. se debe subir a la tarea el script con extensión ".sql", y además debe estar comentado el mismo
--Nombre del Archivo es MarcoAyalaEF.sql 
--Los datos a DML estan comentados

--7. insertar por lo menos un valor cada tabla y en la tabla de detalleventa se debe evidenciar las 3 operaciones de CRUD.
--insert into Venta (cliente,fecha) values ('Marco',getdate());
--insert into Venta (cliente,fecha) values ('Belen',getdate());
--insert into Venta (cliente,fecha) values ('Salome',getdate());

--go

--insert into Producto (codigoProducto,nombre,precio) values ('P001','Leche',0.80);
--insert into Producto (codigoProducto,nombre,precio) values ('P002','Carne',2.20);
--insert into Producto (codigoProducto,nombre,precio) values ('P003','Queso',1.50);
--go 

----guardar
--exec sp_crud_DetalleVenta @Transaccion = N'INSERTAR', @codigoVenta = 1, @codigoProducto = 'P002', @cantidad = 9, @descuento=10
--exec sp_crud_DetalleVenta @Transaccion = N'INSERTAR', @codigoVenta = 2, @codigoProducto = 'P001', @cantidad = 3, @descuento=0
--exec sp_crud_DetalleVenta @Transaccion = N'INSERTAR', @codigoVenta = 3, @codigoProducto = 'P003', @cantidad = 14, @descuento=2

----actualizar
--exec sp_crud_DetalleVenta @Transaccion = N'ACTUALIZAR', @codigoVenta = 2, @codigoProducto = 'P001', @cantidad = 10, @descuento=25

----borrado
--exec sp_crud_DetalleVenta @Transaccion = N'BORRAR', @codigoVenta = 1, @codigoProducto='P002'

--8. Verificar la ejecución de todo el script sera tomado en cuenta en la calificación.
--select * from Producto
--select * from Venta
--select * from DetalleVenta
--select * from LogDetalleVenta