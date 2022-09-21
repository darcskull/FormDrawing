using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace курсов_проект
{
    [Serializable]
   public class Scene
    {
        private List<Shape> _shapes = new List<Shape>();
        public Shape selectedShape = null;
        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }
        
        public void FillShape(List<Shape> sape)
        {
            foreach (var shape in _shapes)
            {
                sape.Add(shape);
            }
            
        }
        public void ListRes()
        {
            _shapes = new List<Shape>();
        }
        public void ReAdd(List<Shape> sape)
        {
            foreach (var shape in sape)
            {
                _shapes.Add(shape);

            }

        }

        public double CalculatePerimeter()
        {
            var perimeter = 0.0;
            foreach (var shape in _shapes)
                perimeter += shape.CalculatePerimeter();

            return perimeter;
        }
        public double CalculateSurface()
        {
            var surface = 0.0;
            foreach (var shape in _shapes)
                surface += shape.CalculateSurface();

            return surface;
        }
        public void DrawAll()
        {
            foreach (var shape in _shapes)
            {
                shape.Draw(shape.x, shape.y, shape.Size);
            }
        }
        public Shape SelectShape(int x, int y)
        {
            foreach (var shape in _shapes)
            {
                if (shape.IsClicked(x, y))
                {
                    selectedShape = shape;
                }
            }
            return selectedShape;
        }


    }
}
