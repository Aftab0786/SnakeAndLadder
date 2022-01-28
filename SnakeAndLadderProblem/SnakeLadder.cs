using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SnakeLadder
    {
        // uc1 : checking player at initial position at zero.

        public const int NO_PLAY = 0;
        public const int SNAKE = 1;
        public const int LADDER = 2;
        public int playerPosition = 0;

        // method using random the position of player.

        Random rand = new Random();

        public void play()
        {
            Console.WriteLine("Initial player position: " + playerPosition);
        }
        // UC2 : Random Dice Value between 1 to 6 

        public int dice()
        {
            int roll = rand.Next(1, 7);
            return roll;
        }

        public void start()
        {
            int roll = this.dice();
            this.playerPosition = playerPosition + roll;
            Console.WriteLine("The value when dice is thrown: " + playerPosition);
        }

    }
}
