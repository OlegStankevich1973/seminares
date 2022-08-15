//=========================================================================================================
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// Разбор на семинаре
//=========================================================================================================

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    // countRow это счетчик строк,countColumn это столбцов
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;//обнуляем j для перехода на столбцы
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

    while (i < inputArray.GetLength(0))//0 это измерениестрок
    {
        j = 0;
        while (j < inputArray.GetLength(1))//1 это измерение столбцов(если трехмерный массив то следующее буде 2)
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        // Console.Write("\n");//печатает конец строки
        Console.WriteLine();// или так печатает конец строки
        i++;
    }
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
            // перед началом печати вводится оператор для цвета
            //  произвольно выбирает цвет из 16 цветов для печати элементов 
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(inputArray[i, j] + " ");//печатаем цветом
            Console.ResetColor(); //сброс цветной печати
            j++;
        }

        //Console.Write("\n");
        Console.WriteLine();
        i++;

    }


}

int[,] twoDimArray = FillTwoDimArray(5, 8);
PrintTwoDimArray(twoDimArray);
PrintColorTwoDimArray(twoDimArray);


