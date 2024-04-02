class Programm 
{
    public static void Main()
    {
        double result = 0;

        Console.WriteLine("Введите х: ");
        int x = Convert.ToInt32(Console.ReadLine());
        while (x == 0)
        {
            Console.WriteLine("X не может быть равно 0!");
            x = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Введите n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n == 0)
        {
            Console.WriteLine("N не может быть равно 0!");
            n = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i <n; i++)
        {
            result += 1 / ((2 * i + 1) * Math.Pow(x, 2 * i + 1));
        }
        Console.WriteLine($"{result*2}");
    }
}
