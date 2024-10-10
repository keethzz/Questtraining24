/*CREATE PROCEDURE sp_Createsupplier (
    @name VARCHAR(100),
    @contact_person VARCHAR(100),
    @phone VARCHAR(20),
    @email VARCHAR(100),
    @address TEXT
)
as
BEGIN
    INSERT INTO suppliers (name, contact_person, phone, email, address)
    VALUES (@name, @contact_person, @phone, @email, @address);
END 

EXEC sp_Createsupplier 
    @name = 'HealthCorp', 
    @contact_person = 'Jane Doe', 
    @phone = '1234567890', 
    @email = 'jane@example.com', 
    @address = '123 Health St, City';
    
create procedure add_medication (
    @name varchar(100),
    @category varchar(100),
    @price decimal(10, 2),
    @expiry_date date,
    @supplier_id int,
    @stock_quantity int
)
as

begin

    insert into medications (name, category, price, expiry_date, supplier_id, stock_quantity)
    values (@name, @category, @price, @expiry_date,@supplier_id,@stock_quantity);
end 


EXEC add_medication @name = 'Paracetamol', @category='Painkiller', @price = 2.50, @expiry_date='2025-12-31', @supplier_id=1, @stock_quantity=100;


select* from medications;



create procedure sp_Createcustomer (
    @name varchar(20),
    @phone varchar(15),
    @email varchar(20),
    @address varchar(50)
)
as
begin
    insert into customers (name, phone, email, address)
    values (@name, @phone, @email, @address);
end




exec sp_Createcustomer  @name = 'john doe', 
             @phone = '9876543210',
             @email = 'john@123', 
             @address = 'adress is not found.';



select* from customers;

*/