using System.Runtime.Serialization;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }

            double soma = 0.0;

            for (int i = 0 ;i < N; i++)
            {
                soma += vet[i];
            }

            double avg = soma / N;

            Console.WriteLine("AVARAGE HEIGHT " + avg.ToString("F2"));
        }
    }
}
