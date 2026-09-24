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

SELECT UrunAdi AS 'Ürün', kategoriAdi AS 'Kategori', SirketAdi AS 'Tedarikçi Firma', Ulke
FROM Urunler 
JOIN Kategoriler ON Urunler.KategoriID = Kategoriler.KategoriID
JOIN Tedarikciler ON Urunler.TedarikciID = Tedarikciler.TedarikciID

-----------------------------------

SELECT UrunAdi, SUM(Miktar) AS 'Satýlan Adet', SUM([Satis Detaylari].BirimFiyati * Miktar) AS 'Ciro'  FROM Urunler
JOIN [Satis Detaylari] ON Urunler.UrunID = [Satis Detaylari].UrunID
JOIN Satislar ON [Satis Detaylari].SatisID = Satislar.SatisID
GROUP BY UrunAdi
ORDER BY UrunAdi
------------------------------------
SELECT UrunAdi, SUM([Satis Detaylari].BirimFiyati * Miktar)  AS 'Toplam Ciro' FROM [Satis Detaylari] JOIN Urunler ON [Satis Detaylari].UrunID = Urunler.UrunID
GROUP BY UrunAdi

--TODO: ÖDEV : Müþteriye Göre Satýþ Toplamlarý raporunu yap.