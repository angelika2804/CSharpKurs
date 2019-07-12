using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];
            Console.WriteLine("Hello, " + name); //zmiana
            //foreach (var item in args)
            //{
            //    Console.WriteLine("Hello, " + item);
            //}
        }
    }
}
