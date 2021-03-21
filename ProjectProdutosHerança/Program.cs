using System;
using ProjectProdutosHerança.Entities;
using System.Globalization;

namespace ProjectProdutosHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produtos = new Produto();

            Console.Write("Enter the number of products: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {

                Console.Write("Common, used or imported (c/u/i): ");
                char tipoProduto = char.Parse(Console.ReadLine());

                if (tipoProduto == 'c')
                {

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Produto produtoComun = new Produto(name,valor);
                    produtos.AddProduto(produtoComun);

                }else if (tipoProduto == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    Produto produtoUsado = new ProdutoUsado(name, valor, date);

                    produtos.AddProduto(produtoUsado);



                }
                else if (tipoProduto == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Customs fee: ");
                    double taxa = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Produto produtoImportado = new ProdutoImportado(name, valor, taxa);

                    produtos.AddProduto(produtoImportado);


                }

            }

            produtos.List();

        }
    }
}
