using System;

namespace metod_tanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            // erişim belirleyici  geri dönüştipi  metot adi (parametreListesi/arguman)
            //{
                //Komutlar;
                //return;
            //}

            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));// metodu tanımlarken string olarak tanımladık ancak şuan int değer attık bu nedenle string metoduna çevirdik.
            
            int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(a+b));
            ornek.EkranaYazdir(Convert.ToString(sonuc2));

            
        }
        static int Topla(int deger1, int deger2){
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1, ref int deger2)//ref demek ramdeki referans değerine gidip koptasıyla çalışmak erine orjinaliyle değişiklik yapmayı sağlar.
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }


    }

}
