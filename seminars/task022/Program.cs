//Вариант 1 
void multipleSearch()
{
    string? inputLkneOne = Console.ReadLine();
    string? inputLkneTwo = Console.ReadLine();

    if (inputLkneOne != null && inputLkneTwo != null)
    {
        int inputNumberOne = int.Parse(inputLkneOne);
        int inputNumberTwo = int.Parse(inputLkneTwo);

        int div = inputNumberTwo % inputNumberOne;
        if (div == 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine(div);
        }
    }
}
// Вариант 2
void multipleSearch2()
{
    Console.Write("Enter first number: ");
    string? firstLine = Console.ReadLine();
    Console.Write("Enter second number: ");
    string? secondLine = Console.ReadLine();
    int first = int.Parse(firstLine);
    int second = int.Parse(secondLine);
    if (second%first == 0)
    {
        Console.WriteLine("Кратное");
    }
    else
    {
    Console.WriteLine("Не кратное, " + second % first);
    }
}
multipleSearch();
multipleSearch2();
