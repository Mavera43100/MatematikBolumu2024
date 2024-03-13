using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_degiskenler
{
    internal class hafta3
    {
        static void Main(string[] args)
        {
            // değişkenler
            //  metin veri saklamak için kullanılacak değişken tipi --string

            // null demek hiçbirşey anlamındadır.Boşluk değildir, sıfır değildir.
            //string adSoyad = "";
            //string firstName = "Şenol";
            //adSoyad = firstName;
            //firstName = null;
            // ctrl + K + C  : seçili satır yada satırları açıklama satırına dönüştürür

            string ad;
            string soyad;
            // bir veri tipinden birden fazla değişkeni aynı satırda tanımlayabilirsiniz. aşağıdaki gibi
            // string name, lastname, sehir, ulke;

            // bir veri tipinden birden fazla değişkeni aynı satırda tanımlarken ilk değerlerini de atayabilirsiniz. Aşağıdaki gibi.
            string name = "ali", lastname = "can", sehir , ulke;

            name = "Şenol";
            lastname = "Demirci";
            sehir = "Kütahya";
            ulke = "Türkiye";

            // + operatörü string değişkenlerle kullanıldığında birleştirme işlemi yapar
            string fullName = name + " " + lastname;
            Console.WriteLine("Tam isim :"+fullName);
            // aşağıdaki satırda + operatörü sayıları toplama işlemi yapar
            Console.WriteLine("toplama sonucu :" + (20 + 50));
            Console.WriteLine("20"+"50");

            //  int sayı$;  yanlış değişken tanımlama
            //  int deger#  yanlış değişken tanımlama

            int sayı;
            int sayi_;
            int sayi1;
            int sayi2;
          //  int 1sayi;  // yanlış tanımlama. Sebebi rakamla başlayacamaz
         //   int 2sayi; // yanlış tanımlama. Sebebi rakamla başlayacamaz
            int _1sayi; //doğru değişken tanımlama
            int _2sayi; //doğru değişken tanımlama

            //aşağıdaki 2 değişkende birbirinden farklıdır. Büyük küçük harf ayrımından dolayı
            string _firstName;
            string _FIRSTNAME;
            _firstName = "şenol";
            string _firstname = "veli";
            _FIRSTNAME = "ahmet";

            long value = 100;
            long Value = 200;

            //değişkenlere en son atanan değer geçerlidir. Önceki veriler kaybolur.
            Value = 300;
            Console.WriteLine(Value);

            int a;
            //Bir değişkenin değeri, aynı veri tipindeki başka bir değişkene atanabilir.Ancak, bir değişken kullanılmadan önce bir değer atanmalıdır
            int ogrenciGecGeldigiGunSayisi;
            //ogrenciGecGeldigiGunSayisi = a; bu satır hatalı. çözümü a değişkenine hiç değer atanmamaış. a değişkenine herhangi bir değer atarsak sorun çözülür.
           


            Console.ReadLine();
        }
    }
}
