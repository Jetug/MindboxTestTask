SELECT Products.name as Продукт, Categories.name as Категория FROM Products
JOIN ProductsCategories ON Products.id = ProductsCategories.ProductsId
JOIN Categories ON Categories.id = ProductsCategories.CategoriesID
UNION SELECT name as Продукт, '' as Категория FROM Products
LEFT JOIN ProductsCategories ON Products.id = ProductsCategories.ProductsId
WHERE ProductsCategories.CategoriesID IS NULL