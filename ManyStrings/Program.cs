﻿using System;
using System.IO.Compression;

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

            string x="c";
            string y="d";
            string concatenacao1= "dez"+2;
            string concatenacao2= "ab"+x ;
            string interpolacao1=$"valor de x e'{x}";
            string interpolacao2=$"{x}mais{y}e' igual a{x+y}";

            Console.WriteLine(concatenacao1);
            Console.WriteLine(concatenacao2);
            Console.WriteLine(interpolacao1);
            Console.WriteLine(interpolacao2);
            


        }
    }
}
