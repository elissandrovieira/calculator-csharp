// See https://aka.ms/new-console-template for more information

Menu(null);

static void Menu(double? finalValue) {
  Console.Clear();
  Console.WriteLine("What is the operation you deserve?");
  Console.WriteLine("1 - Addition");
  Console.WriteLine("2 - Subtraction");
  Console.WriteLine("3 - Multiplication");
  Console.WriteLine("4 - Division");
  Console.
  Console.WriteLine("---------------------------------------------------------");
  Console.WriteLine("Select one option:");

  var operationSign = int.Parse(Console.ReadLine());
  Calculation(operationSign, finalValue);
}

static void Calculation(int calOperator, double? resultOperation) {
  Console.Clear();
  double? value1 = null;
  
  if ( resultOperation == null) {
    Console.WriteLine("First value:");
    value1 = double.Parse(Console.ReadLine());
  } else{
    Console.WriteLine("First value:");
    Console.WriteLine(resultOperation);
    value1 = resultOperation;
  }
  Console.WriteLine("Second value:");
  double value2 = double.Parse(Console.ReadLine());  
  double? result = null;

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
    default: Menu(null); break;
  }
  Result(result);
}

static void Result(double? finalValue) {
  Console.WriteLine("---------------------------------------------------------");
  Console.WriteLine("Do you want use the result in other operation?");
  Console.WriteLine("---------------------------------------------------------");
  Console.WriteLine("1 - Yes");
  Console.WriteLine("2 - No");
  Console.WriteLine("---------------------------------------------------------");
  Console.WriteLine("Select one option:");

  var resultOption = int.Parse(Console.ReadLine());

  switch (resultOption) {
    case 1: Menu(finalValue);
    break;
    case 2: 
      Console.WriteLine("Ok!");
      Console.ReadKey();
      Menu(null);
    break;
  }
}