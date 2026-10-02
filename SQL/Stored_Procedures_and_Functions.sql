USE [Northwind]
GO

--CREATE PROC [dbo].[SP_Musteri_Listesi]
--AS 
--SELECT * FROM Musteriler

--EXECUTE SP_Musteri_Listesi

--CREATE PROC [dbo].[Sp_Aktif_Musteri_Sayisi]
--AS
--SELECT COUNT(MusteriID) FROM Musteriler 

--EXEC Sp_Aktif_Musteri_Sayisi

--ALTER PROC [dbo].[Sp_Aktif_Musteri_Sayisi]
--AS
--SELECT COUNT(T.Adet) AS 'Aktif Müþteri Sayýsý' FROM
--(SELECT COUNT(Musteriler.MusteriID) AS Adet FROM Musteriler JOIN Satislar ON Musteriler.MusteriID = Satislar.MusteriID
--GROUP BY Musteriler.MusteriID) T


--EXEC Sp_Aktif_Musteri_Sayisi

---------------------------------------------------
---------- HESAPLA PROC START ---------------------
---------------------------------------------------

--ALTER PROC Hesapla
--(
--@fiyat decimal(18,2), 
--@kdvOran decimal(18,2)
--)
--AS

--BEGIN TRY 

--	IF @fiyat is null OR @fiyat <= 0  OR  @kdvOran is null OR @kdvOran <= 0
--		BEGIN
--			PRINT 'Girilen deðerler hatalý'
--			SELECT 0 AS 'KDV Dahil Fiyat'
--		END
--	ELSE
--		BEGIN
--			SELECT @fiyat * (1 + @kdvOran)  AS 'KDV Dahil Fiyat'
--		END

--END TRY
--BEGIN CATCH
--	PRINT 'Hata'
--END CATCH

---------------------------------------------------
---------- HESAPLA PROC END ---------------------
---------------------------------------------------


--EXEC Hesapla null, 0 


--ALTER PROC BilgiVer
--AS
--BEGIN
	
--DECLARE	@Tarih smalldatetime
--DECLARE @Gun nvarchar(20)

----SET @Tarih = GETDATE()

--SELECT @Tarih = GETDATE()

--Select @Gun = Format(@Tarih,'dddd','tr-TR')

--Select @Tarih AS 'Günün Tarihi', @Gun AS 'Gün' 

--END

--EXEC BilgiVer