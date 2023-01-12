using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            int j = 4;

            if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            else if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            else 
            {
                Console.WriteLine("i is equal to j");
            }



        }
    }
}