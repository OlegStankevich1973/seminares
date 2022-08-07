

// System.Random numberSintezator = new Random();
// // создание массива из 8 чифр 
// void VariantNaive()
// {
//     int i = 0;
//     Console.Write("[");
//     // убираем последний элемент чтобы потом убрать последнюю запятую при печати
//     while (i < 8 - 1)
//     {
//         // цифры массива 0 и 1(2 не входит) и запятые между ними
//         Console.Write(numberSintezator.Next(0,2)+",");
//         i++;
//     }
//     // распечатываем последний элемент отдельно
//     Console.Write(numberSintezator.Next(0,2));

//     Console.Write("]");

// }
Console.Clear();
// создаем строковую переменную
string? inputLineN =Console.ReadLine();
// проверяем ее на null(пустоту)
if (inputLineN != null)
{
    // меняем строковую на цельночисленную переменную
    int numberN = int.Parse(inputLineN);
    // определяем как будет печатать первая строка в данном случае сразу не касается второй строки
    string lineN = " ";

     string lineNNN = " ";
    // определяем первое число выполнения программы
    int s = 1;

    while (s < numberN+1)
    {
        lineN = lineN + s + " ";
        lineNNN = lineNNN + (s * s * s).ToString() + " ";
        s++;
    }
        Console.WriteLine(lineN);
        Console.WriteLine(lineNNN);

} 
