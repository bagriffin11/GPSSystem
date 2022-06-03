using System;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphObject[] user = new GraphObject[3];
            Utilities sort = new Utilities();
            double[] per = new double[3];
            double[] are = new double[3];

            user[0] = new RightTriangle(19, 10, 0 , 0);
            user[1] = new Square(10, 0, 0);
            user[2] = new RightTriangle(4, 10, 0, 0);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Object #{0}: {1}",i+1, user[i].ToString());
                Console.WriteLine("Perimeter = {0}, Area = {1}", user[i].cal_perimeter(), user[i].cal_area());

            }

           
            for (int t = 0; t < 3; t++)
            {
                per[t] = user[t].cal_perimeter();
                are[t] = user[t].cal_area();
            }

            sort.FindLargest(are, per);

        }
    }
}
