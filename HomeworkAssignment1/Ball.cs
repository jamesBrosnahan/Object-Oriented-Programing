using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssignment1
{
    class Ball
    {
        private Boolean IsRound = true;
        private Boolean IsBouncy = false;
        private Boolean IsRolling = false;
        private String GameAssociatedWithThisTypeOfBall = "";
        private int x, y, z;

        public Ball(String _game, Boolean _bouncy, Boolean _round, Boolean _rolling, int _x, int _y, int _z)
        {
            GameAssociatedWithThisTypeOfBall = _game;
            IsBouncy = _bouncy;
            IsRound = _round;
            IsRolling = _rolling;
            x = _x;
            y = _y;
            z = _z;
        }

        public Boolean Bounce()
        {
            Console.WriteLine(" The ball bounced. ");
            return true;
        }

    }
}
