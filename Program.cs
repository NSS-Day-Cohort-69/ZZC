// See https://aka.ms/new-console-template for more information

/*Phase 1:
write greeting asking for a number guess
create variable to store user input
receive input from user (ReadLine)
display guess*/

/*Phase 2:
create 'secret number' variable, hard-coded
removed display of user guess
if user guess is correct, display message. if not, display different message */

/*Phase 3:
user only has 4 chances to guess
for loop increments < 5
*/
/*Phase 4:
display guessCount after each try
Phase 5:
use Random to select a secret number
use guessCount decreasing to show how many tries are left
Phase 6:
use ternary to display if a guess was too high or low if wrong
*/

/* Phase 7:
    Create maxGuess variable for main loop
    Prompt user for difficulty level
    Set maxGuess based on user answer
        Easy: 8 guesses
        Medium: 6 guesses
        Hard: 4 guesses
*/

/*Phase 8: 
    Create a new option called cheater
    allow user to have unlimited amount of guesses
    */

Random random = new Random();
int secretNumber = random.Next(1, 101);
int? maxGuessCount = null;
bool cheaterModeActive = false;

Console.WriteLine(@"Welcome to The Guessing Game!
What difficulty would you like?
    1. Easy
    2. Medium
    3. Hard
    4. Cheater
");

while (maxGuessCount == null)
{
    Console.WriteLine("Choice:");
    string userChoice = Console.ReadLine()!.Trim();
    switch (userChoice)
    {
        case "1":
            Console.WriteLine("You have chosen Easy Mode, and get 8 guesses!");
            maxGuessCount = 8;
            break;
        case "2":
            Console.WriteLine("You have chosen Medium Mode, and get 6 guesses!");
            maxGuessCount = 6;
            break;
        case "3":
            Console.WriteLine("You have chosen Hard Mode, and get 4 guesses!");
            maxGuessCount = 4;
            break;
        case "4":
            Console.WriteLine("You have chosen Cheater Mode, and get unlimited guesses!");
            cheaterModeActive = true;
            maxGuessCount = 0;
            break;
        default:
            Console.WriteLine("Please input a valid response!");
            break;
    }
}

HandleUserGuess();

void HandleUserGuess()
{
    Console.WriteLine($"You have {(cheaterModeActive ? "infinite" : maxGuessCount)} tries to guess the secret number!");
    Console.WriteLine("Please enter a number:");


    bool userGuessedCorrect = false;
    int currentGuessCount = 0;

    while((currentGuessCount < maxGuessCount | cheaterModeActive) && !userGuessedCorrect)
    {
        if(cheaterModeActive)
        {
            Console.WriteLine($"You have made {currentGuessCount} {(currentGuessCount == 1 ? "guess" : "guesses")}");
        }
        else
        {
            Console.WriteLine($"You have {maxGuessCount - currentGuessCount} {(currentGuessCount == maxGuessCount - 1 ? "guess" : "guesses")} left");
        }

        try
        {
            int numberGuessed = int.Parse(Console.ReadLine().Trim());
            if (numberGuessed == secretNumber)
            {
                Console.WriteLine("MATHEMATICAL! You guessed the secret number! ");
                userGuessedCorrect = true;
            }
            else
            {
                Console.Clear();
                currentGuessCount++;
                Console.WriteLine(@$"Um, no. Not it.
                You're too {(numberGuessed < secretNumber ? "small!" : "large!")}");
                if (currentGuessCount == maxGuessCount - 1)
                {
                    Console.Clear();
                    Console.WriteLine($@"Oh no! You've run out of tries!
                    The secret number was {secretNumber}");
                }
            }
        }

        catch (FormatException)
        {
            Console.WriteLine("That was not a number. Please enter a number.");
        }
    }
}





