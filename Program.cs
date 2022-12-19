//Create a new Calculator object called calc
Calculator calc = new Calculator();

//Addition
float add = calc.Add(100, 253, 75, 3); 
Console.WriteLine(add);

//Subtraction
float subtract = calc.Subtract(100, 200);
Console.WriteLine(subtract);

//Multiplication
float multiply = calc.Multiply(1,2,3,4,5);
Console.WriteLine(multiply);

//Division
float divide = calc.Divide(10, 20);
Console.WriteLine(divide);