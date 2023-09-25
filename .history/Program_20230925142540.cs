// See https://aka.ms/new-console-template for more information

Menu();

static void Menu() {
  Console.Clear();
  Console.WriteLine("What is the operation you deserve?");
  Console.WriteLine("1 - Addition");
  Console.WriteLine("2 - Subtraction");
  Console.WriteLine("3 - Multiplication");
  Console.WriteLine("4 - Division");
  Console.WriteLine("-------------------------");
  Console.WriteLine("Select one option:");

  var operationSign = int.Parse(Console.ReadLine());
  Calculation(operationSign);
}

static void Calculation(int calOperator) {
  Console.Clear();
  Console.WriteLine("First value:");
  double value1 = double.Parse(Console.ReadLine());

  Console.WriteLine("Second value:");
  double value2 = double.Parse(Console.ReadLine());

  double result = 0;
  
  var operationSign = calOperator;
  switch (operationSign) {
    case 1: 
      result
      Console.WriteLine($"The result is: {value1 + value2}");
    break;
  }
}
