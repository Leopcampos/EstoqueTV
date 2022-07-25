using System;
using System.Globalization;

namespace EstoqueTv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Produto p = new Produto(nome, preco, quantidade);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            p.Opcoes();
        }
    }
}
