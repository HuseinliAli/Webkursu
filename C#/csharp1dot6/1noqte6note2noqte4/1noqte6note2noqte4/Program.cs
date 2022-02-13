using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("-");
            int yoxlama = 0;
            while(true)
            {   
                char ch=(char)Console.Read();
                if (ch == '.')
                {
                    break;
                }
                else if (ch != '.')
                {
                    if (ch >= '0' && ch <= '9')
                    {
                        yoxlama = 0;
                  
                    }
                    else
                    {
                        yoxlama = 1;
                        break;
                    }
                }

            }
            if(yoxlama == 0) 
            {
                Console.Write("Ardicilliq ancaq ededden ibaretdir.");
            }
            else if(yoxlama == 1)
            {
                Console.Write("Ardicilliq ancaq ededden ibaret deyil.");
            }

        }
    }
}
