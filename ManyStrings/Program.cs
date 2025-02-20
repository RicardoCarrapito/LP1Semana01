using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string smile = "this is a star \u2606";
            string cross="this is a cross \u274c";
            string heart= "This is a Heart:\u2661";

            Console.WriteLine(smile);
            Console.WriteLine(cross);
            Console.WriteLine(heart);
        }
    }
}
