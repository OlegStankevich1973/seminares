// Принимает число с панели и выводит позледнюю цифру вводимого числа
// ==================================================================
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    int outputNumber = inputNumber % 10;

    Console.WriteLine(outputNumber);
}
