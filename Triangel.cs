using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractClass {
    public class Triangel : Shape {
        public override float Area() {
            throw new NotImplementedException();
        }

        public override float Perimetr() {
            throw new NotImplementedException();
        }
        public Triangel(Pen pen, PointF VertexA, PointF VertexB, PointF VertexC) {
            MyPen = pen;
            Vertexes.Add(VertexA);
            Vertexes.Add(VertexB);
            Vertexes.Add(VertexC);
        }
    }
}
