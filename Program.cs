internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

        Calisan calisan = new Calisan("Ayşe","Yılmaz","IK");

        Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);
        Calisan calisan1 = new Calisan("Ali","Bayrak","IT");
        Calisan calisan2 = new Calisan("Elif","Nur","IK");
        Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

        ;
        Console.WriteLine("Toplama islemi sonucu: {0}",Islemler.Topla(100,200));
        Console.WriteLine("Cikarma islemi sonucu: {0}",Islemler.Cikar(300,200));

    }
}

class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

    private string Isim;

    private string Soyisim;
    private string Departman;

    static Calisan()
    {
        calisanSayisi = 0;
    }

    public Calisan(string isim, string soyisim, string departman)
    {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman =departman;
        calisanSayisi ++;
    }
}

static class Islemler
{
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    public static long Cikar(int sayi1,int sayi2)
    {
        return sayi1 - sayi2;
    }
}