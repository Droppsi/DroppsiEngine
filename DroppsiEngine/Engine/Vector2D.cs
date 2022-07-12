namespace DroppsiEngine.Engine
{
    public class Vector2D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Vector2D()
        {
            X = InIt().X;
            Y = InIt().Y;
        }
        public Vector2D(float x, float y)
        {
            X = x;
            Y = y;
        }
        public static Vector2D InIt()
        {
            return new Vector2D();
        }
    }
}
