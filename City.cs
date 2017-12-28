using MissileCommandRun.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Wanqi Chin
/// 818386160
/// </summary>
namespace MissileCommandRun
{
    /// <summary>
    /// inherits from image base
    /// </summary>
    class City : ImageBase
    {
        private Rectangle city_HotSpot;

        public City()
            : base(Resources.resized_city)
        {
            //city_HotSpot = new Rectangle(this.Left, this.Top, 100, 78);
                
        }
       
        public bool Hit(Point p) //detects hit by creating a small rectangle at the coordinates or point and seeing if hotspot contains it
        {
            city_HotSpot = new Rectangle(this.Left, this.Top+20, 105, 80);
            Rectangle rec = new Rectangle(p.X, p.Y, 1, 1); //creates a cursor rectangle 1 pixel wide 1 pixel long
            if (city_HotSpot.Contains(rec))
            {
                return true;
            }
            return false;
        }
    }
}

