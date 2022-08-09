string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    // создаем массив который разбивает число на цифры
char[] M =inputLine.ToCharArray();
    // сравниваю индексы цифр числа 
    if(inputLine.Length >= 3)
    {
        Console.WriteLine(M[2]);
    }
    else
    {
    Console.WriteLine("Третьей цифры нет");
    }
    
}
        


   