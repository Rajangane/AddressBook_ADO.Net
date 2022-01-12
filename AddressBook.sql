use AddressBookSystem
--created addrebook table
create table AddressBook
(
 ID int  primary key,
 Firstname varchar(100) not null,
 Lastname varchar(100) not null,
 PhoneNumber varchar(255) not null,
 Address varchar(250) not null,
 Zip varchar(6) not null,
 City varchar(100) not null,
 State varchar(100) not null,
 email varchar(100) not null,
 AddressBookName varchar(255) not null,
 Type varchar(12) not null
);

--inserted values in address book
insert into AddressBook values (1,'Pratiksha','Rajangane','6363123456','Chikodi','123456','Belgaum','Karanataka','pratiksha@gmail.com','Book1','Friends')
insert into AddressBook values (2,'Prerana','Rajangane','6363127896','Hubli','123856','Dharwad','Karanataka','prerana@gmail.com','Book2','Sister')

--displaying records
select * from AddressBook;
