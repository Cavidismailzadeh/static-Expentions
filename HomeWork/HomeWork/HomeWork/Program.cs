




using HomeWork.Helpers;

//int num = 9;

//Console.WriteLine(num.GetFactorial());



Console.WriteLine("Ededi daxil edin");

double number = double.Parse(Console.ReadLine());


Console.WriteLine("Quvveti daxil edin");

double power = double.Parse((string)Console.ReadLine());


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(number.GetNumPower(power));
Console.ResetColor();


