--SCRIPT EJERCICIO 1

CREATE DATABASE [EJERCICIO_1]
GO

USE [EJERCICIO_1]
GO

CREATE TABLE AUTOR(
	idAutor varchar(5) NOT NULL,
	nomAutor varchar(45) NOT NULL,
	apeAutor varchar(45) NOT NULL,
	edad int,
 CONSTRAINT PK_IdAutor PRIMARY KEY CLUSTERED(idAutor),
 CONSTRAINT CK_EDAD CHECK(edad>18)
) 
GO

ALTER TABLE AUTOR ADD estado bit CONSTRAINT DF_ESTADO DEFAULT(1) 
GO

CREATE TABLE LIBRO (
idLibro int IDENTITY(1,1) NOT NULL,
nombre varchar(45) NOT NULL,
descripcion varchar(45) NOT NULL,
nro_paginas int,
Autor_idAutor varchar(5)
)
GO

ALTER TABLE LIBRO
ADD 
CONSTRAINT PK_ID_LIBRO PRIMARY KEY CLUSTERED (idLibro),
CONSTRAINT CK_NRO_PAGINAS CHECK(nro_paginas>=10),
CONSTRAINT DF_NRO_PAGINAS DEFAULT(10) FOR nro_paginas
GO

ALTER TABLE LIBRO
ADD isbn varchar(20),
CONSTRAINT U_ISBN UNIQUE NONCLUSTERED(isbn)
GO

ALTER TABLE LIBRO
ADD 
CONSTRAINT FK_AUTOR FOREIGN KEY(Autor_idAutor) REFERENCES Autor(idAutor) ON UPDATE CASCADE

GO

--SCRIPT EJERCICIO 2

CREATE DATABASE [EJERCICIO_2]
GO

USE [EJERCICIO_2]
GO

CREATE TABLE Venta(
codigoVenta int identity(1,1) not null,
cliente varchar(100),
fecha datetime not null 
)
GO

ALTER TABLE Venta
ADD
cedRuc varchar(13),
CONSTRAINT PK_VENTA PRIMARY KEY CLUSTERED(codigoVenta),
CONSTRAINT CK_VALIDA_FECHA CHECK(fecha>='19900101' AND fecha<=GETDATE())

CREATE TABLE Producto
(
codigoProducto varchar(10) not null,
nombre varchar(100) not null,
precio decimal(18,2) not null
)
GO
ALTER TABLE Producto
ADD
CONSTRAINT PK_CLAVE_PRODUCTO PRIMARY KEY CLUSTERED(codigoProducto),
CONSTRAINT U_NOMBRE UNIQUE NONCLUSTERED(nombre),
CONSTRAINT CK_PRECIO CHECK(precio>=0)

CREATE TABLE DetalleVenta
(
codigoVenta int not null,
codigoProducto varchar(10) not null,
cantidad decimal(18,2),
descuento decimal(18,2)
)
GO
ALTER TABLE DetalleVenta
ADD
CONSTRAINT PK_CLAVE_DETALLE PRIMARY KEY CLUSTERED(codigoVenta,codigoProducto),
CONSTRAINT FK_PRODUCTO FOREIGN KEY(codigoProducto) REFERENCES Producto(codigoProducto) ON UPDATE CASCADE
