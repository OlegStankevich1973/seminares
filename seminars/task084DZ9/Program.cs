// // Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30
// ========================================================================
Console.Clear();

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;
// метод проверки какое вводимое число большеи замена их местами
if (m > n)
{
    m = n;
    n = temp;
}

SumNumber(m, n, temp = 0);

void SumNumber(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов= {sum} ");
        return;
    }
    SumNumber(m, n - 1, sum);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

