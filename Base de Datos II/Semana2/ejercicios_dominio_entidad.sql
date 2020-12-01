USE Northwind 
ALTER TABLE dbo.Customers 
ADD 
CONSTRAINT DF_Customers_contactname DEFAULT 'DESCONOCIDO' FOR ContactName,
CONSTRAINT DF_Customers_city DEFAULT 'QUITO' FOR City


alter table Customers
drop
CONSTRAINT DF_Customers_contactname,
CONSTRAINT DF_Customers_city



USE Northwind 
alter table employees
drop 
CONSTRAINT CK_birthdate 

ALTER TABLE dbo.Employees 
ADD 
CONSTRAINT CK_birthdate 
CHECK (BirthDate > DATEADD(year, -82,getdate()) 
		AND BirthDate < DATEADD(year, -18,getdate()))

update Employees
set BirthDate=GETDATE()
where EmployeeID=1

USE [Northwind]
GO

INSERT INTO [dbo].[Employees]
           ([LastName]
           ,[FirstName]
           ,[BirthDate]
          )
     VALUES
           ('Recalde'
           ,'Henry'
           ,getdate())--convert(datetime,'1978/11/22',111))
GO


select * from Employees

select DATEADD(year, -18,getdate())
select DATEADD(year, -80,getdate())






USE [Northwind]
GO

INSERT INTO [dbo].[Customers]
           ([CustomerID]
           ,[CompanyName]
           )
     VALUES
           ('QWE14'
           ,'Mi empresa'
           )
select * from Customers where CustomerID='QWE14'

USE northwind 
ALTER TABLE dbo.Suppliers 
add 
CONSTRAINT U_CompanyName 
UNIQUE NONCLUSTERED (CompanyName)

select * from Suppliers
update Suppliers
set CompanyName='Exotic Liquids'
where SupplierID=2



