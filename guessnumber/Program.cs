// See https://aka.ms/new-console-template for more information
// random number function code block
Random random = new Random();
// creating random number and adding secretNumber int variable
int secretNumber = random.Next(1, 100);
// make sure int numbers are 0
int counter, userGuessNumber = 0;
//int userGuessNumber = int.Parse(Console.ReadLine());

while (userGuessNumber != secretNumber)
{
    Console.Clear();
    Console.WriteLine("Guess number which number I am thinking 1-100 \r\nEnter your Guess:");
    userGuessNumber = int.Parse(Console.ReadLine()) ;
    if (userGuessNumber < secretNumber)
    {
        Console.WriteLine(" To Low! Try again");

    }
    else if (userGuessNumber > secretNumber)
    {
        Console.WriteLine(" To High! Try again");
    }
    else { 
        Console.WriteLine($" Cong. My guess was {secretNumber}");
    }
    // make loop 1000ms delay
    Thread.Sleep(1000);
}
Console.WriteLine(" See you soon");
Console.ReadKey();

