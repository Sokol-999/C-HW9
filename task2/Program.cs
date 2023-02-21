// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// // натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Rec(int m, int n)
{
    if (m <= n)
    {
        return m + Rec(m + 1, n);
    }
    return 0;
}

System.Console.WriteLine(Rec(4, 8));