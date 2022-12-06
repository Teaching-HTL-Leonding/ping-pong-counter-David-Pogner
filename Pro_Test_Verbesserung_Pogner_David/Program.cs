Console.Clear();

Console.Write("Please enter the match type: ");
string type = Console.ReadLine()!;

int Player1Games = 0;
int Player2Games = 0;
int Player1Points = 0;
int Player2Points = 0;
string WinnerOfPoint;
int gamesForWin = 0;

switch (type)
{
    case "short":
        gamesForWin = 1;
        break;

    case "regular":
        gamesForWin = 4;
        break;

    case "double":
        gamesForWin = 3;
        break;
}

do
{
    Console.Write("Who has won the point: ");
    WinnerOfPoint = Console.ReadLine()!;
    switch (WinnerOfPoint)
    {
        case "1":
            Player1Points++;
            if (Player1Points == 11)
            {
                Console.WriteLine("Player 1 has won the game.\n");
                Player1Games++;
                Player1Points = 0;
                Player2Points = 0;
            }
            break;
        case "2":
            Player2Points++;
            if (Player2Points == 11)
            {
                Console.WriteLine("Player 2 has won the game.\n");
                Player2Games++;
                Player1Points = 0;
                Player2Points = 0;
            }
            break;
    }
    Console.WriteLine($"Games: {Player1Games}:{Player2Games}, Points: {Player1Points}:{Player2Points}");

}
while (Player1Games != gamesForWin && Player2Games != gamesForWin);

if (Player1Games == gamesForWin)
{
    Console.WriteLine("Player 1 wins!");
}
else
{
    Console.WriteLine("Player 2 wins!");
}
