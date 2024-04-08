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


int secretNumber = 45;
bool userGuessedCorrect = false;

Console.WriteLine(@"Welcome to The Guessing Game!
Please enter a number: ");

while (userGuessedCorrect == false)
{
    try
    {
        int numberGuessed = int.Parse(Console.ReadLine());
        if (numberGuessed == secretNumber)
        {
            Console.WriteLine("MATHEMATICAL! You guessed the secret number!");
            userGuessedCorrect = true;
        }
        else
        {
            Console.WriteLine("Um, no. Not it.");
        }

    }
    catch (FormatException)
    {
        Console.WriteLine("That was not a number. Please enter a number.");


    }

}



