using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|||||||||| SAYI TAHMİN OYUNU ||||||||||\n");
            Console.WriteLine("               OYNANIŞ\n- Birinci oyuncu 1-50 arasında bir sayı girer.\n- İkinci oyuncu sayıyı tahim etmek için bir sayı girer.\n- İkinci oyuncunun zorluğa göre 5-10-20 tahin hakkı vardır.\n- Sayıyı tahmin eden oyuncu kazanır.");


            Console.WriteLine("Lütfen zorluğu seçiniz kolay/orta/zor : ");
            string deger = Console.ReadLine();
            int tahminSayısı = 2;
            if (deger == "kolay")
            {
                Console.Write("1-50 arası sayı giriniz: ");
                string bulunacakSayi1 = (Console.ReadLine());
                Console.Clear();
                Console.Write("1. Tahmininizi giriniz: ");
                string tahmin1 = Console.ReadLine();
                int hak1 = 19;
                while (tahmin1 != bulunacakSayi1)
                {
                    while (hak1 > 0)
                    {
                        Console.Write(tahminSayısı+". Tahmininizi giriniz: ");
                        tahmin1 = Console.ReadLine();
                        hak1--;
                        tahminSayısı++;
                        if (hak1 == 0)
                        {
                            Console.WriteLine("Hakkınız Bitmiştir.");
                        }
                    }
                }
                Console.WriteLine("SAYIYI DOĞRU TAHMİN ETTİNİZ!!!\nGİRİLEN SAYI: " + bulunacakSayi1);
            }
            else if (deger == "orta")
            {
                Console.Write("Bir sayı giriniz: ");
                string bulunacakSayi2 = (Console.ReadLine());
                Console.Clear();
                Console.Write("1. Tahmininizi giriniz: ");
                string tahmin2 = Console.ReadLine();
                int hak2 = 9;
                while (tahmin2 != bulunacakSayi2)
                {
                    while (hak2 > 0)
                    {
                        Console.Write(tahminSayısı + ". Tahmininizi giriniz: ");
                        tahmin2 = Console.ReadLine();
                        hak2--;
                        tahminSayısı++;
                        if (hak2 == 0)
                        {
                            Console.WriteLine("Hakkınız Bitmiştir.");
                        }
                    }
                }
                Console.WriteLine("SAYIYI DOĞRU TAHMİN ETTİNİZ!!!\nGİRİLEN SAYI: " + bulunacakSayi2);
            }
            else if (deger == "zor") { 
                Console.Write("Bir sayı giriniz: ");
            string bulunacakSayi = (Console.ReadLine());
            Console.Clear();
            Console.Write("1. Tahmininizi giriniz: ");
            string tahmin = Console.ReadLine();
            int hak = 4;
                while (tahmin != bulunacakSayi)
                {
                    while (hak > 0)
                    {
                        Console.Write(tahminSayısı + ". Tahmininizi giriniz: ");
                        tahmin = Console.ReadLine();
                        hak--;
                        tahminSayısı++;
                        if (hak == 0)
                        {
                            Console.WriteLine("Hakkınız Bitmiştir.");
                        }
                    }
                }
                Console.WriteLine("SAYIYI DOĞRU TAHMİN ETTİNİZ!!!\nGİRİLEN SAYI: " + bulunacakSayi);
            }
            else
            {
                Console.WriteLine("Hatalı derece seçtiniz!!");
            }
            
        }
    }
}
