// void CountDown(int n)
// {
//     if (n <= 0)
//     {
//         return;
//     }
//     CountDown(n - 1);

//     Console.WriteLine(n);

// }
// CountDown(3);

// int SumToN(int n)
// {
//     Console.WriteLine($"Вход: {n}");

//     if (n == 1)
//         return 1;

//     // здесь нужно вызвать SumToN рекурсивно и прибавить n к результату
//     int result = SumToN(n - 1) + n;
//     Console.WriteLine($"Exit: {n}, result = {result}");
//     return result;
//     // здесь нужно вывести строку "Выход: {n}, result = {result}"

// }
// SumToN(4);

// void CountDownWithDepth(int n, int depth)
// {
//     Console.WriteLine($"{new string(' ', depth * 2)}Вызов: n={n}");

//     if (n == 0)
//         return;

//     CountDownWithDepth(n - 1, depth + 1);
// }
// CountDownWithDepth(10, 1);

// void Broken(int n)
// {
//     Broken(n + 1);
// }
// Broken(4);

// int SumDigits(int n)
// {
//     if (n < 10)
//     {
//         return n;
//     }
//     int lustNum = n % 10;
//     int allNum = n / 10;
//     return lustNum + SumDigits(allNum);
// }
// Console.WriteLine(SumDigits(4725));

// int Power(int n, int b)
// {
//     if (b == 0)
//     {
//         return 1;
//     }
//     int total = n;
//     int Num = b - 1;
//     return total * Power(n, Num);
// }
// Console.WriteLine(Power(2, 5));


// int Sum(int n) {
//     if (n == 0)
//         return 0;

//     return Sum(n);
// }
// // Здесь не достигнет базового случая так, как число n никак не сможет достигнуть нуля


// int Sum(int n)
// {
//     if (n == 0)
//         return 0;

//     return n + Sum(n + 1);
// }
// // Здесь тоже самое только это число будет отдаляться от нуля

int n = int.Parse(Console.ReadLine());
Console.WriteLine(SumDigits(n));
Console.WriteLine(CountDigits(n));
PrintDigits(n);
Console.WriteLine(MaxDigit(n));
int SumDigits(int n)
{
    if (n < 10)
    {
        return n;
    }
    int lustNum = n % 10;
    int allNum = n / 10;
    return lustNum + SumDigits(allNum);
}
int CountDigits(int n)
{
    if (n < 10)
    {
        return 1;
    }

    return 1 + CountDigits(n/10);
}
void PrintDigits(int n)
{
    if (n < 10)
    {
        Console.WriteLine(n);
        return;
    }
    PrintDigits(n / 10);
    Console.WriteLine(n % 10);

}
int MaxDigit(int n)
{
    if (n < 10)
    {
        return n;
    }
    int maxNum = n % 10;
    int lastNum = MaxDigit(n/10);
    if (maxNum > lastNum)
    {
        return maxNum;
    }
    else
    {
        return lastNum;
    }
}