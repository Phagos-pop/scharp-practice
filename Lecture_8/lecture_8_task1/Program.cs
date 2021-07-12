using System;

namespace lecture_8_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Greating.GetGreeting();
        }
    }
    class Greating
    {
        internal static void GetGreeting()
        {
            System.DateTime time = new DateTime();
            time = DateTime.Now;
            switch (Convert.ToInt32( time.TimeOfDay.Hours))
            {
                case 9 :
                    Console.WriteLine("Good morning, guys");
                    break;
                case 10 :
                    Console.WriteLine("Good morning, guys");
                    break;
                case 11 :
                    Console.WriteLine("Good morning, guys");
                    break;
                case 12:
                    Console.WriteLine("Good morning, guys");
                    break;
                case 13:
                    Console.WriteLine("Good day, guys");
                    break;
                case 14:
                    Console.WriteLine("Good day, guys");
                    break;
                case 15:
                    Console.WriteLine("Good day, guys");
                    break;
                case 16:
                    Console.WriteLine("Good evening, guys");
                    break;
                case 17:
                    Console.WriteLine("Good evening, guys");
                    break;
                case 18:
                    Console.WriteLine("Good evening, guys");
                    break;
                case 19:
                    Console.WriteLine("Good evening, guys");
                    break;
                case 20:
                    Console.WriteLine("Good evening, guys");
                    break;
                case 21:
                    Console.WriteLine("Good evening, guys");
                    break;
                case 22:
                    Console.WriteLine("Good evening, guys");
                    break;
                default:
                    break;
            }
        }
    }
}
