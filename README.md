# Entity Framework First Application
In this project, We are going to learn about ORM (Oject Relational Mapping) pattern using Entity Framework 6.
## Prerequisites
1. Microsoft Visual Studio Community 2019
2. SQL Server Database engine
3. SQL Server Management Studio
### Create a new database using SQL Server Management Studio
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
### Create a new console application using Microsoft Visual Studio Community 2019
1. Create New Project
2. Select **Console App(.Net Framework)**
3. Name it as **EF-1**
4. Select **Location** where you want to save the project
5. Select **Framework** (Here,I selected .NET Freamework 4.7.2)
And click **Create** button to create project with above specifications.
### This Project Requires Enity Framework Package
We can install it using **NuGet Package Manager** > **Package Manager Console**
````install-package EntityFramework````
