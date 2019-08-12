using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ; )
            {
                Greeting();
                Age();
                Settings();
            }

            //foreach (var item in args)
            //{
            //    Console.WriteLine("Hello, " + item);
            //}
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            double maxDouble = double.MaxValue;
            float maxFloat = float.MaxValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
            Console.WriteLine("maxDouble = " + maxDouble);
            Console.WriteLine("maxFloat = " + maxFloat);
        }

        /// <summary>
        /// Ustawienia: czyszczenie ekranu, reset koloru
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Wypisujemy komunikat zależny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz, ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);
            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo. Jesteś pełnoletni, możesz wypić piwo!");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś niepoprawny format wieku");
            }
            else
            {
                Console.WriteLine("Możemy zaoferować Ci mleko");
            }
        }

        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
        }
    }
}
