namespace _17_Struct;

internal class Program
{
    //Birden farklı veri tiplerinin bir araya gelmesinden oluşan yapıya denir.
    struct Ogrenci
    {
        public string ad, soyad, tcno, email, gsm;
        public bool cinsiyet;
        public DateTime dogumtarihi;
        public int okulno;
    }

    struct Kitap
    {
        public short sayfasayisi;
        public string KitapAdi;
        public string Yazar;
        public float Fiyat;
        public DateTime BasimTarihi;
        public byte CiltSayisi;
        public int Basim;
    }

    static void Main(string[] args)
    {
        #region
        /*
         *Bir siniftaki ogrencilerin bilgilerini tutmak için gerekli değişkenleri tanımlayınız.
         *
         *Adi, Soyadi, sinif, tcno, cinsiyet
         */


        /*List<string> adlar = new List<string>();
        List<string> soyadlar = new List<string>();

        List<bool> cinsiyetler = new List<bool>();
        List<DateTime> dogumtarihleri = new List<DateTime>();
        */


        #endregion
        Ogrenci ogrenci = new Ogrenci();

        ogrenci.ad = "Ali";
        ogrenci.soyad"Yılmaz";
        ogrenci.dogumtarihi = new DateTime(2000, 1 , 23);

        List<Ogrenci> ogrencilistesi = new List<Ogrenci>();
        ogrencilistesi.Add
    }
}

