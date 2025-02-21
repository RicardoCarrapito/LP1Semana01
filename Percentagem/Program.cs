using System;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere 4 numeros reais entre 0 e 1:");
            string num1= Console.ReadLine();
            string num2= Console.ReadLine();
            string num3= Console.ReadLine();
            string num4= Console.ReadLine();

            float perc1= float.Parse(num1);
            float perc2= float.Parse(num2);
            float perc3= float.Parse(num3);
            float perc4= float.Parse(num4);

            string final1=$"{perc1:p2}";
            string final2=$"{perc2:p2}";
            string final3=$"{perc3:p2,1}";
            string final4=$"{perc4:p2}";
            

            Console.WriteLine(final1);
            Console.WriteLine(final2);
            Console.WriteLine(final3);
            Console.WriteLine(final4);






        
        }
    }
}
