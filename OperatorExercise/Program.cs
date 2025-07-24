namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int diff = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"Sum of {a} + {b} is {sum}.\n"
                + $"Difference of {a} - {b} is {diff}.\n"
                + $"Product of {a} * {b} is {product}.\n"
                + $"Remainder of {a} / {b} is {remainder}");

            Console.Write("Please input a radius to receive the circle's area: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(radius).ToString());
        }

        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
