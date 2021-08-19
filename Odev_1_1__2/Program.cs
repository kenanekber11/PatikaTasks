using System;

namespace Odev_1_1__2
{
    class Program
    {
        static void Main(string[] args)
        {
             // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
             // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
             // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.    

            Console.WriteLine("İki Adet Sayı giriniz..");
            int n=Convert.ToInt32(Console.ReadLine());
            int m=Convert.ToInt32(Console.ReadLine());
            int[] sayilar=new int[n];
            Console.WriteLine("Sayıları Giriniz..");
            for (int i = 0; i < n; i++)
            {
                sayilar[i]=Convert.ToInt32(Console.ReadLine());    
            }
            Console.WriteLine("*** m-e eşit ve tam bölünenler ****");
            foreach(int sayi in sayilar)
            {
                if (sayi%m==0)
                {
                    Console.WriteLine(sayi);
                }    
            }


        }
    }
}
