using System.Linq.Expressions;

Random random = new Random();
bool playAgain = true;
int number;
String playerMove;
String computerMove;
String response;


while (playAgain)
{
    playerMove = "";
    computerMove = "";
    response = "";
    number = random.Next(1, 4);
    
    while (playerMove != "ROCK" && playerMove != "PAPER" && playerMove != "SCISSORS")
    {
        Console.WriteLine("Choose ROCK, PAPER, SCISSORS");
        playerMove = Console.ReadLine();
        playerMove = playerMove.ToUpper();
    }
    
    switch (number)
    {
        case 1:
            computerMove = "ROCK";
            break;
        case 2:
            computerMove = "PAPER";
            break;
        case 3:
            computerMove = "SCISSORS";
            break;
    }
    

    switch (playerMove)
    {
        case "ROCK":
            if (computerMove == "ROCK")
            {
                Console.WriteLine("Player move: " + playerMove + " Computer move: " + computerMove + 
                    "\n It's a draw");
            } else if (computerMove == "PAPER")
            {
                Console.WriteLine("Player move: " + playerMove + " Computer move: " + computerMove + 
                    "\n You lose!");
            } else
            {
                Console.WriteLine("Player move: " + playerMove + " Computer move: " + computerMove + 
                    "\n You win!");
            }
            break;
        case "PAPER":
            if (computerMove == "ROCK")
            {
                Console.WriteLine("Player move: " + playerMove + " Computer move: " + computerMove + 
                    "\n You win!");
            }
            else if (computerMove == "PAPER")
            {
                Console.WriteLine("Player move: " + playerMove + " Computer move: " + computerMove + 
                    "\n It's a draw");
            }
            else
            {
                Console.WriteLine("Player move: " + playerMove + " Computer move: " + computerMove + 
                    "\n You win!");
            }
            break;
        case "SCISSORS":                                    
            if (computerMove == "ROCK")
            {
                Console.WriteLine("Player move: " + playerMove + " Computer move: " + computerMove + 
                    "\n You lose!");
            }
            else if (computerMove == "PAPER")
            {
                Console.WriteLine("Player move: " + playerMove + " Computer move: " + computerMove + 
                    "\n You win!");
            }
            else
            {
                Console.WriteLine("Player move: " + playerMove + " " +
                    " Computer move: " + computerMove + "\n It's a draw!");
            }
            break;  
    }

    Console.WriteLine("Would you like to play again? (Y or N)");
    response = Console.ReadLine();
    response = response.ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }

}