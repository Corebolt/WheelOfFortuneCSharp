using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Michael Feisthauer
//assignment 2 Final

namespace Wheel_of_Fortune
{
    class Player
    {
   
        //constructor
        public Player(string initialPlayerName)
        {
            PlayerScore = 0;
            NumWins = 0;
            NumLosses = 0;
        }

        //get and set
        public string PlayerName { get; set; }

        public int PlayerScore { get; set; }

        public int NumWins { get; set; }

        public int NumLosses { get; set; }
    }
}
