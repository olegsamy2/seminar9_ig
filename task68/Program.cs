// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите число M: ");
int NumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int NumberN = Convert.ToInt32(Console.ReadLine());

if ((NumberM >= 0) && (NumberN  >= 0))
{
Console.WriteLine("Функция Аккермана - A(" + NumberM +","+ NumberN +") равна " + Ackermann(NumberM, NumberN));
}
else
{
    Console.WriteLine("Введенные числа должны быть неотрицательными");
    return;
}

int Ackermann (int m, int n)
{   
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else 
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}


