using System;

namespace Odev_1_1__3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            // Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.    

            int n=Convert.ToInt32(Console.ReadLine());
            string[] words=new string[n];
            for (int i = 0; i < n; i++)
            {
                words[i]=Console.ReadLine();
            }
            Array.Reverse(words);
            foreach(string word in words)
                Console.WriteLine(word);

        }
    }
}
