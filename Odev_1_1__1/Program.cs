using System;

namespace Odev_1_1__1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            
            Console.WriteLine("Kaç adet sayı gireceksiniz? ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] dizi=new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("{0}. Sayıyı Giriniz", i+1);
                dizi[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Girilen çift sayılar ");
            foreach(int sayilar in dizi){
                if (sayilar%2==0)
                {
                    Console.WriteLine(sayilar);
                }
            }

        }
    }
}
