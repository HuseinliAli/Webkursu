using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ardicilligi daxil edin: ");
            int karakterSayi = -1;
            while (true)
            {
                char ch=(char)Console.Read();
                karakterSayi++;
                if (ch == '\n')
                {
                    karakterSayi--;
                    break;
                }
            }
            Console.Write("Daxil olunan ardiciliqdaki simvollarin sayi: ");
            Console.WriteLine(karakterSayi);
        }
    }
}
