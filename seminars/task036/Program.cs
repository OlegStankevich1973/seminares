Console.Write("Введите число :");

int inputNumber = int.Parse(Console.RedLine());
void VariantSimple()
{
    int sumOfNumbers = 0;
    for (int i = 1; i <= inputNumber; i++)
    {
        sumOfNumbers += i;
        // sumOfNumbers=sumOfNumbers+i;
    }
    Console.WriteLine("Сумма чисел от 1 до" + inputNumber + "=" + sumOfNumbers);

}

VariantSimple();