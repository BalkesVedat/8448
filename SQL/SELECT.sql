USE TarifSepetiDB
GO

SELECT * FROM Siparisler

SELECT COUNT(*) AS 'Sipariþ Adedi' FROM Siparisler

SELECT * FROM Siparisler WHERE Durumu <> '9'

SELECT COUNT(*) AS 'Teslim Edilmemiþ Sipariþler' FROM Siparisler WHERE Durumu <> '9'

SELECT YemekID, COUNT(*) AS 'Sipariþ Adedi' FROM Siparisler GROUP BY YemekID

SELECT Y.YemekAdi, COUNT(*) 'Sipariþ Adedi' FROM Siparisler S JOIN Yemekler Y ON S.YemekID = Y.YemekID WHERE Durumu <> 8 GROUP BY YemekAdi ORDER BY YemekAdi


USE Northwind
GO

SELECT UrunAdi, BirimdekiMiktar, BirimFiyati, HedefStokDuzeyi FROM Urunler WHERE HedefStokDuzeyi > 0 OR Sonlandi = 0

SELECT * FROM Kategoriler


SELECT [MusteriID],[SatisTarihi],[NakliyeUcreti] FROM Satislar WHERE [MusteriID] = 'VINET' ORDER BY  [NakliyeUcreti] DESC

-- WHERE  Filtre ifadesidir. Koþula uyan kayýtlarý seçer.
-- like metinsel koþul ifadelerinde metnin içerisinde, baþýnda ya da sonunda bulunan bir sözcüðe göre filtreler. % iþareti ile birlikte kullanýlýr. aranacak metnin önüne, arkasýna yada her iki tarafýna % iþareti koyarak filtre þablonu oluþturulur. þablon '' içerisinde yazýlýr. like ifadesi de bu þablona benzeyen kayýtlarý döner.  'c%' -> c ile baþlayanlar, '%TL' -> TL ile bitenler, '%anton%' -> içinde anton geçenler.

SELECT * FROM Urunler WHERE UrunAdi like 'C%' -- C ile baþlayanlar.
SELECT * FROM Urunler WHERE UrunAdi like '%anton%' -- içinde anton geçenler
SELECT * FROM Urunler WHERE UrunAdi not like '%anton%' -- içinde anton geçmeyenler.

SELECT * FROM Urunler WHERE kategoriID = 5 OR kategoriID = 6 --ya da
SELECT * FROM Urunler WHERE kategoriID in (3,5,7,9) -- bu listenin içinde geçenler. 
SELECT * FROM Urunler WHERE kategoriID not in (3,5,7,9) -- bu listenin haricindekiler.

SELECT * FROM Urunler WHERE BirimFiyati >= 25 AND BirimFiyati <= 50  -- ve. yani her iki koþula uyanlar listelenir. Burada 25 ile 50 arasýndakileri aldýk.
SELECT * FROM Urunler WHERE BirimFiyati BETWEEN 25 AND 50 -- alternatif aralýk belirtimi.
SELECT * FROM Satislar WHERE SatisTarihi BETWEEN '2026-01-01' AND GETDATE() -- tarih datasý için aralýk belirterek filtreleme.


--ORDER BY
-- Sýralama komutudur. listeyi herhangi bir alana göre artan ya da azalan düzende sýralar.
-- ASC -> artan, DESC -> azalan sýralama belirtir. sýralama yönü belirtilmezse varsayýlan sýralama artan düzende uygulanýr.

SELECT * FROM Urunler ORDER BY UrunAdi --  A-->Z sýralar. (ASC) yazmýþýz gibi.
SELECT * FROM Urunler ORDER BY UrunAdi DESC --  Z-->A sýralar.

SELECT * FROM Satislar ORDER BY SatisTarihi DESC --  Yeniden eskiye doðru sýralar.


-- GROUP BY
-- Listelenen verileri gruplayarak gösterir.

SELECT SatisID FROM [Satis Detaylari] GROUP BY SatisID

SELECT Ulke, COUNT(Sehir) AS 'Þehir Sayýsý' FROM Musteriler GROUP BY Ulke

SELECT Unvan FROM Personeller GROUP BY Unvan

SELECT DISTINCT Unvan FROM Personeller

SELECT Unvan, COUNT(Unvan) 'Ünvan Sayýsý'  FROM Personeller GROUP BY Unvan

-----------------------------------------------------

--JOIN
-- DB deki tablolarý, ortak alanlarý üzerinden birbirine birleþtirir. Birleþtirdiðimiz tablolarýn alanlarýný SELECT listesine ekleyebiliriz. Tablolarýn hangi ortak alanlarý üzerinden birbirine baðlayacaðýmýzý 'ON' ifadesinden sonra yazýyoruz.

--SELECT * FROM Tablo1 .... JOIN Tablo2 ON Tablo1.ID = Tablo2.ID 
-- (INNER) JOIN : Her 2 tabloda da bulunan ve eþleþen kayýtlar listelensin.
-- RIGHT (OUTER) JOIN :  ON ifadesinden sonra eþitliðin saðýnda bulunan (Tablo2) tablodaki tüm kayýtlar listelensin. (Soldaki tabloda onlarla eþleþen kayýtlar olmasa dahi listelenir.)
-- LEFT (OUTER) JOIN  :  ON ifadesinden sonra eþitliðin solunda bulunan (Tablo1) tablodaki tüm kayýtlar listelensin. (Saðdaki tabloda onlarla eþleþen kayýtlar olmasa dahi listelenir.)
-- FULL (OUTER) JOIN  : Eþleþtirilen tablolardan tüm kayýtlar listelensin. Bir tarafta olup, diðer tarafta olmayan kayýtlar da gösterilsin.


-- Ürünlerin Kategori isimleri kategoriler tablosundan ve tedarikçi bilgileri ise tedarikçiler tablosundan join lenerek çekildi.
SELECT UrunAdi AS 'Ürün', kategoriAdi AS 'Kategori', SirketAdi AS 'Tedarikçi Firma', Ulke
FROM Urunler 
JOIN Kategoriler ON Urunler.KategoriID = Kategoriler.KategoriID
JOIN Tedarikciler ON Urunler.TedarikciID = Tedarikciler.TedarikciID

-----------------------------------

-- Ürünlerin Tüm Satýþ Toplamlarý (Hiç satýlmamýþ ürünler hariç. Hiç satýlmamýþ ürünleri de listede görmek isteseydik o zaman bu sorgu için LEFT JOIN yazmalýydýk.)
SELECT UrunAdi, SUM(Miktar) AS 'Satýlan Adet', SUM([Satis Detaylari].BirimFiyati * Miktar) AS 'Ciro'  
FROM Urunler
JOIN [Satis Detaylari] ON Urunler.UrunID = [Satis Detaylari].UrunID
GROUP BY UrunAdi
ORDER BY UrunAdi
------------------------------------

--Ürüne göre satýþ detaylarýnýn tutara göre büyükten-küçüðe sýralý listesi
SELECT UrunAdi, COUNT(Miktar) AS 'Sipariþ Sayýsý', SUM(Miktar) AS 'Adet', SUM([Satis Detaylari].BirimFiyati * Miktar)  AS 'Toplam Ciro' FROM [Satis Detaylari] 
RIGHT OUTER JOIN Urunler ON [Satis Detaylari].UrunID = Urunler.UrunID
GROUP BY UrunAdi
ORDER BY 'Toplam Ciro' DESC

-- Müþteriye Göre Satýþ Toplamlarý raporunu (Tutara göre azalan sýralý)
Select  MusteriAdi, SUM(SD.Miktar * SD.BirimFiyati) AS 'Tutar' From Musteriler M 
LEFT JOIN Satislar S ON M.MusteriID = S.MusteriID 
LEFT joIn [Satis Detaylari] SD ON S.SatisID = SD.SatisID
GROUP BY MusteriAdi
ORDER BY 'Tutar' DESC

------------------------------------------------------------
-- Þimdiye kadar hiç satýlmamýþ ürünlerimizin listesi.
SELECT * FROM Urunler U LEFT OUTER JOIN [Satis Detaylari] SD ON U.UrunID = SD.UrunID  
WHERE SD.UrunID is NULL
-------------------------------------------------------------
-- Þimdiye kadar hiç alýþveriþ yapmamýþ müþteriler.
SELECT * FROM Musteriler LEFT JOIN Satislar ON Musteriler.MusteriID = Satislar.MusteriID
WHERE Satislar.MusteriID is null





