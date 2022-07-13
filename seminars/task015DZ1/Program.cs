string? inputLine = Console.ReadLine();

if(inputLine != null);
{
    int inputNumber = int.Parse(inputLine);

    int startNumber = 1;

    string lineOutput = "0";
    
    // if( startNumber%2 == 0)
    // {
    //     Console.WriteLine(startNumber);
    // }
    // else
    // {
    //     Console.WriteLine();
    // }
    while (startNumber <= inputNumber)
    {
        lineOutput = lineOutput+", "+startNumber;
        startNumber++;
    }
     if( startNumber%2 == 0)
    {
        Console.WriteLine(startNumber);
    }
    else
    {
        Console.WriteLine();
    }

    Console.WriteLine(lineOutput);

}
