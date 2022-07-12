string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    string[]dayOffWeek = new string[7];
    dayOffWeek[0] = "Понедельник";
    dayOffWeek[1] = "Вторник";
    dayOffWeek[2] = "Среда";
    dayOffWeek[3] = "Четверг";
    dayOffWeek[4] = "Пятница";
    dayOffWeek[5] = "Суббота";
    dayOffWeek[6] = "Воскресенье";

    Console.WriteLine(dayOffWeek[inputNumber-1]);


    

}
