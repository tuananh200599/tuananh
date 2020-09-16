namespace AccessModifier
{
public class Circle
    {
        private double Radius = 1.0;
        private string Color = "Red";
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public Circle()
        {

        }
        public void setRadius(double _Radius)
        {
            Radius = _Radius;
        }
        public double getRadius()
        {
            return Radius;
        }
        public void setColor(string _Color)
        {
            Color = _Color;
        }
        public string getColor()
        {
            return Color;
        }
    }
}