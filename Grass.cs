using MissileCommandRun.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileCommandRun
{
    class Grass: ImageBase
    {

        private Rectangle grass_HotSpot = new Rectangle();
        public Grass() : base(Resources.grass)
        {
            grass_HotSpot.X = Left + 20; // 
            grass_HotSpot.Y = Top - 1; // 
            grass_HotSpot.Width = 100;
            grass_HotSpot.Height = 78;
        }
    }
}
