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
// метод решения задачи
bool SearchNum(int[,] inputArray, int searchNumber)
{
    bool resultSearch = false;
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            if (inputArray[i, j] == searchNumber)
            {
                resultSearch = true;
                break;

            }
            j++;
        }
        i++;
    }
    return resultSearch;
}
// метод печати результата задачи
void PrintTaskResult(bool resultSearch,int searchNumber)
{
    bool result = resultSearch;
    if (result == true)
    {
        Console.WriteLine("Число есть в массиве");
    }
    else
    {
        Console.WriteLine( "Данного числа "+searchNumber +"  нет в этом массиве");
    }

}
int[,] twoDimArray = FillTwoDimArray(3, 5);
PrintTwoDimArray(twoDimArray);
Console.WriteLine("Введите искомое число ");
int searchNumber = int.Parse(Console.ReadLine());
bool resultSearch = SearchNum(twoDimArray, searchNumber);
PrintTaskResult(resultSearch,searchNumber);

