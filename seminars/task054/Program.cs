// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.WriteLine(Convert.ToString(int.Parse(Console.ReadLine()), 2));
// то что написал в строке2 только раскладываю по полочкам
// преобразуем в переменную numbe1 то число которое ввели в консоль
string? numbe1 = Console.ReadLine();
// создаем переменную DateTime.Now для  проверки времени начала работы программы
DateTime d1 = DateTime.Now;
// парсим numbe1 в целочисленное значение ,методом ToString преобразуем это число 
// в 2(двоичную систему исчисления) и потом печатаем то что получилось
Console.WriteLine(Convert.ToString(int.Parse(numbe1), 2));
// печатаем время выполнения программы
Console.WriteLine(DateTime.Now - d1);
// задаем время начала выполнения программы
// d1 = DateTime.Now;
// Второй вариант решения задачи

// Console.WriteLine("Введите десятичное число: ");
// int decemalNumber = ReadDecemalNumber();
// PrintAnswer(BinaryConverter(decemalNumber));
// Console.WriteLine(DateTime.Now - d1);


// int ReadDecemalNumber()
// {
//     return int.Parse(numbe1 ?? "");
// }

// string BinaryConverter(int num)
// {
//     string bin = "";
//     while (num > 0)
//     {
//         if (num % 2 == 1)
//         {
//             bin = "1" + bin;
//         }
//         else
//         {
//             bin = "0" + bin;
//         }
//         num /= 2;
//     }
//     return bin;
// }

// void PrintAnswer(string answer)
// {
//     Console.WriteLine("Введенное число в двоичном виде: " + answer);
// }


