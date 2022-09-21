using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace курсов_проект
{
    [Serializable]
   public class Circle : Shape
    {

        public override double CalculateSurface()
        {
            return Math.PI * Size * Size;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Size * Math.PI;
        }

        public override void Draw(int x, int y, int size)
        {
            Graphics g = FormScene.ActiveForm.CreateGraphics();
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, x - size, y - size,
                      2 * size, 2 * size);
            base.Draw(x, y, size);
        }
        public override bool IsClicked(int xx, int yy)
        {
            if (((x - xx) * (x - xx) + (y - yy) * (y - yy)) <= Size * Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
