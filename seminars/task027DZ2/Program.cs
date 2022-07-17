Console.Clear();
Console.WriteLine("Введите число,обозначающее день недели: ");
string? inputLine = Console.ReadLine();

if(inputLine != null)
{
 int inputNumber = int.Parse(inputLine);

    if(inputNumber == 6||inputNumber==7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет"); 
    }
}
