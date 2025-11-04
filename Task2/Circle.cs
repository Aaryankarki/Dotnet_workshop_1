using System;

namespace Task2;


public class Circle
{
    const double PI = 3.14;
     public double Radius;
    // public Circle(double radius)
    // {
    //     Radius = radius;
    // }
    public double GetArea()
    {
        return PI * Radius * Radius;
    }
     public double GetPerimeter()
    {
        return 2*PI * Radius ;
    }


}
