create table Employees
( Id int identity primary key,
  Name varchar(30) not null,
  Salary int,
  DepartmentId int references Departments(DepartmentId) on delete cascade
)

insert into employees values ('Joe',100000,2);
insert into employees values ('Andy',150000,3);
insert into employees values ('James',50000,2);