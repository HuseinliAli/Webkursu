using System;

namespace MyApp
{
    internal class Program
{
    static void Main(string[] args)
    {
            Console.Write("Fenn sayini daxil edin:");
            string fennSayiStr=Console.ReadLine();
            double fennSayi=double.Parse(fennSayiStr);
            
            double ortalama=0;
            double aktCemi = 0;
            double balCemi = 0;

            for(int i = 0; i < fennSayi; i++)
            {
                Console.Write("Fennin akt dayini daxil edin: ");
                string aktSayiStr = Console.ReadLine();
                double aktSayi = double.Parse(aktSayiStr);
                Console.Write("Final imtahanindan topladiginiz bali daxil edin: ");
                string balStr = Console.ReadLine();
                double bal = double.Parse(balStr);
                balCemi += aktSayi * bal;
                aktCemi += aktSayi;
            }
            ortalama = balCemi / aktCemi;
            Console.Write("Semestr uzre ortalama baliniz: ");
            Console.WriteLine(ortalama); ;
            Console.ReadKey();
    }
}
}