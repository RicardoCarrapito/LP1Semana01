using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Introduza um numero inteiro:");
            string str1= Console.ReadLine();
            int inteiro= int.Parse(str1);

            Console.WriteLine("Introduza um numero real:");
            string str2 = Console.ReadLine();
            float real = float.Parse(str2);
            
             

        }
    }
}
