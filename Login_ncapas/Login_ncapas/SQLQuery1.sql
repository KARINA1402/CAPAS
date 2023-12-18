Create Database BDLogin
Go

Create table TableLogin
(
usuario1 varchar(50),
password1 varchar(50)
)
Go

create proc sp_login
@usu varchar(50),
@pas varchar(50)
as
select * from TableLogin where usuario1=@usu and password1=@pas
Go

Insert into TableLogin values('paul','paul123')
Insert into TableLogin values('VaidrollTeam','VaidrollTeam123')

select * from TableLogin