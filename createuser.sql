Create table users (
id int primary key identity,
first_name varchar(50) not null,
last_name varchar(50) not null,
email varchar(100) unique not null,
age int not null
);
