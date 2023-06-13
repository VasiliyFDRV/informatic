using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class Task4Transformer : ITransformer<Task4Parameters>
    {
        double N { get; set; }
        public Size ResultSize { get => Size; }
        public Size Size { get; private set; }

        public void Initialize(Size size, Task4Parameters parameters)
        {
            N = parameters.NInPerents/100;
            Size = size;
        }

        public Point? MapPoint(Point point)
        {
            point = new Point(point.X, point.Y);
            var x = (int)(point.X + (Size.Width*N));
            var y = (int)(point.Y);

            if (x >= Size.Width)
                x -= Size.Width;

            return new Point(x, y);
        }
    }
}
