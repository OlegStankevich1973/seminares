//=========================================================================================================
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// 
//=========================================================================================================

// метод для заполнения двумерного массива
double[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new  System.Random();
    int i = 0; int j = 0;
    // countRow это счетчик строк,countColumn это столбцов
    double[,] outArray = new double[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;//обнуляем j для перехода на столбцы
        while (j < countColumn)
        {
            // элементы массива создаем синтезатором дробных чисел numberSyntezator.NextDouble()
            // при этом чтобы они были в пределах где -то -10 до 10 умножаем случайное число на 20 и 
            // вычитаем 10,оператор Math.Round дает 4 цифру после запятой
             outArray[i, j] = Math.Round(20*numberSyntezator.NextDouble()-12,3);
            j++;
        }
        i++;
    }
    return outArray;
}
// метод для печати двумерного массива
void PrintTwoDimArray(double[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))//0 это измерение строк
    {
        j = 0;
        while (j < inputArray.GetLength(1))//1 это измерение столбцов(если трехмерный массив то следующее буде 2)
        {
            Console.Write(inputArray[i, j] + "\t");
            j++; 
        }
        // Console.Write("\n");//печатает конец строки
        Console.WriteLine( );// или так печатает конец строки
        
        i++;
    }
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

void PrintColorTwoDimArray(double[,] inputArray)
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
            Console.Write(inputArray[i, j] + "\t");//печатаем цветом в виде таблицы \t
            Console.ResetColor(); //сброс цветной печати

            j++;
        }

        //Console.Write("\n");
        Console.WriteLine( );
        
        i++;

    }


}

double[,] twoDimArray = FillTwoDimArray(4, 6);
PrintTwoDimArray(twoDimArray);
Console.WriteLine( );
PrintColorTwoDimArray(twoDimArray);

