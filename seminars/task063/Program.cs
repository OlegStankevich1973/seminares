//=========================================================================================================
// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Разбор на семинаре
//=========================================================================================================

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
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

// Метод решения задачи
int CalcDiagTwoDimArr(int[,] inputArray)
{
    // вводим локальную буферную переменную суммы
    int outSumDiaganal = 0;

    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        // складываем элементы массива находящиеся с одинаковыми индексами i=j=i
        outSumDiaganal+=inputArray[i,i];        
        i++;
    }

    return outSumDiaganal;
}
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

void PrintColorTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;



    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(inputArray[i, j] + "\t");//табулящия печать в виде таблицы
            Console.ResetColor();// сброс консоль в исходное состояние по цвету
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }


}


// создаем массив чтобы вывести его из метода FillTwoDimArray с заданным размером массива
int[,] twoDimArray = FillTwoDimArray(3, 4);
PrintColorTwoDimArray(twoDimArray);
//----------------------------------------------------------
// выводим сумму из метода
int sum = CalcDiagTwoDimArr(twoDimArray);
//----------------------------------------------------------
// печать полученной суммы
Console.WriteLine(sum);
//----------------------------------------------------------
