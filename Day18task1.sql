create database Task
go

create table task(

studentID int identity(22104001,1),
FirstName varchar(255),
LastName varchar(255),
Age int,
constraint ck_age check(age>18),
Gender char(1),
constraint ck_gen check (gender in ('M','F')),
College_Name varchar(255),
Address_line varchar(255),
city varchar(255),
Email_ID varchar(255),
Phone_No varchar(255),
Highest_Qualification varchar(255),
His_Backlog char(1),
YearofPassout int,
CGPA int,
constraint ck_cgpa check(cgpa>6),
school_12th varchar(255),
constraint ck_12th check(school_12th>65),
school_10th varchar(255),
constraint ck_10th check(school_10th>65),



)
select * from task
alter table task
add School_Name varchar(255)
alter table task
add constraint PK_stu primary key(studentID )

insert task values('Meejuru','Ramkishore',21,'M','sjit','guindy','chennai','ram@123','9507645895','BE','0',
2022,7.0,'89','87','Rathnam high school')
insert task values('pavan','R',21,'M','sjec','vel','chennai','pavan@123','9505582895','BE','2',
2022,7.0,'89','87','govt high school')
insert task values('Meejuru','saikishore',28,'M','sathyabama','koyambedu','chennai','saikishore@123','9632145895','BE','0',
2022,7.0,'89','87','Rathnam high school')