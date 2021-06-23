using System;

namespace lecture_5
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNullArray();
            CreateArray();
        }
        static void GetNullArray()
        {
            object[] nullArray = new object[0];
        }
        static void CreateArray()
        {
            object[] array = new object[3];
            array[0] = 32;
            array[1] = 'A';
            array[2] = "Hello";

            foreach (int i in array)
            {
                Console.WriteLine(array[i]);
            }

            int number =  Convert.ToInt32(array[0]) + 10 ;
            array[0] = number;

            string str = Convert.ToString(array[2]);
            string finStr = str + " , guys!";

            foreach (int i in array)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
