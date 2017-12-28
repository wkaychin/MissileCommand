using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MissileCommandRun
{/// <summary>
/// base class for putting bitmaps on the form
/// </summary>
    class ImageBase: IDisposable //release resource
    {
        bool disposed = false;
        Bitmap _bitmap;
        private int X; //top left coordinates
        private int Y;

        public int Left { get { return X ; } set { X = value; } }
        public int Top { get { return Y ; }set { Y = value; } }

        public ImageBase(Bitmap _resource) //constructor to create a new bitmap for image
        {
            _bitmap = new Bitmap(_resource);
        }
        public void DrawImage(Graphics img)
        {
            img.DrawImage(_bitmap, X, Y);
        }
        public void Dispose()
        {
            Dispose(true); //public dispose method will call protected dispose with parameter
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                _bitmap.Dispose();
            }
            disposed = true;
        }

    }
}
