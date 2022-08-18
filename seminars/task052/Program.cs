//=========================================================================================================
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// Разбор на семинаре
//=========================================================================================================
//Метод возвращает массив заполненый случайными числами 
int[] FillingArray(int arrayLength)
{
    int[] outArray = new int[arrayLength];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < arrayLength)
    {
        outArray[i] = numberSintezator.Next(-1000, 1000);
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
// метод переворачивает массив последний элемент будет на первом месте, 
// а первый - на последнем и т.д. 
// возвращаемый метод ( в скобкахберем ранее созданный массив)
int[] ReverseNewArray(int[] array)
{
    // присваиваем число длине массива
    int length = array.Length;
    // создаем новый массив такой же длины(выделяем оперативную память под новый массив)
    int[] newArray = new int[length];
    // проходим весь массив
    for (int i = 0; i < length; i++)
    {
        // берем первое число старого массива и создаем последнее число нового массива которое равно
        //  длина массива-1-индекс числа старого массива
        newArray[length - 1 - i] = array[i];
    }
    // возвращеем новый массив
    return newArray;
}

int[] ReverseSwapArray(int[] array)
{
    int length = array.Length;
    int buf;
    // проходим половину массива т к идем с двух сторон к центру
    for (int i = 0; i < length / 2; i++)
    {
        //i=1
        // создаем буферное число = первому числу массива
        buf = array[i];
        // присваиваем последнему числу  массива  первое число  массива 
        array[i] = array[length - 1 - i];
        // присваиваем буферному числу последнее число массива
        array[length - 1 - i] = buf;
    }
    // передаем массив для возврата наверх для других методов
    return array;
}
// новому массиву testArray присваиваеем то что получилось из метода FillingArray на 17 элементов
int[] testArray = FillingArray(17);
//  из массива, который получился в методе ReverseNewArray из массива testArray
// создаем новый массива reversedArray
int[] reversedArray = ReverseNewArray(testArray);
PrintIntArray(testArray);
PrintIntArray(reversedArray);
// выводим на печать методом PrintIntArray массив testArray
PrintIntArray(testArray);
// выводим на печать методом PrintIntArray массив testArray 
// который преобразован методом ReverseSwapArray
PrintIntArray(ReverseSwapArray(testArray));
