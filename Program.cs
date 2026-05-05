using System;
namespace maioroumenor
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1);
            Console.Write("Digite o segundo numero: ");
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

