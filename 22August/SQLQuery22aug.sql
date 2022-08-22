create database AssessmentTest;
use AssessmentTest
create table Book_details
(
Bookid int primary key identity,
BookName varchar(50),
Aurthor varchar(50),
Publisher varchar(50),
Price decimal(16,2)
)

create procedure addbook
(
@bname varchar(50),
@aurthor varchar(50),
@publisher varchar(50),
@price decimal(16,2)
)
as begin
insert into Book_details values(@bname,@aurthor,@publisher,@price)
end

create proc deletebook
(
@Bookid int
)
as begin 
delete from Book_details where Bookid = @Bookid
end

create proc updatebook
(
@Bookid int,
@bookname varchar(50),
@aurthor varchar(50),
@publisher varchar(50),
@price decimal(16,2)
)
as begin
update Book_details set BookName=@bookname, Aurthor=@aurthor, Publisher=@publisher,Price=@price where Bookid=@Bookid
end

create proc getbook
as begin
select * from Book_details
end