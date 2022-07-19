
//  Метод считывает точки и возвращает массив с ними
int[,] readPoint()
{
    // строка 4 считывает с консоли вводимые значения
    string inputLine = Console.ReadLine();
    // условие задачи x=34;y=-30 ->4
        // переменной inputLine выделить подстроку Substring с "0" до ";"
        //  те x=34;
    string coordXLine = inputLine.Substring(0,inputLine.IndexOf(";"));
    // тут получаем просто 34 строка 12(лишнее убирается)
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=")+1);
    // строка 14 записываем y=-30
    string coordYLine = inputLine.Substring(inputLine.IndexOf(";")+1);
    // строка 16 получаем просто -30( лишнее убирается)
    coordYLine = coordYLine.Substring(coordYLine.IndexOf("=")+1);
    // переделываем (парсим(разбираем)) строчные данные в числовые int
    int coordX = int.Parse(coordXLine);
    int coordY = int.Parse(coordYLine);  
    //  эти цифры кладем в массив [строка,столбик] это таблица из 1 строки и 2 столбцов для одной переменной
    // |_00_|_01_| вид этой таблицы  |_X_|_Y_|
    int[,] arrayOut = new int[1,2];

    arrayOut[0,0] = coordX;
    arrayOut[0,1] = coordY;

    return arrayOut;
}
// метод печатает номер четверти
void printQuter(int[,] arreyPoint)
{
    // определяем где находится x и y
    if(arreyPoint[0,0] > 0 && arreyPoint[0,1] > 0)
    Console.WriteLine( " 1 четверть");

    if(arreyPoint[0,0] < 0 && arreyPoint[0,1] > 0)
    Console.WriteLine( " 2 четверть");

    if(arreyPoint[0,0] < 0 && arreyPoint[0,1] < 0)
    Console.WriteLine( " 3 четверть");

    if(arreyPoint[0,0] > 0 && arreyPoint[0,1] < 0)
    Console.WriteLine( " 4 четверть");
}
// Данные полученные в первом методе передаем во второй и на печать (стр 47)
int[,] arreyPoint = readPoint();
printQuter(arreyPoint);

