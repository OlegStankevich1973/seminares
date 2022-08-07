// задача на ввод числа и посчета суммы его цифр
Console.Clear();
Console.Write("Введите число :");
string inputLineNumber = Console.ReadLine() ?? "";
int inputNumber = int.Parse(inputLineNumber);
// задаем время начало отсчета программы
DateTime timePoint = DateTime.Now;
{

    int VariantChar()
    {
    // обьявили массив в него положили символы из которого состоит наше число
    char[] array = inputLineNumber.ToCharArray();
    // обьявил переменную
    int sumOfNumbers = 0;
    // задал условия выполнения подсчета sumOfNumbers
    for (int i = 0; i < array.Length; i++)
    {
    // тоже самое что и в строке 19 формула подсчета суммы(-48 определил опытным путем ,почему надо делать не знаю)
    // sumOfNumbers = sumOfNumbers + array[i]-48;
        sumOfNumbers += array[i] - 48;
    }
    return sumOfNumbers;

    }
// делаем второй метод выполнения программы(за счет суммирования остатка деления на 10 и последующее деление вводимого числа на 10)
    int VariantTwo()

    {
        // 
        int sumOfNumbers = 0;
        while (inputNumber > 0)
        {
            // суммируем отаток от деления на 10 вводимого числа
            sumOfNumbers = sumOfNumbers+(inputNumber % 10);
            // уменьшаем вводимое число в 10 раз(тюу таким образом перебираем и суммируем все цифры числа)
            inputNumber=inputNumber/10;
        }
        return sumOfNumbers;
    }
    int result = 0;
    // задаем начало выполнения программы
    timePoint = DateTime.Now;
    result = VariantChar();
    Console.WriteLine(result);
    // считаем время выполнения программы и выводим на консоль
    Console.WriteLine(DateTime.Now - timePoint);
    timePoint = DateTime.Now;
    result = VariantTwo();
    Console.WriteLine(result);
    // считаем время выполнения программы и выводим на консоль
    Console.WriteLine(DateTime.Now - timePoint);
}
