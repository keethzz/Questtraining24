CREATE TABLE products (
    id INT IDENTITY PRIMARY KEY,
    fname VARCHAR(255) NOT NULL,
    discription TEXT,
    price DECIMAL(10, 2) NOT NULL,
    stock INT NOT NULL,
    created_at TIMESTAMP DEFAULT NOW()
);
