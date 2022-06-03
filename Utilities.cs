using System;
using System.Linq;
namespace Final
{
    public class Utilities
    {
       public void FindLargest(double[] arr, double[] ar)
        {
            
            double largestarea = arr.Max();
            int maxObjectArea = arr.ToList().IndexOf(largestarea);

            double largestperimeter = ar.Max();
            int maxObjectPerimeter = ar.ToList().IndexOf(largestperimeter);

            
            Console.WriteLine("Object #{0} largest area is {1} \n\n",maxObjectArea+1, largestarea);
            Console.WriteLine("Object #{0} largest perimeter is {1} \n\n", maxObjectPerimeter + 1, largestperimeter);

        }
    }
}
