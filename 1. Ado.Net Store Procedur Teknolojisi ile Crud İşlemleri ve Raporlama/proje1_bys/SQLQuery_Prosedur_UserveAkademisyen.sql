
create proc userKayit 
@name varchar(50),
@surname varchar(50),
@mail varchar(50),
@telefon nchar(11),
@birthday datetime,
@tcNo nchar(11),
@username nchar(20),
@password varchar(25)
as begin
insert into Users (name, surname, mail, telefon, birthday, tcNo, username, password) values 
(@name, @surname, @mail, @telefon, @birthday, @tcNo, @username, @password)
end

execute userKayit 'fatma', 'arslan', 'fatma@gmail.com', '5556665544','2000-07-14',
'11122233344','fatmaarslan','1234'


select*from users
select*from akademisyenler
select*from ogrenciler
select*from dersler



create proc akademisyenEkle 
@sicilNo int,
@ad varchar(50),
@soyad varchar(50),
@unvan varchar(50),
@fakulte varchar(50),
@alan varchar(50),
@mail varchar(50),
@telefon nchar(11),
@yas int
as begin
insert into akademisyenler(sicilNo, ad, soyad, unvan, fakulte, alan, mail, telefon, yas) values 
(@sicilNo, @ad, @soyad, @unvan, @fakulte, @alan, @mail, @telefon, @yas)
end

execute akademisyenEkle 200,'mehmet','öztürk','Dr.','mühendislik','haberleþme',
'mehmet@gmail.com','5556666666',42




create proc akademisyenListele
as begin
select*from akademisyenler
end



create proc akademisyenGüncelle
@sicilNo int,
@ad varchar(50),
@soyad varchar(50),
@unvan varchar(50),
@fakulte varchar(50),
@alan varchar(50),
@mail varchar(50),
@telefon nchar(11),
@yas int
as begin
update akademisyenler set ad=@ad, soyad=@soyad, unvan=@unvan, fakulte=@fakulte, alan=@alan, 
mail=@mail, telefon=@telefon, yas=@yas where sicilNo=@sicilNo
end


create proc akademisyenSil
@sicilNo int
as begin
delete from akademisyenler where sicilNo=@sicilNo
end




create proc akademisyenAraAdSoyad
@ad varchar(50),
@soyad varchar(50)
as begin
select*from akademisyenler where ad=@ad and soyad=@soyad
end





create proc akademisyenAraUnvan
@unvan varchar(50)
as begin
select*from akademisyenler where unvan=@unvan
end





create proc akademisyenSiralaFakulte
as begin
select*from akademisyenler order by fakulte asc
end

execute akademisyenSiralaFakulte







