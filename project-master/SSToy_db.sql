CREATE DATABASE SSToy_db;
USE SSToy_db;

CREATE TABLE department (
    deptID CHAR(3) NOT NULL,
    deptName VARCHAR(15) NULL,
    CONSTRAINT dept_pk PRIMARY KEY (deptID)
);

INSERT INTO department VALUES 
('D01', 'Sales'),
('D02', 'Logistics'),
('D03', 'Production'),
('D04', 'Marketing'),
('D05', 'Finance'),
('D06', 'HR'),
('D07', 'IT'),
('D08', 'R&D'),
('D09', 'Quality'),
('D10', 'Support');

CREATE TABLE staff (
    staffID CHAR(6) NOT NULL,
    staffName VARCHAR(20) NOT NULL,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(15) NOT NULL,
    DoB DATE NULL,
    address VARCHAR(100) NULL,
    phoneNo INT NULL,
    title VARCHAR(15) NULL,
    deptID CHAR(3) NOT NULL,
    CONSTRAINT staff_pk PRIMARY KEY (staffID),
    CONSTRAINT staff_dept_fk FOREIGN KEY (deptID) REFERENCES department (deptID)
);

INSERT INTO staff VALUES 
('S00001', 'John Lee', 'johnlee', 'pass123', '1985-03-15', '123 King St, Kowloon, HK', 91234567, 'Sales Manager', 'D01'),
('S00002', 'Mary Chan', 'marychan', 'pass456', '1990-07-22', '456 Queen Rd, NT, HK', 98765432, 'Logistics Officer', 'D02'),
('S00003', 'Peter Wong', 'peterwong', 'pass789', '1988-11-30', '789 Prince Ave, HK', 87654321, 'Production Head', 'D03'),
('S00004', 'Sarah Lam', 'sarahlam', 'pass101', '1992-05-10', '101 Happy Rd, HK', 92345678, 'Sales Rep', 'D01'),
('S00005', 'Tom Ng', 'tomng', 'pass202', '1987-09-25', '202 Joy St, Kowloon, HK', 93456789, 'Warehouse Manager', 'D02'),
('S00006', 'Emily Ho', 'emilyho', 'pass303', '1991-12-12', '303 Peace Ave, NT, HK', 94567890, 'Designer', 'D03'),
('S00007', 'David Cheung', 'davidcheung', 'pass404', '1986-04-18', '404 Unity Rd, HK', 95678901, 'Marketing Lead', 'D04'),
('S00008', 'Lisa Kwok', 'lisakwok', 'pass505', '1993-08-30', '505 Harmony St, Kowloon, HK', 96789012, 'Finance Officer', 'D05'),
('S00009', 'Michael Lau', 'michaellau', 'pass606', '1989-06-15', '606 Victory Rd, HK', 97890123, 'HR Manager', 'D06'),
('S00010', 'Amy Tsang', 'amytsang', 'pass707', '1994-02-20', '707 Freedom St, NT, HK', 98901234, 'IT Specialist', 'D07');

CREATE TABLE users (
    userID CHAR(6) NOT NULL,
    deptID CHAR(3) NOT NULL,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(15) NOT NULL,
    CONSTRAINT user_pk PRIMARY KEY (userID, deptID),
    CONSTRAINT user_staff_fk FOREIGN KEY (userID) REFERENCES staff (staffID),
    CONSTRAINT user_dept_fk FOREIGN KEY (deptID) REFERENCES department (deptID)
);

INSERT INTO users VALUES 
('S00001', 'D01', 'johnlee', 'pass123'),
('S00002', 'D02', 'marychan', 'pass456'),
('S00003', 'D03', 'peterwong', 'pass789'),
('S00004', 'D01', 'sarahlam', 'pass101'),
('S00005', 'D02', 'tomng', 'pass202'),
('S00006', 'D03', 'emilyho', 'pass303'),
('S00007', 'D04', 'davidcheung', 'pass404'),
('S00008', 'D05', 'lisakwok', 'pass505'),
('S00009', 'D06', 'michaellau', 'pass606'),
('S00010', 'D07', 'amytsang', 'pass707');

CREATE TABLE productList (
    productID CHAR(8) NOT NULL,
    productName VARCHAR(20) NOT NULL,
    price INT NULL,
    target VARCHAR(10) NULL,
    CONSTRAINT product_pk PRIMARY KEY (productID)
);

INSERT INTO productList VALUES 
('PROD0001', 'AI Robot Cat', 499, '8-12'),
('PROD0002', 'Wooden Truck', 20, '3-6'),
('PROD0003', 'Puzzle Cube', 15, '6-10'),
('PROD0004', 'Doll House', 99, '4-8'),
('PROD0005', 'Remote Car', 59, '7-12'),
('PROD0006', 'Building Blocks', 25, '3-7'),
('PROD0007', 'Toy Train', 39, '4-9'),
('PROD0008', 'Action Figure', 29, '6-12'),
('PROD0009', 'Board Game', 35, '8-14'),
('PROD0010', 'Musical Toy', 45, '3-8');

CREATE TABLE productRequirement (
    requirementID CHAR(10) NOT NULL,
    productID CHAR(8) NOT NULL,
    requirementDetails VARCHAR(500) NULL,
    createdDate DATE NOT NULL,
    status VARCHAR(15) NULL,
    CONSTRAINT pr_pk PRIMARY KEY (requirementID),
    CONSTRAINT pr_product_fk FOREIGN KEY (productID) REFERENCES productList (productID)
);

INSERT INTO productRequirement VALUES 
('REQ0000001', 'PROD0001', 'Add voice activation', '2025-04-01', 'Pending'),
('REQ0000002', 'PROD0002', 'Eco-friendly paint', '2025-04-02', 'Approved'),
('REQ0000003', 'PROD0003', 'Non-toxic materials', '2025-04-03', 'In Review'),
('REQ0000004', 'PROD0004', 'Larger windows', '2025-04-04', 'Pending'),
('REQ0000005', 'PROD0005', 'Faster motor', '2025-04-05', 'Approved'),
('REQ0000006', 'PROD0006', 'More block shapes', '2025-04-06', 'In Review'),
('REQ0000007', 'PROD0007', 'Add sound effects', '2025-04-07', 'Pending'),
('REQ0000008', 'PROD0008', 'Flexible joints', '2025-04-08', 'Approved'),
('REQ0000009', 'PROD0009', 'Add expansion pack', '2025-04-09', 'In Review'),
('REQ0000010', 'PROD0010', 'Adjustable volume', '2025-04-10', 'Pending');

CREATE TABLE customer (
    customerID CHAR(8) NOT NULL,
    name VARCHAR(20) NOT NULL,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(15) NOT NULL,
    address VARCHAR(100) NULL,
    emailAddress VARCHAR(50) NULL,
    phoneNo BIGINT NULL,
    CONSTRAINT customer_pk PRIMARY KEY (customerID)
);

INSERT INTO customer VALUES 
('CUST0001', 'Alice Wong', 'alicewong', 'cust123', '101 Happy St, HK', 'alice@company.com', 85291234567),
('CUST0002', 'Bob Chan', 'bobchan', 'cust456', '202 Joy Rd, Kowloon, HK', 'bob@company.com', 85298765432),
('CUST0003', 'Cathy Lau', 'cathylau', 'cust789', '303 Peace St, NT, HK', 'cathy@company.com', 85292345678),
('CUST0004', 'David Ip', 'davidip', 'cust101', '404 Unity Rd, HK', 'david@company.com', 85293456789),
('CUST0005', 'Emma Tsang', 'emmatsang', 'cust202', '505 Harmony Ave, Kowloon, HK', 'emma@company.com', 85294567890),
('CUST0006', 'Frank Yip', 'frankyip', 'cust303', '606 Victory St, HK', 'frank@company.com', 85295678901),
('CUST0007', 'Grace So', 'graceso', 'cust404', '707 Freedom Rd, NT, HK', 'grace@company.com', 85296789012),
('CUST0008', 'Henry Ma', 'henryma', 'cust505', '808 Glory St, HK', 'henry@company.com', 85297890123),
('CUST0009', 'Irene Ng', 'ireneng', 'cust606', '909 Hope Rd, Kowloon, HK', 'irene@company.com', 85298901234),
('CUST0010', 'Jack Leung', 'jackleung', 'cust707', '1010 Dream Ave, NT, HK', 'jack@company.com', 85299012345);

CREATE TABLE productOrder (
    orderID CHAR(10) NOT NULL,
    customerID CHAR(8) NOT NULL,
    productID CHAR(8) NOT NULL,
    quantity INT NULL,
    totalAmount INT NULL,
    orderDate DATE NULL,
    CONSTRAINT order_pk PRIMARY KEY (orderID),
    CONSTRAINT order_customer_fk FOREIGN KEY (customerID) REFERENCES customer (customerID),
    CONSTRAINT order_product_fk FOREIGN KEY (productID) REFERENCES productList (productID)
);

INSERT INTO productOrder VALUES 
('ORD0000001', 'CUST0001', 'PROD0001', 10, 4990, '2025-05-01'),
('ORD0000002', 'CUST0002', 'PROD0002', 50, 1000, '2025-05-02'),
('ORD0000003', 'CUST0003', 'PROD0003', 20, 300, '2025-05-03'),
('ORD0000004', 'CUST0004', 'PROD0004', 5, 495, '2025-05-04'),
('ORD0000005', 'CUST0005', 'PROD0005', 8, 472, '2025-05-05'),
('ORD0000006', 'CUST0006', 'PROD0006', 15, 375, '2025-05-06'),
('ORD0000007', 'CUST0007', 'PROD0007', 12, 468, '2025-05-07'),
('ORD0000008', 'CUST0008', 'PROD0008', 10, 290, '2025-05-08'),
('ORD0000009', 'CUST0009', 'PROD0009', 7, 245, '2025-05-09'),
('ORD0000010', 'CUST0010', 'PROD0010', 6, 270, '2025-05-10');

CREATE TABLE deliveryNote (
    deliveryID CHAR(10) NOT NULL,
    orderID CHAR(10) NOT NULL,
    deliveryDate DATE NOT NULL,
    status VARCHAR(15) NULL,
    CONSTRAINT dn_pk PRIMARY KEY (deliveryID),
    CONSTRAINT dn_order_fk FOREIGN KEY (orderID) REFERENCES productOrder (orderID)
);

INSERT INTO deliveryNote VALUES 
('DEL0000001', 'ORD0000001', '2025-05-05', 'Shipped'),
('DEL0000002', 'ORD0000002', '2025-05-06', 'Delivered'),
('DEL0000003', 'ORD0000003', '2025-05-07', 'In Transit'),
('DEL0000004', 'ORD0000004', '2025-05-08', 'Shipped'),
('DEL0000005', 'ORD0000005', '2025-05-09', 'Delivered'),
('DEL0000006', 'ORD0000006', '2025-05-10', 'In Transit'),
('DEL0000007', 'ORD0000007', '2025-05-11', 'Shipped'),
('DEL0000008', 'ORD0000008', '2025-05-12', 'Delivered'),
('DEL0000009', 'ORD0000009', '2025-05-13', 'In Transit'),
('DEL0000010', 'ORD0000010', '2025-05-14', 'Shipped');

CREATE TABLE goodsReceived (
    receiptID CHAR(10) NOT NULL,
    deliveryID CHAR(10) NOT NULL,
    receivedDate DATE NOT NULL,
    quantityReceived INT NULL,
    CONSTRAINT gr_pk PRIMARY KEY (receiptID),
    CONSTRAINT gr_delivery_fk FOREIGN KEY (deliveryID) REFERENCES deliveryNote (deliveryID)
);

INSERT INTO goodsReceived VALUES 
('REC0000001', 'DEL0000001', '2025-05-06', 10),
('REC0000002', 'DEL0000002', '2025-05-07', 50),
('REC0000003', 'DEL0000003', '2025-05-08', 20),
('REC0000004', 'DEL0000004', '2025-05-09', 5),
('REC0000005', 'DEL0000005', '2025-05-10', 8),
('REC0000006', 'DEL0000006', '2025-05-11', 15),
('REC0000007', 'DEL0000007', '2025-05-12', 12),
('REC0000008', 'DEL0000008', '2025-05-13', 10),
('REC0000009', 'DEL0000009', '2025-05-14', 7),
('REC0000010', 'DEL0000010', '2025-05-15', 6);

CREATE TABLE materialList (
    materialID CHAR(8) NOT NULL,
    name VARCHAR(20) NOT NULL,
    unit VARCHAR(5) NOT NULL,
    reorderQuantity INT NULL,
    CONSTRAINT material_pk PRIMARY KEY (materialID)
);

INSERT INTO materialList VALUES 
('MAT00001', 'Plastic ABS', 'KG', 500),
('MAT00002', 'Wood Pine', 'KG', 1000),
('MAT00003', 'Screws 4x1', 'PC', 20000),
('MAT00004', 'Paint Red', 'L', 100),
('MAT00005', 'Rubber Wheels', 'PC', 5000),
('MAT00006', 'Battery AA', 'PC', 10000),
('MAT00007', 'Fabric Cotton', 'M', 200),
('MAT00008', 'Metal Rods', 'KG', 300),
('MAT00009', 'Glue Strong', 'L', 50),
('MAT00010', 'LED Lights', 'PC', 5000);

CREATE TABLE inventoryRecord (
    recordID CHAR(10) NOT NULL,
    materialID CHAR(8) NOT NULL,
    quantityIn INT NOT NULL,
    dateIn DATE NOT NULL,
    CONSTRAINT ir_pk PRIMARY KEY (recordID),
    CONSTRAINT ir_material_fk FOREIGN KEY (materialID) REFERENCES materialList (materialID)
);

INSERT INTO inventoryRecord VALUES 
('INV0000001', 'MAT00001', 800, '2025-05-01'),
('INV0000002', 'MAT00002', 1500, '2025-05-02'),
('INV0000003', 'MAT00003', 25000, '2025-05-03'),
('INV0000004', 'MAT00004', 120, '2025-05-04'),
('INV0000005', 'MAT00005', 6000, '2025-05-05'),
('INV0000006', 'MAT00006', 12000, '2025-05-06'),
('INV0000007', 'MAT00007', 250, '2025-05-07'),
('INV0000008', 'MAT00008', 400, '2025-05-08'),
('INV0000009', 'MAT00009', 60, '2025-05-09'),
('INV0000010', 'MAT00010', 5500, '2025-05-10');

CREATE TABLE customerFeedback (
    feedbackID INT NOT NULL,
    customerID CHAR(8) NOT NULL,
    orderID CHAR(10) NULL,
    content VARCHAR(500) NULL,
    feedbackDate DATE NOT NULL,
    CONSTRAINT cf_pk PRIMARY KEY (feedbackID),
    CONSTRAINT cf_customer_fk FOREIGN KEY (customerID) REFERENCES customer (customerID),
    CONSTRAINT cf_order_fk FOREIGN KEY (orderID) REFERENCES productOrder (orderID)
);

INSERT INTO customerFeedback VALUES 
(1, 'CUST0001', 'ORD0000001', 'Excellent product!', '2025-05-06'),
(2, 'CUST0002', 'ORD0000002', 'Fast delivery.', '2025-05-07'),
(3, 'CUST0003', 'ORD0000003', 'Very satisfied.', '2025-05-08'),
(4, 'CUST0004', 'ORD0000004', 'Great quality.', '2025-05-09'),
(5, 'CUST0005', 'ORD0000005', 'Kids love it!', '2025-05-10'),
(6, 'CUST0006', 'ORD0000006', 'Good value.', '2025-05-11'),
(7, 'CUST0007', 'ORD0000007', 'Nice design.', '2025-05-12'),
(8, 'CUST0008', 'ORD0000008', 'Durable toy.', '2025-05-13'),
(9, 'CUST0009', 'ORD0000009', 'Fun game.', '2025-05-14'),
(10, 'CUST0010', 'ORD0000010', 'Really engaging.', '2025-05-15');