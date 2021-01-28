-- Select 
Select ContactName, CompanyName, City from Customers
select * from Products where CategoryID = 1
select * from Customers where city ='Berlin'
select * from Products where CategoryID =1 and UnitPrice<=10
select * from Products where CategoryID =2 or CategoryID=3

select * from Products order by ProductName
select * from Products order by UnitPrice
select * from Products where CategoryID=1 order by UnitPrice desc

select * 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

select * from Products p left  join [Order Details] od on p.ProductID = od.ProductID