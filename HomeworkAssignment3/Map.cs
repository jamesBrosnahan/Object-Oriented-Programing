using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssignment3
{
    struct location
    {
        int X;
        int Y;
    }
    class Map
    {
        public int Width { get; private set; }
        public int Height{ get; private set; }
        public Map()
        {
            Width = 0;
            Height = 0;
        }
        public void PlaceObject(ref Player player, int XLocation, int YLocation)
        {
            if (XLocation <= Width && YLocation <= Height)
            {
                player.setLocation(XLocation, YLocation);
            }
            else
            {
                player.Die();
            }
        }
        public void PlaceObject(ref Enemy enemy, int XLocation, int YLocation)
        {
            if (XLocation <= Width && YLocation <= Height)
            {
                enemy.setLocation(XLocation, YLocation);
            }
            else
            {
                enemy.Die();
            }
        }
        public void SpawnObject(ref Object obj, int XLocation, int YLocation)
        {

            throw new NotImplementedException();
        }
        public void SetSize(int width, int height)
        {
                Width = width;
                Height = height;
        }
    }
}
