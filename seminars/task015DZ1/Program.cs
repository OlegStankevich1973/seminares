string? inputLine = Console.ReadLine();

if(inputLine != null);
{
    int inputNumber = int.Parse(inputLine);
// строка 7 первоначальный номер ряда
    int startNumber = 1; 
// строка 9 число 0 в ряду, введен принудительно
    string lineOutput = "0";
       
        while (startNumber <= inputNumber)
    {
        if(startNumber%2 == 0)
   
    lineOutput =lineOutput+","+startNumber;
    startNumber++;
    }
   

    Console.WriteLine(lineOutput);

}
