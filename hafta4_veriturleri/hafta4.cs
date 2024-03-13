using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace hafta4_veriturleri
{
    internal class hafta4
    {
        static void Main(string[] args)
        {
            // ctrl + K + c  = SEÇili satırları yorum satırı yapar
            // ctrl + k + U  = seçili yorum satırlarını kaldırır.

            string adSoyad; //değişken tanımlama
            adSoyad = "Ahmet";  //değişkeni başlattık

            ushort satilanAracSayisi = 7;  //ushort veri tipi, sadece tamsayı kullanır.(0-65535) arası değer alır.
            //aşağıdaki satırda + operatörü birleştirme işlemi yaptı
            Console.WriteLine(adSoyad + " " + satilanAracSayisi + 5 + " araç sattı");
            //aşağıdaki satırda parantez içindeki + operatörü toplama yaptı, diğer ifadelerle sonucu birleştirme işlemi yaptı
           // Console.WriteLine(adSoyad + " " + (satilanAracSayisi + 5) + " araç sattı");

            //int toplam = 7 + 5;
            //int fark = 7 - 5;
            //int carpim = 7 * 5;
            //double bolme = 7 / 5;

            int sayi1=7, sayi2=5;

            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;
            int carpim = sayi1 * sayi2;  // int veri tipi tam sayılar için kullanılır
            float bolme =  (sayi1 / (float)sayi2); //double veri tipi ondalıklı veriler için kullanılır


            Console.WriteLine("ilk bolme sonucu : "+sayi1/sayi2);
            Console.WriteLine("ilk bolme sonucu {0}: ",sayi1 / sayi2);

            //aşağıdaki satırda tırnaklı ifadenin içindekiler aynen ekrana yazıdırılır. Aritemetiksel bir işlem yapılmaz.
            //Console.WriteLine("5 * 7 / 2 + 99");
            //aşağıdaki satırda tırnaklı ifade kaldırıldığı için aritmetiksel ifade çalışır
            //Console.WriteLine(5 * 7 / 2 + 99);
            // istediğimiz çıktı : toplama sonucu :  7 + 5 = 12
            //  Console.WriteLine("Toplama Sonucu :" +sayi1 + "+" + sayi2 + "=" + (sayi1+sayi2));
            Console.WriteLine("Toplama Sonucu : {0} + {1} = {2} ", sayi1,sayi2,(sayi1+sayi2));
            Console.WriteLine("çıkartma Sonucu : {0} - {1} = {2} ", sayi1, sayi2, (sayi1 - sayi2));
            Console.WriteLine("Çarpma Sonucu : {0} * {1} = {2} ", sayi1, sayi2, (sayi1 * sayi2));

            //tam sayılar bolme işleminden sonra ondalık kısmı atılır. Bunu engellemek için tamsayı değişkenlerden bir tanesini ondalıklı veri tipine dönüştürürüz. Yani değişkenin başına parantez içinde double, float yada decimal yazarız.
            bolme = (sayi1 / (float)sayi2);
            Console.WriteLine("Bölme Sonucu : {0} / {1} = {2} ", sayi1, sayi2, bolme);







            Console.ReadLine();
        }
    }
}
