using System.Diagnostics.CodeAnalysis;

namespace VetProblemaExemplo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Product[] vect = new Product[N];

            for (int i = 0; i < N; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product
                {
                    Name = name,
                    Price = price
                };
            }

            double som = 0.0;
            for (int i = 0;i < N;i++)
            {
                som += vect[i].Price;
            }

            double avg = som / N;
            Console.WriteLine("Avarage price: " 
                + avg.ToString("F2"));
        }
    }
}
