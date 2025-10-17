using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_Arv_Boardspel.Game
{
    internal class ComputerPlayer : Player
    {
        public ComputerPlayer(string userid) : base(userid)
        {
        }

        public override int TakePins(Board board)// slumpar en siffra mellan 1 och 2
        {
            Random random = new Random();
            int Take = 0;
            if (board.NumberOfPins == 6)// kunde göra Switch men gillar if bättre och då hade jag behövt göra så att alla 20 pins har en speciffic interation det kärr ner det problemet med en hel del 
                //who ever gets to five or six wins the game
                //who ever gets to four loses the game
            {
                Take = 2;
            }
            else if (board.NumberOfPins == 5)
            {
                Take = 1;
            }
            else if (board.NumberOfPins==3)
            {
                Take = 2;
            }
            else if (board.NumberOfPins == 2)
            {
                Take = 1;
            }
            else if (board.NumberOfPins == 1)
            {
                Take = 1;
            }
            else
            {
                Take = random.Next(1, 3);
            }
            Console.WriteLine($"Computer takes {Take} pins");
            board.TakePins(Take);
            return Take;
        }
    }
}
