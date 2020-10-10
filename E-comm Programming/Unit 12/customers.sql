USE ecommerce_online;


CREATE TABLE hat_states (
	hat_states_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
	state VARCHAR(30) NOT NULL,
	abbr CHAR(2) NOT NULL,
	PRIMARY KEY (hat_states_id)
) ENGINE = InnoDB;

INSERT INTO hat_states(state, abbr) VALUES
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

CREATE TABLE hat_customers (
	hat_customers_id MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT, 
	first_name VARCHAR(30) NOT NULL,
	last_name VARCHAR(30) NOT NULL,
	email VARCHAR(40) NOT NULL,
	phone VARCHAR(20) NOT NULL,
	password CHAR(255) NOT NULL,
	address_1 VARCHAR(100) NOT NULL,
	address_2 VARCHAR(100),
	city VARCHAR(50) NOT NULL,
	hat_states_id TINYINT UNSIGNED NOT NULL,
	zip CHAR(5) NOT NULL,
	date_created TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(hat_customers_id),
	INDEX ind_hat_states_id (hat_states_id),
	CONSTRAINT fk_hat_states_id FOREIGN KEY (hat_states_id) REFERENCES hat_states(hat_states_id) ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE = InnoDB;

create table hat_transactions(
	hat_transactions_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	amount_charged DECIMAL(6, 3) NOT NULL, 
	type VARCHAR(100) NOT NULL, 
	response_code VARCHAR(200) NOT NULL, 
	response_reason VARCHAR(200) NOT NULL, 
	response_text VARCHAR(400) NOT NULL, 
	date_created TIMESTAMP NOT NULL, 
	PRIMARY KEY(hat_transactions_id)
) ENGINE = InnoDB;

create table hat_shipping_addresses(
	hat_shipping_addresses_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	address_1 VARCHAR(100) NOT NULL, 
	address_2 VARCHAR(100), 
	city VARCHAR(50) NOT NULL, 
	hat_states_id TINYINT UNSIGNED NOT NULL, 
	zip CHAR(5) NOT NULL, 
	date_created TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(hat_shipping_addresses_id)
) ENGINE = InnoDB;

create table hat_billing_addresses(
	hat_billing_addresses_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	address_1 VARCHAR(100) NOT NULL, 
	address_2 VARCHAR(100), 
	city VARCHAR(50) NOT NULL, 
	hat_states_id TINYINT UNSIGNED NOT NULL, 
	zip CHAR(5) NOT NULL, 
	date_created TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(hat_billing_addresses_id)
) ENGINE = InnoDB;

create table hat_carriers_methods(
	hat_carriers_methods_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
	carrier VARCHAR(50) NOT NULL, 
	method VARCHAR(50) NOT NULL, 
	fee DECIMAL(6, 3) NOT NULL, 
	PRIMARY KEY(hat_carriers_methods_id)
) ENGINE = InnoDB;

INSERT INTO hat_carriers_methods (carrier, method, fee) VALUES 
('UPS', 'Ground', '4.99'),
('UPS', 'Express', '9.99'),
('USPS', 'Standard', '3.99'),
('USPS', 'Expedited', '6.99'),
('FEDEX', 'Same Day', '49.99'),
('FEDEX', 'One Day', '29.99'),
('FEDEX', 'Three Days', '9.99');

create table hat_orders(
	hat_orders_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	hat_customers_id MEDIUMINT UNSIGNED NOT NULL,
	hat_transactions_id INT UNSIGNED NOT NULL,
	hat_shipping_addresses_id INT UNSIGNED NOT NULL,
	hat_carriers_methods_id TINYINT UNSIGNED NOT NULL,
	hat_billing_addresses_id INT UNSIGNED NOT NULL,
	credit_no CHAR(4) NOT NULL, 
	credit_type VARCHAR(20) NOT NULL, 
	order_total DECIMAL(7, 3) NOT NULL, 
	shipping_fee DECIMAL(6, 3) NOT NULL, 
	order_date TIMESTAMP NOT NULL, 
	shipping_date TIMESTAMP NOT NULL, 
	PRIMARY KEY(hat_orders_id),
	INDEX ind_hat_customers_id (hat_customers_id),
	CONSTRAINT fk_hat_customers_id FOREIGN KEY (hat_customers_id) REFERENCES hat_customers(hat_customers_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_hat_transactions_id (hat_transactions_id),
	CONSTRAINT fk_hat_transactions_id FOREIGN KEY (hat_transactions_id) REFERENCES hat_transactions(hat_transactions_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_hat_shipping_addresses_id (hat_shipping_addresses_id),
	CONSTRAINT fk_hat_shipping_addresses_id FOREIGN KEY (hat_shipping_addresses_id) REFERENCES hat_shipping_addresses(hat_shipping_addresses_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_hat_carriers_methods_id (hat_carriers_methods_id),
	CONSTRAINT fk_hat_carriers_methods_id FOREIGN KEY (hat_carriers_methods_id) REFERENCES hat_carriers_methods(hat_carriers_methods_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_hat_billing_addresses_id (hat_billing_addresses_id),
	CONSTRAINT fk_hat_billing_addresses_id FOREIGN KEY (hat_billing_addresses_id) REFERENCES hat_billing_addresses(hat_billing_addresses_id)
	ON DELETE CASCADE on UPDATE CASCADE
) ENGINE = InnoDB;

create table hat_categories(
	hat_categories_id SMALLINT UNSIGNED NOT NULL AUTO_INCREMENT,
	category VARCHAR(100) NOT NULL,
	description VARCHAR(1000),
	PRIMARY KEY(hat_categories_id)
) ENGINE = InnoDB;

create table hat_sizes(
	hat_sizes_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
	size VARCHAR(20) NOT NULL,
	PRIMARY KEY(hat_sizes_id)
) ENGINE = InnoDB;

INSERT INTO hat_sizes (size) VALUES
	('xxx-small'),
	('xx-small'),
	('x-small'),
	('small'),
	('medium'),
	('large'),
	('x-large'),
	('xx-large'),
	('xxx-large');
	
create table hat_colors(
	hat_colors_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
	keyword VARCHAR(20) NOT NULL,
	code VARCHAR(20) NOT NULL,
	PRIMARY KEY(hat_colors_id)
) ENGINE = InnoDB;

INSERT INTO hat_colors (keyword, code) VALUES
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

create table hats(
	hats_id MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT,
	hat_categories_id SMALLINT UNSIGNED NOT NULL,
	hat_sizes_id TINYINT UNSIGNED NOT NULL,
	hat_colors_id TINYINT UNSIGNED NOT NULL,
	price DECIMAL(6,3) NOT NULL,
	photo VARCHAR(100),
	stock_quantity MEDIUMINT UNSIGNED NOT NULL,
	date_added TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(hats_id),
	INDEX ind_hat_categories_id (hat_categories_id),
	CONSTRAINT fk_hat_categories_id FOREIGN KEY (hat_categories_id) REFERENCES hat_categories(hat_categories_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX fk_hat_sizes_id (hat_sizes_id),
	CONSTRAINT fk_hat_sizes_id FOREIGN KEY (hat_sizes_id) REFERENCES hat_sizes(hat_sizes_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_hat_colors_id (hat_colors_id),
	CONSTRAINT fk_hat_colors_id FOREIGN KEY (hat_colors_id) REFERENCES hat_colors(hat_colors_id)
	ON DELETE CASCADE on UPDATE CASCADE
) ENGINE = InnoDB;

create table hat_orders_hats(
	hat_orders_hats_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
	hat_orders_id INT UNSIGNED NOT NULL,
	hats_id MEDIUMINT UNSIGNED NOT NULL,
	quantity TINYINT UNSIGNED NOT NULL,
	price DECIMAL(7,3) NOT NULL,
	PRIMARY KEY(hat_orders_hats_id),
	INDEX ind_hat_orders_id (hat_orders_id),
	CONSTRAINT fk_hat_orders_id FOREIGN KEY (hat_orders_id) REFERENCES hat_orders(hat_orders_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_hats_id (hats_id),
	CONSTRAINT fk_hats_id FOREIGN KEY (hats_id) REFERENCES hats(hats_id)
	ON DELETE CASCADE on UPDATE CASCADE
) ENGINE = InnoDB;


create table hat_carts(
	hat_carts_id MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT,
	hat_customers_id MEDIUMINT UNSIGNED NOT NULL, 
	hats_id MEDIUMINT UNSIGNED NOT NULL, 
	quantity TINYINT UNSIGNED NOT NULL, 
	date_added TIMESTAMP NOT NULL, 
	date_modified TIMESTAMP NOT NULL, 
	PRIMARY KEY(hat_carts_id),
	INDEX ind_hat_customers_id (hat_customers_id),
	CONSTRAINT fk_carts_hat_customers_id FOREIGN KEY (hat_customers_id) REFERENCES hat_customers(hat_customers_id)
	ON DELETE CASCADE on UPDATE CASCADE,
	INDEX ind_hats_id (hats_id),
	CONSTRAINT fk_carts_hats_id FOREIGN KEY (hats_id) REFERENCES hats(hats_id)
	ON DELETE CASCADE on UPDATE CASCADE
) ENGINE = InnoDB;

ALTER TABLE hat_customers MODIFY COLUMN address_2 varchar(100);
ALTER TABLE hat_shipping_addresses MODIFY COLUMN address_2 varchar(100);
ALTER TABLE hat_billing_addresses MODIFY COLUMN address_2 varchar(100);


INSERT INTO hat_customers (first_name, last_name, email, phone, password, address_1, address_2, city, hat_states_id, zip, date_created) VALUES
	('David', 'Steel', 'dsteel@ysu.edu', '330-333-4444', 'mypassword', 'One University Plaza', 'Youngstown State University - Meshel Hall #123', 'Youngstown', 36, '44555', current_timestamp),
	('Mark', 'Jordan', 'mjordan@gmail.com', '330-444-5555', 'mypassword', '123 Main Street', '', 'Youngstown', 36, '44555', current_timestamp),
	('Mary', 'Alan', 'malan@yahoo.com', '330-555-6666', 'mypassword', '5068 South Avenue', '', 'Boardman', 36, '44512', current_timestamp);
	
INSERT INTO hat_transactions (amount_charged, type, response_code, response_reason, response_text, date_created) VALUES
	(48.98, 'regular', '100', '', 'OK', current_timestamp),
	(22.98, 'regular', '100', '', 'OK', current_timestamp);

INSERT INTO hat_shipping_addresses (address_1, address_2, city, hat_states_id, zip, date_created) VALUES 
	('One University Plaza', 'Youngstown State University - Meshel Hall #123', 'Youngstown', 36, '44555', current_timestamp);

INSERT INTO hat_billing_addresses (address_1, address_2, city, hat_states_id, zip, date_created) VALUES
	('100 Lockwood Avenue', '', 'Canfield', 36, '44406', current_timestamp);	

INSERT INTO hat_orders (hat_customers_id, hat_transactions_id, hat_shipping_addresses_id, hat_billing_addresses_id, hat_carriers_methods_id, credit_no, credit_type, order_total, shipping_fee, shipping_date, order_date) VALUES
	(1, 1, 1, 1, 3, '4345', 'Visa', 43.99, 4.99, current_timestamp, current_timestamp),
	(1, 2, 1, 1, 4, '4345', 'Visa', 19.99, 2.99, current_timestamp, current_timestamp);
	
select * from hat_customers;
select * from hat_transactions;
select * from hat_shipping_addresses;
select * from hat_billing_addresses;
select * from hat_orders;

SELECT first_name, last_name, credit_no, credit_type FROM hat_customers, hat_orders 
	WHERE hat_customers.hat_customers_id = hat_orders.hat_customers_id;

SELECT first_name, last_name, credit_no, credit_type FROM hat_customers 
	INNER JOIN hat_orders ON hat_customers.hat_customers_id = hat_orders.hat_customers_id;

SELECT first_name, last_name, credit_no, credit_type FROM hat_customers 
	INNER JOIN hat_orders USING (hat_customers_id);
	
SELECT first_name, last_name, credit_no, credit_type, CONCAT_WS(' ', hat_shipping_addresses.address_1, hat_shipping_addresses.address_2, hat_shipping_addresses.city, state, hat_shipping_addresses.zip) as 'Shipping Address' FROM hat_customers 
	INNER JOIN hat_orders USING (hat_customers_id)
	INNER JOIN hat_shipping_addresses USING (hat_shipping_addresses_id)
	INNER JOIN hat_states ON hat_shipping_addresses.hat_states_id = hat_states.hat_states_id;

SELECT first_name, last_name, credit_no, credit_type, CONCAT_WS(' ', hat_shipping_addresses.address_1, hat_shipping_addresses.address_2, hat_shipping_addresses.city, state, hat_shipping_addresses.zip) as 'Shipping Address' FROM hat_customers 
	LEFT JOIN hat_orders USING (hat_customers_id)
	LEFT JOIN hat_shipping_addresses USING (hat_shipping_addresses_id)
	LEFT JOIN hat_states ON hat_shipping_addresses.hat_states_id = hat_states.hat_states_id 
	WHERE hat_shipping_addresses.city = 'Youngstown'
	ORDER BY last_name ASC
	;
	
SELECT first_name, last_name, credit_no, credit_type, CONCAT_WS(' ', hat_shipping_addresses.address_1, hat_shipping_addresses.address_2, hat_shipping_addresses.city, state, hat_shipping_addresses.zip) as 'Shipping Address' FROM hat_states 
	RIGHT JOIN hat_shipping_addresses ON hat_shipping_addresses.hat_states_id = hat_states.hat_states_id 
	RIGHT JOIN hat_orders USING (hat_shipping_addresses_id)
	RIGHT JOIN hat_customers USING (hat_customers_id);
	
INSERT INTO hat_categories (category, description) 
	VALUES
	('Ascot Cap', 'A hard style of hat, usually worn by men, dating back to the 1900s. Sometimes associated with livestock slaughter.'),
	('Akubra', 'An Australian brand of bush hat, whose wide-brimmed styles are a distinctive part of Australian culture, especially in rural areas'),
	('Ayam', 'A traditional Korean winter cap mostly worn by women in the Joseon and Daehan Jeguk periods (1392–1910).'),
	('Balaclava', 'Headgear, usually made from fabric such as cotton and/or polyester, that covers the whole head, exposing only the face or part of it. Sometimes only the eyes or eyes and mouth are visible. Also known as a ski mask.'),
	('Barretina', 'A floppy fabric pull-on hat, usually worn with its top flopped down. In red, it is now used as a symbol of Catalan identity.'),
	('Baseball Cap', 'A type of soft, light cotton cap with a rounded crown and a stiff, frontward-projecting bill.'),
	('Bearskin', 'The tall, furry hat of the Brigade of Guards\' full-dress uniform, originally designed to protect them against sword-cuts, etc. Commonly seen at Buckingham Palace in London, England. Sometimes mistakenly identified as a busby.'),
	('Beret', 'A soft round cap, usually of woollen felt, with a bulging flat crown and tight-fitting brimless headband. Worn by both men and women and traditionally associated with Basque people, France, and the military. Often part of [European?] schoolgirls\' uniform during the 1920s, \'30s and \'40s.'),
	('Bicorne', 'A broad-brimmed felt hat with brim folded up and pinned front and back to create a long-horned shape. Also known as a cocked hat. Worn by European military officers in the 1790s and, as illustrated, commonly associated with Napoleon.'),
	('Boater', 'A flat-brimmed and flat-topped straw hat formerly worn by seamen. Schools, especially public schools in the UK, might include a boater as part of their (summer) uniform. Now mostly worn at summer regattas or formal garden parties, often with a ribbon in club, college or school colors.'),
	('Bowler', 'A hard felt hat with a rounded crown created in 1850 by Lock\'s of St James\'s, the hatters to Thomas Coke, 2nd Earl of Leicester, for his servants. More commonly known as a Derby in the United States.'),
	('Breton', 'A woman\'s hat with round crown and deep brim turned upwards all the way round. Said to be based on hats worn by Breton agricultural workers.'),
	('Bucket Hat', 'A soft cotton hat with a wide, downwards-sloping brim'),
	('Campaign Hat', 'Also known as a "Smokey Bear" hat. A broad-brimmed felt or straw hat with high crown, pinched symmetrically at its four corners (the \"Montana crease\").'),
	('Capotain', 'A hat worn between the 1590s and 1640s in England and northwestern Europe. Also known as a \"Pilgrim hat\" in the United States.'),
	('Chullo', 'Peruvian or Bolivian hat with ear-flaps made from vicuña, alpaca, llama or sheep\'s wool.'),
	('Cloche Hat', 'A bell-shaped ladies\' hat that was popular during the Roaring Twenties.'),
	('Cricket Cap', 'A type of soft cap traditionally worn by cricket players.'),
	('Fedora', 'A soft felt hat with a medium brim and lengthwise crease in the crown.'),
	('Fez', 'Red felt hat in the shape of a truncated cone, common to Arab-speaking countries.'),
	('Flat Cap', 'A soft, round wool or tweed men\'s cap with a small bill in front.');

SELECT * from hat_categories;

INSERT INTO hats (hat_categories_id, photo, stock_quantity, price, date_added, hat_sizes_id, hat_colors_id)
	VALUES
	(1, '../images/ascot_cap.jpg', 38, 29.99, current_timestamp(), 4, 18),
	(5, '../images/barretina.jpg', 127, 9.99,current_timestamp(), 5, 6),
	(10, '../images/boater.jpg', 499, 39.99, current_timestamp(), 3, 2);

SELECT * FROM hats;
	
INSERT INTO hat_orders_hats (hat_orders_id, hats_id, quantity, price)
	VALUES
	(3, 1, 1, 19.99),
	(3, 2, 1, 24.99),
	(4, 3, 1, 19.99);
	
/*View User Account Info including 
first_name, last_name, email, phone, address, date_created*/

SELECT first_name, last_name, email, phone, CONCAT_WS(' ',address_1, address_2, city, abbr, zip) as address, date_created
	from hat_customers 
	INNER JOIN hat_states USING(hat_states_id);

/*View Available Hats including
category, size, color, price, photo*/

SELECT category, description, size, keyword, code, price, stock_quantity, date_added, photo
	FROM hats
	INNER JOIN hat_categories USING (hat_categories_id)
	INNER JOIN hat_sizes USING (hat_sizes_id)
	INNER JOIN hat_colors USING (hat_colors_id)
	ORDER BY $order_by $asc_desc;

/*
View previous orders including
category, size, color, price, photo, shipping address, billing address, credit_card, shipping_date, order_date, order_total, shipping_cost
*/

SELECT hat_orders_hats.hat_orders_id, CONCAT_WS(' ',hat_shipping_addresses.address_1, hat_shipping_addresses.address_2, hat_shipping_addresses.city, state, hat_shipping_addresses.zip) as 'Shipping Address', CONCAT_WS(' ',hat_billing_addresses.address_1, hat_billing_addresses.address_2, hat_billing_addresses.city, state, hat_billing_addresses.zip) as 'Billing Address', GROUP_CONCAT(category SEPARATOR '<br><hr>') as category, GROUP_CONCAT(size SEPARATOR '<br><hr>') as size, GROUP_CONCAT(keyword SEPARATOR '<br><hr>') as keyword, GROUP_CONCAT(hat_orders_hats.quantity SEPARATOR '<br><hr>') as quantity, GROUP_CONCAT(hat_orders_hats.price SEPARATOR '<br><hr>') as price, credit_no, credit_type, order_total, shipping_fee, order_date, shipping_date
	FROM hat_customers
	INNER JOIN hat_states USING (hat_states_id)
	INNER JOIN hat_orders USING (hat_customers_id)
	INNER JOIN hat_shipping_addresses USING (hat_shipping_addresses_id)
	INNER JOIN hat_billing_addresses USING (hat_billing_addresses_id)
	INNER JOIN hat_orders_hats USING (hat_orders_id)
	INNER JOIN hats USING (hats_id)
	INNER JOIN hat_categories USING (hat_categories_id)
	INNER JOIN hat_sizes USING (hat_sizes_id)
	INNER JOIN hat_colors USING (hat_colors_id)
	WHERE hat_customers_id = 1
	GROUP BY hat_orders_hats.hat_orders_id
	ORDER BY $order_by $asc_desc;

/* Update hat_colors table */

UPDATE hat_colors set code = '#800080' WHERE hat_colors_id = 8;
UPDATE hat_colors set code = '#FFFF00' WHERE hat_colors_id = 9; 
UPDATE hat_colors set code = '#00FF00' WHERE hat_colors_id = 10;
UPDATE hat_colors set code = '#FF00FF' WHERE hat_colors_id = 11;
UPDATE hat_colors set code = '#C0C0C0' WHERE hat_colors_id = 12;
UPDATE hat_colors set code = '#808080' WHERE hat_colors_id = 13;
UPDATE hat_colors set code = '#FFA500' WHERE hat_colors_id = 14;
UPDATE hat_colors set code = '#A52A2A' WHERE hat_colors_id = 15;
UPDATE hat_colors set code = '#800000' WHERE hat_colors_id = 16;
UPDATE hat_colors set code = '#008000' WHERE hat_colors_id = 17;
UPDATE hat_colors set code = '#808000' WHERE hat_colors_id = 18; 

ALTER table hat_carriers_methods add column fee decimal(6, 3) not null; 
UPDATE hat_carriers_methods set fee = '4.99' WHERE hat_carriers_methods_id = 1;
UPDATE hat_carriers_methods set fee = '9.99' WHERE hat_carriers_methods_id = 2;
UPDATE hat_carriers_methods set fee = '3.99' WHERE hat_carriers_methods_id = 3;
UPDATE hat_carriers_methods set fee = '6.99' WHERE hat_carriers_methods_id = 4;
UPDATE hat_carriers_methods set fee = '49.99' WHERE hat_carriers_methods_id = 5;
UPDATE hat_carriers_methods set fee = '29.99' WHERE hat_carriers_methods_id = 6;
UPDATE hat_carriers_methods set fee = '9.99' WHERE hat_carriers_methods_id = 7;

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
 select first_name, last_name from hat_customers where first_name LIKE 'A___' ORDER BY last_name asc;
 select first_name, last_name from hat_customers where first_name LIKE 'A%' order by first_name asc, last_name DESC;
 select state, abbr from hat_states order by state asc limit 5;
 UPDATE hat_customers SET first_name = 'David' WHERE hat_customers_id = 1;
 DELETE from hat_customers WHERE hat_customers_id = 1 LIMIT 1; 
 
 
 */
 
