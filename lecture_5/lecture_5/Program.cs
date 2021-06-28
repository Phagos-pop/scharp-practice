using System;

namespace lecture_5
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNullArray();
            CreateArray();
            GetMaxNumber();
            BoxUnbox();
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

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int number =  Convert.ToInt32(array[0]) + 10 ;
            array[0] = number;

            string str = Convert.ToString(array[2]);
            string finStr = str + " , guys!";
            array[2] = finStr;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void GetMaxNumber()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0,1000);
            }
            int maxNumber = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxNumber < array[i])
                {
                    maxNumber = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("Максимальное число: " + maxNumber);
        }
        static void BoxUnbox() 
        {
            short number = 12;
            object box = number;

            short num = (short)box;
            System.SByte num2 = (sbyte)num;
            Console.WriteLine(num + " " + num.GetType());

        }
    }
}
