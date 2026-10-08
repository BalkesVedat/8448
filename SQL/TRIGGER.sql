
-- TRIGGERS - Tetikleyiciler :
-- Bir DB nesnesi yada bir tablodaki kayýt üzerinde herhangi bir iþlem yapýldýðýnda otomatik çalýþan kod yapýlarýdýr. Hangi nesnede hangi iþlem yapýldýðýnda çalýþacaðý TRIGGER yaratýlýrken belirtilir. - C# taki Event ve delege mekanizmasý gibi çalýþýr. Kod gövdesi içine de tetiklendiðinde yapýlacak iþlemler kodlanýr. 


-- Her tablo için 2 Tane geçici Hafýza Tablomuz var.
-- 1. INSERTED tablosu : Bir kayýt eklenmek istendiðinde önce inserted tablosuna yazýlýr, bir sorun çýkmazsa ya da baþka bir iþlem tarafýndan engellenmezse gerçek tabloya veriler aktarýlýr.
-- 2. DELETED tablosu : Bir kayýt silinmek istendiðinde önce deleted tablosuna yazýlýr, bir sorun çýkmazsa ya da baþka bir iþlem tarafýndan engellenmezse gerçek tablodan ilgili kayýt ya da kayýtlar silinir.

-- Güncelleme iþleminde ise kaydýn güncellenmeden önceki verileri deleted tablosuna, güncellendikten sonraki yeni verileri ise inserted tablosuna yazýlýr.

---------------------------------------------------------------------------------
--ALTER TRIGGER Trg_SilmeyiEngelle
--ON Urunler
--INSTEAD OF DELETE
--AS
--BEGIN

--	INSERT INTO LogTbl Values (GETDATE(),  SYSTEM_USER +  ' tarafýndan kayýt Silinmeye Çalýþýldý.')

--END

--------------------------------------------------------------------------------
--ALTER TRIGGER Trg_SilveLogla
--ON Urunler
--AFTER DELETE 
--AS
--BEGIN

--	DECLARE @ID int
--	DECLARE @Urun nvarchar(40)

--	SELECT @ID = UrunID FROM deleted 
--	SELECT @Urun = UrunAdi   FROM deleted

--	INSERT INTO LogTbl VALUES 
--	(Getdate(), SYSTEM_USER + ' tarafýndan ' + TRIM(Str(@ID)) + ' ID li ' + @Urun + ' isimli ürün, Ürünler tablosundan silindi.'  )
--END
--------------------------------------------------------------------------------

--ALTER TRIGGER Trg_UrunStoguGuncelle
--ON [dbo].[Satis Detaylari]
--AFTER INSERT
--AS
--BEGIN
--	DECLARE @UrunID int
--	DECLARE @Miktar smallint

--	SELECT @UrunID = UrunID, @Miktar = Miktar FROM inserted 

--	UPDATE Urunler SET HedefStokDuzeyi = HedefStokDuzeyi - @Miktar, YeniSatis = YeniSatis + @Miktar WHERE UrunID = @UrunID

--END
------------------------------------------------------------------------

--ALTER TRIGGER Trg_GuncellemeyiLogla
--ON Urunler
--AFTER Update
--AS
--BEGIN
--	DECLARE @UrunID int

--	DECLARE @old_UrunAd nvarchar(40)
--	DECLARE @new_UrunAd nvarchar(40)

--	DECLARE @old_Fiyat money
--	DECLARE @new_Fiyat money

--	SELECT @old_UrunAd = UrunAdi, @old_Fiyat = BirimFiyati, @UrunID = UrunID FROM deleted
--	SELECT @new_UrunAd = UrunAdi, @new_Fiyat = BirimFiyati FROM inserted

--	INSERT INTO LogTbl
--	VALUES (GETDATE(), SYSTEM_USER + ' tarafindan ' + TRIM(Str(@UrunID)) +  
--	' ID li Ürünün Eski Ürün Adi: ' + @old_UrunAd + ' - Yeni Ürün Adý: ' + @new_UrunAd + 
--	' - Eski Fiyatý: ' + TRIM(Str(@old_Fiyat)) + ' - Yeni Fiyatý: ' + TRIM(Str(@new_fiyat)) + ' olarak güncellendi.' )

--END








































