using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileCommandRun
{
    class Blow
    {
        int X;
        int Y;
        Brush b = new SolidBrush(Color.Fuchsia);
        Rectangle _explosionStart;
        bool stop = false;

        public Blow(int x, int y, Rectangle rect)
        {
            X = x;
            Y = y;
            _explosionStart = rect;



        }

        public void expand(Graphics g)
        {

            if (!stop)
            {
                _explosionStart.Height += 3;
                _explosionStart.Width += 3;
                _explosionStart.X -= 1;
                _explosionStart.Y -= 1;
                g.FillEllipse(b, _explosionStart);
                if (_explosionStart.Height >= 34)
                    stop = true;

            }

        }
        public bool Stop {
            get {return stop;}
            }
        public bool Hit(Point p)
        {
            if (_explosionStart.Contains(p))
                return true;
            else return false;
        }
        
    }
}
