select Goods.*, Category.CategoryName
 from Goods
left join Good_Category
 on Good_Category.GoodId = Goods.id
left join Category
 on Category.id = Good_Category.CategoryId