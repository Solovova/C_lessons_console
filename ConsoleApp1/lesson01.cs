using System;
using System.Text;


namespace ConsoleApp01
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();       // вводим 
            Console.WriteLine($"Привет {name}");    // выводим имя на консоль   
            

            // переменные
            string name1 = "Tom";
            Console.WriteLine($"Привет переменная {name1} \\\t ssdsdsd");

            string name2 = "Tom";
            int age = 33;
            bool isEmployed = false;
            double weight = 78.65;

            Console.WriteLine($"Имя: {name2}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {isEmployed}");

            var hello = "Hell to World";
            var c = 20;

            Console.WriteLine(c.GetType().ToString());
            Console.WriteLine(hello.GetType().ToString());

            // побитные операции
            int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
            int key = 102; //Пусть это будет ключ - в двоичной форме 1100110
            int encrypt = x ^ key; //Результатом будет число 1001011 или 75
            Console.WriteLine("Зашифрованное число: " + encrypt);

            int decrypt = encrypt ^ key; // Результатом будет исходное число 45
            Console.WriteLine("Расшифрованное число: " + decrypt);

            // преобразовывание плюс в минус с исп побитных
            int x4 = 12;
            int y4 = ~x4;
            y4 += 1;
            Console.WriteLine(y4);   // -12

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
