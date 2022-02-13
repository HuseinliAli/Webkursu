using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ardicilligin olcusunu daxil edin: ");
            string karakterSayiStr = Console.ReadLine();
            double karakterSayi = double.Parse(karakterSayiStr);
            int aSayi = 0;
            int bSayi = 0;
            for (int i = 0; i < karakterSayi; i++)
            {
                char ch = (char)Console.Read();
                if (ch == 'a')
                {
                    aSayi++; 
                }
                if(ch == 'b')
                {
                    bSayi++;
                }
            }
            if (aSayi >= bSayi)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();  
        }
    }
}