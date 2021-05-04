using System;
using System.IO;
using Newtonsoft.Json;

//All C# types fall into the following categories:
//• Value types
//• Reference types
//• Generic type parameters
//• Pointer types

//1-[Value types] comprise most built-in types (specifically, all numeric types, the char
//2- [Reference types] type, and the bool type) as well as custom struct and enum types.
//Reference types comprise all class, array, delegate, and interface types. (This includesnthe predefined string type.)

//The fundamental difference between value types and reference types is how they arehandled in memory.

namespace Books
{
    internal static class Test
    {
        private static void Main(string[] args) 
        {
            //Point p1 = new Point();
            //p1.X = 7;
            //Point p2 = p1;   
            //p1.X = 9;

            //Console.WriteLine($"{p1.X},{p1.Y}");

            Point p1 = new Point();
            p1.X = 7;
            Point p2 = p1; // Assignment causes copy
            Console.WriteLine(p1.X); // 7
            Console.WriteLine(p2.X); // 7
            p1.X = 9; // Change p1.X
            Console.WriteLine(p1.X); // 9
            Console.WriteLine(p2.X); // 7

            Console.WriteLine("************************************");

            //Ponto po1 = new Ponto();
            //po1.X = 7;
            //Ponto po2 = po1; // Assignment causes copy
            //Console.WriteLine(po1.X); // 7
            //Console.WriteLine(po2.X); // 7
            //po1.X = 9; // Change p1.X
            //Console.WriteLine(po1.X); // 9
            //Console.WriteLine(po2.X); // 9

            Ponto ponto1 = new Ponto();
            ponto1.X = 7;
            Ponto ponto2 = ponto1; // Copies p1 reference
            Console.WriteLine(ponto1.X); // 7
            Console.WriteLine(ponto2.X); // 7
            ponto1.X = 9; // Change p1.X
            Console.WriteLine(ponto1.X); // 9
            Console.WriteLine(ponto2.X); // 9

            Console.WriteLine("***********************************************");
            Console.WriteLine("Produto em Json");
            Product pr = new Product();
            string output = JsonConvert.SerializeObject(pr);
            Console.WriteLine(output);
            Console.WriteLine("________________________________________________");
            Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);
            Console.WriteLine(deserializedProduct);
        }
    }

    public struct Point { public int X; public int Y; }
    public struct Ponto { public int X; public int Y; }


}


//public class UnitConverter
//{
//    int ratio; // Field
//    public UnitConverter(int unitRatio) { ratio = unitRatio; } // Constructor
//    public int Convert(int unit) { return unit * ratio; } // Method
//}
//class Test
//{
//    //static void Main(string[] args)
//    //{           
//    //    Console.WriteLine(FeetToInches(30));
//    //    Console.WriteLine(FeetToInches(100));           
//    //}

//    // static int FeetToInches(int feet)
//    // {
//    //    int inches = feet * 12;
//    //    return inches;
//    // }



//    static void Main()
//    {
//        UnitConverter feetToInchesConverter = new UnitConverter(12);
//        UnitConverter milesToFeetConverter = new UnitConverter(5280);
//        Console.WriteLine(feetToInchesConverter.Convert(30)); // 360
//        Console.WriteLine(feetToInchesConverter.Convert(100)); // 1200
//        Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1))); // 63360
//    }
//}

//class Test
//{
//    static void Main()
//    {
//        Panda p1 = new Panda("Pan Dee");
//        Panda p2 = new Panda("Pan Dah");
//        Console.WriteLine(p1.Name); // Pan Dee
//        Console.WriteLine(p2.Name); // Pan Dah
//        Console.WriteLine(Panda.Population); // 2
//    }
//}

//public class Panda
//{
//    public string Name; // Instance field
//    public static int Population; // Static field
//    public Panda(string n) // Constructor
//    {
//        Name = n; // Assign the instance field
//        Population = Population + 1; // Increment the static Population field
//    }
//}

