CREATE DATABASE BDD_VENTAS
GO
USE BDD_VENTAS
GO
CREATE TABLE CLIENTES
(
usuario varchar(7) not null,
nombre varchar(10) not null,
constraint PK_usuario primary key clustered(usuario)
)
GO
CREATE TABLE PEDIDOS
(
cliente varchar(7) not null,
numpedido int not null,
fecha date not null,
total varchar(45) not null,
constraint PK_numeropedido primary key clustered(numpedido)
)
GO

ALTER TABLE PEDIDOS 
Add constraint FK_usuario foreign key(cliente) references CLIENTES(usuario)

GO

CREATE TABLE PRODUCTO
(
id int not null,
nombre varchar(20) not null,
constraint PK_producto primary key clustered(id)
)
GO

CREATE TABLE LINEAS_PEDIDO
(
pedido int not null,
producto int not null,
precio int not null,
cantidad int not null,
constraint PK_lineaspedido primary key clustered(pedido,producto),
constraint PK_pedido foreign key(producto) references PRODUCTO(id),
constraint PK_cliente foreign key(producto) references PEDIDOS(numpedido)
)
GO
