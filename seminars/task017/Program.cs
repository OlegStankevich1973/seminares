System.Random numberSintezator = new System.Random();
double number = numberSintezator.Next(10,100);

Console.WriteLine(number);
double firstNumber = number/10;
double secondNumber = number%10;

if(firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}