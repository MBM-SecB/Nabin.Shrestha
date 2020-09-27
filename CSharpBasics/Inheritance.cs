using System;
public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetCircumference();

public class Rectangle :Shape
{
    public double Length {get; set;}
    public double Breadth {get; set;}

    public Rectangle (double Length, double Breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public override double GetArea()  => Length*Breadth;

     public override double GetCircumference() => 2*(Length+Breadth);

     public override void PrintResults()
     {
         Console.WriteLine($"printing result for rectangle [{Length}x {Breadth}]:");
         Console.WriteLine($"Area: {this.GetArea()");
         Console.WriteLine()
     }


}
public class Square : Rectangle
   { 
    public Square(double side)
    {
        base.Length=side;
        base.Breadth=side;
    }
   }

public class Circle :Shape
{
    public double Radius {get; set;}

    public override double GetArea()  => Math.PI*Radius*Radius;

     public override double GetCircumference() => 2*Math.PI*Radius;

}
