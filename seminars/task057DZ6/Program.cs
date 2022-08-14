
//Метод возвращает массив заполненый случайными числами 
int[] FillingArray(int arrayLength)
{
    int[] outArray = new int[arrayLength];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < arrayLength)
    {
        outArray[i] = numberSintezator.Next(-100, 100);
        i++;
    }
    return outArray;
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + ", ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}

//Метод считает положительные элементы массива 
int ColculateTask(int[] inputArray)
{
    int resultCount = 0;
    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i] >= 0)
        {
            resultCount++;// суммируем элементы соответствующие условию
        }
        i++;
    }
    return resultCount;
}

int[] buferArray = FillingArray(17);
PrintIntArray(buferArray);
Console.WriteLine("Количество подходящих элементов " + (ColculateTask(buferArray)));
