CREATE TABLE products (
	product_id INT PRIMARY KEY,
	product_name VARCHAR(100) NOT NULL);

CREATE TABLE categories (
	category_id INT PRIMARY KEY,
	category_name VARCHAR(150) NOT NULL);

CREATE TABLE prod_cat (
	id_prod INT REFERENCES products (product_id) NOT NULL,
	id_cat INT REFERENCES categories (category_id) NOT NULL);

INSERT INTO products VALUES 
	(1, '����'),
	(2, '������'),
	(3, '�����'),
	(4, '�����������'),
	(5, '������������� ����'),
	(6, '������'),
	(7, '�������'),
	(8, '������'),
	(9, '������'),
	(10, '��������� �����'),
	(11, '�����'),
	(12, '��������'),
	(13, '�����'),
	(14, '�������'),
	(15, '�������'),
	(16, '��������� �������'),
	(17, '���������')

INSERT INTO categories VALUES 
	(1, '�������� �������'),
	(2, '�������������� �������'),
	(3, '������'),
	(4, '������������ ������'),
	(5, '������������ �����������')

INSERT INTO prod_cat VALUES 
	(1, 1),
	(2, 1),
	(3, 1),
	(4, 2),
	(5, 2),
	(6, 2),
	(7, 3),
	(8, 3),
	(9, 3),
	(10, 4),
	(11, 4),
	(11, 5),
	(12, 4),
	(13, 5),
	(14, 5),
	(15, 5)

--������ ��� ������ ���� ��� ���� �������� � ��� ���������.
SELECT products.product_name AS "��� ��������", categories.category_name AS "��� ���������"
FROM products 
LEFT JOIN prod_cat
ON products.product_id = prod_cat.id_prod
LEFT JOIN categories
ON prod_cat.id_cat = categories.category_id