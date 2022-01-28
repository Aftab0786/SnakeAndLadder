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
        public const int Winning = 100;
        public int Startpoint = 0;
        public int standingPositionofPlayer = 0;
        public int count = 0;

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
        // method to check the value of dice thrown.
        public void start()
        {
            int roll = this.dice();
            this.playerPosition = playerPosition + roll;
            Console.WriteLine("The value when dice is thrown: " + playerPosition);
        }

        //uc3 : option check play or not.

        public int Roll()
        {
            int Roll = rand.Next(1, 7);
            return Roll;
        }

        // method to check play or not

        public void Rolling()
        {
            int Roll = this.Roll();
            int check = rand.Next(0, 3);
            switch (check)
            {
                case NO_PLAY:
                    this.playerPosition += NO_PLAY;
                    break;
                case SNAKE:
                    this.playerPosition += SNAKE;
                    break;
                case LADDER:
                    this.playerPosition += LADDER;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Player postion is: " + this.playerPosition);

        }
        // UseCase-4 : Repeat till the Player reaches the winning position 100

        public void StartGame()
        {
            Console.WriteLine(" Game Started ");
            Console.WriteLine(" PlayerPosition :" + playerPosition);
            Random random = new Random();

            while (Startpoint < Winning)
            {
                int DieRolled = random.Next(1, 7);
                int Option = random.Next(0, 3);
                switch (Option)
                {
                    case NO_PLAY:
                        Console.WriteLine(" No Play");
                        break;
                    case LADDER:
                        Startpoint += DieRolled;
                        Console.WriteLine(" Dice Rolls Number : +{0} ", DieRolled);
                        Console.WriteLine(" Got Ladder : " + Startpoint);
                        Console.WriteLine(" PlayerPosition : " + Startpoint);
                        break;
                    case SNAKE:
                        Startpoint -= DieRolled;
                        Console.WriteLine(" Dice Rolls Number : -{0} ", DieRolled);
                        Console.WriteLine(" Snake Attack : " + Startpoint);

                        if (Startpoint < 0)
                        {
                            Startpoint = 0;

                        }
                        Console.WriteLine(" PlayerPosition : " + Startpoint);
                        break;
                }
                if (Startpoint >= Winning)
                {
                    Console.WriteLine("Playe won");
                    break;
                }
            }
        }
        // UC6 : The Number Of Time Dice Was Rolled To Win The Game

        public int DieRolling()
        {
            int roll = rand.Next(1, 7);
            return roll;
        }
        public void PlayerCheck()
        {
            while (standingPositionofPlayer < Winning)
            {
                int dieRoll = this.DieRolling();
                int option = rand.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.standingPositionofPlayer += dieRoll;
                        if (this.standingPositionofPlayer > Winning)
                        {
                            this.standingPositionofPlayer -= dieRoll;
                        }
                        Console.WriteLine("Got Ladder");

                        break;
                    case SNAKE:
                        this.standingPositionofPlayer -= dieRoll;
                        if (this.standingPositionofPlayer < Startpoint)
                        {
                            this.standingPositionofPlayer = Startpoint;
                        }

                        Console.WriteLine("Got Snake");
                        break;
                }
                count++;
                Console.WriteLine("The standing Position of Player is :" + this.standingPositionofPlayer + " " + "with a roll of " + dieRoll);
            }
            Console.WriteLine("the number of time dice was rolled to win the game is : " + count);
                Console.WriteLine("The Player wins the Game");
        }
    }
}

