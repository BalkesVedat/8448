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