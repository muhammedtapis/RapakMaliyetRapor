using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapakMaliyetRapor.Core.Entity;

public class MuhasebeFis
{
    [Key]
    public int Row_ID { get; set; }

    public string AltHesapKodu { get; set; }
    public DateTime IslemTarihi { get; set; }
    public int FisTipi { get; set; }
    public int FisNo { get; set; }
    public int SiraNo { get; set; }
    public string Aciklama { get; set; }
    public bool BorcAlacak { get; set; }
    public decimal Tutar { get; set; }
    public int MaddeNo { get; set; }
    public string FisKodu { get; set; }
    public int IsleminParaBirimi { get; set; }
    public string GirenKaynak { get; set; }
    public DateTime GirenTarih { get; set; }
    public string GirenSaat { get; set; }
    public string GirenKodu { get; set; }
    public string GirenSurum { get; set; }
    public string DegistirenKaynak { get; set; }
    public DateTime DegistirenTarih { get; set; }
    public string DegistirenSaat { get; set; }
    public string DegistirenKodu { get; set; }
    public string DegistirenSurum { get; set; }
    public string Referans { get; set; }
    public string Aciklama2 { get; set; }
    public string DovizCinsi { get; set; }
    public decimal DovizTutari { get; set; }
    public decimal DovizKuru { get; set; }
    public string OzelKod { get; set; }
    public string EvrakNo { get; set; }
    public string MasrafMerkeziKodu { get; set; }
    public decimal Miktar { get; set; }
    public string Birim { get; set; }
    public DateTime EvrakTarihi { get; set; }
    public string CHKodu { get; set; }
    public DateTime VadeTarihi { get; set; }
    public int IslemTipi { get; set; }
    public decimal VadeFarkiTutari { get; set; }
    public DateTime DuzeltmeyeEsasTarih { get; set; }
    public decimal KrediTutari { get; set; }
    public decimal KrediFaizi { get; set; }
    public DateTime KrediFaizDonBasTarih { get; set; }
    public DateTime KrediFaizDonBitTarih { get; set; }
    public decimal ReelOlmFinMaliyet { get; set; }
    public int DuzAitOlduguYil { get; set; }
    public int DuzAitOlduguDonem { get; set; }
    public string DuzAitOlduguEvrak { get; set; }
    public DateTime DuzAitOlduguTarih { get; set; }
    public string GiderTuru { get; set; }
    public int ArindirmaSekli { get; set; }
    public decimal DuzeltilmisDeger { get; set; }
    public bool BaBsFlag { get; set; }
    public string VergiHesapNo { get; set; }
    public string VergiDairesi { get; set; }
    public string Ulke { get; set; }
    public int EvrakSayisi { get; set; }
    public string KartUnvani { get; set; }
    public decimal KDVOrani { get; set; }
    public int FormBYil { get; set; }
    public int FormBAy { get; set; }
    public string KartDovizCinsi { get; set; }
    public decimal KartDovizTutari { get; set; }
    public int EvrakTipi { get; set; }
    public decimal KDVMatrahi { get; set; }
    public decimal KDVTutari { get; set; }
    public int SEQNo { get; set; }
    public string IthalatNo { get; set; }
    public int YevmiyeSiraNo { get; set; }
    public int OdemeTipi { get; set; }
    public int YevmiyeEvrakTip { get; set; }
    public string EvrakTipAciklama { get; set; }
    public int KDVTevkIslemTuru { get; set; }
    public decimal KDVTevkOrani { get; set; }
    public decimal KDVTevkIslemBedeli { get; set; }
    public string KaynakEvrakNo { get; set; }
    public DateTime KaynakEvrakTarihi { get; set; }
    public int OdemeTurKodu { get; set; }
    public string Kod1 { get; set; }
    public string Kod2 { get; set; }
    public string Kod3 { get; set; }
    public string Kod4 { get; set; }
    public string Kod5 { get; set; }
    public int KDV1BelgeTipi { get; set; }
    public int KDV1BelgeSayisi { get; set; }
    public string Resim { get; set; }
    public string Kod6 { get; set; }
    public string Kod7 { get; set; }
    public int BYNTurKodu { get; set; }
    public int BYNOdemeTuru { get; set; }
}