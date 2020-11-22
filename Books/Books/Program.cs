using System;

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


            Index last = ^1;
            Range firstTwoRange = 0..2;
            //char separator = ' ';
            //string[] words = "The quick brown fox".Split();
            //public string this[Index index] => words[index];
            //public string[] this[Range range] => words[range];
            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}
            string s = null;

            s ??= "Joao";
            Console.WriteLine(s);

            ((ILogger)new Logger()).Log("message");
            
            //var t = ILogger.Prefix = "x";
            //Log("ww");

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        //private static void Log(string v)
        //{
        //    Console.WriteLine(v);
        //}
    }
}
