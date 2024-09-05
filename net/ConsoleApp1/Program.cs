public class Calculator
{
    public static void Main(string[] args)
    {
        Figure circle = new Circle(7);
        Figure tri = new Triangle(5,5,5);
        Console.WriteLine (circle.CalculateArea().ToString("0,00"));
        Console.WriteLine (tri.CalculateArea().ToString());
        Console.ReadLine();
    }
}

public abstract class Figure
{
    public abstract double CalculateArea();
}

public class Circle : Figure
{
    private double _radius;
    public Circle(int radius)
    {
        _radius = radius;
    }
    
    public override double CalculateArea()
    {
        double s;
        s = Math.PI * (_radius * _radius);
        return s;
    }
}

public class Triangle : Figure
{
    private double _sideA;
    private double _sideB;
    private double _sideC;
    
    public Triangle (double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }
    
    public override double CalculateArea()
    {
        double s;
        double p;
        p = (_sideA + _sideB + _sideC)/2;
        s = Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        return s;
    }
}
