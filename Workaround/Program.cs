using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaraund
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer(isim:"Merve ");
            SelamVer(isim:"Engin ");
            SelamVer(isim:"Mehmet ");
            SelamVer();

            int sonuc = Topla(6,58);


            string ogrenci1 = "merve";
            string ogrenci2 = "Engin";
            string ogrenci3 = "Mehmet";


            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Merve";
            ogrenciler[1] = "Engin";
            ogrenciler[2] = "Mehmet";

            ogrenciler = new string[4];
            ogrenciler[3] = "ilker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Merve";
            person1.LastName = "demirel";
            person1.DateOfBirthYear = 2007;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Engin";

            foreach(string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //myList
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add(item: "Adana");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            
                Console.ReadLine();
            
        }
        //        //Degiskenler();
        //        Vatandas vatandas1 = new Vatandas();

        //        Console.ReadLine();
        //    }


        //resharper
        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("merhaba "+isim);
        }

        static int Topla(int sayi1=5,int sayi2=10)
        {
            int sonuc=sayi1+ sayi2;
            Console.WriteLine("Toplam: " +sonuc.ToString());
            return sonuc;
        }
        //    private static void Degiskenler()
        //    {
        //        string mesaj = "Merhaba";
        //        double tutar = 100000;
        //        int sayi = 100;
        //        bool girisYapmisMi = false;

        //        string ad = "merve";
        //        string soyad = "demirel";
        //        int dogumYili = 2007;
        //        long TCNo = 12345678910;


        //        Console.WriteLine(tutar * 1.18);

        //        Console.WriteLine(tutar * 1.18);
        //    }
        //}

        ////pascal casing
        //public class Vatandas
        //{
        //   public string Ad { get; set; }
        //  public  string Soyad { get; set; }
        //    public  int DogumYili { get; set; }
        //    public  long TCNo  { get; set; }
    }
}
