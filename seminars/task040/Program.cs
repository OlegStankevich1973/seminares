System.Random numberSintezator = new Random();
// создание массива из 8 чифр 
void VariantNaive()
{
    int i = 0;
    Console.Write("[");
    // убираем последний элемент чтобы потом убрать последнюю запятую при печати
    while (i < 8 - 1)
    {
        // цифры массива 0 и 1(2 не входит) и запятые между ними
        Console.Write(numberSintezator.Next(0,2)+",");
        i++;
    }
    // распечатываем последний элемент отдельно
    Console.Write(numberSintezator.Next(0,2));

    Console.Write("]");

}
VariantNaive();