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
            int Take = random.Next(1-2);
            return Take;
        }
    }
}
