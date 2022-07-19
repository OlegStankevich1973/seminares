void printAnswer(int number)
{
    // смотря какую цифру четверти ввел пользователь выдаются параметры этой четверти
    if(number==1) Console.WriteLine("Допустимо: x>0, y>0");
    if(number==2) Console.WriteLine("Допустимо: x<0, y>0");
    if(number==3) Console.WriteLine("Допустимо: x<0, y<0");
    if(number==4) Console.WriteLine("Допустимо: x>0, y<0");
}
// создаем строковую переменную
string? inputLine = Console.ReadLine();
// проверяем ее на пустоту
if(inputLine != null)
{
    // преобразуем строковую переменную в целочисленную
    int inputNumber = int.Parse(inputLine);
    // передаем ее в метод определения printAnswer
    printAnswer(inputNumber);
}