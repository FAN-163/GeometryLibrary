SELECT p.Title, c.Title, COALESCE(Category.Title, 'без категории') AS Category
    FROM Product AS p
         LEFT JOIN ProductCategory pc ON pc.ProductId = p.Id
         LEFT JOIN Category c ON pc.CategoryId = c.Id
ORDER BY p.Title ASC, c.Title ASC;