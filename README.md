# Entity Framework First Application
In this project, We are going to learn about ORM (Oject Relational Mapping) pattern using Entity Framework 6.
## Prerequisites
1. Microsoft Visual Studio Community 2019
2. SQL Server Database engine
3. SQL Server Management Studio
### Create a new database with the name of * ![#1589F0](company) * using SQL Server Management Studio
````
create database company;
go
use company;
go
create table Employees(
EmployeeId int primary key,
EmployeeName nvarchar(max),
Salary decimal
);
go
insert into Employees(EmployeeId ,EmployeeName,Salary)
values(1,'Ravi',95000);
insert into Employees(EmployeeId ,EmployeeName,Salary)
values(2,'Hyma',25000);
insert into Employees(EmployeeId ,EmployeeName,Salary)
values(3,'Sree lakshmi',8000);
insert into Employees(EmployeeId ,EmployeeName,Salary)
values(4,'Siva',3000);
go
select * from Employees;

-- drop database company;
-- use master;
````
### Create a new console application with the name of *EF-1* using Microsoft Visual Studio Community 2019
