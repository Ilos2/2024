
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер координатной четверти плоскости, в которой находится эта точка.


internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Введите координату X: ");
        int x = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Введите координату y: ");
        int y = Convert.ToInt32(System.Console.ReadLine());

        if (x*y != 0)
        {
            if ( x > 0 && y > 0)
            {
                System.Console.WriteLine("координатная плоскость №1");
            }

            if ( x < 0 && y > 0)
            {
                System.Console.WriteLine("координатная плоскость №2");
            }

            if ( x < 0 && y < 0)
            {
                System.Console.WriteLine("координатная плоскость №3");
            }

            if ( x > 0 && y < 0)
            {
                System.Console.WriteLine("координатная плоскость №4");
            }


        }

        else 
        {
            System.Console.WriteLine("координаты должны быть X ≠ 0 и Y ≠ 0");
        }



    }
}