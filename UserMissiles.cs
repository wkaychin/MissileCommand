using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileCommandRun
{
    class UserMissiles
    {
        int x;
        int y;
        Brush p;
        bool done = false;
        Rectangle _missile;
        public UserMissiles(int mouseclick_x, int mouseclick_y)
        {
            x = mouseclick_x;
            y = mouseclick_y;
            p = new SolidBrush(Color.Green);
            
        }

        public void missile_flicker(Graphics g)
        {
            _missile = new Rectangle(x, y, 4, 4);
            if (!done)
            {
                g.FillRectangle(p, _missile);
                if (_missile.Height >= 4)
                    done = true;
            }

        }
        public bool Done
        {
            get { return done; }
        }
        
    }

}
