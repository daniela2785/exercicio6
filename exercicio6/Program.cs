using System;
using System.Globalization;


namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2;
            string nome1, nome2;
            double media;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);

            media = (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de  " + nome1 + " e " + nome2 + "é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");

            Console.ReadLine();
        }
    }
}