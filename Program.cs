using System;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine(Password.Get());
                Console.ReadKey();
            }
        }
    }
}
