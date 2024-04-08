// See https://aka.ms/new-console-template for more information

/*Phase 1:
write greeting asking for a number guess
create variable to store user input
receive input from user (ReadLine)
display guess*/

Console.WriteLine(@"Welcome to The Guessing Game!
Please enter a number: ");
int numberGuessed = int.Parse(Console.ReadLine());

Console.WriteLine($"You've guessed {numberGuessed}!");