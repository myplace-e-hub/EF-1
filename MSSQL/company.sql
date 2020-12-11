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