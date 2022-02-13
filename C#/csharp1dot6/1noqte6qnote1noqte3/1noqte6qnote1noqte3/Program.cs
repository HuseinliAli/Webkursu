using System;

namespace MyApp // A ni evvelden girende tapmir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Simvol sayini daxil edin:");
            int simvolSayi = int.Parse(Console.ReadLine());
            Console.Write("Simvollari daxil edin:");

            int aSayi = 0;

            for (int i = 1; i <= simvolSayi; i++)
            {
                char ch = (char)Console.Read();
                if (ch == 'a')
                {
                    aSayi++;
                }
                else if (ch != 'a')
                {
                    aSayi = 0;
                }
            }
            if (aSayi == 2)
            {
                Console.Write("Ardicil  aa tapildi: ");
                Console.WriteLine(aSayi);
            }
            else
            {
                Console.Write("Ardicil aa tapilmadi");
            }
            Console.ReadKey();
        }
    }
}