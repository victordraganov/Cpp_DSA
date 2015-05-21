//01.Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. Define two new classes Triangle and 
//   Rectangle that implement the virtual method and return the surface of the figure (height*width for rectangle and height*width/2 for triangle).
//   Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface()
//   method. Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in
//   an array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Principles_II
{
    class Program
    {
        static void Main()
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Triangle(10, 5);
            shapes[1] = new Rectangle(4, 6);
            shapes[2] = new Circle(5);

            foreach (var s in shapes)
            {
                Console.WriteLine("The surface of {0} is {1:F2}.", s.GetType().Name,
                    s.CalculateSurface());
            }
        }
    }
}