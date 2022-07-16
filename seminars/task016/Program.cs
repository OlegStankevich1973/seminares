string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();
string? inputLineThree = Console.ReadLine();
if (inputLineOne != null && inputLineTwo != null && inputLineThree != null) ;
{
int inputNumberOne = int.Parse(inputLineOne);
int inputNumberTwo = int.Parse(inputLineTwo);
int inputNumberThree = int.Parse(inputLineThree);
int maxNumber = inputNumberOne;
if (inputNumberOne < inputNumberTwo)
{
maxNumber = inputNumberTwo;
if (inputNumberTwo < inputNumberThree)
{
maxNumber = inputNumberThree;
}
}
else
{
if (inputNumberOne < inputNumberThree)
{
maxNumber = inputNumberThree;
}
}
Console.WriteLine(maxNumber);
}