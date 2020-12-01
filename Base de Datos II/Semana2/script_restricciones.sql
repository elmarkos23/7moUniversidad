USE Northwind 
--retriccion tipo DEFAULT
ALTER TABLE dbo.Customers 
ADD 
CONSTRAINT DF_contactname DEFAULT 'UNKNOWN' FOR ContactName
--insersión de datos para comprobar restricción
INSERT INTO [dbo].[Customers]
           ([CustomerID]
           ,[CompanyName]
           )
     VALUES
           ('QWE13'
           ,'Personal'
          )
select * from Customers where CustomerID='QWE13'


--restricción tipo CHECK
ALTER TABLE dbo.Employees 
ADD 
CONSTRAINT CK_birthdate
CHECK (BirthDate > '01-01-1936' AND BirthDate <dateadd(year,-18,getdate()))

USE Northwind 
ALTER TABLE dbo.Employees 
ADD 
CONSTRAINT CK_birthdate 
CHECK (BirthDate > '01-01-1800' AND BirthDate < getdate()-1)

--comprobar restricción
update Employees
set BirthDate = '01-01-2000'
where EmployeeID=1

--restricción tipo UNIQUE 
ALTER TABLE dbo.Suppliers 
ADD 
CONSTRAINT U_CompanyName 
UNIQUE NONCLUSTERED (CompanyName)

--comprobar restricción
INSERT INTO [dbo].[Suppliers]
           ([CompanyName]
           ,[ContactName]
           )
     VALUES
           ('Exotic Liquids1'
           ,'prueba'
           )
GO

--restricción tipo FOREIGN KEY
USE northwind 
ALTER TABLE dbo.Orders 
drop 
CONSTRAINT FK_Orders_Customers 

USE northwind 
ALTER TABLE dbo.Orders 
ADD 
CONSTRAINT FK_Orders_Customers 
FOREIGN KEY (CustomerID) 
REFERENCES dbo.Customers(CustomerID) 
