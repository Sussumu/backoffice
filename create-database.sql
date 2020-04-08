create database Backoffice

use Backoffice

create table QueryType (
	Id tinyint not null primary key identity(1, 1),
	Name varchar(50) not null
)

create table Query (
	Id int not null primary key identity(1, 1),
	Name varchar(100) not null,
	Description varchar(200),
	Query varchar(max) not null,
	Type tinyint not null foreign key references QueryType(Id)
)