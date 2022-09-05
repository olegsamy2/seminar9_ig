// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int NumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int NumberN = Convert.ToInt32(Console.ReadLine());

if (NumberM > NumberN)
{
    Console.WriteLine(" Число M не должно быть больше N");
}
else
{
    int res = GetSumNutElementsMToN(NumberM, NumberN);
    Console.WriteLine("Сумма натуральных элементов в промежутке от " + NumberM + " до " + NumberN + " равна " + res);
}

int GetSumNutElementsMToN(int M, int N)
{
    if (N < M) return 0;
    return N + GetSumNutElementsMToN(M, N - 1);
}



