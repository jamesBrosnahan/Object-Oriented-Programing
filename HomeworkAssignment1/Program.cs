using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Ted = new Employee(1, "Username", "Password", "HR", "Ted");
            Ted.LoginToServer("127.0.0.1");

            Ball BouncyBall = new Ball("Tennis", true, true, false, 0, 0, 0);
            BouncyBall.Bounce();

        }
    }
}
