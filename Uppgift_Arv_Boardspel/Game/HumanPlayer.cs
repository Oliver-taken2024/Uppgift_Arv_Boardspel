using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_Arv_Boardspel.Game
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string userid) : base(userid)
        {
        }

        public override int TakePins(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
