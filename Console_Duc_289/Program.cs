using System;
using System.Collections.Generic;
using System.Text;
using DLL;
namespace Console_Duc_289
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 storyGen = new Class1();

            Console.WriteLine("\n Nhập keyword 1: ");
            string k1 = Console.ReadLine();

            Console.WriteLine("Nhập keyword 2: ");
            string k2 = Console.ReadLine();

            Console.WriteLine("Nhập keyword 3: ");
            string k3 = Console.ReadLine();

            string story = storyGen.GenerateStory(k1, k2, k3);

            Console.WriteLine("\n===== CÂU CHUYỆN ĐƯỢC TẠO =====");
            Console.WriteLine(story);

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
