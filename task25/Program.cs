double PowNum ()
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень");
    int pow = Convert.ToInt32(Console.ReadLine());
    while (pow<0)
    {
        Console.WriteLine("Недопустимая степень");
        Console.WriteLine("Введите степень");
        pow = Convert.ToInt32(Console.ReadLine());
    }
    double res = Math.Pow(num, pow);
    return res;
}

double result = PowNum();
Console.WriteLine($"Искомое число: {result}");