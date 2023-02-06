using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Michael Feisthauer
// Assignment 2 Final
namespace Wheel_of_Fortune
{
    class Game
    { 
        

        //constructor
        public Game()
        {
                    
            TargetWords = new string[] {"tiefling", "dwarf", "elf", "human",   
                                        "halfling", "gnome", "dragonborn",
                                        "half-elf", "half-orc", "orc"};
            PrizeAmounts = new int[] { 100, 150, 200, 250, 300, 350, 400, 450,
                                        5000, 550, 600, 650, 700, 750, 800, 900, 
                                        1000, 0};
            WordGenerator();

            PlayerTurn = 1;
        }

        //set and get
        public int PlayerTurn { get; set; }
        public string[] TargetWords { get; set; }
        public int[] PrizeAmounts { get; set; }
        public string CurrentWord { get; set; } = "";
        public int CurrentPrizeAmount { get; set; }

        //functions
        public void WordGenerator()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 10);
            CurrentWord = TargetWords[randomNumber];
        }

    }
}
