using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace курсов_проект
{
    [Serializable]
   public class Square : Shape
    {
        public override double CalculateSurface()
        {
            return Size * Size;
        }
        public override double CalculatePerimeter()
        {
            return 4 * Size;
        }
        public override void Draw(int x, int y, int size)
        {
            Graphics g = FormScene.ActiveForm.CreateGraphics();
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, x - size, y - size, 2 * size, 2 * size); 
            base.Draw(x, y, size);
        }
        public override bool IsClicked(int xx, int yy)
        {
            if (x - Size <= xx && xx <= x + Size && y - Size <= yy && yy <= y + Size) 
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
