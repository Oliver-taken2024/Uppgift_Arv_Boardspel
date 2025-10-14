using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_Arv_Boardspel.Game
{
    public abstract class Player
    {
        public string UserID { get; set; } 

        public Player(string userid) 
        {
            UserID = userid;
        }

        public string GetUserId()
        { 
            return UserID;
        }

        public abstract int TakePins(Board board);// vet fortsfarande inte varför jag använder Board men förstår lite varför jag gör den abstract tror jag
        

    }
}
