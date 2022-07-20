// создаем строковую переменную
string? inputLineN =Console.ReadLine();
// проверяем ее на null(пустоту)
if (inputLineN != null)
{
    // меняем строковую на цельночисленную переменную
    int numberN = int.Parse(inputLineN);
    // определяем как будет печатать первая строка в данном случае сразу не касается второй строки
    string lineN = "";
    
    // string lineNN = string.Empty;
    string lineNN = "";
    // определяем первое число выполнения программы
    int s = 1;
    while (s <= numberN)
    {
        lineN = lineN + s + "";
        lineNN = lineNN + (s * s).ToString() + "";
        s++;
    }
        Console.WriteLine(lineN);
        Console.WriteLine(lineNN);
    
}