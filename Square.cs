using System;
namespace Final
{
    public class Square:GraphObject
    { 
        private int segment;
        

        public Square():base()
        { 
            segment = 2;
        }
        public Square(int s, double a, double p):base(a, p)
        {
           
            segment = s;
        }

        public int Segment 
        {
            get { return segment; }
            set { segment = value; }
        }

        public  override double cal_area()
        {
            double a = 0;
            a = segment * segment;
            return a;
        }

        public override double cal_perimeter()
        {
            double p = 0;
            p = segment * 4;
            return p;
        }

        public override string ToString()
        {
            return " The Square segment = " +segment;
        }
        ~Square() { }
    }
}
