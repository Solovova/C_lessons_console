using System;
using System.Text;



namespace ConsoleApp05
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            int[] numbers = { 4,7,2,8,1,6,0,3,5,9};
            array_print(numbers);


            // --------------------
            sort_m2(numbers);
            array_print(numbers);

            Console.ReadKey();


        }

        static void array_print(int[] arr)
        {
            foreach (int i in arr) {
                Console.Write(i);
            };
            Console.WriteLine("");
        }


        static void sort_m1(int[] arr)
        {
            int transactions = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    transactions++;
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    
                    }
                }
            }
            Console.WriteLine($"Сортировка №1 транзакций: {transactions}");
            
        }

        static void sort_m2(int[] arr)
        {
            int transactions = 0;
            int changes = 0;
            do
            {
                changes = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    transactions++;
                    if (arr[i] > arr[i + 1])
                    {
                        int tmp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = tmp;
                        
                        changes++;
                    }

                }
            }
            while (changes > 0);
        
            Console.WriteLine($"Сортировка №1 транзакций: {transactions}");
        }



    }
}
