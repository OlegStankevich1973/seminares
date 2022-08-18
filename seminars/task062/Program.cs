//=========================================================================================================
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты
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
        //Console.Write("\n");          //можно так делать и как  в строке 40
        Console.WriteLine();
        i++;
    }
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
// Метод цветной печати
void PrintColorTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;



    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(inputArray[i, j] + "\t");  //\t это табуляция выводит таблицей
            Console.ResetColor();
            j++;
        }
        //Console.Write("\n");  //можно так  и как в строке 69
        Console.WriteLine();
        i++;
    }

}
// метод решения задачи
int[,] UpdateTwoDimArray(int[,] inputArray)
{
    // создаем новый массив буферный outArray
    int[,] outArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            // если i четное и j четное 
            if (i % 2 == 0 && j % 2 == 0)
            {
                // элемент массива возводим в квадрат
                outArray[i, j] = inputArray[i, j] * inputArray[i, j];
            }
            else
            {
                // если иначе то оставляем тот который был
                outArray[i, j] = inputArray[i, j];
            }
            j++;
        }
        i++;
    }

    return outArray;
}
// метод два решения задачи более быстрый ( с использованием ref,без создания буферного массива
//  и прогона только по четным элементам массива)
void UpdateTwoDimArrayNataliaVersion(ref int[,] inputArray)
{
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            inputArray[i, j] = inputArray[i, j] * inputArray[i, j];
            j += 2;
        }
        i += 2;
    }
}

// вводим параметры массива
int[,] twoDimArray = FillTwoDimArray(10, 10);
PrintColorTwoDimArray(twoDimArray);
//----------------------------------------------------------
// считаем время выполнения первого метода
DateTime d = DateTime.Now;
int[,] bufTwoDimArray = UpdateTwoDimArray(twoDimArray);
Console.WriteLine(DateTime.Now - d);
// считаем время выполнения второго метода
d = DateTime.Now;
UpdateTwoDimArrayNataliaVersion(ref twoDimArray);
Console.WriteLine(DateTime.Now - d);
//----------------------------------------------------------
// печать первого метода
PrintColorTwoDimArray(bufTwoDimArray);
// печать второго метода
PrintColorTwoDimArray(twoDimArray);
//----------------------------------------------------------


