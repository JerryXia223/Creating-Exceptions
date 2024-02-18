using System;

//create the Circle class with the attribute Radius of type double and the required methods.
class Circle
{
    private double radius;

    public void SetRadius(double r)
    {
        if (r > 0)
        {
            radius = r;
        }
        else
        {
            throw new InvalidRadiusException(r);
        }
    }

    public override string ToString()
    {
        return "Circle with radius " + radius;
    }
}

//create the InvalidRadiusException class with the constructors
class InvalidRadiusException : Exception
{
    public InvalidRadiusException() : base("Invalid radius") { }
    public InvalidRadiusException(double r) : base("Invalid radius: " + r) { }
}

//create a Main class to test the Circle class and the exception handling
class MainClass
{
    static void Main()
    {
        Circle c1 = new Circle();
        try
        {
            c1.SetRadius(2.5);
            Console.WriteLine(c1.ToString());
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine(e.Message);
        }

        Circle c2 = new Circle();
        try
        {
            c2.SetRadius(-3.0);
            Console.WriteLine(c2.ToString());
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine(e.Message);
        }

        Circle c3 = new Circle();
        try
        {
            c3.SetRadius(0.0);
            Console.WriteLine(c3.ToString());
        }
        catch (InvalidRadiusException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}