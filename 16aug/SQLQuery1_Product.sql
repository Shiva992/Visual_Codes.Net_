CREATE TABLE Product (
    ProductID int primary key not null,
    ProductName varchar(255) not null ,
    Price int not null ,
    CategoryID int not null,
	Foreign Key(CategoryID) references Category(CategoryID)
);
Select * from Product