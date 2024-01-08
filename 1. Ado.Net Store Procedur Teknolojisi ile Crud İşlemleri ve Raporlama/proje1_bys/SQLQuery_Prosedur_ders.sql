
create proc dersEkle 
@dersNo int,
@dersAdi varchar(50),
@kredi int,
@zorunlu nchar(10),
@dili varchar(50),
@yil int,
@donem nchar(10),
@saat int,
@ogrNo int,
@akademisyenNo int
as begin
insert into dersler(dersNo, dersAdi, kredi, zorunlu, dili, yil, donem, saat, ogrNo, akademisyenNo) values 
(@dersNo, @dersAdi, @kredi, @zorunlu, @dili, @yil, @donem, @saat, @ogrNo, @akademisyenNo)
end




create proc dersListele
as begin
select*from dersler
end





create proc dersGüncelle
@dersNo int,
@dersAdi varchar(50),
@kredi int,
@zorunlu nchar(10),
@dili varchar(50),
@yil int,
@donem nchar(10),
@saat int,
@ogrNo int,
@akademisyenNo int
as begin 
update dersler set dersAdi=@dersAdi, kredi=@kredi, zorunlu=@zorunlu, dili=@dili, yil=@yil, 
donem=@donem, saat=@saat, ogrNo=@ogrNo, akademisyenNo=@akademisyenNo where dersNo=@dersNo
end




create proc dersSilme
@dersNo int
as begin
delete from dersler where dersNo=@dersNo
end




create proc dersAraAd
@dersadi varchar(50)
as begin
select*from dersler where dersAdi=@dersAdi
end




create proc dersAraYilveDonem
@yil int,
@donem nchar(10)
as begin
select*from dersler where yil=@yil and donem=@donem
end






create proc dersSiralaYilveDonem
as begin
select*from dersler order by yil,donem asc
end






create proc dersSiralaBolum
as begin
select*from dersler order by bolum asc
end





alter table dersler add bolum varchar(50)

