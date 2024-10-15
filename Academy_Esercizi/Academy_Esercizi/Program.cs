//// ESERCIZIO 1 

//Console.WriteLine("Inserire il primo cateto in cm");
//double a = double.Parse(Console.ReadLine());

//Console.WriteLine("Inserire il secondo cateto in cm");
//double b = double.Parse(Console.ReadLine());

//double hypotenuse = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

//Console.WriteLine($"L'ipotenusa misura {hypotenuse} cm");


//// ESERCIZIO 2

Console.WriteLine("Inserire il primo numero:");
bool valid1 = int.TryParse(Console.ReadLine(), out double firstNumber);

Console.WriteLine("Inserire il secondo numero:");
bool valid2 = int.TryParse(Console.ReadLine(), out double secondNumber);

if (firstNumber == secondNumber)
{
    Console.WriteLine("I numeri sono uguali");
}

if (firstNumber < secondNumber)
{
    Console.WriteLine("Il secondo numero è maggiore");
}

if (firstNumber > secondNumber)
{
    Console.WriteLine("Il primo numero è maggiore");
}
