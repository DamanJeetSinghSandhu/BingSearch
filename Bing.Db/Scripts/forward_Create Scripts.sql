Create Database BingSearch

Use BingSearch

Create Table [Location]
(ID int Identity(1,1) Not Null Primary Key,
Name varchar(50) Not Null,
AvailFrom TIME Not Null,
AvailTo TIME Not Null,

)


--Drop table [Location]

Select * from [Location]