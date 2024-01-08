
create proc ogrEkle 
@ogrNo int,
@ad varchar(50),
@soyad varchar(50),
@fakulte varchar(50),
@bolum varchar(50),
@sinif int,
@danisman varchar(50),
@mail varchar(50),
@telefon nchar(11),
@yas int
as begin
insert into ogrenciler(ogrNo, ad, soyad, fakulte, bolum, sinif, danisman, mail, telefon, yas) values 
(@ogrNo, @ad, @soyad, @fakulte, @bolum, @sinif, @danisman, @mail, @telefon, @yas)
end

execute ogrEkle 5,'müberra','kabataþ','mühendislik','elektrik-elektronik',4,'oðuzhan çakýr',
'muberra@gmail.com','5555555555',24
select*from ogrenciler





create proc ogrListele
as begin
select*from ogrenciler
end





create proc ogrGüncelle
@ogrNo int,
@ad varchar(50),
@soyad varchar(50),
@fakulte varchar(50),
@bolum varchar(50),
@sinif int,
@danisman varchar(50),
@mail varchar(50),
@telefon nchar(11),
@yas int
as begin
update ogrenciler set ad=@ad, soyad=@soyad, fakulte=@fakulte, bolum=@bolum, sinif=@sinif,
danisman=@danisman, mail=@mail, telefon=@telefon, yas=@yas where ogrNo=@ogrNo
end




create proc ogrSil
@ogrNo int
as begin
delete from ogrenciler where ogrNo=@ogrNo
end




create proc ogrAra
@ogrNo int
as begin
select*from ogrenciler where ogrNo=@ogrNo
end



create proc ogrAraSinif
@sinif int
as begin
select*from ogrenciler where sinif=@sinif
end


create proc ogrListeleBolum
as begin
select*from ogrenciler order by bolum asc
end

execute ogrListeleBolum
