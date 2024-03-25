using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader reader = new StreamReader("C:\\Users\\joaol\\source\\repos\\ConsoleApp2\\ConsoleApp2\\arq.txt");
            List<Product> listProdutos = new List<Product>();
            string linha = reader.ReadLine();

            while (linha != null)
            {
                string[] vetorProd = linha.Split(',');
                Product produto = new Product();
                produto.Nome = vetorProd[0];
                produto.Categoria = vetorProd[1];
                produto.Preco = Convert.ToDouble(vetorProd[2].Replace("R$", "").Trim());

                listProdutos.Add(produto);
                linha = reader.ReadLine();
            }

            // Exercício 1:
            double somaPrecos = 0;
            foreach (var produto in listProdutos)
            {
                somaPrecos += produto.Preco;
            }
            double mediaPrecos = somaPrecos / listProdutos.Count;
            Console.WriteLine("Média de preços dos produtos: R$" + mediaPrecos.ToString("0.00"));

            // Exercício 2:
            Console.WriteLine("Produtos com preço maior que R$ 700,00:");
            foreach (var produto in listProdutos)
            {
                if (produto.Preco > 700)
                {
                    Console.WriteLine(produto.Nome + " - " + produto.Preco.ToString("0.00"));
                }
            }

            // Exercício 3:
            int quantidadePerifericos = 0;
            double somaPerifericos = 0;
            foreach (var produto in listProdutos)
            {
                if (produto.Categoria.ToLower() == "periféricos")
                {
                    quantidadePerifericos++;
                    somaPerifericos += produto.Preco;
                }
            }
            Console.WriteLine("Quantidade de produtos da categoria 'periféricos': " + quantidadePerifericos);
            Console.WriteLine("Soma dos valores dos produtos da categoria 'periféricos': R$" + somaPerifericos.ToString("0.00"));

            // Exercício 4:
            Console.WriteLine("Produtos com preço menor que R$ 100,00:");
            foreach (var produto in listProdutos)
            {
                if (produto.Preco < 100)
                {
                    Console.WriteLine(produto.Nome + " - " + produto.Preco.ToString("0.00"));
                }
            }

            reader.Close();
        }
    }
}