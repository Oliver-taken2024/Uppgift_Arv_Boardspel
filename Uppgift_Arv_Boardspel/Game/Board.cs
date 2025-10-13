using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_Arv_Boardspel.Game
{
    public class Board
    {

        public int NumberOfPins {  get; set; }
       

        public int SetUp(int pins)
        { 

            return pins; 
        }

        public virtual int TakePins(int pins) 
        { 
            SetUpPins -=2;
            //Console.WriteLine(SetUpPins);
            return SetUpPins; 
        }


    }
}
