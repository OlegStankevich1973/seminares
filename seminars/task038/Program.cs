Console.Clear();
Console.Write("Введите число :");
string inputLine = Console.ReadLine();
long inputNumber = long.Parse(inputLine);
Console.WriteLine(sumNums(inputNumber));
DateTime timePoint = DateTime.Now;
timePoint = DateTime.Now;
long sumNums(long num)
{
    long sum = 1;
    for (long i = 1; i <= inputNumber; i++)
    {
        //   sum*=i;
        sum = sum * i;
    }
    return sum;
}
Console.WriteLine(DateTime.Now - timePoint);
