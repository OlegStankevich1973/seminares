// ================================================================================================
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//  в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// ==================================================================================================
// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
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

//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        //Console.Write("\n");          
        Console.WriteLine();
        i++;
    }
}
// метод вычисления среднегоарифметического чисел столбцов
string CalcTwoDimArray(int[,] inputArray)
{
    // присваиваем численное значение длине строк
    int stringLength = inputArray.GetLength(0);
    // присваиваем численное значение длине столбцов
    int colLength = inputArray.GetLength(1);
    // создаеи одномерный массив куда будем складывать сумму столбцов
    double[] sumArray = new double[colLength];
    // для i проходим по столбцам
    for (int i = 0; i < colLength; i++)
    {
        double sum = 0;
        // для j проходим по строкам
        for (int j = 0; j < stringLength; j++)
        {
            // накапливаем сумму элементов (индексы обратные вместо (i,j стоит индекс j,i))
            sum = sum + inputArray[j, i];
        }
        // вычисляем среднее арифметическое столбцов при этом делим на количество элементов строк
        sumArray[i] = sum / stringLength;
    }
    // возвращаем переменную sumArray( Join не знаю зачем)
    return string.Join("; ", sumArray);

}

int[,] twoDimArray = FillTwoDimArray(3, 4);
PrintTwoDimArray(twoDimArray);

string sumColumn = CalcTwoDimArray(twoDimArray);

Console.WriteLine(sumColumn);



