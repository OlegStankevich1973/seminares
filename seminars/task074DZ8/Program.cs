// /Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
// =========================================================================================

// ​// метод для заполнения двумерного массива первого
int[,] FillTwoDimArrayOne(int countRowOne, int countColumnOne)
{
    System.Random numberSyntezatorOne = new System.Random();
    int i = 0;
    int j = 0;
    int[,] outArrayOne = new int[countRowOne, countColumnOne];
    while (i < countRowOne)
    {

        j = 0;
        while (j < countColumnOne)
        {
            outArrayOne[i, j] = numberSyntezatorOne.Next(0, 10);
            j++;
        }
        i++;
    }
    return outArrayOne;
}
// метод печати массива первого ,второго и третьего
void PrintTwoDimArrayOne(int[,] inputArrayOne)
{
    int i = 0; int j = 0;

    while (i < inputArrayOne.GetLength(0))
    {
        j = 0;
        while (j < inputArrayOne.GetLength(1))
        {
            Console.Write(inputArrayOne[i, j] + "\t");
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}
// метод создание второго массива
int[,] FillTwoDimArrayTwo(int countRowTwo, int countColumnTwo)
{
    System.Random numberSyntezatorTwo = new System.Random();
    int m = 0; int n = 0;
    int[,] outArrayTwo = new int[countRowTwo, countColumnTwo];
    while (m < countRowTwo)
    {
        n = 0;
        while (n < countColumnTwo)
        {
            outArrayTwo[m, n] = numberSyntezatorTwo.Next(0, 10);
            n++;
        }
        m++;
    }
    return outArrayTwo;
}

// метод решения задачи
int[,] MultiplTwoDimArray(int[,] inputArrayOne,int[,] inputArrayTwo)
{
    // создаем новый массив буферный outArray с длиной строк и столбцов как у первого
    //  или можно как у второго как сделать чтобы любое было не знаю(если разные)
    int[,] outArray = new int[inputArrayOne.GetLength(0),inputArrayOne.GetLength(1)];
    // int[,] outArray = new int[inputArrayOne, inputArrayTwo];
    int i = 0; int j = 0;int m = 0; int n = 0;
    while (i < inputArrayOne.GetLength(0))
    {
        j = 0;n=0;
        while (j < inputArrayOne.GetLength(1) )
        {
            // если индексы одинаковые в двух массивах
            if (i  == m && j == n)
            {
                // рассчитываем элемент нового массива 
                outArray[i, j] = inputArrayOne[i, j] * inputArrayTwo[m, n];
            }
            
            j++;n++;
        }
        i++;m++;
    }

    return outArray;
}
int[,] twoDimArrayOne = FillTwoDimArrayOne(3, 5);
PrintTwoDimArrayOne(twoDimArrayOne);
Console.WriteLine();
int[,] twoDimArrayTwo = FillTwoDimArrayTwo(3, 5);
PrintTwoDimArrayOne(twoDimArrayTwo);
Console.WriteLine();
int[,] bufTwoDimArray = MultiplTwoDimArray(twoDimArrayOne,twoDimArrayTwo);
PrintTwoDimArrayOne(bufTwoDimArray);





