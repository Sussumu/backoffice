use Backoffice

sp_rename 'Query.Type', 'QueryType', 'column'

create table ParamType (
	Id tinyint not null primary key identity(1, 1),
	Name varchar(50) not null	
)

create table QueryParam (
	Id int not null primary key identity(1, 1),
	Name varchar(100) not null,
	Description varchar(200) null,
	QueryId int not null foreign key references Query(Id),
	ParamType tinyInt not null foreign key references ParamType(Id),
	Required bit not null,
	Length int null,
	Precision int null,
	Scale int null
)