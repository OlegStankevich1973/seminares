
// Программа создания любого массива с любым диапазоном случайных чисел
Console.Clear();
void VariantOne()
{
    Console.WriteLine("Введите длину массива");
    int lengthArray = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите начальный диапазон чисел массива");
    int initNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите конечный диапазон чисел массива");
    int finalNumber = int.Parse(Console.ReadLine());
        System.Random numberSintezator = new Random();
   
    int i = 0;
    Console.Write("[");
    // убираем последний элемент чтобы потом убрать последнюю запятую при печати(задаём диапазон массива)
    while (i < lengthArray - 1)
    {
        // цифры массива от0 до 99(100 не входит) и запятые между ними
        Console.Write(numberSintezator.Next(initNumber, finalNumber) + ",");
        i++;
    }
    // распечатываем последний элемент отдельно
    Console.Write(numberSintezator.Next(initNumber, finalNumber));

    Console.WriteLine("]");
    Console.WriteLine("Диапазон значений элементов " + "(" + initNumber + "," + (finalNumber) + ")");
    Console.WriteLine("Длина элементов массива равна " + lengthArray + " элементов");

}
VariantOne();
void VariantTwo()
{ // Программа создания любого массива с любым диапазоном чисел выдаваемых случайно
// (ввод данных вручную в программе)
    System.Random numberSintezator = new Random();
    // создание синтезатором случайных цифр

    int initNumber = 0;
    // вводим конечный диапазон чисел
    int finalNumber = 100;
    // вводим длину массива
    int lengthArray = 8;
    int i = 0;
    Console.Write("[");
    // убираем последний элемент чтобы потом убрать последнюю запятую при печати(задаём диапазон массива)
    while (i < lengthArray - 1)
    {
        // цифры массива от0 до 99(100 не входит) и запятые между ними
        Console.Write(numberSintezator.Next(initNumber, finalNumber) + ",");
        i++;
    }
    // распечатываем последний элемент отдельно
    Console.Write(numberSintezator.Next(initNumber, finalNumber));

    Console.WriteLine("]");
    Console.WriteLine("Диапазон значений элементов " + "(" + initNumber + "," + (finalNumber) + ")");
    Console.WriteLine("Длина элементов массива равна " + lengthArray + " элементов");

}
VariantTwo();


