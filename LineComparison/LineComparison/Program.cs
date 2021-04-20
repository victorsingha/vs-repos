using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1=2 , x2=4, x3=3, x4=6, y1=6, y2=8, y3=2, y4=5;

            double lenghtLine1 = Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2 - y1), 2));
            double lenghtLine2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            
            int res1 = lenghtLine1.CompareTo(lenghtLine2);       
            if (res1 < 0) Console.WriteLine("line1 < line2");
            else if(res1 == 0) Console.WriteLine("line1 = line2");
            else Console.WriteLine("line1 > line2");

            bool isEqual = lenghtLine1.Equals(lenghtLine2);
            if(isEqual==true) Console.WriteLine("line1 equals line2");
            else Console.WriteLine("line1 not equals line2");
        }
    }
}
