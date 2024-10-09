CREATE TABLE Orders (
   Id BIGINT PRIMARY KEY IDENTITY,
  quantity INT NOT NULL DEFAULT 1,
  product_id BIGINT NOT NULL,  -- Change product_id to BIGINT
  user_id INT NOT NULL,  -- or BIGINT if you chose to update user_id
  CONSTRAINT FK_orders_user_id FOREIGN KEY(user_id) REFERENCES users(id),
  CONSTRAINT FK_orders_product_id FOREIGN KEY(product_id) REFERENCES product(id)
);
INSERT INTO Orders (quantity, product_id, user_id) VALUES (10, 1, 1);
INSERT INTO Orders (quantity, product_id, user_id) VALUES (10, 1, 9); --Conflict
DELETE FROM users WHERE id = 1; --conflict