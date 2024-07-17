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
float answer = 0;
float lastAnswer = 0;   

while (true)
{
    Console.Write("Operation: ");
    string operatorText = Console.ReadLine();

    if (operatorText == "sqrt")
    {
        Console.Write("Number: ");
        string numberText = Console.ReadLine();
        if (numberText == "ans")
        {
            number = lastAnswer;
        }
        else
        {
            number = Convert.ToSingle(numberText);
        }
        
       
    }
    else if (operatorText == "pow")
    {
        Console.Write("Number: ");
        string numberText = Console.ReadLine();
        if (numberText == "ans")
        {
            number = lastAnswer;
        }
        else
        {
            number = Convert.ToSingle(numberText);
        }
        Console.Write("Power: ");
        powerOfNumber = Convert.ToSingle(Console.ReadLine());
    }
    else
    {
        
        Console.Write("First Number: ");
        string numberText = Console.ReadLine();
        if (numberText == "ans")
        {
            num1 = lastAnswer;
        }
        else
        {
            num1 = Convert.ToSingle(numberText);
        }

        Console.Write("Second Number: ");
        num2 = Convert.ToSingle(Console.ReadLine());
    }

    switch (operatorText)
    {
        case "+":
            answer = num1 + num2;
            break;
        case "-":
            answer = num1 - num2;
            break;
        case "*":
            answer = num1 * num2;
            break;
        case "/":
            answer = num1 / num2;
            break;
        case "sqrt":
            answer = MathF.Sqrt(number);
            break;
        case "pow":
            Console.WriteLine(number);
            answer = MathF.Pow(number, powerOfNumber);   
            break;

        default:
            Console.WriteLine("ummm..?");
            return;
    }

    lastAnswer = answer;
    Console.WriteLine($"Answer: {answer}");

}