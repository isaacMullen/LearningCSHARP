Random random = new Random();

while(true)
{
    int guessTracker = 0;

    int upperRange = 1000000;
    int lowerRange = 1;

    int randomInteger = random.Next(lowerRange, upperRange);
    int integerGuess = 0;

    Console.WriteLine($"Int to guess: {randomInteger}");

    integerGuess = (upperRange - lowerRange) / 2 + lowerRange;
    Console.WriteLine($"Initial guess: {integerGuess}");
    while (integerGuess != randomInteger)
    {

        if (integerGuess > randomInteger)
        {
            upperRange = integerGuess;
            integerGuess = (upperRange - lowerRange) / 2 + lowerRange; 

        }
        else if (integerGuess < randomInteger)
        {
            lowerRange = integerGuess;
            integerGuess = (upperRange - lowerRange) / 2 + lowerRange; 

        } 
        Console.WriteLine(integerGuess);
        guessTracker++;
    }
    Console.WriteLine($"{guessTracker} guesses.");
    Console.ReadKey();
    Console.Clear();
}
