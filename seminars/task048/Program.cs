//Метод возвращает массив заполненый случайными числами 
int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 12)
    {
        outArray[i] = numberSintezator.Next(-5,10);
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

//Метод решения задачи 37 наивный
int[] ColculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length/2+1];
    int i =0;

    while(i<resultArray.Length)
    {
        // считаем произведение элемент массива*напоследний элемент массива-индекс массива
        // пример индекс =1(получаем второй элемент*последний элемент -1 -1 те предпоследний)
        resultArray[i] = inputArray[i]*inputArray[inputArray.Length-1-i];
        i++;
    }

    return resultArray;
}


int[] buferArray = FillingArray();
PrintIntArray(buferArray);
int[] resultArray = ColculateTask(buferArray);
PrintIntArray(resultArray);
