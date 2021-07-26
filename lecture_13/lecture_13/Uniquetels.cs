using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_13
{
    class Uniquetels
    {
        static int Id = default;

        public Uniquetels()
        {
            Id++;
            Console.WriteLine($"Число отсчета :{Id}");
        }

        public static void StartWith(int newNumber)
        {
            Id = newNumber;
            Console.WriteLine($"Выбрано число отчета: {Id}");
        }

        public static void StartWith()
        {
            Console.WriteLine("Выберите число отсчета: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Выбрано число отчета: {Id}");
        }
    }
}
