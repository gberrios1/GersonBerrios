using System;

namespace GersonBerrios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pause to display 
            Console.WriteLine("Hi, this is Gerson Berrios!");
            Console.WriteLine("Let me know how you are doing - type your answer below and hit enter:");

            //Setting the string variable
            string pacho;
            pacho = Console.ReadLine();

            Console.WriteLine("You typed: {0}", pacho); 
        }
    }
}
