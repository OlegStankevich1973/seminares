Console.Clear();
// создаем строковую переменную
string? inputNumber = Console.ReadLine();
// проверяем ее на null(пустоту)
if (inputNumber != null)
{
    // меняем строковую на цельночислeнную;
    int number = int.Parse(inputNumber);
    // определяем цифры числа от первой до пятой
    int num1 = number / 10000;
    int num2 = number / 1000 % 10;
    int num3 = number / 100 % 10;
    int num4 = number / 10 % 10;
    int num5 = number % 10;
    // метод определения палиндрома
    void palindromdetect()
    {
        if ((num1 == num5) && (num2 == num4))

            Console.Write("Это палиндром");

        else
        {
            Console.Write("Это не палиндром");
        }
    }    
    palindromdetect();
}