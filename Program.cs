using System;

namespace ders4
{
    class Program
    {
        static void Main(string[] args)
        {    //sayı tahmin oyunu

        tekrar:
            Console.WriteLine("Oyuna hoşgeldin 0 ile 10 arasında bir sayı tahmin etmen gerekiyor");
            Random random = new Random();

            int sayiaralik = random.Next(1, 11);
            int hak = 2;

            int tahminsayi = -1;
           

            
            while(tahminsayi != sayiaralik)
            {   tahminsayi = Convert.ToInt32(Console.ReadLine());
                if (sayiaralik == tahminsayi)
                {
                    Console.WriteLine("doğru tahmin");
                    break;
                }
                else
                {
                    if (hak ==0)
                    {
                        Console.WriteLine(" tahmin hakkınız kalmadı. Tahmin edilecek sayı:" + sayiaralik);

                        break;
                    }
                    else
                    {
                        Console.WriteLine("tekrar deneyin");
                    }
                    if (sayiaralik - tahminsayi <= 2)
                    {
                        Console.WriteLine("sıcak");
                    }
                    if (sayiaralik - tahminsayi >= 2)
                    {
                        Console.WriteLine("soğuk");

                    }




                    hak--;
                }
            }
            Console.WriteLine("Oyuna devam etmek için E tuşuna çıkmak için H tuşuna basın");
            char c = Convert.ToChar(Console.ReadLine());

            if (c == 'E')
            {
                Console.Clear();
                goto tekrar;

            }
            else if (c == 'H')
            {
                Console.Clear();
                Console.WriteLine("Oyundan çıkılıyor");
            }
            Console.ReadLine();


            





            Console.ReadLine();
        }
    }
}
