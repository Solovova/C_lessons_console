using System;
using System.Text;



namespace ConsoleApp04
{

    class Program
    {
        static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int ti = 10;
            ffunc(ref ti);

            Console.WriteLine("{0}", ti);

            int[] tm = { 1, 2, 3, 4 };

            ffunc_mas(tm);
            Console.WriteLine("{0}", tm[0]);

            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 1, 2 };
            numbers[1] = new int[] { 1, 2, 3 };
            numbers[2] = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("{0}", numbers.Length);
            Console.WriteLine("{0}", numbers.GetLength(0));

            Console.WriteLine("{0}", numbers[0].Length);
            Console.WriteLine("{0}", numbers[0].GetLength(0));

            Console.WriteLine(numbers[0].ToString());
            Console.ReadKey();


        }

        static void ffunc(ref int i)
        {
            i++;
            Console.WriteLine(i.ToString());
        }

        static void ffunc_mas(int[] m)
        {
            m[0]++;
            Console.WriteLine(m[0].ToString());
        }
    }
}