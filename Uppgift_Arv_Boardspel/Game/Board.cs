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
       

        public void SetUp(int pins)
        {
            NumberOfPins = pins;
             
        }

        public void TakePins(int pins) 
        { 
            NumberOfPins -= pins;
            //Console.WriteLine(SetUpPins);
             
        }

        public int GetNumberOfPins()
        {
         return NumberOfPins;
        }

    }
}
