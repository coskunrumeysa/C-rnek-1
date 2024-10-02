//Benim Başarım Ancak ALLAH'ın Yardımı İledir. Hud/88
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_Proje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definition Variables
            string isim;
            int yas;
            int sinif;

            Console.Write("Lütfen İsmininizi Giriniz:");
            isim = Console.ReadLine();

            //Ekrana bastırmak için Write ve WriteLine fonksiyonları kullanılır.Readline fonksiyonu ise girdiler için kullanılır. Ancak Readline fonksiyonu
            //String değer döndürdüğü için veri tipi int olan bir değerde Convert.ToInt32(Readline()) dönüşümü yapmamız gerekir.
            Console.Write("Lütfen Yaşınızı Giriniz:");
            yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen Sınıfınızı Giriniz:");
            sinif = Convert.ToInt32(Console.ReadLine());


            // WriteLine ve Write fonksiyonları arasındaki fark ise Writeline fonksiyonu satırdaki kod okuduktan sonra imleci bir alt satıra geçirir. Write ise aynı satırdan devam eder.
            Console.WriteLine("Hoşgeldiniz " + isim);
            Console.WriteLine("Yaşınız " + yas);
            Console.Write("Sınıfınız " + sinif);
                
            //Kod çalıştıktan sonra komut sayfasının kapanmasını engellemek için kullanılır.
            Console.ReadKey();




           


        }
    }
}
