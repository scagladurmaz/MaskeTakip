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
        string ogrenci1 = "Çağla";
        string ogrenci2 = "Damla";
        string ogrenci3 = "Özgü";

        Console.WriteLine(ogrenci1);
        Console.WriteLine(ogrenci2);
        Console.WriteLine(ogrenci3);

        string[] ogrenciler = new string[3];
        ogrenciler[0] =  "Çağla";
        ogrenciler[1] =  "Damla";
        ogrenciler[2] =  "Özgü";
        //ogrenciler[3] = "TheRasmus";
        ogrenciler = new string[4];
        ogrenciler[3] = "SomeoneLikeU";

        for(int i = 0; i< ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new[] { "Tokat", "Trabzon", "Ordu" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Kahramanmaraş";

        Console.WriteLine(sehirler2[0]);


        //int sayi1 = 10;
        //int sayi2 = 20;
        //sayi2 = sayi1;
        //sayi1 = 30;
        //sayi2= ? -> artık 10'dur


        //Person person1 = new Person();
        //person1.FirstName = "Çağla";

        //Person person2 = new Person(); bellekte bu nesne için (yine person sınıfından türetilen) bambaşka bir yer açtık
        //person2.FirstName = "Özgü";

        //String aslında bir referans tiptir. Çoğunlukla değer tip kullanılır. String bir char arraydir. 

        foreach (string sehir in sehirler1)// Bu döngüyle dizi formatındaki yapıları dönüyoruz. uzun uzun for yazmamak için
        {
            Console.WriteLine("sehir");//buradaki sehir diziyi gezerken elemanlar verilen bir takma isimdir, aliastır. hangisinn gezdiğimizi bilmek için 
        }

        //Generic Collections
        //3 elemanlı 4 elemanlı vs diye liste oluşturmuyoruz. Referans tipin referans probleminden kurtulmuş oluyoruz.
        List<string> yeniSehirler1 = new List<string> { "Sinop", "İstanbul", "Ağrı" };
        yeniSehirler1.Add("Tokat");
        //Add komutunun yaptıkları:newlediğimizde önce eski verileri cebe atıyo, newlediğimizde yenilioyr, cebe attıklarını listeye koyuyor ve yeni elemanı da sonuna ekliyor.
        foreach( var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }

        //ÖDEV



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
