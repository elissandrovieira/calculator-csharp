// See https://aka.ms/new-console-template for more information

Menu();

static void Menu() {
  Console.Clear();
  Console.WriteLine("What is the operation you deserve?");
  Console.WriteLine("1 - Addition");
  Console.WriteLine("2 - Subtraction");
  Console.WriteLine("3 - Multiplication");
  Console.WriteLine("4 - Division");

  
}


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