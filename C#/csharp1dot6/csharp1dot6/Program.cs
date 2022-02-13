using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // A meselesi
            Console.Write("Zehmet olmasa daxil edeceyiniz char-in uzunlugunu daxil edin: ");
            string karakterSayiStr = Console.ReadLine();
            double karakterSayi = double.Parse(karakterSayiStr);
            double ozelKarakterSayi = 0;
            for(int i = 0; i < karakterSayi; i++)
            {
                char c = (char)Console.Read();
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    ozelKarakterSayi++;
                }
            }
            Console.WriteLine(ozelKarakterSayi);
            Console.ReadKey();
           
        }
    }
}
