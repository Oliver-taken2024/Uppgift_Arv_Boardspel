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
            bool validpins = false;

            int pins =0;
            while (!validpins)
            {
                try
                {
                    int min = 1, max = 2;
                    pins = Convert.ToInt32(Console.ReadLine());//För hoppnings vis gör detta så att varje gång jag kallar på metoden så körs console.readline
                    while (pins < min || pins > max)
                    {
                        Console.WriteLine("Du kan bara skriva siffror mellan 1 och 2");// gjorde detta för att jag tycker det är lättare och för att slippa söka vad alla exceptions gör
                        pins = Convert.ToInt32(Console.ReadLine());
                    }
                    
                    validpins = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du kan bara skriva siffror");
                }
                
            }
            Console.WriteLine($"Player takes {pins} pins");
            board.TakePins(pins);
            return pins;// metoden ska returnera min console.readline
        }
    }
}
