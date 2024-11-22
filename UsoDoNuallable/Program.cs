namespace UsoDoNuallable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            double? X = null;
            // Nullable<double> x = null;  tornar a variavel nula
            double? Y = 10.0;

            Console.WriteLine(X.GetValueOrDefault());
            Console.WriteLine(Y.GetValueOrDefault());

            Console.WriteLine(X.HasValue);
            Console.WriteLine(Y.HasValue);

            if (X.HasValue)
            {
                Console.WriteLine(X.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }
            if (Y.HasValue)
            {
                Console.WriteLine(Y.Value);
            }
            else
            {
                Console.WriteLine("Y  is null");
            }
            */

            
            
            // Operador de coalecencia do null

            double? x = null;
            double? y = 10.0;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
