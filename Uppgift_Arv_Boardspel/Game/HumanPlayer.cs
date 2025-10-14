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
           int pins =Convert.ToInt32(Console.ReadLine());//För hoppnings vis gör detta så att varje gång jag kallar på metoden så körs console.readline
            return pins;
        }
    }
}
