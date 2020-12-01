USE Northwind 
ALTER TABLE dbo.Customers 
ADD 
CONSTRAINT DF_contactname DEFAULT 'UNKNOWN' FOR ContactName
---- 
INSERT INTO [Northwind].[dbo].[Customers]
           ([CustomerID]
           ,[CompanyName]
           ,[ContactTitle]
           ,[Address]
           ,[City]
           ,[Region]
           ,[PostalCode]
           ,[Country]
           ,[Phone]
           ,[Fax])
     VALUES
           ('ASDEF'
           ,'PERSONAL'
           ,'SEÑOR'
           ,'QUITO'
           ,'QUITO'
           ,'SIERRA'
           ,'170001'
           ,'ECUADOR'
           ,'2222222'
           ,'2222222')
GO


SELECT * FROM Customers 
WHERE CustomerID='ASDEF'
----
USE Northwind 
ALTER TABLE dbo.Employees 
ADD 
CONSTRAINT CK_birthdate 
CHECK (BirthDate > '01-01-1800' AND BirthDate < getdate()-1)
-----
INSERT INTO [Northwind].[dbo].[Employees]
           ([LastName]
           ,[FirstName]
           ,[Title]
           ,[TitleOfCourtesy]
           ,[BirthDate]
           ,[HireDate]
           ,[Address]
           ,[City]
           ,[Region]
           ,[PostalCode]
           ,[Country]
           ,[HomePhone]
           ,[Extension]
           ,[Photo]
           ,[Notes]
           ,[ReportsTo]
           ,[PhotoPath])
     VALUES
           ('HENRY'
           ,'RECALDE'
           ,'SR'
           ,'SR'
           ,'1801/01/01'
           ,GETDATE()-10
           ,'QUITO'
           ,'QUITO'
           ,'SIERRA'
           ,NULL
           ,'ECUADOR'
           ,NULL
           ,NULL
           ,NULL
           ,NULL
           ,NULL
           ,NULL)
GO

---
SELECT * FROM Employees
WHERE EmployeeID =2

SELECT * FROM Employees
WHERE Country='USA'

----
SELECT OD.*  FROM Customers CU 
INNER JOIN Orders OD 
ON CU.CustomerID = OD.CustomerID
WHERE OD.CustomerID='QWERT'
---
USE northwind 
ALTER TABLE dbo.Orders 
ADD 
CONSTRAINT FK_Orders_Customers 
FOREIGN KEY (CustomerID) 
REFERENCES dbo.Customers(CustomerID) 
ON UPDATE CASCADE 
---
UPDATE Customers
SET CustomerID='QWERT'
WHERE CustomerID='ALFKI'
