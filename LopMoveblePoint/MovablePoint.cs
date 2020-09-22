namespace LopMoveblePoint
{
    public class MovablePoint:Point
    {
        private float ySpeed = 0.0f;
        private float xSpeed = 0.0f;


        public MovablePoint(float _xSpeed,float _ySpeed)
        {
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }
        public MovablePoint()
        {

        }

        public void SetySpeed(float _ySpeed)
        {
            ySpeed = _ySpeed;
        }
        public void SetxSpeed(float _xSpeed)
        {
            xSpeed = _xSpeed;
        }
        public float GetxSpeed()
        {
            return xSpeed;
        }
        public float GetySpeed()
        {
            return ySpeed;
        }
        public void SetXYSpeed(float _X,float _Y)
        {
            xSpeed = _X;
            ySpeed = _Y;
        }
        public float[] GetXYSpeed()
        {
            float[] XY = new float[2] { xSpeed, ySpeed };
            return XY;
        }
        public override string ToString()
        {
            return "xSpeed = " + GetxSpeed() + "ySpeed = " + GetySpeed() + " (XSpeed,YSpeed) = " + string.Join(',', GetXYSpeed());

        }
        public MovablePoint Move()
        {
            X += xSpeed;
            Y += ySpeed;
            return this;
        }

    }
}