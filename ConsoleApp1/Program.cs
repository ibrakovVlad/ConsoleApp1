using CalculatorLibrary;
namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("a + b = {0}", calculator.Add(a, b));
            Console.WriteLine("a - b = {0}", calculator.Subtract(a, b));
            Console.WriteLine("a * b = {0}", calculator.Multiply(a, b));
            Console.WriteLine("a / b = {0}", calculator.Divide(a, b));
        }
    }
}