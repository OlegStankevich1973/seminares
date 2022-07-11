string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int outNumber = inputNumber*inputNumber;
    Console.WriteLine(outNumber);
}
