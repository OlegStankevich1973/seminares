// Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();
int numberM = ReadData("Задайте число M");
int numberN = ReadData("Задайте число N");
// условия включения метода рекурсии
if (numberM < numberN)
{
    NaturalNamberPrinter(numberM, numberN);
}
else
{
    NaturalNamberPrinter(numberN, numberM);
}

// метод ввода с консоли
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

// 3 6
// 4 6
// 5 6
// 6 6
// 7 6
// int sum =0;
// метод рекурсии
void NaturalNamberPrinter(int m, int n)
{
    if (m - 1 == n) return;//-1 чтобы вывело все цифры на печать
    Console.Write(m + " ");
    NaturalNamberPrinter(m + 1, n);//=1 чтобы числа от меньшего двигались к большему
}
