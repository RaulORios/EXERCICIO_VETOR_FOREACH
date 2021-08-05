using System;

namespace EXERCICIO_VETOR_FOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            for (int i = 0; i < n; i++)
            {
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Lista de nomes: ");
            foreach(string elemento in nomes)
            {
                Console.WriteLine(elemento);
            }

            Console.ReadKey();
        }
    }
}
