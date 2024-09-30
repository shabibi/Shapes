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
}
