Console.WriteLine("Введите начальное число M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N");
int numberN =Convert.ToInt32 (Console.ReadLine());

void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);
