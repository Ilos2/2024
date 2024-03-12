// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.


internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Введите целое число из отрезка [10, 99]");
        int x = Convert.ToInt32(System.Console.ReadLine());
        int a;
        int b;
        if (x>9 && x<100)
        {
            a = x / 10;
            b = x % 10;
            if (a>b)
            {
                System.Console.WriteLine($"наибольшая цифра числа: {a}");
            }
            else
            {
                System.Console.WriteLine($"наибольшая цифра числа: {b}");
            }
        }

        else
        {
            System.Console.WriteLine("Число не из отрезка [10, 99]");
           
        }

    }
}