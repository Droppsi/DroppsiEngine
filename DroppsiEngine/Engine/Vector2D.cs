using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroppsiEngine.Engine
{
    public class Vector2D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Vector2D()
        {
            X = InIt().X;
            X = InIt().X;
        }
        public Vector2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
        public static Vector2D InIt()
        {
            return new Vector2D();
        }
    }
    
}
