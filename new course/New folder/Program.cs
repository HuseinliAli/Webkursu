using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
            int rnd=(new Random()).Next(1,10);
            int chance=5;
            while(chance>0){
                chance--;
                Console.Write("Please enter which number you want find: ");
                int estimated=int.Parse(Console.ReadLine());
                if(estimated==rnd)
                {
                    System.Console.WriteLine("You find element.Congratulations");
                    break;
                }
                else if(rnd>estimated)
                {
                    System.Console.WriteLine("High");
                }
                else if(rnd<estimated)
                {
                    System.Console.WriteLine("Low");
                }
                
            }
            System.Console.WriteLine("Program was excited: "+rnd);
            System.Console.WriteLine("Your score: "+chance);
            System.Console.WriteLine("Do you want continue to the game? y-n");
            char ch=char.Parse(Console.ReadLine());
            if(ch=='n'||ch=='N'){
                break;
            }
            } while (true);
        }
    }
}