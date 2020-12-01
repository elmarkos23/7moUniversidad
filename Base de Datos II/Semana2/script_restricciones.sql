USE Northwind 
--retriccion tipo DEFAULT
ALTER TABLE dbo.Customers 
ADD 
CONSTRAINT DF_contactname DEFAULT 'UNKNOWN' FOR ContactName
--insersi�n de datos para comprobar restricci�n
INSERT INTO [dbo].[Customers]
           ([CustomerID]
           ,[CompanyName]
           )
     VALUES
           ('QWE13'
           ,'Personal'
          )
select * from Customers where CustomerID='QWE13'


--restricci�n tipo CHECK
ALTER TABLE dbo.Employees 
ADD 
CONSTRAINT CK_birthdate
CHECK (BirthDate > '01-01-1936' AND BirthDate <dateadd(year,-18,getdate()))

USE Northwind 
ALTER TABLE dbo.Employees 
ADD 
CONSTRAINT CK_birthdate 
CHECK (BirthDate > '01-01-1800' AND BirthDate < getdate()-1)

--comprobar restricci�n
update Employees
set BirthDate = '01-01-2000'
where EmployeeID=1

--restricci�n tipo UNIQUE 
ALTER TABLE dbo.Suppliers 
ADD 
CONSTRAINT U_CompanyName 
UNIQUE NONCLUSTERED (CompanyName)

--comprobar restricci�n
INSERT INTO [dbo].[Suppliers]
           ([CompanyName]
           ,[ContactName]
           )
     VALUES
           ('Exotic Liquids1'
           ,'prueba'
           )
GO

--restricci�n tipo FOREIGN KEY
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
