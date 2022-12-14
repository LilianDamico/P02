using P02;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Informe os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Informe o preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de itens em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Informe a quantidade a ser acrescentada ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            //Console.WriteLine();
            //Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Informe a quantidade a ser retirada do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
