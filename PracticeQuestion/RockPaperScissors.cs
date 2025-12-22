/// <summary>
/// RockPaperScissors - Implements Rock Paper Scissors game logic for 2 players
/// Rules: Rock beats Scissors, Scissors beats Paper, Paper beats Rock
/// Uses nested conditionals to determine winner
/// </summary>
class RockPaperScissors
{
    /// <summary>
    /// Determines the winner of Rock Paper Scissors game
    /// </summary>
    /// <param name="player1Choice">Player 1's choice (R/P/S)</param>
    /// <param name="player2Choice">Player 2's choice (R/P/S)</param>
    public void PlayGame(char player1Choice, char player2Choice)
    {
        // Convert to uppercase for consistent comparison
        player1Choice = char.ToUpper(player1Choice);
        player2Choice = char.ToUpper(player2Choice);

        // Validate input choices
        if (!IsValidChoice(player1Choice) || !IsValidChoice(player2Choice))
        {
            Console.WriteLine("Invalid choice! Please use R (Rock), P (Paper), or S (Scissors)");
            return;
        }

        // Display choices
        Console.WriteLine($"Player 1: {GetChoiceName(player1Choice)}");
        Console.WriteLine($"Player 2: {GetChoiceName(player2Choice)}");

        // Check for tie
        if (player1Choice == player2Choice)
        {
            Console.WriteLine("It's a Tie!");
        }
        else
        {
            // Determine winner using nested conditionals
            if (player1Choice == 'R') // Player 1 chose Rock
            {
                if (player2Choice == 'S')
                {
                    Console.WriteLine("Player 1 Wins! (Rock beats Scissors)");
                }
                else // player2Choice == 'P'
                {
                    Console.WriteLine("Player 2 Wins! (Paper beats Rock)");
                }
            }
            else if (player1Choice == 'P') // Player 1 chose Paper
            {
                if (player2Choice == 'R')
                {
                    Console.WriteLine("Player 1 Wins! (Paper beats Rock)");
                }
                else // player2Choice == 'S'
                {
                    Console.WriteLine("Player 2 Wins! (Scissors beats Paper)");
                }
            }
            else // player1Choice == 'S' (Player 1 chose Scissors)
            {
                if (player2Choice == 'P')
                {
                    Console.WriteLine("Player 1 Wins! (Scissors beats Paper)");
                }
                else // player2Choice == 'R'
                {
                    Console.WriteLine("Player 2 Wins! (Rock beats Scissors)");
                }
            }
        }
    }

    /// <summary>
    /// Validates if the choice is valid (R, P, or S)
    /// </summary>
    /// <param name="choice">Choice to validate</param>
    /// <returns>True if valid, false otherwise</returns>
    private bool IsValidChoice(char choice)
    {
        return choice == 'R' || choice == 'P' || choice == 'S';
    }

    /// <summary>
    /// Gets the full name of the choice for display
    /// </summary>
    /// <param name="choice">Choice character</param>
    /// <returns>Full name of the choice</returns>
    private string GetChoiceName(char choice)
    {
        return choice switch
        {
            'R' => "Rock",
            'P' => "Paper",
            'S' => "Scissors",
            _ => "Unknown"
        };
    }
}