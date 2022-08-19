// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
//столбце.
//=========================================================================================================

// ​// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0;
    int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {

        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 10);
            j++;
        }
        i++;
    }
    return outArray;
}
// ​// Метод подсчета среднего арифметического каждого столбца
double CalcAverageTwoDimArr(int[,] inputArray)
{
  // задаем локальную переменную среднего арифметич
    double outAverageColumn = 0;
    int j = 0;
    // пробегаем по столбцам (1 это количество столбцов)
    while (j < inputArray.GetLength(1))
    {
        int i = 0;
        // обнуляем среднее арифм при заверш прохода по строкам(0 это количество строчек)
        outAverageColumn = 0;
        while (i < inputArray.GetLength(0))
        {
          // к каждому значению среднего арифм  добавляем числов столбце (те берем столбец и 
          //  прыгаем по строкам)
            outAverageColumn = outAverageColumn + inputArray[i, j];
            // изменяем строки
            i++;
        }
        // считаем среднееарифм  полученую сумму делим на количество строк
        outAverageColumn = outAverageColumn / inputArray.GetLength(0);
        // уменьшаем количество знаков после запятой
        Console.Write(Math.Round(outAverageColumn, 2) + "; ");
        // переходим на другой столбец
        j++;
    }
    return outAverageColumn;
}
ConsoleColor[] col = new ConsoleColor[]
{
  ConsoleColor.Black,
  ConsoleColor.Blue,
  ConsoleColor.Cyan,
  ConsoleColor.DarkBlue,
  ConsoleColor.DarkCyan,
  ConsoleColor.DarkGray,
  ConsoleColor.DarkGreen,
 ConsoleColor.DarkMagenta,
 ConsoleColor.DarkRed,
  ConsoleColor.DarkYellow,
 ConsoleColor.Gray,
 ConsoleColor.Green,
 ConsoleColor.Magenta,
  ConsoleColor.Red,
 ConsoleColor.White,
 ConsoleColor.Yellow
};
void PrintColorTwoDimArray(int[,] inputArray)
{
    int i = 0;
    int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 10)];
            Console.Write(inputArray[i, j] + "\t");
            Console.ResetColor();
            j++;
        }
        Console.Write("\n");
        //Console.WriteLine();
        i++;
    }
}
int[,] twoDimArray = FillTwoDimArray(6, 7);
PrintColorTwoDimArray(twoDimArray);
Console.Write($"\nCреднее арифметическое:\n");
CalcAverageTwoDimArr(twoDimArray);
