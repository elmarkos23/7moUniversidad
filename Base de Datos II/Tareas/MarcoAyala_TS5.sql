--Tarea semana 5
-- Marco Ayala
--Bases de Datos II

--Funciones escalares

/*Realizar una función que reciba 2 números y la operación y realice las 4 operaciones 
básicas (suma, resta, multiplicación, y división), validar que no exista división para 0 */
create function Operaciones
(
  @operador char(1), 
  @num1 int,
  @num2 int
)
returns varchar(50) 
as
begin
declare @resultado varchar(50)

	if @operador='+'
	begin
		set @resultado = @num1 + @num2
	end
	else if @operador='-'
	begin
		set @resultado = @num1 - @num2
	end
	else if @operador='x'
	begin
		set @resultado = @num1 * @num2
	end
	else if @operador='/'
	begin
		set @resultado = ISNULL(@num1 / NULLIF(@num2,0),-9999)
		if(@resultado='-9999')
			set @resultado='No se puede realizar una division para cero'
	end
	else
	begin
		set @resultado = 'Operacion no valida'
	end
	return @resultado
end
go
select dbo.Operaciones('x',5,5)
go

/*Realizar un función que obtenga el resultado de un numero elevado a una potencia x^y, 
validar que el numero no exceda a 10000 y la potencia a 100.*/
create function Potencia
(
@valorx int,
@valory int
)
returns varchar(max) 
as
begin
declare @resultado varchar(50)
declare @contador int
declare @auxiliar int
if(@valorx>10000)
begin
	set @resultado='el valor de x no debe exceder a 10000'
	goto misalida
end
if(@valory>100)
begin
	set @resultado='el valor de y no debe exceder a 100'
	goto misalida
end
	
set @contador=1
set @auxiliar=@valorx
while @contador<@valory
begin
	set @valorx = (@valorx * @auxiliar)
	set @contador=@contador+1
end
set @resultado = cast(@valorx as varchar(max))

misalida:
	return @resultado
end
go

select dbo.Potencia(5,3)
go
/*Realizar una función que permita calcular el total de ventas de un 
factura se debe tomar en cuenta la cantidad por el precio menos el descuento.*/
create function TotalVentasFactura
(
@cantidad int,@precio decimal(18,2), @descuento decimal(18,2)
)
returns decimal(18,2)
as 
begin
declare @resultado decimal(18,2)

  set @resultado=(@cantidad*@precio)-@descuento

return @resultado
end
go
select dbo.TotalVentasFactura(10,29,0)
go
--Usando Northwind
--Realizar una función que permita obtener los datos por empleado el total vendido por factura.
create function VentasEmpleado
(
	@factura int
)
returns table 
as
return 
(
	select E.FirstName +' '+E.LastName as NombreEmpleado,sum(UnitPrice*Quantity) as TotalVendido
	from Orders as O
	inner join Employees as E on E.EmployeeID=O.EmployeeID
	inner join [Order Details] OD on OD.OrderID=O.OrderID
	where O.OrderID = @factura
	group by E.FirstName,E.LastName
)
go
select * from  dbo.VentasEmpleado(10301);
go

--Realizar una función que permita obtener los datos por cliente el total comprado por factura.
create function VentasCliente
(
	@factura int
)
returns table 
as
return 
(
	select C.CompanyName as NombreCliente,sum(UnitPrice*Quantity) as TotalVendido
	from Orders as O
	inner join Customers as C on C.CustomerID=O.CustomerID
	inner join [Order Details] OD on OD.OrderID=O.OrderID
	where O.OrderID = @factura
	group by C.CompanyName
)
go
select * from  dbo.VentasCliente(10301)
go
--Realizar una función que permita obtener el listado de productos por país procedencia, indicar los datos principales de producto y proveedor.

create function ListaProductos
(
 @pais varchar(30)
)
returns table 
as
return
(
	select P.ProductName as Producto,P.QuantityPerUnit as Presentacion,P.UnitPrice as Precio,S.CompanyName as Proveedor
	from Products as P
	inner join Suppliers as S on S.SupplierID=P.SupplierID
	where S.Country=@pais
)
go
select * from dbo.ListaProductos('UK')