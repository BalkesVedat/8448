USE [Northwind]
GO

-- STORED PROCEDURES : Saklý Yordamlar
-- Veri tabanýnýn programlama nesneleridir. Yazdýðýmýz t-sql programlarý sp lerde saklanýr. SELECT de dahil tüm komutlarý içerebilir ve çalýþtýrabilir. IF - WHILE DÖNGÜSÜ - TRY/CATCH  - TRANSACTION - DEÐÝÞKEN - v.b. gibi yapýlarý da kullanabiliriz. SP ile kaydedilen komut dosyasý EXECUTE ya da EXEC komutu ile çalýþtýrýlýr. 



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


--create proc While_Dongusu(@sayac int)
--as
--begin

--declare @i int

--select @i = 1

--	while @i <= @sayac
--	begin 		
--		print @i
--		set @i = @i + 1
--	end

--	-- MSSQL de yok ama ORACLE SQL de var
--	--FOR @i IN 1..@sayac
--	--LOOP
--	--	print @i
--	--END LOOP;

--end

--EXEC While_Dongusu 15


--CREATE PROC Havale
--(@GonderenHesapNo int, @AliciHesapNo int, @Tutar money)
--AS
--BEGIN
	
--BEGIN TRY
--	BEGIN TRAN
	
--	-- iþlemler

--	--UPDATE Musteriler SET HesapBakiyesi = HesapBakiyesi - @Tutar WHERE MusteriID = @GonderenHesapNo

--	--UPDATE Musteriler SET HesapBakiyesi = HesapBakiyesi + @Tutar WHERE MusteriID = @AliciHesapNo

--	COMMIT TRAN
--	PRINT 'Ýþlem Baþarýyla Tamamlandý'
--END TRY
--BEGIN CATCH
--	ROLLBACK TRAN
--	PRINT 'Ýþlem iptal edildi'
--END CATCH

--END

-----------------------------------------------------------------------------------------------------------
------------------------FUNCTIONS -------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------

--FUNCTION : Bir deðer üreten ve ürettiði deðeri geri döndürebilen kod bloklarýdýr. SP lerin deðer döndürebilen ve döndürdüðü deðeri alýp kullanabildiðimiz versiyonu olarak ta düþünebiliriz. Geri dönen deðer bir deðiþkene aktarýlýp kullanýlabilir. Kullanýrken parametresi olsun ya da olmasýn yanýnda parantez aç-kapa yapýlýr. fonksiyonadi(), fonksiyonadi(param1, param2)  gibi. Fonksiyon tanýmlanýrken ne tür bir veri dönecek ise RETURNS ifadesi ile belirtilmelidir.

 --   CREATE FUNCTION Fonksiyon_adi(parametre1 param1_tipi, parametre2 param2_tipi,...) 
	--RETURNS Dönüþ_tipi 
	--[AS]
	--BEGIN
	--    --iþlemler
	--	RETURN döndürülecek_deðer (Dönüþ tipine uygun olmalý)
	--END




-----------------------------------------------------------------
--CREATE FUNCTION UrunListesi()  RETURNS TABLE 
--	RETURN SELECT * FROM Urunler
----------------------------------------------------------------

	--SELECT * FROM UrunListesi()

	--SELECT 3*5

	--SELECT GETDATE()

-------------------------------------------------------------------

-- Verilen bir ürün ID sine ait kaydýn olup olmadýðý bilgisini dönen fonksiyon

--CREATE FUNCTION UrunVarMi(@UrunID int) RETURNS bit
--BEGIN
--	DECLARE @adet int
--	DECLARE @sonuc bit

--	SELECT @adet = Count(UrunID) FROM Urunler WHERE UrunID = @UrunID

--	IF @adet > 0 
--		select @sonuc = 1
--	ELSE
--		select @sonuc = 0

--		return @sonuc

--END
-----------------------------------------------------------------------

--DECLARE @sonuc bit
--DECLARE @ID int = 500

--SELECT @sonuc =  dbo.UrunVarMi(@ID)

--IF @sonuc = 1
--	SELECT * FROM Urunler WHERE UrunID = @ID
--ELSE
--	PRINT TRIM(Str(@ID)) + ' Koduna Sahip Ürün Bulunamadý'
--	PRINT CONVERT(varchar(10), @ID) + ' Koduna Sahip Ürün Bulunamadý' 
-------------------------------------------------------------------------