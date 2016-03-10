using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //implement gamestate, map, player, 
            var state = new GameState();
            state.mainLoop();
        }
    }
}
