﻿using System;

namespace lecture_13.Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle() { Trips = new DateTime[2] };
            Console.WriteLine(motorcycle.ToString());

            motorcycle.Drive();
            motorcycle.Drive();
            motorcycle.Drive();
        }
    }
}
