SELECT orders.id, product.fname,users.first_name
FROM orders
INNER JOIN product
ON orders.product_id = product.id inner join users on users.id = product.id

SELECT orders.id, product.fname
FROM orders
left JOIN product
ON orders.product_id = product.id;

SELECT orders.id, product.fname
FROM orders
right JOIN product
ON orders.product_id = product.id inner join users on orders.user_id = users.id;