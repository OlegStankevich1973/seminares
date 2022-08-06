
// программа калькулятор на основе оператора switch
Console.Write("Введите первое число :");
string? inputLineOne = Console.ReadLine();
Console.Write("Введите второе число :");
string? inputLineTvo = Console.ReadLine();
Console.Write("Введите действие: (+,-,*,/,^) ");
string inputLineAction = Console.ReadLine();

if ((inputLineOne != null) && (inputLineTvo != null))

{
    double inputNumberOne = double.Parse(inputLineOne);
    double inputNumberTvo = double.Parse(inputLineTvo);
    
    switch (inputLineAction)
    {
        case "^":
            double outNumber = (double)Math.Pow(inputNumberOne, inputNumberTvo);

            Console.WriteLine("число " + inputNumberOne + " в степени " + inputNumberTvo + " = " + outNumber);
            break;
       
        case "+":
            double sumNumber = inputNumberOne + inputNumberTvo;
            Console.WriteLine(+inputNumberOne + " + " + inputNumberTvo + " = " + sumNumber);
            break;

        case "-":
            double difNumber = inputNumberOne - inputNumberTvo;
            Console.WriteLine(+inputNumberOne + " - " + inputNumberTvo + " = " + difNumber);
            break;

        case "*":
            double multiplicatNumber = inputNumberOne * inputNumberTvo;
            Console.WriteLine(+inputNumberOne + " * " + inputNumberTvo + " = " + multiplicatNumber);
            break;

        case "/":
            double divNumber = inputNumberOne / inputNumberTvo;
            Console.WriteLine(+inputNumberOne + " / " + inputNumberTvo + " = " + divNumber);
            break;

    }
    
}
