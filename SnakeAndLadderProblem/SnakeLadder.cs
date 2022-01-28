using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SnakeLadder
    {
        // uc1 checking player at initial position at zero.

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
    }
}
