using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    double x1 = number / 1000;
    double x2 = number % 1000 / 100;
    double x3 = number % 100 / 10;
    double x4 = number % 10;

    double result = (Math.Pow(x1, 2) - Math.Pow(x4, 2)) + (Math.Pow(x2, 2) - Math.Pow(x3, 2));
    
    Console.WriteLine($"Ответ: {result}");
    Console.ReadKey();
  }
}
