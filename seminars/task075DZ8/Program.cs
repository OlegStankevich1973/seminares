// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// ===============================================================================================
Console.Clear();
Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
PrintArray(array3D);
// метод ввода данных через консоль
int InputNumbers(string input)
{
    Console.Write(input);

    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
// метод печати ответа  
void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        Console.Write($"X({i}) ");
        for (int j = 0; j < array3D.GetLength(1); j++)
        {

            Console.Write($"Y({j}) ");

            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"Z({k})={array3D[i, j, k]}; ");


            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
// метод заполнения случайными не совпадающими числами трехмерного массива
void CreateArray(int[,,] array3D)
{
    // создаем буферный одномерный массив(зачем перемножать длину массивов?)
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        // для буферного массива (i)создаем случайные числа
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                // если случайн число для i  и j равны
                while (temp[i] == temp[j])
                {
                    // тогда создаем новое случайное число для j
                    temp[j] = new Random().Next(10, 100);

                    j = 0;
                    number = temp[j];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];//присваиваем число трехмерному массиву
                count++;
            }
        }
    }
}
