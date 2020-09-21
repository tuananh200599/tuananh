namespace LopPoint
{
    public class Point2D
    {
        private float X;
        private float Y;
        public Point2D(float x,float y)
        {
            X = x;
            Y = y;
        }
        public Point2D()
        {

        }
        public float GetX()
        {
            return X;
        }
        public float GetY()
        {
            return Y;
        }
        public void SetX(float x)
        {
            X = x;
        }
        public void SetY(float y)
        {
            Y = y;
        }
        public void SetXY(float x,float y)
        {
            X = x;
            Y = y;
        }
        public float[] GetXY()
        {
            float[] xy = new float[2] { X, Y};
            return xy;
        }

        public override string ToString()
        {
            return "X = "+GetX()+" Y = "+GetY()+" (X,Y) = " + string.Join(',', GetXY());
        }
    }
}