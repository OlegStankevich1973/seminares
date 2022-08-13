//=========================================================================================================
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// На семинаре
//=========================================================================================================
// задаем глобальные переменные те длины сторон
int sideA = 0;
int sideB = 0;
int sideC = 0;
// вводим значения используя метод ReadSides
ReadSides();
// в метод TestTriangle вкладываем переменные sideA,sideB,sideC и передем результат
//  в новую переменную bool res
bool res = TestTriangle(sideA,sideB,sideC);
// выводим на печать с помощью метода PrintAnswer результат res
PrintAnswer(res);

// метод ввода чисел в консоле( стороны треугольника длины ( строки 7,8,9))
void ReadSides()
{
    Console.Write("Введите число 1: ");
    sideA = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число 2: ");
    sideB = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число 3: ");
    sideC = int.Parse(Console.ReadLine() ?? "");
}
// метод проверки получится ли треугольник с заданными сторонами
bool TestTriangle(int num1, int num2, int num3)
{
    bool answer = ((num1 + num2 > num3) 
    && (num2 + num3 > num1) 
    && (num1 + num3 > num2)) ? true : false;
    // переменная answer = (условие)?значение1 true :значение2 false ;
    return answer;
}
// метод печати
void PrintAnswer(bool answer)
{
    if (answer)
    {
        Console.WriteLine("Из этих отрезков можно составить треугольник");
    }
    else
    {
        Console.WriteLine("Из этих отрезков нельзя составить треугольник");
    }
}

// внизу вариант решения задачи рабочий но не очень логичный тут в этом решении
// можно посмотреть как использовать в методах оператор try и catch
//проверка существования треугольника
// bool CheckTriangle(int[] numbers)
// {
//     if ((numbers[0] + numbers[1] > numbers[2]) 
//     && (numbers[2] + numbers[0] > numbers[1]) 
//     && (numbers[1] + numbers[2] > numbers[0]))
//         return true;
//     else
//         return false;
// }

// Console.Clear();

// Console.WriteLine("Введите три числа в формате Ч1 Ч2 Ч3");
// try
// {
//     string[] stringNumbers = Console.ReadLine().Split(" ");
//     int[] numbers = new int[3];
// for (int i = 0; i < stringNumbers.Length; i++)
//     numbers[i] = int.Parse(stringNumbers[i]);

// if (CheckTriangle(numbers))
//     Console.WriteLine("Треугольник существует!");
// else
//     Console.WriteLine("Треугольника не существует!");
// }
// catch
// {
//     Console.WriteLine("Некорректный формат ввода");
// }

