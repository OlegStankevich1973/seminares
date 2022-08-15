// //=================================================================================
// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// //==================================================================================

Console.Clear();
// вводим глобальные переменные часть которые вводим через консоль и 
// часть которые будут результатом
double initNumberX;
double initNumberY;
double initNumberB1;
double initNumberK1;
double initNumberB2;
double initNumberK2;
// метод ввода данных через консоль
void VariantOne()
{
    Console.WriteLine("Введите значение B1");
    initNumberB1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение K1");
    initNumberK1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение B2");
    initNumberB2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение K2");
    initNumberK2 = double.Parse(Console.ReadLine());
}

// метод подсчета X и Y
void СalculationXY()
{
    initNumberX = ((initNumberB2 - initNumberB1) / (initNumberK1 - initNumberK2));
    initNumberY = ((initNumberK1 * (initNumberX)) + initNumberB1);

}
VariantOne();
СalculationXY();
Console.WriteLine("(" + initNumberX + ";" + initNumberY + ")");


