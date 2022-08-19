// // ================================================================================================
// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// //  в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// // ==================================================================================================
// // метод для заполнения двумерного массива
// int[,] FillTwoDimArray(int countRow, int countColumn)
// {
//     System.Random numberSyntezator = new System.Random();
//     int i = 0; int j = 0;
//     int[,] outArray = new int[countRow, countColumn];
//     while (i < countRow)
//     {
//         j = 0;
//         while (j < countColumn)
//         {
//             outArray[i, j] = numberSyntezator.Next(0, 10);
//             j++;
//         }
//         i++;
//     }
//     return outArray;
// }

// //метод для печати двумерного массива
// void PrintTwoDimArray(int[,] inputArray)
// {
//     int i = 0; int j = 0;

//     while (i < inputArray.GetLength(0))
//     {
//         j = 0;
//         while (j < inputArray.GetLength(1))
//         {
//             Console.Write(inputArray[i, j] + " ");
//             j++;
//         }
//         //Console.Write("\n");          
//         Console.WriteLine();
//         i++;
//     }
// }
// // метод вычисления среднегоарифметического чисел столбцов
// string CalcTwoDimArray(int[,] inputArray)
// {
//     // присваиваем численное значение длине строк
//     int stringLength = inputArray.GetLength(0);
//     // присваиваем численное значение длине столбцов
//     int colLength = inputArray.GetLength(1);
//     // создаеи одномерный массив куда будем складывать сумму столбцов
//     double[] sumArray = new double[colLength];
//     // для i проходим по столбцам
//     for (int i = 0; i < colLength; i++)
//     {
//         double sum = 0;
//         // для j проходим по строкам
//         for (int j = 0; j < stringLength; j++)
//         {
//             // накапливаем сумму элементов (индексы обратные вместо (i,j стоит индекс j,i))
//             sum = sum + inputArray[j, i];
//         }
//         // вычисляем среднее арифметическое столбцов при этом делим на количество элементов строк
//         sumArray[i] = sum / stringLength;
//     }
//     // возвращаем переменную sumArray( Join не знаю зачем)
//     return string.Join("; ", sumArray);

// }

// int[,] twoDimArray = FillTwoDimArray(3, 4);
// PrintTwoDimArray(twoDimArray);

// string sumColumn = CalcTwoDimArray(twoDimArray);

// Console.WriteLine(sumColumn);



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
 double outAverageColumn = 0;
 int j = 0;
 while (j < inputArray.GetLength(1))
  {
  int i = 0;
  outAverageColumn = 0;
  while (i < inputArray.GetLength(0))
  {
 outAverageColumn = outAverageColumn + inputArray[i, j];
  i++;
  }
 outAverageColumn = outAverageColumn / inputArray.GetLength(0);
  Console.Write(Math.Round(outAverageColumn, 2) + "; ");
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
  Console.ForegroundColor = col[new System.Random().Next(0, 7)];
  Console.Write(inputArray[i, j] + "\t");
  Console.ResetColor();
 j++;
}
 Console.Write("\n");
  //Console.WriteLine();
 i++;
  }
}

int[,] twoDimArray = FillTwoDimArray(4, 4);
PrintColorTwoDimArray(twoDimArray);
Console.Write($"\nCреднее арифметическое:\n");
CalcAverageTwoDimArr(twoDimArray)