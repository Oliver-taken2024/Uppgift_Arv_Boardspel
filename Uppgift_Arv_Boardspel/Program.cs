using Uppgift_Arv_Boardspel.Game;

namespace Uppgift_Arv_Boardspel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Board board = new Board();
            Player computerPlayer = new ComputerPlayer("Comp");
            Player humanPlayer = new HumanPlayer("Me");
            int pin = random.Next(10, 21);//Slumpar mellan 10 - 20
            board.SetUp (pin);
            Console.WriteLine($"brädet har {pin} pinar");
            Console.WriteLine("spelarna kan bara ta en eller två pinar per runda");

            Player currentPlayer = computerPlayer;
            int Player= random.Next(1, 3);

            if (Player == 1)//bestämmer vem som ska börja
            {
                currentPlayer = humanPlayer;
            }
            else 
            {
                currentPlayer = computerPlayer;
            }
            while( board.NumberOfPins != 0 && board.NumberOfPins>=0)
            { 
                    currentPlayer.TakePins(board);
                currentPlayer = (currentPlayer == humanPlayer) ? computerPlayer : humanPlayer;//Byter vems tur det är
            }
            Console.WriteLine($"Game over {currentPlayer.UserID}");

            
                
            
        }
    }
}
