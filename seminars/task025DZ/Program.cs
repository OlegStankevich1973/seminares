
// вариант 1
void digitTensNumbers()
{
int number = new Random().Next(100,1000);
Console.WriteLine("Число: "+number);
int numberTensDigit = number/10;
int numberSecondDigit = numberTensDigit%10;
Console.WriteLine("Вторая цифра трехзначного числа: "+numberSecondDigit);
}
// вариант 2
void digitTensNumbers1()
{
int number = new Random().Next(100,1000);
    Console.Write("The random number is: ");
    Console.WriteLine(number);
    string stringNum = number.ToString();
    Console.Write("The modified num is: ");
    Console.Write(stringNum[1]);
} 
 digitTensNumbers ();
 digitTensNumbers1 ();