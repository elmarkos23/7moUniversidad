--TAREA SEMANA 1
--MARCO AYALA
--1721481586
--7mo "A"

USE Northwind
go

/*
1. Crear una vista para mostrar los productos comprados por cada cliente con 
el total de su precio unitario y además se debe filtrar por el país de procedencia 
del cliente que debe ser Mexico, mostrar el producto, y total del precio unitario.
*/
DROP VIEW IF EXISTS ProductosCompradosClientes
GO
CREATE VIEW [ProductosCompradosClientes] 
AS
SELECT C.ContactName,P.ProductName,SUM(OD.UnitPrice) AS [Total]
FROM [Order Details] AS OD 
INNER JOIN Products AS P ON P.ProductID=OD.ProductID
INNER JOIN Orders AS O ON O.OrderID=OD.OrderID
INNER JOIN Customers AS C ON C.CustomerID=O.CustomerID
WHERE C.Country='Mexico'
GROUP BY C.ContactName,P.ProductName

GO
/*
2.Crear una vista para mostrar el total del precio unitario de productos 
vendidos agrupando por producto y país, mostrar producto, país y el total
antes mencionado.
*/
DROP VIEW IF EXISTS TotalPrecioUnitarioProductos
GO
CREATE VIEW [TotalPrecioUnitarioProductos] 
AS
SELECT P.ProductName,S.Country,SUM(OD.UnitPrice) AS [Total]
FROM [Order Details] AS OD
INNER JOIN Products AS P ON P.ProductID=OD.ProductID
INNER JOIN Suppliers AS S ON S.SupplierID=P.SupplierID
GROUP BY P.ProductName,S.Country
GO
/*
3. Crear una vista para mostrar la cantidad total de productos vendidos los 
cuales estén en estado discontinuado, mostrar producto, país y el total antes 
mencionado.
*/
DROP VIEW IF EXISTS ProductosVendidos
GO
CREATE VIEW [ProductosVendidos] 
AS
SELECT P.ProductName,S.Country,SUM(OD.Quantity) AS CantidadTotal
FROM [Order Details] AS OD
INNER JOIN Products AS P ON P.ProductID=OD.ProductID
INNER JOIN Suppliers AS S ON S.SupplierID=P.SupplierID
WHERE P.Discontinued=1
GROUP BY P.ProductName,S.Country
GO

/*
4. Crear una vista que muestre los productos vendidos por cada empleado y los 
productos comprados por cada cliente establecer las diferencias de compra o venta, 
mostrar empleado/cliente, producto y compra/venta.
*/
DROP VIEW IF EXISTS CompraVenta
GO
CREATE VIEW [CompraVenta] 
AS
SELECT DISTINCT E.FirstName+' '+E.LastName AS [Empleado/Cliente],P.ProductName as Producto,'VENTA' AS [Compra/Venta]
FROM [Order Details] AS OD
INNER JOIN Products AS P ON P.ProductID=OD.ProductID
INNER JOIN Orders AS O ON O.OrderID=OD.OrderID
INNER JOIN Employees AS E ON E.EmployeeID=O.EmployeeID
UNION 
SELECT DISTINCT C.ContactName AS [Empleado/Cliente],P.ProductName as Producto,'COMPRA' AS [Compra/Venta]
FROM [Order Details] AS OD
INNER JOIN Products AS P ON P.ProductID=OD.ProductID
INNER JOIN Orders AS O ON O.OrderID=OD.OrderID
INNER JOIN Customers AS C ON C.CustomerID=O.CustomerID
GO
/*
5. Crear una vista que muestre cuantas órdenes ha realizado cada empleado
(mostrar el nombre, apellidos y número de pedidos) que sean mayores a 100.
*/

DROP VIEW IF EXISTS PedidosEmpleados
GO
CREATE VIEW [PedidosEmpleados] 
AS
SELECT FirstName,LastName,COUNT(ORD.OrderID) AS NumeroPedidos
FROM Employees AS EMP
JOIN Orders AS ORD ON ORD.EmployeeID=EMP.EmployeeID
GROUP BY FirstName,LastName
HAVING COUNT(ORD.OrderID)>100
GO
