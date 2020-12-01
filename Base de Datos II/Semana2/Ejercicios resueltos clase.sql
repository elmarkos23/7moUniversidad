use Northwind
go

select * from Employees
select * from Orders
select * from Employees,Orders
where Employees.EmployeeID = Orders.EmployeeID

select * from Employees e,Orders o
where e.EmployeeID = o.EmployeeID

--Seleccionar el total de la cantidad (Quantity) 
--de productos por orden(OrderID) y (ProductID) 
--de la tabla Products
select od.OrderID, od.ProductID, SUM(od.Quantity) as total_cantidad
from Products pr, [Order Details] od
where pr.ProductID = od.ProductID
group by od.OrderID, od.ProductID

--total de ordenes por shipper
select shp.CompanyName, COUNT(OrderID) total_envios 
from Orders ord inner join Shippers shp
on ord.ShipVia = shp.ShipperID
group by shp.CompanyName
--empleados por jefe
select jef.FirstName+ ' '+jef.LastName Jefe,
emp.FirstName+' '+emp.LastName Empleado
from Employees emp inner join Employees jef
on emp.EmployeeID = jef.ReportsTo
order by Jefe, Empleado
--Obtener datos correspondientes a diversos grupos de filas, concretamente agrupados por cada empleado
SELECT EmployeeID, COUNT(*) AS TotalPedidos, 
COUNT(ShipRegion) AS FilasNoNulas, 
MIN(ShippedDate) AS FechaMin, 
MAX(ShippedDate) AS FechaMax, 
SUM(Freight) PesoTotal, 
AVG(Freight) PesoPromedio
FROM Orders
GROUP BY EmployeeID
--Usando la consulta anterior devolver el nombre y apellido cruzando la consulta anterior con empleado
SELECT emp.FirstName+' '+emp.LastName Empleado, 
COUNT(*) AS TotalPedidos, 
COUNT(ShipRegion) AS FilasNoNulas, 
MIN(ShippedDate) AS FechaMin, 
MAX(ShippedDate) AS FechaMax, 
SUM(Freight) PesoTotal, 
AVG(Freight) PesoPromedio
FROM Orders ord inner join Employees emp
on ord.EmployeeID = emp.EmployeeID
GROUP BY emp.FirstName+' '+emp.LastName
--Queremos conocer la cantidad de pedidos que cada empleado ha enviado a través de cada transportista
select emp.FirstName+' '+emp.LastName, shp.CompanyName, COUNT(OrderID) 'Numero de envios' 
from Employees emp inner join Orders ord
on emp.EmployeeID = ord.EmployeeID
inner join Shippers shp 
on ord.ShipVia = shp.ShipperID
group by emp.FirstName+' '+emp.LastName, shp.CompanyName
order by emp.FirstName+' '+emp.LastName, shp.CompanyName
--Queremos repetir la consulta de pedidos por empleado de hace un rato, pero obteniendo solamente aquellos que hayan enviado más de 5.000 Kg de producto, y ordenados por el nombre del empleado, la consulta sería muy sencilla usando HAVING y ORDER BY
SELECT emp.FirstName+' '+emp.LastName Empleado, 
COUNT(*) AS TotalPedidos, 
COUNT(ShipRegion) AS FilasNoNulas, 
MIN(ShippedDate) AS FechaMin, 
MAX(ShippedDate) AS FechaMax, 
SUM(Freight) PesoTotal, 
AVG(Freight) PesoPromedio
FROM Orders ord inner join Employees emp
on ord.EmployeeID = emp.EmployeeID
GROUP BY emp.FirstName+' '+emp.LastName
having SUM(Freight)>5000