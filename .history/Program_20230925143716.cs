// See https://aka.ms/new-console-template for more information

Menu();

static void Menu() {
  Console.Clear();
  Console.WriteLine("What is the operation you deserve?");
  Console.WriteLine("1 - Addition");
  Console.WriteLine("2 - Subtraction");
  Console.WriteLine("3 - Multiplication");
  Console.WriteLine("4 - Division");
  Console.WriteLine("---------------------------------------------------------");
  Console.WriteLine("Select one option:");

  var operationSign = int.Parse(Console.ReadLine());
  Calculation(operationSign);
}

static void Calculation(int calOperator) {
  Console.Clear();
  Console.WriteLine("First value:");
  double value1 = 0;

  switch 

  Console.WriteLine("Second value:");
  double value2 = double.Parse(Console.ReadLine());

  double result = 0;
  
  var operationSign = calOperator;
  switch (operationSign) {
    case 1: 
      result = value1 + value2;
      Console.WriteLine($"The result is: {result}");
    break;
    case 2: 
      result = value1 - value2;
      Console.WriteLine($"The result is: {result}");
    break;
    case 3: 
      result = value1 * value2;
      Console.WriteLine($"The result is: {result}");
    break;
    case 4: 
      result = value1 / value2;
      Console.WriteLine($"The result is: {result}");
    break;
  }
  Result();
}

static void Result() {
  Console.WriteLine("---------------------------------------------------------");
  Console.WriteLine("Do you want use the result in other operation?");
  Console.WriteLine("---------------------------------------------------------");
  Console.WriteLine("1 - Yes");
  Console.WriteLine("2 - No");
  Console.WriteLine("---------------------------------------------------------");
  Console.WriteLine("Select one option:");

  var resultOption = int.Parse(Console.ReadLine());

  switch (resultOption) {
    case 1: Menu();
    break;
    case 2: Console.WriteLine("Ok!");
    break;
  }
}