using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string karakterSayiStr = Console.ReadLine();
            double karakterSayi = double.Parse(karakterSayiStr);
            int latinHerfSayi = 0;
            for(int i = 0; i < karakterSayi; i++)
            {
                char ch = (char)Console.Read();
                if (ch >= 'a' && ch <= 'z'||ch<='Z'&&ch>='A')
                {
                    latinHerfSayi++;
                }
            }
            Console.Write("latin herflerinin sayi: ");
            Console.WriteLine(latinHerfSayi);
        }
    }
}
