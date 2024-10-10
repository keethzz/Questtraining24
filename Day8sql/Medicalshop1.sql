create table suppliers (
	id int primary key identity,
	name varchar(50) not null,
	contact_person varchar(20),
	phone varchar(15),
	email varchar(20) unique not null,
	address varchar(100)
)

create table medications(
	id int primary key identity,
	name varchar(50) not null,
	category varchar(50) not null,
	price decimal(10,2) not null,
	expiry_date date not null,
	supplier_id int not null,
	stock_quantity int not null,
    constraint FK_medications_sup_id foreign key (supplier_id) references suppliers(id)
)

 create table customers (
    id INT PRIMARY KEY identity,
    name VARCHAR(50) not null,
    phone VARCHAR(20) not null,
    email VARCHAR(15) not null,
    address TEXT
);

create table sales (
    id int primary key identity,
    customer_id int,
    medication_id int,
    quantity int,
    sale_date date,
    total_price decimal(10, 2),
    constraint FK_sales_customer_id foreign key (customer_id) references customers(id),
    constraint FK_sales_medication_id foreign key (medication_id) references medications(id)
);

create table inventory (
    id int primary key identity,
    medication_id int,
    supplier_id int,
    stock_in int,
    stock_out int,
    date_added date,
    constraint FK_inventory_med_id foreign key (medication_id) references medications(id),
    constraint FK_inventory_supp_id foreign key (supplier_id) references suppliers(id)
);