namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public abstract class Shapes
    {
        protected double length;
        protected double whidth;

        public abstract double area();
    }

    public class square : Shapes
    {
        public square(double length)
        {
            this.length = length;
        }
        public override double area()
        {
            return length*length;
        }
    }

    public class Rectangle : Shapes
    {
        public Rectangle(double length , double whidth)
        {
            this.length = length;
            this.whidth = whidth;
        }
        public override double area()
        {
            return length * whidth;
        }
    }

    public class Circle : Shapes
    {
        public Circle(double radius)
        {
            length = radius;
            
        }
        public override double area()
        {
            return Math.PI * length * length;
        }
    }

    public class Triangle : Shapes
    {
        public Triangle(double baselength, double height)
        {
            length = baselength;
            whidth = height;

        }
        public override double area()
        {
            return 0.5 * length * whidth;
        }
    }
}
