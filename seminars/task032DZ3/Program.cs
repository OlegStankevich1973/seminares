int coordXPointA;
int coordYPointA;
int coordZPointA;
int coordXPointB;
int coordYPointB;
int coordZPointB;
double lengthAB;
// Метод считывания координат точек
void readDataOfPoint()
{
    Console.WriteLine("Введите координату X точки A");
    coordXPointA = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите координату Y точки A");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки A");
    coordZPointA = int.Parse(Console.ReadLine());


    Console.WriteLine("Введите координату X точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordYPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки B");
    coordZPointB = int.Parse(Console.ReadLine());

   
}
// Метод вычисления расстояния между точками
void calculationsLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2)+ Math.Pow((coordZPointA - coordZPointB), 2));
}
readDataOfPoint();
calculationsLengthAB();

Console.WriteLine(lengthAB);
