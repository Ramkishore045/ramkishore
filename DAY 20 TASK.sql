use [AdventureWorks2019]
go
--TASK 1--
select [FirstName],[LastName]
from [Person].[Person] 
where [Title] IS NOT NULL

--TASK 2--
select [FirstName],[LastName]
from[Person].[Person]
where [FirstName] LIKE '%a%' and  [LastName] LIKE '%a%'

--TASK 3--
select sal.Name as [CurrencyCode],[Name]
from [Sales].[Currency] sal
join [Sales].[CountryRegionCurrency] salcrc
on sal.[CurrencyCode]=salcrc.[CurrencyCode]

create view vw_tbl
as
select [CurrencyCode],[Name]
from [Sales].[Currency]
go
select * from vw_tbl

select dis.[CurrencyCode],Name
from [Sales].[Currency],[Sales].[CountryRegionCurrency] dis


--TASK 4--
select * into HR_dept
from [HumanResources].[Department]
select * from HR_dept


--TASK 5--

create table task5
(
Sno int identity(1,1),
FName varchar(255),
LName varchar(255),
Gender char,
ModifiedDate date default getdate()
)
select * from task5
insert into task5(Fname,LName,Gender) 
values('MEEJURU','RAMKISHORE','M')
insert into task5(Fname,LName,Gender) 
values('JAGAU','ZEE','M')
insert into task5(Fname,LName,Gender) 
values('GIRISH','S','M')
insert into task5(Fname,LName,Gender) 
values('VENKATESH','I','M')
insert into task5(Fname,LName,Gender) 
values('ABDUL','SAMED','M')
insert into task5(Fname,LName,Gender) 
values('DILLI','S','M')
insert into task5(Fname,LName,Gender) 
values('JOHNNY','O','M')
insert into task5(Fname,LName,Gender) 
values('PAVAN','A','M')
insert into task5(Fname,LName,Gender) 
values('ANAND','F','M')
insert into task5(Fname,LName,Gender) 
values('NITHIN','C','M')
insert into task5(Fname,LName,Gender) 
values('HARISH','Q','M')
insert into task5(Fname,LName,Gender) 
values('SAIRAM','I','M')
insert into task5(Fname,LName,Gender) 
values('SURYA','P','M')
insert into task5(Fname,LName,Gender) 
values('KEASHAV','Z','M')
insert into task5(Fname,LName,Gender) 
values('RICKY','O','M')
insert into task5(Fname,LName,Gender) 
values('RANJITH','T','M')
insert into task5(Fname,LName,Gender) 
values('NAVEEN','F','M')
insert into task5(Fname,LName,Gender) 
values('KUMAR','D','M')
insert into task5(Fname,LName,Gender) 
values('SATHYA','D','M')
insert into task5(Fname,LName,Gender) 
values('MUTHU','KUMAR','M')

--TASK 6--
select dept.Name as[BusinessEntityID],[AddressTypeID]
from [HumanResources].[Department] dept
join [HumanResources].[EmployeeDepartmentHistory]edept
on dept.DepartmentID=edept.[DepartmentID]
join[Person].[BusinessEntityAddress]bea
on bea.[BusinessEntityID]=edept.[BusinessEntityID]

--TASK 7--
select distinct [GroupName]
from [HumanResources].[Department]

--TASK 8--
select a.standardcost,sum(listprice) sum1,sum(a.standardcost+ListPrice) Sum2
from Production.Product a
join Production.ProductCostHistory b
on a.ProductID = b.ProductID
group by a.StandardCost

--TASK 9--
select DATEDIFF (YY,StartDate,EndDate) as YearsOnAge
from HumanResources.EmployeeDepartmentHistory

--TASK 10--
select sum(SalesQuota)
 from Sales.SalesPersonQuotaHistory
 where SalesQuota>5000 and salesquota<100000
 group by SalesQuota


--TASK 11--
select max(TaxRate) maximumtaxrate
from Sales.SalesTaxRate

--TASK 12--
select hdh.BusinessEntityID,dept.DepartmentID,ShiftID
from HumanResources.Employee He
join HumanResources.EmployeeDepartmentHistory hdh
on he.BusinessEntityID=hdh.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=hdh.DepartmentID
Select BirthDate,getdate() as CurrentDate, datediff(YY,BirthDate,getdate()) as age 
from HumanResources.Employee

--TASK 13--
create view task12
as
Select BirthDate,getdate() as CurrentDate, datediff(YY,BirthDate,getdate()) as age 
from HumanResources.Employee
go
select *from task12

--TASK 14--
SELECT count(*) No_of_rows_hr
FROM [HumanResources].[Department],[HumanResources].[Employee],[HumanResources].[EmployeeDepartmentHistory],[HumanResources].[EmployeePayHistory],[HumanResources].[Shift]

--TASK 15--
select max(rate) as MaxSalary,Name
from HumanResources.EmployeePayHistory pay
join HumanResources.EmployeeDepartmentHistory dhis
on pay.BusinessEntityID = dhis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID = dhis.DepartmentID
GRoup By name

--TASK 16--
select FirstName,MiddleName,Title,dhis.BusinessEntityID
from Person.BusinessEntityAddress dhis
left outer join Person.Person pp
on pp.BusinessEntityID=dhis.BusinessEntityID
where title is not null

--TASK 17--
select ProductID,LocationID,Shelf 
from [Production].[ProductInventory]
where ProductID>300 and ProductID<=350 and locationID=50
--TASK 18--
select p1.LocationID,Shelf,Name
from [Production].[ProductInventory] pp
join [Production].[Location] p1
on pp.LocationID=p1.LocationID

--TASK 19--
select AddressID,AddressLine1,AddressLine2, pa.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince psp
join Person.Address pa
on psp.StateProvinceID=pa.StateProvinceID

--TASK 20--
select sum([SubTotal]),sum([TaxAmt])
from [Sales].[CountryRegionCurrency] crc
join [Sales].[SalesTerritory] st
on crc.[CountryRegionCode]=st.[CountryRegionCode]
join [Sales].[SalesOrderHeader] soh
on st.[TerritoryID]=soh.[TerritoryID]
group by st.[TerritoryID]
