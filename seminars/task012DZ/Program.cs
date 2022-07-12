string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();

if(inputLineOne != null && inputLineTwo != null)
{
    int inputNumberOne = int.Parse(inputLineOne);
    int inputNumberTwo = int.Parse(inputLineTwo);

 Console.Write("max = ");
 
    if(inputNumberOne > inputNumberTwo)

         Console.Write(inputNumberOne);
    else  
         
        Console.Write(inputNumberTwo); 

}
