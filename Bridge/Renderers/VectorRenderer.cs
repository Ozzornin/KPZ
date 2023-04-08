using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Renderers
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle()
        {
            Console.WriteLine("Drawing Circle as vector");
        }

        public void RenderSquare()
        {
            Console.WriteLine("Drawing Square as vector");
        }

        public void RenderTriangle()
        {
            Console.WriteLine("Drawing Triangle as vector");
        }
    }
}
