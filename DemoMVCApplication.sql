USE [Sample]
GO
CREATE TABLE tblEmployee(EmployeeId INT,Name VARCHAR(20),Gender VARCHAR(6),City VARCHAR (20) )
GO
INSERT INTO [dbo].[tblEmployee]
           ([EmployeeId]
           ,[Name]
           ,[Gender]
           ,[City])
     VALUES(1
           ,'Sebastien'
           ,'Male'
           ,'New York'),
		 (2
           ,'Mary'
           ,'Female'
           ,'Los Angeles'),
           (3
           ,'John'
           ,'Male'
           ,'Washington'),
		 (4
           ,'Stella'
           ,'Female'
           ,'Mexico'),
		 (5
           ,'Todd'
           ,'Male'
           ,'San Fransico')
GO
Select * from tblEmployee
