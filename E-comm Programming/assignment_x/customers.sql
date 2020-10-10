USE ecommerce_online;


CREATE TABLE shirt_states (
	shirt_states_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
	state VARCHAR(30) NOT NULL,
	abbr CHAR(2) NOT NULL,
	PRIMARY KEY (shirt_states_id)
) ENGINE = InnoDB;

INSERT INTO shirt_states(state, abbr) VALUES
	('Alabama', 'AL'),
	('Alaska', 'AK'),
	('Arizona', 'AZ'),
	('Arkansas', 'AR'),
	('California', 'CA'),
	('Colorado', 'CO'),
	('Connecticut', 'CT'),
	('Delaware', 'DE'),
	('District of Columbia', 'DC'),
	('Florida', 'FL'),
	('Georgia', 'GA'),
	('Hawaii', 'HI'),
	('Idaho', 'ID'),
	('Illinois', 'IL'),
	('Indiana', 'IN'),
	('Iowa', 'IA'),
	('Kansas', 'KS'),
	('Kentucky', 'KY'),
	('Louisiana', 'LA'),
	('Maine', 'ME'),
	('Maryland', 'MD'),
	('Massachusetts', 'MA'),
	('Michigan', 'MI'),
	('Minnesota', 'MN'),
	('Mississippi', 'MS'),
	('Missouri', 'MO'),
	('Montana', 'MT'),
	('Nebraska', 'NE'),
	('Nevada', 'NV'),
	('New Hampshire', 'NH'),
	('New Jersey', 'NJ'),
	('New Mexico', 'NM'),
	('New York', 'NY'),
	('North Carolina', 'NC'),
	('North Dakota', 'ND'),
	('Ohio', 'OH'),
	('Oklahoma', 'OK'),
	('Oregon', 'OR'),
	('Pennsylvania', 'PA'),
	('Rhode Island', 'RI'),
	('South Carolina', 'SC'),
	('South Dakota', 'SD'),
	('Tennessee', 'TN'),
	('Texas', 'TX'),
	('Utah', 'UT'),
	('Vermont', 'VT'),
	('Virginia', 'VA'),
	('Washington', 'WA'),
	('West Virginia', 'WV'),
	('Wisconsin', 'WI'),
	('Wyoming', 'WY');

CREATE TABLE shirt_customers (
	shirt_customers_id MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT, 
	first_name VARCHAR(30) NOT NULL,
	last_name VARCHAR(30) NOT NULL,
	email VARCHAR(40) NOT NULL,
	phone VARCHAR(20) NOT NULL,
	password CHAR(255) NOT NULL,
	address_1 VARCHAR(100) NOT NULL,
	address_2 VARCHAR(100),
	city VARCHAR(50) NOT NULL,
	shirt_states_id TINYINT UNSIGNED NOT NULL,
	zip CHAR(5) NOT NULL,
	date_created TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(shirt_customers_id),
	INDEX ind_shirt_states_id (shirt_states_id),
	CONSTRAINT fk_shirt_states_id FOREIGN KEY (shirt_states_id) REFERENCES shirt_states(shirt_states_id) ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE = InnoDB;

create table shirt_transactions(
	shirt_transactions_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	amount_charged DECIMAL(6, 3) NOT NULL, 
	type VARCHAR(100) NOT NULL, 
	response_code VARCHAR(200) NOT NULL, 
	response_reason VARCHAR(200) NOT NULL, 
	response_text VARCHAR(400) NOT NULL, 
	date_created TIMESTAMP NOT NULL, 
	PRIMARY KEY(shirt_transactions_id)
) ENGINE = InnoDB;

create table shirt_shipping_addresses(
	shirt_shipping_addresses_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	address_1 VARCHAR(100) NOT NULL, 
	address_2 VARCHAR(100), 
	city VARCHAR(50) NOT NULL, 
	shirt_states_id TINYINT UNSIGNED NOT NULL, 
	zip CHAR(5) NOT NULL, 
	date_created TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(shirt_shipping_addresses_id)
) ENGINE = InnoDB;

create table shirt_billing_addresses(
	shirt_billing_addresses_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	address_1 VARCHAR(100) NOT NULL, 
	address_2 VARCHAR(100), 
	city VARCHAR(50) NOT NULL, 
	shirt_states_id TINYINT UNSIGNED NOT NULL, 
	zip CHAR(5) NOT NULL, 
	date_created TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(shirt_billing_addresses_id)
) ENGINE = InnoDB;

create table shirt_carriers_methods(
	shirt_carriers_methods_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
	carrier VARCHAR(50) NOT NULL, 
	method VARCHAR(50) NOT NULL, 
	fee DECIMAL(6, 3) NOT NULL, 
	PRIMARY KEY(shirt_carriers_methods_id)
) ENGINE = InnoDB;

INSERT INTO shirt_carriers_methods (carrier, method, fee) VALUES 
('UPS', 'Ground', '4.99'),
('UPS', 'Express', '9.99'),
('USPS', 'Standard', '3.99'),
('USPS', 'Expedited', '6.99'),
('FEDEX', 'Same Day', '49.99'),
('FEDEX', 'One Day', '29.99'),
('FEDEX', 'Three Days', '9.99');

create table shirt_orders(
	shirt_orders_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	shirt_customers_id MEDIUMINT UNSIGNED NOT NULL,
	shirt_transactions_id INT UNSIGNED NOT NULL,
	shirt_shipping_addresses_id INT UNSIGNED NOT NULL,
	shirt_carriers_methods_id TINYINT UNSIGNED NOT NULL,
	shirt_billing_addresses_id INT UNSIGNED NOT NULL,
	credit_no CHAR(4) NOT NULL, 
	credit_type VARCHAR(20) NOT NULL, 
	order_total DECIMAL(7, 3) NOT NULL, 
	shipping_fee DECIMAL(6, 3) NOT NULL, 
	order_date TIMESTAMP NOT NULL, 
	shipping_date TIMESTAMP NOT NULL, 
	PRIMARY KEY(shirt_orders_id),
	INDEX ind_shirt_customers_id (shirt_customers_id),
	CONSTRAINT fk_shirt_customers_id FOREIGN KEY (shirt_customers_id) REFERENCES shirt_customers(shirt_customers_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_shirt_transactions_id (shirt_transactions_id),
	CONSTRAINT fk_shirt_transactions_id FOREIGN KEY (shirt_transactions_id) REFERENCES shirt_transactions(shirt_transactions_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_shirt_shipping_addresses_id (shirt_shipping_addresses_id),
	CONSTRAINT fk_shirt_shipping_addresses_id FOREIGN KEY (shirt_shipping_addresses_id) REFERENCES shirt_shipping_addresses(shirt_shipping_addresses_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_shirt_carriers_methods_id (shirt_carriers_methods_id),
	CONSTRAINT fk_shirt_carriers_methods_id FOREIGN KEY (shirt_carriers_methods_id) REFERENCES shirt_carriers_methods(shirt_carriers_methods_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_shirt_billing_addresses_id (shirt_billing_addresses_id),
	CONSTRAINT fk_shirt_billing_addresses_id FOREIGN KEY (shirt_billing_addresses_id) REFERENCES shirt_billing_addresses(shirt_billing_addresses_id)
	ON DELETE CASCADE on UPDATE CASCADE
) ENGINE = InnoDB;

create table shirt_categories(
	shirt_categories_id SMALLINT UNSIGNED NOT NULL AUTO_INCREMENT,
	category VARCHAR(100) NOT NULL,
	description VARCHAR(1000),
	PRIMARY KEY(shirt_categories_id)
) ENGINE = InnoDB;

create table shirt_sizes(
	shirt_sizes_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
	size VARCHAR(20) NOT NULL,
	PRIMARY KEY(shirt_sizes_id)
) ENGINE = InnoDB;

INSERT INTO shirt_sizes (size) VALUES
	('xxx-small'),
	('xx-small'),
	('x-small'),
	('small'),
	('medium'),
	('large'),
	('x-large'),
	('xx-large'),
	('xxx-large');
	
create table shirt_colors(
	shirt_colors_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
	keyword VARCHAR(20) NOT NULL,
	code VARCHAR(20) NOT NULL,
	PRIMARY KEY(shirt_colors_id)
) ENGINE = InnoDB;

INSERT INTO shirt_colors (keyword, code) VALUES
	('black', '#000000'),
	('white', '#ffffff'),
	('blue', '#0000FF'),
	('dark blue', '#0000A0'),
	('light blue', '#ADD8E6'),
	('red', '#FF0000'),
	('cyan', '#00FFFF'),
	('purple', '#800080'),
	('yellow', '#FFFF00'),
	('lime', '#00FF00'),
	('magenta', '#FF00FF'),
	('silver', '#C0C0C0'),
	('gray', '#808080'),
	('orange', '#FFA500'),
	('brown', '#A52A2A'),
	('maroon', '#800000'),
	('green', '#008000'),
	('olive', '#808000');

create table shirts(
	shirts_id MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT,
	shirt_categories_id SMALLINT UNSIGNED NOT NULL,
	shirt_sizes_id TINYINT UNSIGNED NOT NULL,
	shirt_colors_id TINYINT UNSIGNED NOT NULL,
	price DECIMAL(6,3) NOT NULL,
	photo VARCHAR(100),
	stock_quantity MEDIUMINT UNSIGNED NOT NULL,
	date_added TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(shirts_id),
	INDEX ind_shirt_categories_id (shirt_categories_id),
	CONSTRAINT fk_shirt_categories_id FOREIGN KEY (shirt_categories_id) REFERENCES shirt_categories(shirt_categories_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX fk_shirt_sizes_id (shirt_sizes_id),
	CONSTRAINT fk_shirt_sizes_id FOREIGN KEY (shirt_sizes_id) REFERENCES shirt_sizes(shirt_sizes_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_shirt_colors_id (shirt_colors_id),
	CONSTRAINT fk_shirt_colors_id FOREIGN KEY (shirt_colors_id) REFERENCES shirt_colors(shirt_colors_id)
	ON DELETE CASCADE on UPDATE CASCADE
) ENGINE = InnoDB;

create table shirt_orders_shirts(
	shirt_orders_shirts_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
	shirt_orders_id INT UNSIGNED NOT NULL,
	shirts_id MEDIUMINT UNSIGNED NOT NULL,
	quantity TINYINT UNSIGNED NOT NULL,
	price DECIMAL(7,3) NOT NULL,
	PRIMARY KEY(shirt_orders_shirts_id),
	INDEX ind_shirt_orders_id (shirt_orders_id),
	CONSTRAINT fk_shirt_orders_id FOREIGN KEY (shirt_orders_id) REFERENCES shirt_orders(shirt_orders_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_shirts_id (shirts_id),
	CONSTRAINT fk_shirts_id FOREIGN KEY (shirts_id) REFERENCES shirts(shirts_id)
	ON DELETE CASCADE on UPDATE CASCADE
) ENGINE = InnoDB;


create table shirt_carts(
	shirt_carts_id MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT,
	shirt_customers_id MEDIUMINT UNSIGNED NOT NULL, 
	shirts_id MEDIUMINT UNSIGNED NOT NULL, 
	quantity TINYINT UNSIGNED NOT NULL, 
	date_added TIMESTAMP NOT NULL, 
	date_modified TIMESTAMP NOT NULL, 
	PRIMARY KEY(shirt_carts_id),
	INDEX ind_shirt_customers_id (shirt_customers_id),
	CONSTRAINT fk_carts_shirt_customers_id FOREIGN KEY (shirt_customers_id) REFERENCES shirt_customers(shirt_customers_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_shirts_id (shirts_id),
	CONSTRAINT fk_carts_shirts_id FOREIGN KEY (shirts_id) REFERENCES shirts(shirts_id)
	ON DELETE CASCADE on UPDATE CASCADE
) ENGINE = InnoDB;

ALTER TABLE shirt_customers MODIFY COLUMN address_2 varchar(100);
ALTER TABLE shirt_shipping_addresses MODIFY COLUMN address_2 varchar(100);
ALTER TABLE shirt_billing_addresses MODIFY COLUMN address_2 varchar(100);


INSERT INTO shirt_customers (first_name, last_name, email, phone, password, address_1, address_2, city, shirt_states_id, zip, date_created) VALUES
	('David', 'Steel', 'dsteel@ysu.edu', '330-333-4444', 'mypassword', 'One University Plaza', 'Youngstown State University - Meshel Hall #123', 'Youngstown', 36, '44555', current_timestamp),
	('Mark', 'Jordan', 'mjordan@gmail.com', '330-444-5555', 'mypassword', '123 Main Street', '', 'Youngstown', 36, '44555', current_timestamp),
	('Mary', 'Alan', 'malan@yahoo.com', '330-555-6666', 'mypassword', '5068 South Avenue', '', 'Boardman', 36, '44512', current_timestamp);
	
INSERT INTO shirt_transactions (amount_charged, type, response_code, response_reason, response_text, date_created) VALUES
	(48.98, 'regular', '100', '', 'OK', current_timestamp),
	(22.98, 'regular', '100', '', 'OK', current_timestamp);

INSERT INTO shirt_shipping_addresses (address_1, address_2, city, shirt_states_id, zip, date_created) VALUES 
	('One University Plaza', 'Youngstown State University - Meshel Hall #123', 'Youngstown', 36, '44555', current_timestamp);

INSERT INTO shirt_billing_addresses (address_1, address_2, city, shirt_states_id, zip, date_created) VALUES
	('100 Lockwood Avenue', '', 'Canfield', 36, '44406', current_timestamp);	

INSERT INTO shirt_orders (shirt_customers_id, shirt_transactions_id, shirt_shipping_addresses_id, shirt_billing_addresses_id, shirt_carriers_methods_id, credit_no, credit_type, order_total, shipping_fee, shipping_date, order_date) VALUES
	(1, 1, 1, 1, 3, '4345', 'Visa', 43.99, 4.99, current_timestamp, current_timestamp),
	(1, 2, 1, 1, 4, '4345', 'Visa', 19.99, 2.99, current_timestamp, current_timestamp);
	
select * from shirt_customers;
select * from shirt_transactions;
select * from shirt_shipping_addresses;
select * from shirt_billing_addresses;
select * from shirt_orders;

SELECT first_name, last_name, credit_no, credit_type FROM shirt_customers, shirt_orders 
	WHERE shirt_customers.shirt_customers_id = shirt_orders.shirt_customers_id;

SELECT first_name, last_name, credit_no, credit_type FROM shirt_customers 
	INNER JOIN shirt_orders ON shirt_customers.shirt_customers_id = shirt_orders.shirt_customers_id;

SELECT first_name, last_name, credit_no, credit_type FROM shirt_customers 
	INNER JOIN shirt_orders USING (shirt_customers_id);
	
SELECT first_name, last_name, credit_no, credit_type, CONCAT_WS(' ', shirt_shipping_addresses.address_1, shirt_shipping_addresses.address_2, shirt_shipping_addresses.city, state, shirt_shipping_addresses.zip) as 'Shipping Address' FROM shirt_customers 
	INNER JOIN shirt_orders USING (shirt_customers_id)
	INNER JOIN shirt_shipping_addresses USING (shirt_shipping_addresses_id)
	INNER JOIN shirt_states ON shirt_shipping_addresses.shirt_states_id = shirt_states.shirt_states_id;

SELECT first_name, last_name, credit_no, credit_type, CONCAT_WS(' ', shirt_shipping_addresses.address_1, shirt_shipping_addresses.address_2, shirt_shipping_addresses.city, state, shirt_shipping_addresses.zip) as 'Shipping Address' FROM shirt_customers 
	LEFT JOIN shirt_orders USING (shirt_customers_id)
	LEFT JOIN shirt_shipping_addresses USING (shirt_shipping_addresses_id)
	LEFT JOIN shirt_states ON shirt_shipping_addresses.shirt_states_id = shirt_states.shirt_states_id 
	WHERE shirt_shipping_addresses.city = 'Youngstown'
	ORDER BY last_name ASC
	;
	
SELECT first_name, last_name, credit_no, credit_type, CONCAT_WS(' ', shirt_shipping_addresses.address_1, shirt_shipping_addresses.address_2, shirt_shipping_addresses.city, state, shirt_shipping_addresses.zip) as 'Shipping Address' FROM shirt_states 
	RIGHT JOIN shirt_shipping_addresses ON shirt_shipping_addresses.shirt_states_id = shirt_states.shirt_states_id 
	RIGHT JOIN shirt_orders USING (shirt_shipping_addresses_id)
	RIGHT JOIN shirt_customers USING (shirt_customers_id);
	
INSERT INTO shirt_categories (category, description) 
	VALUES
	('T-Shirt', 'A unisex cotton shirt with a scoop neck and short sleeves.'),
	('3/4 Tee', 'The same as a t-shirt, except the sleeves go down to the mid forearm'),
	('Long-Sleeve Tee', 'The same as a t-shirt, except the sleeves extend to the wrists.'),
	('Sleeveless Tee', 'The same as the t-shirt, sans the sleeves.'),
	('V-neck Tee', 'The same as the t-shirt, except the neck is shaved as a V instead of a traditional scoop.'),
	('Sweatshirt', 'The same as a Long-Sleeve Tee, made with a thicker, warmer cotton.'),

SELECT * from shirt_categories;

INSERT INTO shirts (shirt_categories_id, photo, stock_quantity, price, date_added, shirt_sizes_id, shirt_colors_id)
	VALUES
	(1, '../images/t-shirt.jpeg', 38, 29.99, current_timestamp(), 4, 18),
	(2, '../images/long-sleeve-t-shirt.jpeg', 38, 29.99, current_timestamp(), 4, 18),
	(3, '../images/34-sleeve-t-shirt.jpeg', 38, 29.99, current_timestamp(), 4, 18),
	(4, '../images/vneck-t-shirt.jpeg', 38, 29.99, current_timestamp(), 4, 18),
	(5, '../images/tanktop.jpeg', 38, 29.99, current_timestamp(), 4, 18),
	(6, '../images/sweatshirt.jpg', 38, 29.99, current_timestamp(), 4, 18),

SELECT * FROM shirts;
	
INSERT INTO shirt_orders_shirts (shirt_orders_id, shirts_id, quantity, price)
	VALUES
	(3, 1, 1, 29.99),
	(3, 2, 1, 29.99),
	(4, 3, 1, 29.99);
	
/*View User Account Info including 
first_name, last_name, email, phone, address, date_created*/

SELECT first_name, last_name, email, phone, CONCAT_WS(' ',address_1, address_2, city, abbr, zip) as address, date_created
	from shirt_customers 
	INNER JOIN shirt_states USING(shirt_states_id);

/*View Available shirts including
category, size, color, price, photo*/

SELECT category, description, size, keyword, code, price, stock_quantity, date_added, photo
	FROM shirts
	INNER JOIN shirt_categories USING (shirt_categories_id)
	INNER JOIN shirt_sizes USING (shirt_sizes_id)
	INNER JOIN shirt_colors USING (shirt_colors_id)
	ORDER BY $order_by $asc_desc;

/*
View previous orders including
category, size, color, price, photo, shipping address, billing address, credit_card, shipping_date, order_date, order_total, shipping_cost
*/

SELECT shirt_orders_shirts.shirt_orders_id, CONCAT_WS(' ',shirt_shipping_addresses.address_1, shirt_shipping_addresses.address_2, shirt_shipping_addresses.city, state, shirt_shipping_addresses.zip) as 'Shipping Address', CONCAT_WS(' ',shirt_billing_addresses.address_1, shirt_billing_addresses.address_2, shirt_billing_addresses.city, state, shirt_billing_addresses.zip) as 'Billing Address', GROUP_CONCAT(category SEPARATOR '<br><hr>') as category, GROUP_CONCAT(size SEPARATOR '<br><hr>') as size, GROUP_CONCAT(keyword SEPARATOR '<br><hr>') as keyword, GROUP_CONCAT(shirt_orders_shirts.quantity SEPARATOR '<br><hr>') as quantity, GROUP_CONCAT(shirt_orders_shirts.price SEPARATOR '<br><hr>') as price, credit_no, credit_type, order_total, shipping_fee, order_date, shipping_date
	FROM shirt_customers
	INNER JOIN shirt_states USING (shirt_states_id)
	INNER JOIN shirt_orders USING (shirt_customers_id)
	INNER JOIN shirt_shipping_addresses USING (shirt_shipping_addresses_id)
	INNER JOIN shirt_billing_addresses USING (shirt_billing_addresses_id)
	INNER JOIN shirt_orders_shirts USING (shirt_orders_id)
	INNER JOIN shirts USING (shirts_id)
	INNER JOIN shirt_categories USING (shirt_categories_id)
	INNER JOIN shirt_sizes USING (shirt_sizes_id)
	INNER JOIN shirt_colors USING (shirt_colors_id)
	WHERE shirt_customers_id = 1
	GROUP BY shirt_orders_shirts.shirt_orders_id
	ORDER BY $order_by $asc_desc;

/* Update shirt_colors table */

UPDATE shirt_colors set code = '#800080' WHERE shirt_colors_id = 8;
UPDATE shirt_colors set code = '#FFFF00' WHERE shirt_colors_id = 9; 
UPDATE shirt_colors set code = '#00FF00' WHERE shirt_colors_id = 10;
UPDATE shirt_colors set code = '#FF00FF' WHERE shirt_colors_id = 11;
UPDATE shirt_colors set code = '#C0C0C0' WHERE shirt_colors_id = 12;
UPDATE shirt_colors set code = '#808080' WHERE shirt_colors_id = 13;
UPDATE shirt_colors set code = '#FFA500' WHERE shirt_colors_id = 14;
UPDATE shirt_colors set code = '#A52A2A' WHERE shirt_colors_id = 15;
UPDATE shirt_colors set code = '#800000' WHERE shirt_colors_id = 16;
UPDATE shirt_colors set code = '#008000' WHERE shirt_colors_id = 17;
UPDATE shirt_colors set code = '#808000' WHERE shirt_colors_id = 18; 
	
/*
 = equal to 
 != not equal to
 < less than
 > greater than
 <= less than or equal to
 >= greater than or equal to
 IS NULL
 IS NOT NULL 
 BETWEEN
 NOT BETWEEN
 IN
 
 Logical operators
 AND / &&
 OR / ||
 
 LIKE NOT LIKE -> _ and % 
 _ one single character of anything
 % 0 or more of any character
 select first_name, last_name from shirt_customers where first_name LIKE 'A___' ORDER BY last_name asc;
 select first_name, last_name from shirt_customers where first_name LIKE 'A%' order by first_name asc, last_name DESC;
 select state, abbr from shirt_states order by state asc limit 5;
 UPDATE shirt_customers SET first_name = 'David' WHERE shirt_customers_id = 1;
 DELETE from shirt_customers WHERE shirt_customers_id = 1 LIMIT 1; 
 
 
 */
 
