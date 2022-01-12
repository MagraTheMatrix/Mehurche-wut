using System;

namespace Mehurche_wut
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[5];

            array[0] = double.Parse(Console.ReadLine());
            array[1] = double.Parse(Console.ReadLine());
            array[2] = double.Parse(Console.ReadLine());
            array[3] = double.Parse(Console.ReadLine());
            array[4] = double.Parse(Console.ReadLine());

            double temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;

                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (double p in array)
                Console.Write(p + " ");
        }
    }
}
