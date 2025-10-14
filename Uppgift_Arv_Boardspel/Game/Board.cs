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
       

        public void SetUp(int pins) //ser till så att det ställs upp pinar
        {
            NumberOfPins = pins;
             
        }

        public void TakePins(int pins) //tar bort pinar
        { 
            NumberOfPins -= pins;
            //Console.WriteLine(SetUpPins);
             
        }

        public int GetNumberOfPins()// skriver ut hur många pinar som finns kvar
        {
         return NumberOfPins;
        }

    }
}
