using System;
using System.Collections.Generic;
using System.Text;
namespace LopCircleVsLopCylinder
{
    public class Cylinder : Circle
    {
        private double Height;

        public Cylinder(double height,double R, string Color):base(R,Color)
        {
            Height = height;
        }
        public Cylinder()
        {

        }

        public void setHeight(double height)
        {
            Height = height;
        }
        public double getHeight()
        {
            return Height;
        }
        
        public double Volume()
        {
            return Area * Height;
        }
        public override string ToString()
        {
            return"Height = "+ getHeight() + " The tich = "+ Volume() + base.ToString();
        }
    }
}