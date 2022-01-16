using System;

namespace ProjeÖrnek
{
    class Program
    {
        private static readonly object kullanıcıadı;

        static void Main(string[] args)
        {
            Console. BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console. ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("kullanıcı hesap oluşturma");

            string oyuncuismi;
            string kad = "Arzu", ksifre = "123";
            string kullaniciad, kullanicişifre;
            int hak = 3;
            do
            {
                Console.Write("kullanıcı adını giriniz:");

                kullaniciad = Console.ReadLine();
                Console.Write("şifrenizi giriniz:");
                kullanicişifre = Console.ReadLine();
                if (kullaniciad == kad && kullanicişifre == ksifre)
                {
                    Console.Write("doğru girdiniz");

                }




                else
                {
                    hak--;
                    Console.WriteLine("yanlış girdiniz {0} hakkınız kaldı ",hak);
                   

                   

                }
            } while ((kullaniciad != kad || kullanicişifre != ksifre) && hak != 0);
            if (hak == 0) 
            {
                Console.WriteLine("3 kez yanlış girdiniz program kapatılıyor");
                Environment.Exit(0);
            }
            Console.WriteLine();
            Console.Write("Oyuncuismi giriniz:");
            oyuncuismi = Console.ReadLine();
            Console.WriteLine("Oyuna Başlayalım");

            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("ÖDÜLLER");
            Console.WriteLine();
            Console.WriteLine("1)Araba        2)Motosiklet");
            Console.WriteLine();
            Console.WriteLine("3)Bisiklet      4)Telefon");
            Console.WriteLine();
            Console.WriteLine("5)Bilgisayar    6)Tablet");
            Console.WriteLine();
            Console.WriteLine("7)Oyuncak       8)Mobilya Takımı ");
            Console.WriteLine();
            Console.WriteLine("9)Gözlük        10)Hediye çeki");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.ReadLine();
            Random random = new Random();
            int X = random.Next(1, 50);
            byte tahmin;
            byte sayac = 0;

            while (true)
            {
                Console.Write(" SAYI GİRİNİZ: ");
                tahmin = Convert.ToByte(Console.ReadLine());

                sayac ++;
                if (tahmin > X)
                {
                    Console.WriteLine ("Sayıyı küçültünüz.");

                }
                else if (tahmin < X)
                {
                    Console.WriteLine("Sayıyı büyütünüz.");
                }
                else if (tahmin == X) 
                {
                    Console.WriteLine("TEBRİKLER " + sayac + ". denemede sayıyı buldunuz !!");
                   
                    break;
                }
                if (sayac  == 10)
                {
                    Console.WriteLine("OYUN BİTTİ");
                    Console.WriteLine("Tekrar oynamak için [T] basınız ");
                    char input = Convert.ToChar(Console.ReadLine());
                    if (input=='T')
                    {
                        continue;

                    }
                    else
                    {
                        break;
                    }
                }
            } 
           
           
            switch (sayac)

            {
                case 1:

                    Console.WriteLine("Araba Kazandınız");
                    break;
                case 2:
                    Console.WriteLine("Motosiklet Kazandınız");
                    break;
                case 3:
                    Console.WriteLine("Bisiklet Kazandınız");
                    break;
                case 4:
                    Console.WriteLine("Telefon Kazandınız");
                    break;
                case 5:
                    Console.WriteLine("Bilgisayar Kazandınız");
                    break;
                case 6:
                    Console.WriteLine("Tablet Kazandınız");
                    break;
                case 7:
                    Console.WriteLine("Oyuncak Kazandınız");
                    break;
                case 8:
                    Console.WriteLine("Mobilya takımı Kazandınız");

                   break;
                case 9:
                    Console.WriteLine("Gözlük Kazandınız");
                    break;
                case 10:
                    Console.WriteLine("Hediye çeki Kazandınız");
                    break;
                default:

                    break;

            }

            Console.ReadLine();





        }
    }
}
