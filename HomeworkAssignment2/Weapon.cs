using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssignment2
{
    public class Weapon
    {
        protected Weapon(int speed, int damage)
        {
            Speed = speed;
            Damage = damage;
        }
        public int Speed
        {
            get;
            protected set;
        }
        public int Damage
        {
            get;
            protected set;
        }
    }
    class Sword : Weapon
    {
        public int Handed
        {
            get;
            private set;
        }
        public Sword(int handed) 
            : base(100, 100)
        {
            Handed = handed;
        }
    }
    class Axe : Weapon
    {
        public int Handed
        {
            get;
            private set;
        }
        public Axe(int handed) 
            : base(50, 150)
        {
            Handed = handed;
        }
    }
    class Club : Weapon
    {
        public int Handed
        {
            get;
            private set;
        }
        public Club(int handed)
            : base(50, 50)
        {
            Handed = handed;
        }
    }
    class Bow : Weapon
    {
        private int Handed = 2;
        public int Range
        {
            get;
            private set;
        }
        public Bow(int range)
            : base(500, 10)
        {
            Range = range;
        }
    }
}
