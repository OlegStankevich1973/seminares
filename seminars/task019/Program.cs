System.Random numberSintezator = new System.Random();
char[] digits =numberSintezator.Next(10,100).ToString().ToCharArray();
// выводим случайное число на экран
Console.WriteLine(digits);
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;
// сравниваем по типу оператора(if и else)
int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);