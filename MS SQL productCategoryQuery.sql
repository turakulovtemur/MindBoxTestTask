create table Product
(
	Id int primary key not null,
	Name nvarchar(30) not null
)

create table Category
(
	Id int primary key not null,
	Name nvarchar(30) not null
)

create table ProductCategory
(
	Id int not null,
	ProductId int foreign key references  dbo.Product(Id) ,
	CategoryId int foreign key references dbo.Category(Id),
	primary key(ProductId,CategoryId)
)

Insert into dbo.Product
values(1, '—ахар'),
(2, 'яблоко'),
(3, '–ис очищенный'),
(4, '–ис не очищенный');

Insert into dbo.Category("Id","Name")
values(1, '—ахар'),
(2, 'яблоко красное'),
(3, 'яблоко зеленое'),
(4, '–ис');

Insert into dbo.ProductCategory
values(1,1, 1),
(2,2, 2),
(3,2, 3),
(4,3, 4),
(5,4, 4);


select p.Name as ProductName, c.Name as CategoryName 
from Product as p
left join ProductCategory as pc on pc.ProductId=p.Id
left join Category as c on pc.categoryId=c.Id

