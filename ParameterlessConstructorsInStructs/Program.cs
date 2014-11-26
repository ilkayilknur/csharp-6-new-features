using System;

namespace ParameterlessConstructorsInStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parameterless constructor does not run.
            Point p;
            p.x = 12;

            //Parameterless constructor runs.
            Point p2 = new Point();

            Console.WriteLine("X=\{p2.x}, Y=\{p2.y}");
        }
    }

    struct Point
    {
        public int x, y;
        public Point(int xPoint, int yPoint)
        {
            x = xPoint;
            y = yPoint;
        }

        //Parameterless constructors are not allowed before C# 6.0

        //After C# 6.0
        //This constructor only runs if you use new when declaring struct.
        public Point() : this(10, 20)
        {

        }
    }
}
