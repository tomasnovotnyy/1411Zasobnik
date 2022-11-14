namespace Zasobnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zasobnik<int> zasobnik = new Zasobnik<int>();
            zasobnik.Push(42);
            zasobnik.Push(43);
            zasobnik.Push(22);
            zasobnik.Push(15);
            zasobnik.Push(35);

            while (!zasobnik.IsEmpty)
            {
                Console.WriteLine(zasobnik.Pop());
            }

        }
    }
}