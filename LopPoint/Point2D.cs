namespace LopPoint
{
    class Point3D : Point2D
    {
        private float Z;
        public Point3D(float X,float Y,float z):base(X,Y)
        {
            Z = z;
        }
        public Point3D()
        {

        }
        public float GetZ()
        {
            return Z;
        }
        public void SetZ(float z)
        {
            Z = z;
        }
        public void SetXYZ(float x, float y, float z)
        {
            SetX(x);
            SetY(y);
            Z = z;
        }
        public float[] GetXYZ()
        {
            float[] xyz = new float[3] { GetX(), GetY(), Z };
            return xyz;
        }
        public override string ToString()
        {
            return "X = " + GetX() + " Y = " + GetY() + " Z = "+GetZ()+" (X,Y,Z) = " + string.Join(',', GetXYZ());
        }
    }
}