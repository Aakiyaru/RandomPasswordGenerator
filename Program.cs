using System;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Укажите длину пароля: ");
                string passLength = Console.ReadLine();
                Console.WriteLine(Password.Get(passLength) + Environment.NewLine);
            }
        }
    }
}
