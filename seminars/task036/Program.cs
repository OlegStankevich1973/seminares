Console.Clear();
Console.Write("Введите число :");

int inputNumber = int.Parse(Console.ReadLine());
// задаем переменную для подсчета времени
int t;

void VariantSimple()
{
    int sumOfNumbers = 0;
    for (int i = 1; i <= inputNumber; i++)
    {
        sumOfNumbers += i;
        // sumOfNumbers=sumOfNumbers+i;
    }
    Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " 
    + sumOfNumbers);

}
void VariantGauss()
{
     int sumOfNumbers = 0;

    sumOfNumbers = ((inputNumber + 1) * inputNumber) / 2;

    Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = "
     + sumOfNumbers);

}
// задаем время для подсчета
t =Environment.TickCount; 
VariantSimple();
// измерение времени выполнения программы 0дин из вариантов
Console.WriteLine("Simple time: {0} ms",Environment.TickCount - t);
VariantGauss();
Console.WriteLine("Simple time: {0} ms",Environment.TickCount - t);