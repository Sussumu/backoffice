use Backoffice

sp_rename 'Query.Type', 'QueryType', 'column'

create table QueryParam (
	Id int not null primary key identity(1, 1),
	Name varchar(100) not null,
	Description varchar(200) null,
	QueryId int not null foreign key references Query(Id)
)