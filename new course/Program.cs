using System;

namespace asdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad="ali";
            string soyad="husenli";
            int age=56;
            System.Console.WriteLine("menim adim "+ad+" soyadim ise "+soyad+" yasim ise "+age);
            string name = "alihusenli alasda";
            long c=10;
            int d=(int)c;
            double k=10.6;
            int l=(int)k;
            int x=200;
            string z=x.ToString();
            System.Console.WriteLine(z);
            System.Console.WriteLine(l);
            Console.WriteLine(name);
            Console.Write("First number: ");
            string firstNum= Console.ReadLine();
            Console.WriteLine(firstNum);
            Console.Write("Please enter A:");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Please enter B:");
            int b=int.Parse(Console.ReadLine());
            int area=a*b;
            int counts=2*(a+b);
            Console.WriteLine(area);
            Console.WriteLine(counts);
        }
    }
}