/* TO-DO
 * - (input) first number
 * - (input) second number
 * - (input) Operator
 * - Switch Case to Handle + - / * sqrt pow(x)
 */
    float num1 = 0;
    float num2 = 0;
    float powerOfNumber = 0;
    float number = 0;
    float answer;

    Console.Write("Operation: ");
    string operatorText = Console.ReadLine();

if(operatorText == "sqrt")
{
    Console.Write("Number: ");
    number = Convert.ToSingle(Console.ReadLine());
}
else if (operatorText == "pow")
{
    Console.Write("Number: ");
    number = Convert.ToSingle(Console.ReadLine());
    Console.Write("Power: ");
    powerOfNumber = Convert.ToSingle(Console.ReadLine());
}
else
{
    Console.Write("First Number: ");
    string numOneText = Console.ReadLine();

    Console.Write("Second Number: ");
    string numTwoText = Console.ReadLine();



    num1 = float.Parse(numOneText);
    num2 = float.Parse(numTwoText);

}

switch (operatorText)
    {
        case "+":
            answer = num1 + num2;
            Console.WriteLine($"Answer: {answer}");
            break;
        case "-":
            answer = num1 - num2;
            Console.WriteLine($"Answer: {answer}");
            break;
        case "*":
            answer = num1 * num2;
            Console.WriteLine($"Answer: {answer}");
            break;
        case "/":
            answer = num1 / num2;
            Console.WriteLine($"Answer: {answer}");
            break;
        case "sqrt":
            answer = MathF.Sqrt(number);
            Console.WriteLine($"Answer: {answer}");
            break;
        case "pow":
            answer = MathF.Pow(number, powerOfNumber);
            Console.WriteLine($"Answer: {answer}");
            break;
        
    default:
            Console.WriteLine("ummm..?");
            break;
        
    
        
    }
       


