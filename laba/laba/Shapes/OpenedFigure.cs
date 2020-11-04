using System.Drawing;
namespace Shapes{
    abstract class OpenedFigure:Figure{
        protected Point[] vertices;
        public Point[] Vertices { get { return vertices; } set { vertices = value; } }

        override public Point[] GetBasePoints()
        {
            return Vertices;
        } 
    }
}