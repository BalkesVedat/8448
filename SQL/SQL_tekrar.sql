--1. 8448 adýnda bir DB yarat

--CREATE DATABASE DB8448

--2. DB8448 aktif DB olsun

--USE DB8448
--GO

--3. DB içine ARACLAR tablosu ekleyin
-- AracID int PK IDENTITY(1,1)
-- Arac_Adi  
-- Marka
-- Model 
-- Yili int
-- Maliyet money
-- Fiyati money
-- Rengi
-- Stokta bit

--CREATE TaBLE Araclar
--(
--	AracID int IDENTITY(1,1) PRIMARY KEY,
--	Arac_Adi nvarchar(100),
--	Marka nvarchar(100),
--	Model nvarchar(100),
--	Yili int,
--	Maliyet money,
--	Fiyati money,
--	Rengi nvarchar(100),
--	Stokta bit
--)

--4. DB içine SATISLAR tablosu ekleyin
-- SatisID int PK IDENTITY
-- Tarihi SmallDateTime
-- AracID int
-- SatisFiyati

--CREATE TABLE Satislar
--(
--	SatisID int IDENTITY(1,1) Primary KEy,
--	Tarihi smalldatetime,
--	AracID int not null,
--	SatisFiyati money
--)

--ALTER TABLE Satislar
--	Alter Column AracID int not null

--5. 5 araç kaydedin, 3 tanesine satýþ girin
-- OK

--6. Araç Listesini çekin
--SELECT * From Araclar

--7. Satýlan Araçlar Listesini çekin
--SELECT * From Araclar  WHERE Stokta = 0

--8. Elimizdeki araçlar listesini çekin
--SELECT * From Araclar WHERE Stokta = 1

--9. Satýþ adedi ve Toplam satýþ tutarý raporu - VIEW

--CREATE VIEW Ciro_Qry
--AS
--SELECT COUNT(AracID) AS 'Satilan Adet', SUM(SatisFiyati) AS 'Toplam Ciro' FROM Satislar   

--10. Elimizdeki araçlarýn adedini ve toplam maliyetini, toplam deðerini gösteren rapor. - VIEW

--CREATE VIEW Elimizdeki_Araclar_Qry
--AS
--SELECT Count(AracID) AS 'Adet', SUM(Fiyati) AS 'ToplamDeðer', SUM(Maliyet) AS 'Toplam Maliyet' FROM Araclar WHERE Stokta = 1


--11. Satýþ cirosu, maliyet ve kar raporu - VIEW - ÖDEV

--12. Bir araç satýldýðýnda otomatik araçlar listesinden aracýn STOKTA bilgisini 0 yapan trigger

--CREATE TRIGGER Trg_SatilanAraciStoktanDus
--ON Satislar
--AFTER Insert
--AS
--BEGIN
--	DECLARE @AracID int

--	SELECT @AracID = AracID  FROM inserted

--	UPDATE Araclar SET Stokta = 0 WHERE  AracID = @AracID 

--END

--13. Bir satýþ silindiðinde, ilgili satýþtaki aracýn STOKTA bilgisi tekrar 1 yapýlsýn. - ÖDEV