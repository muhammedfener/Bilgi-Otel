CREATE PROCEDURE sp_calisanGuncelle
(
	@calisanID int,
	@calisanAd nvarchar(80),
	@calisanSoyad nvarchar(80),
	@calisanTelefon nvarchar(15),
	@calisanTCKimlik nvarchar(80),
	@calisanAdres nvarchar(200),
	@calisanIrtibatTelefon nvarchar(15),
	@calisanIseBaslamaTarihi Date,
	@calisanIstenAyrilmaTarihi Date,
	@calisanMeslekID int,
	@calisanSaatlikUcret decimal(5,2),
	@calisanAktifMi bit
)
AS
BEGIN
	BEGIN TRY
		UPDATE calisanlar SET calisanAd = @calisanAd, calisanSoyad = @calisanSoyad, calisanTelefon = @calisanTelefon,calisanTCKimlik = @calisanTCKimlik, calisanAdres = @calisanAdres, calisanIrtibatTelefon=@calisanIrtibatTelefon, calisanIseBaslamaTarihi=@calisanIseBaslamaTarihi, calisanIstenAyrilmaTarihi = @calisanIstenAyrilmaTarihi, calisanMeslekID=@calisanMeslekID, calisanSaatlikUcret = @calisanSaatlikUcret, calisanAktifMi=@calisanAktifMi WHERE calisanID = @calisanID;
	END TRY
	BEGIN CATCH
		SELECT 0;
	END CATCH
END

GO

CREATE PROCEDURE sp_calisanEkle
(
	@calisanID int,
	@calisanAd nvarchar(80),
	@calisanSoyad nvarchar(80),
	@calisanTelefon nvarchar(15),
	@calisanTCKimlik nvarchar(80),
	@calisanAdres nvarchar(200),
	@calisanIrtibatTelefon nvarchar(15),
	@calisanIseBaslamaTarihi Date,
	@calisanIstenAyrilmaTarihi Date,
	@calisanMeslekID int,
	@calisanSaatlikUcret decimal(5,2),
	@calisanAktifMi bit
)
AS
BEGIN
	BEGIN TRY
		INSERT INTO calisanlar (calisanAd,calisanSoyad,calisanTelefon,calisanTCKimlik,calisanAdres,calisanIrtibatTelefon,calisanIseBaslamaTarihi,calisanIstenAyrilmaTarihi,calisanMeslekID,calisanSaatlikUcret,calisanAktifMi) VALUES (@calisanAd,@calisanSoyad,@calisanTelefon,@calisanTCKimlik,@calisanAdres,@calisanIrtibatTelefon,@calisanIseBaslamaTarihi,@calisanIstenAyrilmaTarihi,@calisanMeslekID,@calisanSaatlikUcret,@calisanAktifMi);
	END TRY
	BEGIN CATCH
		SELECT 0;
	END CATCH
END

GO

CREATE VIEW vw_calisanlarLv
AS
SELECT (calisanAd + ' ' + calisanSoyad) as [Ad Soyad], calisanTCKimlik, calisanTelefon, meslekAd, calisanAdres, calisanSaatlikUcret FROM calisanlar JOIN meslekler ON meslekler.meslekID = calisanlar.calisanMeslekID WHERE calisanAktifMi=1;

GO

CREATE VIEW vw_mesleklerCmb
AS
SELECT meslekID,meslekAd FROM meslekler WHERE meslekAktifMi=1;

GO

CREATE VIEW vw_odalarLv
AS
SELECT odaNumara, odaKat, odaKisiSayisi, odaFiyat FROM odalar;

GO

CREATE VIEW vw_kampanyalarLv
AS
SELECT kampanyaID, kampanyaAd, kampanyaIndirimOrani, kampanyaBaslangic, kampanyaBitis, kampanyaAciklama FROM kampanyalar;