using System;
using System.Collections.Generic;
using System.Text;
namespace LopCircleVsLopCylinder
{
    public class Circle
    {
        private double R;
        private string Color;
        public double Area;
        public Circle(double r, string color)
        {
            R = r;
            Color = color;
        }
        public Circle()
        {

        }
        public void setR(double r)
        {
            R = r;
        }
        public double getR()
        {
            return R;
        }
        public void setColor(string color)
        {
            Color = color;
        }
        public string getColor()
        {
            return Color;
        }
        public double getArea()
        {
            return Area = Math.PI * R * R;
        }
        public override string ToString()
        {
            return "Co R = " + getR() + "  Area =  "+ getArea() +"  Color  " + getColor();
        }
    }
}