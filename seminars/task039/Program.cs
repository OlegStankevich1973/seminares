Console.Clear();
Console.Write("Введите число :");
string inputLine = Console.ReadLine();
long inputNumber = long.Parse(inputLine);
Console.WriteLine(mulRec(inputNumber));
DateTime timePoint = DateTime.Now;
timePoint = DateTime.Now;
long mulRec(long num)
{
    // тк 0!=1
    if (num == 0)
    {
        return 1;
    }
    else
    {
        // формула рекурсии n!=(n-1)*n
        return num*mulRec(num-1);
    }
}


Console.WriteLine(DateTime.Now - timePoint);