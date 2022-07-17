// вариант 1
    void digitTensNumbers ()
{
int number = new Random().Next(100,1000);
    Console.Write("The random number is: ");
    Console.WriteLine(number);
    string stringNum = number.ToString();
    Console.Write("The modified num is: ");
    Console.Write(stringNum[1]);
}    
// вариант 2
    void digitTensNumbers1 ()
{
int number = new Random().Next(100,1000);
    Console.Write("The random number is: ");
    Console.WriteLine(number);
    int num1 = number/10;
    int num2 = num1%10;
    Console.Write("The modified num is: ");
    Console.WriteLine(num2);
}
    digitTensNumbers ();
    digitTensNumbers1 ();

