using System;

namespace ConsoleApp34
{
    class Program
    {


        static void Main(string[] args)
        {
           
            char[,] number = new char[3, 3];
            for (int j = 0; j < 3; j++)
            {
                for(int i = 0; i < 3; i++)
                {
                    number[i, j] = char.Parse(Console.ReadLine());
                }
            }
           for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(number[j, i]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
    
}
            
            




