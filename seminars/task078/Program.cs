
// Заполните спирально квадратный массив по возрастанию,
// с заданным размером:

int Prompt(string message)
{
    Console.Write(message);
    string NumStr = Console.ReadLine();
    int Num = int.Parse(NumStr);
    return Num;
}

int[,] InitMatrix(int rows, int columns)
{ return new int[rows, columns]; }

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] FillSpiral(int[,] matrix, int startNumber = 1, int count = 1)
{
    for (int j = -1 + count; j < matrix.GetLength(1) + 1 - count; j++)
    {
        matrix[-1 + count, j] = startNumber++;
    }
    for (int i = count; i < matrix.GetLength(0) + 1 - count; i++)
    {
        matrix[i, matrix.GetLength(1) - count] = startNumber++;
    }
    for (int j = matrix.GetLength(1) - 1 - count; j > -1 + count; j--)
    {
        matrix[matrix.GetLength(0) - count, j] = startNumber++;
    }
    for (int i = matrix.GetLength(0) - count; i > -1 + count; i--)
    {
        matrix[i, -1 + count] = startNumber++;
    }
    if (startNumber <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        FillSpiral(matrix, startNumber, ++count);
    }
    return matrix;
}

int MatrixDimension = Prompt("Enter the number of rows/columns in square matrix => ");

int[,] NewMatrix = InitMatrix(MatrixDimension, MatrixDimension);

PrintMatrix(FillSpiral(NewMatrix));
