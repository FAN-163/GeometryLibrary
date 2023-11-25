DROP TABLE IF EXISTS ProductCategory;
DROP TABLE IF EXISTS Category;
DROP TABLE IF EXISTS Product;

CREATE TABLE Category
        (
        Id INT PRIMARY KEY,
        Title VARCHAR(200) NOT NULL
        );

CREATE TABLE Product
        (
        Id INT PRIMARY KEY,
        Title VARCHAR(200) NOT NULL
        );

CREATE TABLE ProductCategory
        (
        ProductId  INT NOT NULL,
        CategoryId INT NOT NULL,
        FOREIGN KEY (ProductId) REFERENCES Product (Id),
        FOREIGN KEY (CategoryId) REFERENCES Category (Id),
        PRIMARY KEY (ProductId, CategoryId)
        );


INSERT INTO dbo.Product(Id, Title)
VALUES  (1, 'product1'),
        (2, 'product2'),
        (3, 'product3'),
        (4, 'product4'),
        (5, 'product5'),
        (6, 'product6'),
        (7, 'product7'),
        (8, 'product8'),
        (9, 'product9'),
        (10, 'product10');

INSERT INTO dbo.Category(Id, Title)
VALUES  (1, 'category1'),
        (2, 'category2'),
        (3, 'category3'),
        (4, 'category4'),
        (5, 'category5'),
        (6, 'category6'),
        (7, 'category7'),
        (8, 'category8'),
        (9, 'category9'),
        (10, 'category10');

INSERT INTO ProductCategory(ProductId, CategoryId)
VALUES  (1, 1),
        (1, 2),
        (1, 3),
        (1, 4),
        (1, 5),
        (3, 3),
        (3, 4),
        (3, 7),
        (2, 8),
        (2, 9),
        (2, 10),
        (2, 1);