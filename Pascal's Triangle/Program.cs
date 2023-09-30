using System;

int i, j, n;
Console.WriteLine("Введите количество строк треугольника Паскаля:");
string s = Console.ReadLine();
n = Convert.ToInt32(s);

static long Factorial(int x)
{
    if (x <= 1)
    {
        return 1;
    }
    else
    {
        return x * Factorial(x - 1);
    }
}

long maxNumberWidth = Factorial(n - 1).ToString().Length;

for (i = 0; i < n; i++)
{
    for (j = 0; j < n - i; j++)
    {
        Console.Write("".PadLeft((int)(maxNumberWidth + 2)));
    }
    for (j = 0; j <= i; j++)
    {
        long number = Factorial(i) / (Factorial(j) * Factorial(i - j));
        Console.Write(number.ToString().PadLeft((int)(maxNumberWidth + 2)));
    }
    Console.WriteLine();
}

Console.ReadLine();

