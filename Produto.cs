using System.Globalization;
using System;

namespace EstoqueTv
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

       public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public void Opcoes()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("***********OPÇÕES***********");
            System.Console.WriteLine("1 - Adicionar Produtos");
            System.Console.WriteLine("2 - Remover Produtos");
            System.Console.WriteLine("3 - Voltar ao Menu");
            System.Console.WriteLine();

            Console.Write("Opção: ");
            int resp = int.Parse(Console.ReadLine());
            if(resp == 1)
            {
                Console.WriteLine();
                Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                int qte = int.Parse(Console.ReadLine());
                AdicionarProdutos(qte);
                Console.WriteLine();
                Console.WriteLine("Dados atualizados: " + ToString());
            }else if (resp == 2)
            {
                Console.WriteLine();
                Console.Write("Digite o número de produtos a ser removido do estoque: ");
                int qte = int.Parse(Console.ReadLine());
                RemoverProdutos(qte);
                Console.WriteLine("Dados atualizados: " + ToString());
            }
            else if(resp == 3)
            {
                Opcoes();
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }

        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("C", CultureInfo.CurrentCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("C", CultureInfo.CurrentUICulture);
        }
    }
}
