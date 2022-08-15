// //=================================================================================
// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// //==================================================================================

Console.Clear();

int[] EnteringNumbers()//метод ввода с клавиатуры
{
    Console.WriteLine("Введите требуемое количество чисел M");
    int M = int.Parse(Console.ReadLine());//преобразуем данные с консоли в целочисленное значение
    int[] buferArr = new int[M];//создаем буферный массив вводимых чисел
    for (int i = 0; i < M; i++)//для (условия)
    {
        Console.WriteLine("Введите {0}-й элемент", i + 1);//выводим на печать в{изменяемый номер вводимого числа}
        buferArr[i] = int.Parse(Console.ReadLine());//все вводимые числа засовываем в массив
    }
    return buferArr;//возвращаем массив
}
int СountNumbers(int[]inputArray)//метод подсчета чисел >0
{
    int result = 0;//задаем начальное значение результата
    for (int i = 0; i < inputArray.Length; i++)// для (условие)(inputArray.Length длина массива строка 10)
        if (inputArray[i] > 0)
            result++;
    return result;
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


int[] enteringNumber = EnteringNumbers();//вкладываем в массив значения из массива в методе EnteringNumbers
int num = СountNumbers(enteringNumber);//вкладываем в переменную значение результата из метода СountNumbers
PrintIntArray(enteringNumber);//печатаем массиввводимых чисел
Console.WriteLine(num);//выводим на экран количество чисел>0
