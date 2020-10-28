use DXC
select * from employee

CREATE TABLE Persons (
    PersonID int,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255)
);

insert into Persons(PersonID,LastName,FirstName,Address,City) values(101,'s','s','aaaaa','bbb');
insert into Persons(PersonID,LastName,FirstName,Address,City) values(102,'a','b','aaaaa','bbb');
insert into Persons(PersonID,LastName,FirstName,Address,City) values(103,'c','c','aaaaa','bbb');
select * from Persons


create table student(
ID int identity(1,1),
FirstName varchar(20),
LastName varchar(20),
Location varchar(20))

insert into student values('soumya','shavi','bangalore')
insert into student values('parveen','palled','bangalore')
insert into student values('swathi','shavi','hyderbad')

select * from student

create table employ
(
ID int identity(1,1),
EmpName varchar(20),
EmpDes varchar(20),
EmpLoc varchar(20))

insert into employ values('b','c','d')
select * from employ

create table IndianCricketTeam(
JursyNo int not null,
FirstName varchar(20),
LastName varchar(20),
NoCenturies int )

insert into IndianCricketTeam values(7,'MS','Dhoni',20)
insert into IndianCricketTeam values(18,'virat','kohli',20)

create table railway(
train_no int not null,
train_name varchar(100),
source varchar(100),
destination varchar(100),
arrival_time time)

insert into railway values(12356,'karnatakaexpress','banglore','hubli','09:12:00')
insert into railway values(12323,'RaniChennammaExpress','hubli','banglore','23:12:23')

insert into railway values(14432,'Ahmedabad mumbai passenger','ahemadabad','mumbau','10:12:00')

create table bank(
emp_id int not null primary key identity(1,1),
emp_name varchar(100),
emp_depat varchar(100),
emp_location varchar(100))


insert into bank values('gnana','cashsection','banglore')
insert into bank values('seema','passbooksection','mumbai')

insert into bank values('karthik','creditcardsection','chennai')

