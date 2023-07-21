# deneme-diziler-d-ng-ler
### DÖNGÜLER

**ÖRNEK 1**

*Lise yıllarında bir sayının asal olup olmadığı anlamak öğrenci için çok zordur.Aslında tam bölenlerini bulmakla aynı şeydir diyebiliriz.Bunu yazılım dilinde görmek gerekirse ...*
           
            int sayac = 0;
            Console.WriteLine("Sayıyı Girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 2)
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", sayi);
            }
            else
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", sayi);
            }
            Console.ReadLine();

**ÖRNEK 2**

*Ortaokul , Lise yıllarında bir sayı başka hangi sayılara tam bölündüğünü bulmak için çarpanlarını bulup yazılırdı.Ama büyük sayılar için bulmak zordur.Biraz C# dili biliniyorsa bunu bulmak kolay oluyor. C# 'da koda dökersek.*

*Kullanıcıdan ilk olarak veri girilmesi beklenir.Tabi bu veri int yani tam sayı olmak şartıyla.Girilen veriyi ilk tipi belli değildir.Biz bunu int çevirmek için conver.ToInt32(Console.ReadLine()) kullanırız.Daha sonra bu sayıyı döngüye sokarız.Çünkü bu sayı için tam bölenleri bulmak için belli şartları içermeli.Bir i değeri olur.Tam bölüneni bulmak için i değeri 1 den başlatılır ve sayıya eşit olana kadar döngü döner.Girilen sayı ilk (1) bloğuna düşer.Burada i değerimiz 1 dir.Her sayı 1'e tam bölüneceğinden 1 değeri tam bölünenler içine atılır.Bir sonraki i değeri için bakılır.Bunun için ise sayac ifadesi kullanmayı tercih ettim.Döngü sonunda her İ değeri  1 kere artırılarak i değerlerine bakılır.Eğer sadece bu döngü 2 kere dönüyor ise bu sayı asal sayıdır diyebiliriz.Çünkü sadece 1 ve kendisi için dönmüştür.*

            sayac = tane hessabını yapıyor burada
            int sayac = 0;
            Console.WriteLine("Sayıyı Girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)//(1)
                {
                    Console.Write(i + " ");
                    sayac++;
                }
            }
            if (sayac == 2)
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", sayi);
            }
            else
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir. {1} tane tam böleni vardır.", sayi, sayac);
            }

            Console.ReadLine();
**ÖRNEK 3**

*1'den 100'e kadar olan sayıların toplamını veren kod.DO WHİLE döngüsü kullanılmıştır.*

            int a = 1;
            int toplam = 0;
            do
            {
                toplam += a;
                a = a + 1;
            }
            while (a <= 100);
            {
                Console.WriteLine("toplam: " + toplam);
            }
            Console.ReadLine();

**ÖRNEK 4**

*Çarpım tablosunu veren kod için diziler kullanılabilir.*


            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + (i * j));
                    Console.WriteLine("----------------------");
                }

            }

### DİZİLER

**ÖRNEK 1**

*Kullanıcıdan istenilen 4 değeri tek tek yazdıran kod.*

            int[] sayılar = new int[4];

            for (int i = 0; i < sayılar.Length; i++)
            {
                Console.WriteLine((i + 1) + ".sayı giriniz:");
                sayılar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < sayılar.Length; i++)

            {
                Console.WriteLine(sayılar[i]);
            }

**ÖRNEK 2**

*Kullanıcıdan alınan 10 tane değer arasında çift sayı adedini ve toplamını,tek sayıların adedini ve toplamını veren kod için diziler kullanılır.

int teksayıadet = 0;
            int çiftsayıadet = 0;

            int teksayıtoplam = 0;
            int çiftsayıtoplam = 0;

            int kullanıcı;

            int[] sayı = new int[10];
            for (int i = 0; i < sayı.Length; i++)
            {
                Console.Write((i + 1) + ".değer:");
                kullanıcı = int.Parse(Console.ReadLine());
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
            Console.WriteLine("çift sayıların toplamı:" + çiftsayıtoplam);
            Console.WriteLine("tek sayıların adedi:" + teksayıadet);
            Console.WriteLine("tek sayıların toplamı:" + teksayıtoplam);
            Console.ReadLine();
