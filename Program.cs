// Калькулятор расхода топлива, в котом нужно ввести количество пройденных километров, цену бензина и расход топлива по бортовому компьютеру.
Console.WriteLine("Введите цену бензина за литр: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите расход топлива по бортовому компьютеру: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите количество пройденных километров: ");
double number2 = Convert.ToDouble(Console.ReadLine());
//расход топлива в литрах на 1 км
double num3 = number1 / 100;
Console.WriteLine($"{num3} литров на 1 км");
//узнаем сколько литров уходит на пройденное количество км
double num4 = num3 * number2;
Console.WriteLine("Количество литров использованных для поездки: " + Math.Round(num4 , 2));
double num5 = num4 * number;
Console.WriteLine("Стоимость бензина потраченного за поездку: " + Math.Round(num5 , 2));