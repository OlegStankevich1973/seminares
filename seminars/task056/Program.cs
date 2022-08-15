// Напишите программу, которая будет создавать копию заданного 
// одномерного массива с помощью поэлементного копирования.


//Метод возвращает массив заполненый случайными числами 
int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 12)
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
// метод создает копию массива
int[] CopyArrayStandartTool(params int[] inputArray)
{
    int[] buferArray = new int[inputArray.Length];
    inputArray.CopyTo(buferArray, 0);
    return buferArray;
}

int[] testArray = FillingArray();
PrintIntArray(testArray);

int[] outArray = (int[])CopyArrayStandartTool(testArray);
PrintIntArray(outArray);
