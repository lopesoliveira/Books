/*using System;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    interface ILogger
    {
        void Log(string text) => Console.WriteLine(text);
        //void Log(string text) => Console.WriteLine(Prefix + text);
        static string Prefix = "";
    }
}


using System;
using System.IO;

namespace Books
{
    class Program : ILogger
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char lastElement = vowels[^1];   // 'u'
            char secondToLast = vowels[^2];   // 'o'
            Console.WriteLine(lastElement);
            Console.WriteLine(secondToLast);
            //using the range oprator
            char[] firstTwo = vowels[..2];
            char[] lastThree = vowels[2..];
            Console.WriteLine(firstTwo);
            Console.WriteLine(lastThree);
            char[] middleOne = vowels[2..3];    // 'i'
            char[] lastTwo = vowels[^2..];   // 'o', 'u'
            Console.WriteLine(middleOne);
            Console.WriteLine(lastTwo);



            //Index last = ^1;
            ////string firstTwoRange = "0..2";
            //char[] qq = vowels[0..2];
            //Console.WriteLine(qq);

            Index last = ^1;
            Console.WriteLine(last);
            Range firstTwoRange = 0..2;
            char[] firstTwov = vowels[firstTwoRange];
            Console.WriteLine(firstTwov);

            string? s = null;
            s ??= "Hello, world";

            if (File.Exists("file.txt"))
            {
                using var reader = File.OpenText("file.txt");
                Console.WriteLine(reader.ReadLine());
            }

            ((ILogger)new Logger()).Log("message");

            ILogger.Prefix = "File Log";


            string cardName = cardName switch // assuming cardNumber is an int
            {
                13 => "King",
                12 => "Queen",
                11 => "Jack",
                _ => "Pip card" // equivalent to 'default'
            };

            //char[] qq= vowels[firstTwoRange];
            //Console.WriteLine(qq);



            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}
            //string s = null;


            //s ??= "Joao";
            //Console.WriteLine(s);

            //((ILogger)new Logger()).Log("message");

            //var t = ILogger.Prefix = "x";
            //Log("ww");

            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
        }

        //private static void Log(string v)
        //{
        //    Console.WriteLine(v);
        //}        
    }

    class Sentence
    {
        string[] words = "The quick brown fox".Split();
        public string this[Index index] => words[index];
        public string[] this[Range range] => words[range];
    }

    struct Point
    {
        public int X, Y;
        public readonly void ResetX() => X = 0; // Error!
    }

}
*/