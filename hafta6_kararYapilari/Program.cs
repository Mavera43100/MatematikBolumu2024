using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta6_kararYapilari
{
    internal class Program
    {

        static void tekli_IF()
        {
            //karar yapıları
            //  1- tek seçenekli if deyimi

            // if(koşul)
            // koşul sağlanırsa bu kodlar çalışacak

            //örnek
            // alabileceği kredi = 24 olan  bir öğrenci eğer GNO(genel not ort.) 3 ve üzerinde ise ilave 4 kredi verilecek. Ayrıca harç tutarı da %50 azaltılacak
            int maksimumKredi = 24;
            double gno = 3.2;
            double harcTutari = 2000;

            // neden if bloğunu süslü parantez içine alırız? cevap. Eğer koşul sağlanması durumunda çalışacak olan satır sayısı 1'den fazla ise süslü parantez içinde yazılır. Tek satırsa gerek yoktur.

            if (gno >= 3.0)  //çalışacak satır sayısı 1'den fazla olduğundan süslü parantez içinde yazdık.
            {
                maksimumKredi = maksimumKredi + 4;
                harcTutari = harcTutari * .50;
                Console.WriteLine("Öğrencinin Alabileceği Max Kredi değişti {0}", maksimumKredi);
                Console.WriteLine($"Öğrencinin Harç Tutarı Azaltıldı {harcTutari}");
            }
        }

        void tekliIF_2()
        {
            int maksimumKredi = 24;
            double gno = 3.2;
            double harcTutari = 2000;
            string bolum = "matematik";

            if (gno >= 3 && bolum == "matematik")
            {
                maksimumKredi += 4;   //yada ==> maksimumKredi = maksimumKredi + 4;
                harcTutari = harcTutari * .5;
                Console.WriteLine("Öğrencinin Alabileceği Max Kredi artırıldı {0}", maksimumKredi);
                Console.WriteLine($"Öğrencinin Harç Tutarı Azaltıldı {harcTutari}");
            }

        }

        void ifelse_1()
        {  // klavyden girilen bir sayının tek mi yada çift mi olduğunu bulan kod?
            Console.WriteLine("Bir sayı giriniz .");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 0)
                Console.WriteLine("sayı çifttir...");
            else //if satırı false olursa buradaki else bloğu çalışır
                Console.WriteLine("sayı tektir"); //olse için sadece bu satır çalışır.
        }

        void ifelse_2()
        {
            // if else yapısı
            // if else yapısı

            //örnek
            // alabileceği kredi = 24 olan bir öğrenci eğer GNO(genel not ort.) 3 ve üzerinde ise ilave 4 kredi verilecek. Ayrıca öğrencinin bölümü "matematik" ise harç tutarı da % 50 azaltılacak
            // bu 2 koşul sağlanmıyorsa kredi 2 artırılacak, harç % 10 azaltılacak.
            int maksimumKredi = 24;
            double gno = 3.2;
            double harcTutari = 2000;
            string bolum = "matematik";

            if (gno >= 3 && bolum == "matematik")
            {
                maksimumKredi += 4;   //yada ==> maksimumKredi = maksimumKredi + 4;
                harcTutari = harcTutari * .5;
            }
            else
            {
                maksimumKredi += 2;   //yada ==> maksimumKredi = maksimumKredi + 2;
                harcTutari -= harcTutari * .1;
            }
            Console.WriteLine("Öğrencinin Alabileceği Max Kredi artırıldı {0}", maksimumKredi);
            Console.WriteLine($"Öğrencinin Harç Tutarı Azaltıldı {harcTutari}");

            Console.WriteLine("Program bitti.");
            Console.ReadLine();//sadece ENTER tuşuna basılmasını bekliyoruz. O yüzden bir değişkene aktarmadık.


        }
        static void Main(string[] args)
        {
            // girilen 5 sayının toplamını ve ortalamasını bulan prog. kodlarını yazın.
            double sayi = 0;
            double toplam = 0;
            double ortalama = 0;
            int sayac = 1;

            tekraret:   //label yani etiket tanımlaması yaptık.
            Console.WriteLine($"{sayac}.Sayıyı Giriniz :");
            sayi = double.Parse( Console.ReadLine());
            toplam += sayi;
            sayac++;
            //girilen sayı adedi 5 den küçükse tekraret etiketine git...
            if (sayac <= 5)
                goto tekraret;
            ortalama = toplam / sayac;
            Console.WriteLine($"Girilen 5 sayının Toplamı : {toplam}.\nOrtalaması ise : {ortalama}");
            Console.ReadLine();



        }
    }
}
