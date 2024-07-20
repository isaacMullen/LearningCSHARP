Random random = new Random();

while(true)
{
    int guessTracker = 0;

    int upperRange = 100001;
    int lowerRange = 1;

    int randomInteger = random.Next(1, 100001);
    int integerGuess = 0;

    Console.WriteLine($"Int to guess: {randomInteger}");

    integerGuess = random.Next(1, 100001);
    Console.WriteLine($"Initial guess: {integerGuess}");
    while (integerGuess != randomInteger)
    {

        if (integerGuess > randomInteger)
        {
            upperRange = integerGuess;
            integerGuess = random.Next(1, upperRange);

        }
        else if (integerGuess < randomInteger)
        {
            lowerRange = integerGuess;
            integerGuess = random.Next(lowerRange, upperRange);

        }
        Console.WriteLine(integerGuess);
        guessTracker++;
    }
    Console.WriteLine($"{guessTracker} guesses.");
    Console.ReadKey();
    Console.Clear();
}
