using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Simvol sayini daxil edin:");
            int sozSayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Simvollari daxil edin:");
            int noqteSayi = 0;
            for (int i = 0; i < sozSayi; i++)
            {
                char ch = (char)Console.Read();
                if (ch == '.')
                {
                    noqteSayi++;
                }
                else if (ch != '.')
                {
                    noqteSayi = 0;
                }
            }
                if (noqteSayi >= 3)
                {
                    Console.Write("Ardicil 3 noqte tapildi");
                }
                else
                {
                    Console.Write("Ardicil 3 noqte tapilmadi");
                }
            Console.ReadKey();
        }
    }
}