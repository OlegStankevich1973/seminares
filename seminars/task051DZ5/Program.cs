Console.Clear();
//   Программа подсчета разницы между максимальным и минимальным элементом массива
 
//Метод возвращает массив заполненый случайными числами от 0 до 100
int[] FillingArray()
{
    // создаем навый массив на 12 элементов
    int[] outArray = new int[12];
    // в массиве создаем итератор
    int i = 0;
    // создаем синтезатор для заполнения массива случайными числами
    System.Random numberSintezator = new System.Random();
    while (i < 12)
    {
        // заполняем массив случайными числами от 0 до 100
        outArray[i] = numberSintezator.Next(0, 101);
        i++;
    }
    // возвращаем из метода массив 
    return outArray ;
}
//Метод печатает массив
// берем массив из прошлого метода FillingArray
void PrintIntArray(int[] outArray)
{
    //Буфферная переменная
    int i = 0;
    // выводим первую скобку до действия цикла печати
    Console.Write("[");
    //Пробегаем все элементы массива без последнего чтобы не было (,)
    while (i < outArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(outArray[i] + ", ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим последний элемент массива и последнюю скобку тк после цикла находится
    Console.WriteLine(outArray[i] + "]");
}
// метод поиска максимального элемента массива
// берем массив из прошлого метода FillingArray
int SearchMaxNumber(int[] outArray)
{
    int maxNumber = outArray[0];  //присваиваем максимальный элемент 0 элементу массива
    // задаем условие прохождения массива
    for (int i = 1; i < outArray.Length; i++) 
    {
        // сравниваем 0 и 1 элементы и присваиваем максимум наибольшему
        if (outArray[i] > maxNumber) maxNumber = outArray[i];
    }
    // возвращаем maxNumber в программу
    return (maxNumber);
}
// метод поиска минимального элемента массива
int SearchMinNumber(int[] outArray)
{
    int minNumber = outArray[0];  // минимальный элемент
    for (int i = 1; i < outArray.Length; i++)
    {
        if (outArray[i] < minNumber) minNumber = outArray[i];
    }
    return (minNumber);
    
}
int[] bufferArray = FillingArray();
int difNumber = 0;
int maxNumber = SearchMaxNumber(bufferArray);
int minNumber = SearchMinNumber(bufferArray);


// печатаем созданный массив
PrintIntArray(bufferArray);
// ищем максимальный элемент
SearchMaxNumber(bufferArray);
// ищем минимальный элемент
SearchMinNumber(bufferArray);
// печатаем 
Console.WriteLine("Максимальный элемент = " + maxNumber);
// печатаем
Console.WriteLine("Минимальный элемент = " + minNumber);
// печатаем разницу между макс и мин
Console.WriteLine ( difNumber = SearchMaxNumber(bufferArray)-SearchMinNumber(bufferArray));

