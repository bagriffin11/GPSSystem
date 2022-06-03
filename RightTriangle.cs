using System;
namespace Final
{
    public class RightTriangle : GraphObject
    {
  
        private int bas;
        private int height;
        


        public RightTriangle():base()
        {
            bas = 2;
            height = 2;
           
        }
        public RightTriangle(int x, int y, double a, double p) : base(a, p)
        {
            bas = x;
            height = y;
           
        }
      
        public int Bas
        {
            get { return bas; }
            set { bas = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public override double cal_area()
        {
            return (bas * height)/2;
        }

        public override double cal_perimeter()
        {
            double hyp = Math.Round(Math.Sqrt(Math.Pow(bas, 2) + Math.Pow(height, 2)), 2);
            return hyp + bas + height; 
        }


        public override string ToString()
        {
            return "The right triangle has a base = " +bas +  " and a height = " + height;
        }
        ~RightTriangle() { }
    }
}
