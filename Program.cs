using System;
namespace maioroumenor
{
    class Program
    {
        static void Main()
        {
            Console.Write("Informe o primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1);
            Console.Write("Informe o segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num2);
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " É Maior");
            }
            else
            {
                Console.WriteLine(num2 + " É Menor");
            }
        }
    }
}

