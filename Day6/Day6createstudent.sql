Create table Students (
id int primary key identity,
fname varchar(50) not null,
email varchar(100) unique not null,
class int not null
);

