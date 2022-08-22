//==========================================================
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
//==========================================================

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
//  метод упорядочивания строк массива
void SortStringTwoFrreay(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            // сортировка пузырьком
            for (int k = j + 1; k < inputArray.GetLength(1); k++)
            {
                if (inputArray[i, j] <= inputArray[i, k]) continue;//continue не понятно зачем
                int temp = inputArray[i, j];
                inputArray[i, j] = inputArray[i, k];
                inputArray[i, k] = temp;
            }

        }

    }

}

int[,] twoDimArray = FillTwoDimArray(5, 6);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();
SortStringTwoFrreay(twoDimArray);
PrintTwoDimArray(twoDimArray);









