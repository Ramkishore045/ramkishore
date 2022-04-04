use [AdventureWorks2019]
go
--USING COUNT
select  COUNT(+[StandardCost]) Totalnoofrows
from [Production].[ProductCostHistory]

--USING SUM()
select SUM([StandardCost]) SumCost
from [Production].[ProductCostHistory]

--USING DATEDIFF()
select DATEDIFF(YY,StartDate,EndDate) datedifference
from [Production].[ProductCostHistory]
--USING ADDDATE()
SELECT DATEADD(year, 3, '2019/04/04') AS DateAdd
--USING CONVERT()
SELECT CONVERT(int,88.77);
--USING LEFT()
SELECT LEFT('MEEJURU', 3) AS ExtractString
--USING LEN()
select LEN('RAMKISHORE')
--USING REVERSE()
select REVERSE('VARUN SAI')

--Task 2
create function fn_RupeesC(@amount as Nvarchar(50))
returns Nvarchar(50)
as 
begin
return (N'?'+@amount)
end
select BusinessEntityID,dbo.fn_RupeesC(rate) as RUPEE 
from HumanResources.EmployeePayHistory


----TASK3

create view  Vx_dept1
as
select [DepartmentID],[Name],[GroupName]
from[HumanResources].[Department]
go

select*from [HumanResources].[Department]

insert Vx_dept1 ([Name],[GroupName])
values('prodcution','abc');

insert [HumanResources].[Department] ([Name],[GroupName])
values('RAMKISHORE','Rsoftura')

select *from Vx_dept1
-------TASK4--------
use softura
go
select * from [dbo].[tbl_just]
create proc taskIns_sp
@name varchar(50),
@gender char(1)
as
insert into tbl_just(name,gender)
values(@name,@gender)
taskIns_sp 'ramkishore','M'
create proc taskup_sp
@sno int,
@age int,
@name varchar(50)
as
update tbl_just set sno=@sno,age=@age where name = @name

task1_sp 1,19,'ramkishore'
create proc taskDel_sp
@sno int
as
delete from tbl_just where sno = @sno

taskDel_sp 1


-------TASK5-------
select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))



-------TASK6-----
select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
GRoup By [ProductModelID]

-----TASK7-------
USE [AdventureWorks2019]
GO
select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name