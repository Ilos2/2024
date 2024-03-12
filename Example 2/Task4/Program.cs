
// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(System.Console.ReadLine());
        string numbers = number.ToString();
        int i=0;
        char t;
        while (i < numbers.Length)
        {
            //System.Console.Write(numbers[i]+", ");
           t = numbers[i];
            i++;
        }
        System.Console.WriteLine(t);
    }
}