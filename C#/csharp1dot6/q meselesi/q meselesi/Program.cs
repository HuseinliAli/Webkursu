using System;

namespace MyApp1 
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Daxil edeceyiniz char-in uzunlugunu gosterin: ");
            string charUzunluqStr=Console.ReadLine();   
            double charUzunluq=double.Parse(charUzunluqStr);
            int i;
            for (i = 1; i < charUzunluq; i++)
            {
                char ch=(char)Console.Read();
                if (ch == ',')
                {
                    Console.WriteLine("1-ci vergulun i-si: ");
                    Console.Write(i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
