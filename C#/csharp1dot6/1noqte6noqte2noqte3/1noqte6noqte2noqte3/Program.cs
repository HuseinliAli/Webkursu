using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ardicilligin simvol sayini daxil edin: ");
            double karakterSayi = int.Parse(Console.ReadLine());
            char ch;
            for(int i = 0; i < karakterSayi; i++)
            {
                ch = (char)Console.Read();
                if (ch == '('&&ch==')')
                {
                    Console.WriteLine("Moterize duzgun baglanib");
                }
                else
                {
                    Console.WriteLine("Moterize duzgun baglanmayib");
                }
            }
            Console.ReadKey();
        }
    }
}