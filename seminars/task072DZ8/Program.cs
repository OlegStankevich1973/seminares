// /Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// =========================================================================================

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
// метод печати массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + "\t");
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}
// ​// Метод подсчета суммы каждой строки и поиска строки с максимальной суммой
void CalcSumString(int[,] inputArray)
{
    // задаем локальные переменные 
    int stringNum = 0;// номер строки
    int maxNumSum = int.MinValue;//максимальная сумма
    int sumString = 0;//сумма строки
    int i = 0;//после прохода столбцов обнуляем строки
    // пробегаем по строкам (0 это количество строк)
    while (i < inputArray.GetLength(0))
    {
        int j = 0;
        // обнуляем сумму при заверш прохода по столбцам(1 это количество столбцов)
        sumString = 0;
        while (j < inputArray.GetLength(1))
        {
            // к каждому значению суммы  добавляем числов столбце (те берем столбец и 
            //  идем по одной строке)
            sumString = sumString + inputArray[i, j];
            // изменяем столбцы
            j++;
        }
        if (sumString > maxNumSum) // сравниваем максимальную сумму  
        {
            maxNumSum = sumString;//если сумма больше чем предыдущая записываем ее
            stringNum = i + 1;//увеличиваем номер строки на1 чтобы показать номер по счету реальный
        }
        Console.Write((sumString) + "; ");
        // переходим на другую строку
        i++;
    }

    Console.WriteLine("Максимальная сумма элементов  строки, находится в {0}-й строке: {1}", stringNum, maxNumSum);


}
int[,] twoDimArray = FillTwoDimArray(3, 4);
PrintTwoDimArray(twoDimArray);
Console.Write($"\nCуммы по строчно:\n");
CalcSumString(twoDimArray);
