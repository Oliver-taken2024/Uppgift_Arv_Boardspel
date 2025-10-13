using Uppgift_Arv_Boardspel.Game;

namespace Uppgift_Arv_Boardspel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Board board = new Board();
            int pin = random.Next(10, 20);
            board.SetUp (pin);
            Console.WriteLine($"brädet har {pin}");

            //while (board.SetUp >= 0)
            //{
            //    Console.WriteLine(board.SetUp);
            //  board.TakePins();
                
            //}
            
            
            
        }
    }
}
