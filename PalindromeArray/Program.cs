using System;

namespace PalindromeArray
{
    class Program
    {
        static void Main(string[] args)//Bahar Merdamert cümle içerisindeki palindrome kelimeleri bulma uygulaması
        {
            string cumle = "bu gün hava çok güzel....arkadaşlar ile kavak olan bir yere gittik. tabi gitmeden ütü yaptım. orada ata bindim....";
            string[] cumleler = cumle.Split(' '); // boşluğa göre dizi oluştur....
                     
            string[] palindrome = new string[0];
            int palindromeIndis = 0;

            string donenkelime = "";

            for (int i = 0; i < cumleler.Length; i++)
            {
                string kelime = "";
                donenkelime = "";
                kelime = cumleler[i];
                int j = kelime.Length;
                for (int m = j - 1; m >= 0; m--)
                {
                    donenkelime += kelime[m];
          
                }
                  if (donenkelime == kelime)
                    {

                        Array.Resize(ref palindrome, palindrome.Length + 1);
                        palindrome[palindromeIndis] = donenkelime + " - palindrome bir kelimedir.";
                        palindromeIndis++;
                    }

            }

            foreach (var item in palindrome)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
         
            
        
    }
}
