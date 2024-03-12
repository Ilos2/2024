internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход число 
        // и проверяет, кратно ли оно одновременно 7 и 23.
        System.Console.WriteLine("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int a = 7;
        int b = 23;
        
        if(num%a==0 && num%b==0)
        {
            System.Console.WriteLine("число кратно 7 и 23");
        }
        else
        {
            System.Console.WriteLine("число не кратно 7 и 23");
        }
    }
}
