//Переменные для накопления результата
int resultCount = 0;

//Метод возвращает массив заполненый случайными трехзначными числами 
int[] FillingArray()
{
    // создаём массив на 12 чисел
    int[] outArray = new int[12];
    int i = 0;
    // создаем случайные числа
    System.Random numberSintezator = new System.Random();
    while (i < 12)
    {
        // создаём случайные числа в диапвзоне 100 до 999
        outArray[i] = numberSintezator.Next(100, 1000);
        i++;
    }
    return outArray;
}
// Метод подсчета четных  значений
void ColculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] % 2 == 0)
        {
            resultCount++;
        }
        i++;
    }
}
//Выводим результат на кансоль
void PrintResult()
{
    Console.WriteLine(resultCount);
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
//Метод решения задачи 34 

//запускаем метод создания массива со случайными числами
int[] bufferArray = FillingArray();
//выводим на печать этот массив
PrintIntArray(bufferArray);
// считаем количество положительных элементов
ColculateTask(bufferArray);
// выводим сумму этих положительных элементов
PrintResult();



