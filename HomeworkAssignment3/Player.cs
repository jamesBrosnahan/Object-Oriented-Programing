using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssignment3
{
    enum Action { up, down, left, right, attack}
    class Player : IPlaceable, IKillable
    {
        public int lives = 3;
        public int health = 1;
        public Boolean IsDead;
        public int X { get; set; }
        public int Y { get; set; }

        public double dX { get; set; }
        public double dY { get; set; }

        public Player()
        {
            dX = 0;
            dY = 0;
            X = 0;
            Y = 0;
        }

        public void readInput()
        {
            Action Input = new Action();
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);// true avoids the keys printing out 
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        Input = Action.up;
                        break;
                    case ConsoleKey.DownArrow:
                        Input = Action.down;
                        break;
                    case ConsoleKey.RightArrow:
                        Input = Action.right;
                        break;
                    case ConsoleKey.LeftArrow:
                        Input = Action.left;
                        break;
                    case ConsoleKey.Spacebar:
                        break;
                }
                this.act(Input);
            }
        }

        public void act(Action action)
        {
            switch (action)
            {
                case Action.up:
                    Y -= 1;
                    break;
                case Action.down:
                    Y += 1;
                    break;
                case Action.right:
                    X += 1;
                    break;
                case Action.left:
                    X -= 1;
                    break;
                case Action.attack:
                    break;
                default:
                    break;
            }
        }

        public void setLocation(int X_, int Y_)
        {
            X = X_;
            Y = Y_;
        }

        public int getLocation()
        {
            throw new NotImplementedException();
        }

        public void Die()
        {
            IsDead = true;
        }


    }
}
