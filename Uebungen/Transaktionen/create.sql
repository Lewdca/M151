DROP TABLE products;

CREATE TABLE products (
	id int,
	name varchar(255),
	price int,
	PRIMARY KEY (id)
);

DELETE FROM products;

INSERT INTO products (id, name, price)
VALUES (1, 'Banane', 5);

INSERT INTO products (id, name, price)
VALUES (2, 'Apfel', 2);
