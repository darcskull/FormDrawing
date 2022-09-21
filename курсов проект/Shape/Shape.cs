using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace курсов_проект
{
    [Serializable]
   public abstract class Shape
    {
        public int x, y;

        public int Size { get; set; }
        public Color Color { get; set; }
       
        public abstract double CalculateSurface();
        public abstract double CalculatePerimeter();
        public abstract bool IsClicked(int x, int y);
        public virtual void Draw(int x, int y, int size)
        {
           this.x = x;
            this.y = y;
            this.Size = size;
        }
    }
}
