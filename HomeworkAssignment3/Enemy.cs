using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssignment3
{
    enum enemyType { }
    enum direction { Left, Right, Up, Down}
    class Enemy : IPlaceable, IKillable
    {
        direction Facing = direction.Up;
        public Boolean IsDead;
        public int X { get; private set; }
        public int Y { get; private set; }

        public Enemy()
        {

        }

        public void attack()
        {
            throw new NotImplementedException();
        }

        public void Die()
        {
            IsDead = true;
        }

        public int getLocation()
        {
            throw new NotImplementedException();
        }

        public void setLocation(int X_, int Y_)
        {
            X = X_;
            Y = Y_;
        }

        internal void MoveTowardsPlayer(int X_, int Y_)
        {
            Random random = new Random();
            var step = random.Next(10);
            if(X < X_)
            {
                X+= step;
            }
            else if(X > X_)
            {
                X-=step;
            }
            if (Y < Y_)
            {
                Y+=step;
            }
            else if (Y > Y_)
            {
                Y-=step;
            }
        }
    }
}
