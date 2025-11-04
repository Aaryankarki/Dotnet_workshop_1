using System;
using Task2;

class Program
{
    static void Main()
    {
        Circle c = new Circle();

        Console.WriteLine("Area: " + c.GetArea());
        Console.WriteLine("Perimeter: " + c.GetPerimeter());

        // changing the value of PI
        Circle.PI = 3.14159; 
         
         //explaination: It has const so the value is changeable only one time at the time of the declaration.That's why when we try to assign new value in PI, it will show 'Circle.PI' is inaccessible due to its protection level.
    }
}
