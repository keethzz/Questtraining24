CREATE TABLE product (
id BIGINT IDENTITY PRIMARY KEY,
fname VARCHAR(100) NOT NULL,
discription TEXT,
price DECIMAL(10, 2) NOT NULL CHECK (price>0),
stock_quantity INT NOT NULL DEFAULT 0,
created_at DATETIME2 DEFAULT GETDATE()
);

INSERT INTO product (fname, discription, price, stock_quantity)
VALUES
('Laptop', '15.6 inch display, 16GB RAM, 512GB SSD', 1200.99, 50),
('Smartphone', '6.1 inch display, 128GB storage, 12MP camera', 799.49, 200),
('Tablet', '10 inch display, 64GB storage', 350.75, 150),
('Headphones', 'Wireless, noise-cancelling', 149.99, 300),
('Smartwatch', 'Fitness tracker, heart rate monitor', 249.99, 120),
('Camera', '24MP, DSLR with kit lens', 899.99, 40),
('Gaming Console', '500GB storage, wireless controller included', 499.99, 75),
('Bluetooth Speaker', 'Portable, 12 hours battery life', 99.99, 180),
('Monitor', '27 inch, 144Hz refresh rate, 1ms response time', 329.99, 65),
('External Hard Drive', '1TB storage, USB 3.0', 79.99, 250);