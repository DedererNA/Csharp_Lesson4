int GetSumm (int num)
{
    int res = 0;
    while (num>0)
    {
        res += num%10;
        num/=10;
    }
    return res;
}

Console.WriteLine("Введите число");
int number = GetSumm(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"{number}");