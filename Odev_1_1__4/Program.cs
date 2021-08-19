using System;

namespace Odev_1_1__4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            //  Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            
            string cumle=Console.ReadLine();
            string[] kelimeler=cumle.Split(' ');

            Console.WriteLine(kelimeler.Length);
            Console.WriteLine(cumle.Length-(kelimeler.Length-1));




        }
    }
}
