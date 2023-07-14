using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_diziler_döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tek boyutlu
            //string[] student = new string[3] { "gözde", "ceren", "yıldız" };
            //Console.WriteLine();
            //Console.ReadLine(); 
            #endregion
            #region çok boyutlu diziler

            //string[,] bolge = new string[7, 3]
            //{
            //    {"istanbul","bursa","izmit"},
            //    { "ankara","konya","eskişehir"},
            //    {"antalya","mersin","hatay" },
            //    {"aydın","izmir","muğla"},
            //    {"trabzon","ordu","rize" },
            //    {"sivas","van","elazığ" },
            //    { "antep","diyarbakır","adana"}

            //};
            //for (int i = 0; i <= bolge.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= bolge.GetUpperBound(1); j++)
            //    {
            //        Console.WriteLine(bolge[i, j]);
            //    }
            //    Console.WriteLine("---------------");
            //}
            //Console.ReadLine();
            #endregion

            #region döngüler

            #endregion

            #region örnek (asal sayıları bulan bir örnek)döngü
            //int sayac = 0;
            //Console.WriteLine("Sayıyı Girin");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //    }
            //}
            //if (sayac == 2)
            //{
            //    Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", sayi);
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", sayi);
            //}
            //Console.ReadLine();
            #endregion

            #region örnek 2 tam bölenlerini veren(döngü)
            //sayac=tane hessabını yapıyor burada
            //int sayac = 0;
            //Console.WriteLine("Sayıyı Girin");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        Console.Write(i + " ");
            //        sayac++;
            //    }
            //}
            //if (sayac == 2)
            //{
            //    Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", sayi);
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir. {1} tane tam böleni vardır.", sayi, sayac);
            //}

            //Console.ReadLine();

            #endregion

            #region örnek3 döngü

            //for(int i =1;i <=10;i++)
            //    {
            //        for (int j = 1; j <=i ; j++)
            //        {
            //            Console.Write(j);
            //        }
            //        Console.WriteLine("");
            //    }
            //Console.ReadLine();
            #endregion


            //1----------------------------------------------------
            //int a = 1;
            //int toplam = 0;
            //do
            //{
            //    toplam += a;
            //    a = a + 1;
            //}
            //while (a <= 100);
            //{
            //    Console.WriteLine("toplam: " + toplam);
            //}
            //Console.ReadLine();

            //2-------------------------------------------------

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 0; j <= 10; j++)
            //    {
            //        Console.WriteLine(i + "x" + j+"="+(i*j)) ;
            //        Console.WriteLine("----------------------");
            //    }

            //}
            //3---------------------------------------------------
            #region örnek diziler

            //int[] sayılar = new int[4];

            //for (int i = 0; i < sayılar.Length; i++) 
            //{
            //    Console.WriteLine((i + 1) + ".sayı giriniz:");
            //    sayılar[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < sayılar.Length; i++) 

            //{
            //    Console.WriteLine(sayılar[i]);
            //}
            #endregion
            #region örnek diziler2
            int teksayıadet =0;
            int çiftsayıadet = 0;

            int teksayıtoplam = 0;
            int çiftsayıtoplam = 0;

            int kullanıcı;

            int[] sayı = new int[10];
            for (int i = 0; i < sayı.Length; i++)
            {
                Console.Write((i+1)+".değer:");
                kullanıcı=int.Parse(Console.ReadLine());
                sayı[i] = kullanıcı;

            }
            for (int j = 0; j < sayı.Length; j++)
            {
                if (sayı[j] % 2 == 0)
                {
                    çiftsayıadet++;
                    çiftsayıtoplam += sayı[j];
                }
                else
                {
                    teksayıadet++;
                    teksayıtoplam += sayı[j];
                }
            }
            Console.WriteLine("çift sayıların adedi:" + çiftsayıadet);
            Console.WriteLine("çift sayıların toplamı:"+çiftsayıtoplam);
            Console.WriteLine("tek sayıların adedi:" + teksayıadet);
            Console.WriteLine("tek sayıların toplamı:" + teksayıtoplam);

           
            #endregion
            Console.ReadLine(); 
        }
    }
}
