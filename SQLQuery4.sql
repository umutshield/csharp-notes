--SELECT 

--yazdığımız sorgularımız aslında bir tablodur
--Select ContactName, CompanyName, City from Customers

--SQL, küçük büyük harf uyumuna dikkat etmez     -case insensitive
--varlıkların yanına alias(takma ad) yazabiliriz
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

--tek bir sorgunun veya istediğin sorgunun çalışmasını istiyorsan imleçle o sorguyu seç ve execute'a(sol üst) bas

Select * from Products where CategoryID = 1 or CategoryId = 3

Select * from Products where CategoryID= 1 and UnitPrice>10


--ORDER BY (Sıralama - Filtreleme)

select * from Products order by UnitPrice

--asc(ascending): artan  -order by'ın default halidir
select * from Products order by UnitPrice asc

--desc(descending): azalan, düşen
select * from Products where CategoryID=1 order by UnitPrice desc

--count sayı verir. aşağıdaki örnekte kategori id'si 2 olan tüm ürünlerin sayısını istedik
select count(*) from Products where CategoryID = 2 
 

--GROUP BY (gruplama)
--group by yapılınca her bir grup için arka planda bir tablo oluşturuluyormuş gibi düşünebilirsin

select CategoryID, count(*) from Products group by CategoryID


--HAVING (gruplamada filtreleme)

--kategori sayısı 10'dan az olan ürünleri id'leri ile birlikte grupla
select CategoryID, count(*) from Products group by CategoryID having count(*)<10

--birim fiyatı 20'den pahalı olan ve kategori sayısı 10'dan az olan ürünleri id'leri ile birlikte grupla
select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10


--INNER JOIN
--on şart/durumunda demek
--Join'in C#'taki karşılığı DTO(Data Transformation Object)
--Inner join iki tablodada eşleşenleri bir araya getirir.

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where UnitPrice>10

--LEFT JOIN

--order details'te boşluk olduğu için kapalı paranteze aldık, başka bir olayı yok
--left join'de mantık şu: solda olup sağda olmayanları da yazdır
--bir de right join var left join'in tam tersi: sağda olup solda olmayanlar
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID


--IS NULL
--solda olup sağda olmayanlar null diye geçer
select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

--ikiden fazla tabloyu birleştirmek istersen bir join daha eklersin
--inner join on inner join on gibi..

