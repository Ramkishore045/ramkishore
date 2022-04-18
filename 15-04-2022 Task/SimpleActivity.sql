create database SimpleActivity
use SimpleActivity
create table Product(Prod_ID int identity(1,1),Prod_Name varchar(20),Price money,Manufac_Date varchar(20),Exp_Date as dateadd(month,2,Manufac_Date))
insert Product values('Milk Bikis',25,'2022-04-15')
insert Product values('Dairy Milk',10,'2022-05-29')
insert Product values('Maaza',50,'2022-06-25')
insert Product values('Lays',20,'2022-07-21')
insert Product values('Sugar',40,'2022-07-10')
insert Product values('Marie gold',30,'2022-1-10')

select * from Product
select * from Customer
select * from Purchase

create table Customer(Cust_ID int identity(101,1),Name varchar(20),Gender char(1),DOB varchar(20),Contact varchar(20),Email varchar(20),City varchar(20)
constraint cty check(City in('Chennai','Mumbai','Kolkata','Delhi')));
insert Customer values('Yeswanth','M','12-10-1998','9654832568','yeswanth@gmail.com','chennai')
insert Customer values('Akash','M','23-01-2001','8546923756','Akash017@gmail.com','Delhi')




create proc CustomerIns
@name varchar(20),@gender char(1),@Dob varchar(20),@contact varchar(20),@mail varchar(20),@city varchar(20)
as
insert Customer values(@name,@gender,@Dob,@contact,@mail,@city)
CustomerIns 'Baskar','M','23-02-2000','7654328732','bk56@gmail.com','Delhi'

create table Purchase(Bill_No int identity(1,1),Cust_ID int,Prod_ID int,Quantity int,Total_Amount varchar(20),Pur_Date date default getdate())
 
insert Purchase values(101,1,2,GETDATE())
insert Purchase valueS(102,2,4,GETDATE())
drop table Purchase

select Bill_No,pur.Cust_ID,pur.Prod_ID,Quantity,sum(Price*Quantity) as Total_Amount
from Purchase pur
join Customer cus
on pur.Cust_ID=cus.Cust_ID
join Product pro
on
pur.Prod_ID=pro.Prod_ID
where pur.Prod_ID=4
group by Bill_No,pur.Cust_ID,Pur.Prod_ID,Quantity
having pur.Cust_ID=101