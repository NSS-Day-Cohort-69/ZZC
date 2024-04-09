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

Random random = new Random();
int secretNumber = random.Next(1, 101);

Console.WriteLine(@"Welcome to The Guessing Game!
You have four tries to guess the secret number!
Please enter a number: ");

HandleUserGuess();

void HandleUserGuess()
{

    bool userGuessedCorrect = false;

    for (int i = 0; i < 4 && !userGuessedCorrect; i++)
    {
        Console.WriteLine($"You have {4 - i} {(i == 1 ? "guess" : "guesses")} left");

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
                Console.WriteLine(@$"Um, no. Not it.
                You're too {(numberGuessed < secretNumber ? "small!" : "large!")}");
                if (i == 3)
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





