namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shapes C = new Circle(4);
            Shapes R = new Rectangle(4,5);
            Shapes T = new Triangle(4,5);
            Shapes S = new square(4);

            Console.WriteLine($"The area of the Circle is   : {C.area()}\n");
            Console.WriteLine($"The area of the Rectangle is: {R.area()}\n");
            Console.WriteLine($"The area of the Triangle is : {T.area()}\n");
            Console.WriteLine($"The area of the Square is   : {S.area()}\n");


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
            return (length*length);
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
