/* 
SQL - Structured Query Language - Yapýlandýrýlmýþ Sorgulama Dili
T-SQL : Transact - Ortak dil komutlarý

DDL - Data Definition Language - Veri Tanýmlama Dili
CREATE - ALTER - DROP

CREATE : Nesne oluþturur. (DATABASE - TABLE - VIEW - SP - TRIGGER - LOGIN ...)
CREATE Nesne_Tipi Nesne_Adi
CREATE DATABASE Northwind

ALTER : Nesneleri güncellemek, ayarlarýný deðiþtirmek için kullanýlýr.
ALTER Nesne_Tipi Nesne_Adi
ALTER TABLE Musteriler
	ALTER COLUMN MusteriAdSoyad nvarchar(100)

DROP : Nesneleri Silmek için kullanýlýr.
DROP Nesne_Tipi Nesne_Adi
DROP TABLE Musteriler

--------------------------------------------------------------

DML : Data Manipulation Language - Veri üzerinde iþlem yapan komutlar (CRUD)
INSERT - UPDATE - DELETE - SELECT
--------------
INSERT - EKLEME : VeriTabanýndaki bir tabloya kayýt ekler.

1. INSERT INTO Tablo_Adý (Kolon listesi) VALUES (Veri listesi)  
2. INSERT INTO Tablo_Adý VALUES (Veri Listesi)
---------------

DELETE - SÝL : Bir tablodan belirtilen kriterlere uyan kayýtlarý siler. 
***ÖNEMLÝ : Kriter belirtilmezse tablodaki tüm kayýtlarý siler.

DELETE FROM Tablo_Adý WHERE Kriterler
---------------

UPDATE - GÜNCELLE : Bir tablodaki kriterlere uyan kayýtlarýn verilerini günceller. 
***ÖNEMLÝ : Kriter belirtilmezse tablodaki tüm kayýtlar yeni deðerlerle güncellenir.

UPDATE Tablo_Adý SET Kolon1_adý = yeni_deðeri, kolon2_adý = yeni_deðeri, ..... WHERE Kriterler

----------------------

SELECT - SEÇ - QUERY - SORGU  : Tablolardan veri sorgulayarak istenilen verileri çekmek için kullanýlýr.

SELECT alan_listesi FROM tablo_adý WHERE filtre_ifadesi 


*/

--CREATE DATABASE ABC
--DROP DATABASE ABC

--CREATE DATABASE TarifSepetiDB 

USE TarifSepetiDB
GO

--CREATE TABLE Yemekler
--(
--YemekID int IDENTITY(1,1) NOT NULL,
--YemekAdi nvarchar(50) NOT NULL,
--Malzemeler nvarchar(500) NOT NULL,
--Tarifi nvarchar(MAX) NOT NULL,
--KayitTarihi datetime 

--)

--CREATE TABLE Musteriler
--(
--MusteriID int IDENTITY(1,1) PRIMARY KEY NOT NULL, -- zorunlu
--MusteriAdSoyad nvarchar(50) NOT NULL, -- zorunlu
--MusteriEmail varchar(50),
--AktifMi bit 
--)

--ALTER TABLE Yemekler
--	DROP COLUMN KayitTarihi

--ALTER TABLE Yemekler
--	ADD KayitTarihi SmallDateTime --NOT NULL DEFAULT GETDATE()

--ALTER TABLE Yemekler
--	ALTER COLUMN KayitTarihi smalldatetime NOT NULL

--ALTER TABLE Musteriler 
--	ADD MusteriAdresi nvarchar(MAX) 

--ALTER TABLE Yemekler
--	ADD Kalorisi int 

--ALTER TABLE Yemekler
--	ADD CONSTRAINT PK_Yemekler PRIMARY KEY CLUSTERED (YemekID ASC)     

--------------------------------------------------------
-------------  DML -------------------------------------
--------------------------------------------------------

--INSERT INTO Musteriler (MusteriAdSoyad) VALUES ('Ahmet Ak')

--INSERT INTO Musteriler 
--(MusteriAdSoyad, MusteriEmail) 
--VALUES 
--('Korkmaz Ticaret', 'abc@korkmaz.com');

--INSERT INTO Musteriler 
--VALUES
--('Ayþe Pak', NULL, 1, NULL)

--INSERT INTO Yemekler
--([YemekAdi],[Malzemeler],[KayitTarihi],[Tarifi],[Kalorisi])
--VALUES
--('Kuru Fasülye','Fasülye, su, tuz, karabiber, tereyað', getdate(), 'fdsfsdfsf',400)


--INSERT INTO Siparisler VALUES (GETDATE(),9,1,5,1)
--INSERT INTO Siparisler VALUES ('2026-09-24',9,2,2,9)
--INSERT INTO Siparisler VALUES ('2025-08-17',10,2,4,8)
--INSERT INTO Siparisler VALUES ('2025-10-13',10,1,8,9)
--INSERT INTO Siparisler VALUES (GETDATE(),9,1,3,9)



---------------------------------------------------------------------

--DELETE FROM Musteriler WHERE MusteriID = 7
--DELETE FROM Musteriler WHERE AktifMi = 0 OR AktifMi is NULL
--DELETE FROM Musteriler WHERE MusteriEmail is NULL

-----------------------------------------------------------------------

--UPDATE Musteriler SET MusteriEmail = 'aaa@bbb.com' WHERE MusteriID = 9
--UPDATE Musteriler SET AktifMi = 1 WHERE AktifMi is NULL

--------------------------------------------------------------------------

----------------   SELECT ------------------------------------------------

--SELECT [YemekAdi],[Malzemeler],[Tarifi],[Kalorisi] FROM [Yemekler]

SELECT [MusteriAdSoyad],[MusteriEmail],[AktifMi],[MusteriAdresi] FROM Musteriler WHERE AktifMi = 1

--UPDATE Musteriler SET AktifMi = 0 WHERE MusteriAdSoyad = 'Ayþe Pak'

SELECT * FROM Musteriler 