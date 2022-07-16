int number = new Random().Next(10, 100);

string stringNum = number.ToString();
Console.Write("The random number is: ");
Console.WriteLine(number);
Console.Write("The biggest digit is: ");
if(stringNum[0] > stringNum[1])
{
    Console.WriteLine(stringNum[0]);
}
else
{
    Console.WriteLine(stringNum[1]);
}
