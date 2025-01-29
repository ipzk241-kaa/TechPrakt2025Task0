using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть числа для додавання");
        Console.Write("Перше число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Друге число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine($"Сума числ: {sum}");
    }
}