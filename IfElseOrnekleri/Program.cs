using System;

namespace IfElseOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir mağazada alınan ürünün fiyatı 100 Tl
            ve üzerinde ise 10 Tl olan kargo ücreti alınmamaktadır.
            Ürünün fiyatı girildiğinde
            toplam ödenmesi gereken tutarı gösteren programı yazalım.*/

            Console.WriteLine("Ürünün Fiyatını Giriniz = ");
            double fiyat = Convert.ToDouble(Console.ReadLine());

            if (fiyat >= 100)
            {
                double fiyat2 = fiyat + 10;
                Console.WriteLine("Ödemeniz Gereken Tutar = " + fiyat2 + " TL'dir.");
                
            }
            else 
            {
                Console.WriteLine("Ödemeniz Gereken Tutar = " + fiyat + "TL'dir.");

            }


            /* Kullanıcının girdiği iki sayı
            ve yapılacak işlem türü (toplama, çıkarma, çarpma, bölme) seçildiğinde
            sonucu hesaplayarak ekranda gösteren programı yazalım.*/

            
            Console.Write("Birinci sayıyı girin:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("İkinci sayıyı girin:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Toplama için ---> t \n Çıkarma için ---> ç \n Çarpma için ---> x \n Bölme için ---> b tuşuna basınız.");
            
            string islem = Console.ReadLine();

            if (islem == "t")
            {
                double sonuct = sayi1 + sayi2;
                Console.WriteLine("Toplamının sonucu : " + sonuct);
            }
            else if (islem == "ç")
            {
                double sonucc = sayi1 - sayi2;
                Console.WriteLine("Çıkarma İşleminin Sonucu : " + sonucc);
            }
            else if (islem == "x")
            {
                double sonucx = sayi1 * sayi2;
                Console.WriteLine("Çarpma İşleminin Sonucu : " + sonucx);
            }
            else if (islem == "b")
            {
                double sonucb = sayi1 / sayi2;
                Console.WriteLine("Bölme İşleminin Sonucu : " + sonucb);
            }
            else
            {
                Console.WriteLine("Geçersiz İşlem Girdiniz...");
            }
            


            //Kullanıcıdan maddenin sıcaklık değerini girmesi istenerek
            //kullanıcının girmiş olduğu sıcaklık değerine göre ekrana maddenin halini yazan proje.


            
            Console.WriteLine("Maddenin Sıcaklık Halini Giriniz : ");
            double sıcaklık = Convert.ToDouble(Console.ReadLine());

            if (sıcaklık >= 100)
            {
                Console.WriteLine(sıcaklık + " Derecede olan madde gaz haldedir.");
            }
            else if (sıcaklık > 0)
            {
                Console.WriteLine(sıcaklık + " Derecede olan madde sıvı haldedir.");
            }
            else
            {
                Console.WriteLine(sıcaklık + " Derecede olan madde katı haldedir.");
            }

            

            //Girilen bir tam sayının kaç basamaklı olduğunu ekrana yazan proje...


            Console.WriteLine("Bir Sayı Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 10)
            {
                Console.WriteLine("Girmiş olduğunuz sayı 1 basamaklıdır...");
            }
            else if (sayi < 100)
            {
                Console.WriteLine("Girmiş olduğunuz sayı 2 basamaklıdır...");
            }
            else if (sayi < 1000)
            {
                Console.WriteLine("Girmiş olduğunuz sayı 3 basamaklıdır...");
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz sayı 3 basamakdan büyüktür.");
            }


            Console.ReadKey();  
        }
    }
}