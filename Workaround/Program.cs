internal class Program
{
    private static void Main(string[] args)
    {
        //Degiskenler();
        //Instance olusturma
        Vatandas vatandas1 = new Vatandas();

        SelamVer(isim: "Çağla");
        SelamVer(isim: "Özgü");
        SelamVer(isim: "Damla");
        SelamVer();

        int sonuc = Topla(777,2024);

        //Dizlier  


        Console.ReadLine();

    }

    //void metodlar sadece işi yaparlar , geriye bir değer döndürmezler.
    static void SelamVer(string isim="isimsiz")//isimsiz = default parametre
        
    {
        Console.WriteLine("Merhaba "+ isim);
    }


    //resharper uygulamasıyla sayi1 ve diğer parametrelerin değerleri görüntülenebilir

    static int Topla(int sayi1=5, int sayi2=10)
    {
        //default parametreler en sona yazılır.
        // ilk parametrenin defaultunu verip sonraki parametrenin defaultunu yazmamak gibi bi şey yok
        int sonuc = sayi1 + sayi2;
        //Console.WriteLine tostring dönüşümünü kendi yapıyor .ToString metoduna gerek kalmıyor.
        Console.WriteLine("Toplam :" + sonuc.ToString());
        return sonuc;
    }













    private static void Degiskenler()
    {
        string mesaj = "Merhaba!";
        double tutar = 100000; //dbden gelecek değer
        int sayi = 100;
        bool girisYapmisMi = false;

        string ad = "Cagla";
        string soyad = "Durmaz";
        int dogumYili = 1994;
        long tcNo = 12345678910;


        Console.WriteLine(tutar * 1.18);

        Console.ReadLine();
    }
}
/// <summary>
/// Sınıf içi değişkenlere public vermezsen başka yerden çağıramazsın
/// Classların defaultu public, değişkelerin private.
/// </summary>
public class Vatandas
{  //Pascal casing
    public string Ad { get; set; } // public fieldlar buyuk harle yazılır
    public string Soyad { get; set;}
    public int DogumYili { get; set;}
    public long TcNo { get; set;}
}
