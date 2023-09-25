// See https://aka.ms/new-console-template for more information

Console.Clear();
Console.


Console.WriteLine("First value:");
double value1 = double.Parse(Console.ReadLine());

Console.WriteLine("Second value:");
double value2 = double.Parse(Console.ReadLine());

Console.WriteLine("Operator:");
string operatorSign = Console.ReadLine();

if (operatorSign == "+") {
  Console.WriteLine(value1 + value2);
} else if (operatorSign == "-") {
  Console.WriteLine(value1 - value2);
} else if (operatorSign == "*") {
  Console.WriteLine(value1 * value2);
} else if (operatorSign == "/") {
  Console.WriteLine(value1 / value2);
} else {
  Console.WriteLine("WTF!");
}