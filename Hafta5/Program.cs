using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tamsayı değişkenler değerler bölme işlleminden sonra ondalık kısmı atılır
            //Console.WriteLine("bölme(float) işlem sonucu: " + (10 / 3f));//float -- f yada F decimal soneki
            //Console.WriteLine("bölme(double) işlem sonucu: " + (10 / 3d));//double -- d yada D double soneki
            //Console.WriteLine("bölme(decimal) işlem sonucu: " + (10 / 3m));//decimal -- m yada M decimal soneki

            //int s1=10, s2 = 3;

            //Console.WriteLine("bölme(float) işlem sonucu: " + (s1 / (float)s2));//float -- f yada F decimal soneki
            //Console.WriteLine("bölme(double) işlem sonucu: " + (s1 / (double)s2));//double -- d yada D double soneki
            //Console.WriteLine("bölme(decimal) işlem sonucu: " + ((decimal)s1 / s2));//decimal -- m yada M decimal soneki

            // artırma ve azaltma operatörleri  
            // artırma ve azaltma operatörleri

            int x = 5, y=10;
            x = 10;  //atama işlemi yapılıyor
            x = x + 10;  // ekleme işlemi yapılıyor.
           //Console.WriteLine("x değerinin son verisi : {0}", x);


            y = -5;//atama işlemi yapılıyor
            y = y - 5;  //eksiltme işlemi yapılıyor
                        // Console.WriteLine($"y değerinin son verisi : {y}");
            // x'in son değeri : 20, y'Nin son değeri : -10
            
            Console.WriteLine($"x'in son değeri : {x}");
            Console.WriteLine($"y'nin son değeri : {y}");
            //yukarıdaki 2 satır yazdırmak yerine \n kullanarak tek satırda yazdırdık.
            Console.WriteLine($"x'in son değeri : {x}\ny'nin son değeri : {y}");
            //Aşağıdaki satır, yukarıdaki satırın değişik bir yöntemle yazıdırlıması.
            // Console.WriteLine("x'in son değeri : {0}\ty'nin son değeri : {1}",x,y);

            //bir değişkeni 1'er artırmak veya azaltmak için ;
            int sayi = 10;
            sayi++;  //sayi değişkenini 1 artırır
            sayi = sayi + 1;//bu satır bir üst satırdaki işlemle aynısı


            sayi--; //sayi değişkenini 1 eksiltir
            sayi = sayi - 1; //bu satır bir üst satırdaki işlemle aynısı

            int value1 = 20;
            int value2 = 0;
            //value1 = value1++;  //postfix
            value2 = value1++;  //prefix
            Console.WriteLine($"value1 değeri: {value1}");

            // = atama operatörü
            // bileşik atam operatörleri
            //   +=
            //   -=
            //   *=
            //   /=

            long val1 = 15;
            long val2 = 25;
            long sonuc = 100;
            //sonuc = sonuc + (val2 * val1); // ekleme işlemi yapıldı. sonuc değişkenin önceki değeri ekleme yapıldı.
            //sonuc = (val2 * val1); //atama işlemi yapıldı. sonuç değişkeninin önceki değeri yok sayıldı.

            sonuc += val1 * val2;//eşitliğin sağındaki işlem sonucunu sol taraftaki değişkene ilave et/ekle.
            Console.WriteLine($"sonuc değişkeninin değeri : {sonuc}");

         
            sonuc = 100;
            sonuc = sonuc - 15; //sonuc değikenini 15 eksilttik
            sonuc -= 15;  //sonuc değikenini 15 eksilttik
            sonuc -= val2;
            Console.WriteLine($"eksiltme operatöründen sonra : sonuc değişkeninin değeri : {sonuc}");

            sonuc = 100;
            //sonuc = val1 * val2; //atama işlemi
            //sonuc = sonuc + (val1 * val2);
            // sonuc = sonuc * val1;

            sonuc *= val1; //aşağıdaki satırın kısa yazılışı
            sonuc = sonuc * val1;//yukarıdaki satırın aynısı

            sonuc = 100;
            sonuc = sonuc / 10; //aşağıdaki satırın ayınısı
            sonuc /= 10;  //yukarıdaki satırın kısa yazılışı

            double kalan = 10;
            kalan = kalan % 3f;

            kalan %= 3f;

            Console.OutputEncoding = Encoding.UTF8;

            decimal[] tutarlar = { 16305.32m, 18794.16m };
            Console.WriteLine("{0,-28}{1,-20}", "Bütçe Başlangıç Tutarı", "Bütçe Bitiş Tutarı");
            Console.WriteLine("{0,-28:C2}{1,-20:C2}", tutarlar[0], tutarlar[1]);


        }
    }
}
