/* criar a classe Produto
 * 
 * -Nome : string
 * -Preco : double
 * -Quantidade: int

Métodos

ValorTotalEmEstoque() : double
AdicionarProdutos(quantidade : int) : void
RemoverProdutos(quantidade : int) : void

Entre os dados do produto:
Nome: TV
Preço: 900.00
Quantidade no estoque: 10
Dados do produto: TV, $ 900.00, 10 unidades, Total: $ 9000.00
Digite o número de produtos a ser adicionado ao estoque: 5
Dados atualizados: TV, $ 900.00, 15 unidades, Total: $ 13500.00
Digite o número de produtos a ser removido do estoque: 3
Dados atualizados: TV, $ 900.00, 12 unidades, Total: $ 10800.00

*/
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
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
