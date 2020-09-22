
namespace LopMoveblePoint
{
    public class Point
    {
        public float X = 0;
        public float Y = 0;
        public Point(float _X,float _Y)
        {
            X = _X;
            Y = _Y;
        }
        public Point()
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
        public void SetX(float _X)
        {
            X = _X;
        }
        public void SetY(float _Y)
        {
            Y = _Y;
        }
        public void SetXY(float _X, float _Y)
        {
            X = _X;
            Y = _Y;
        }
        public float[] GetXY()
        {
            float[] xy = new float[2] { X, Y };
            return xy;
        }

        public override string ToString()
        {
            return "X = " + GetX() + " Y = " + GetY() + " (X,Y) = " + string.Join(',', GetXY());
        }
    }
}