using System;
using System.Text;


namespace ConsoleApp03
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
                int a5 = 33;
                int b5 = 600;
                byte c5 = checked((byte)(a5 + b5));
                Console.WriteLine(c5);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();


        }
    }
}
