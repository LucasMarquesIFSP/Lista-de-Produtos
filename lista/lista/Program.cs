using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produtos = new Produtos();
            bool key = true;

            while (key)
            {
                Console.WriteLine(" 0 - Sair");
                Console.WriteLine(" 1 - Adicionar Produto");
                Console.WriteLine(" 2 - Pesquisar Produto");
                Console.WriteLine(" 3 - Remover Produto");
                Console.WriteLine(" 4 - Listar Produto");

                int entrada = int.Parse(Console.ReadLine());

                Console.Clear();
                if (entrada == 1)
                {
                    Console.WriteLine("Digite o Codigo: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a Descricão: ");
                    string descricao = Console.ReadLine();
                    Console.WriteLine("Digite a Qtde: ");
                    int qtde = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Preço: ");
                    double preco = double.Parse(Console.ReadLine());
                    produtos.adicionar(new Produto(codigo, descricao, qtde, preco));

                }
                else if(entrada == 2)
                {
                    Console.WriteLine("Digite o Codigo: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Produto result = produtos.pesquisar(new Produto(codigo,"",0, 0));
                    Console.WriteLine("Codigo : "+result.Codigo+"\nDescrição : "+result.Descricao+"\nQtde : "+result.Qtde+"\nPreco : "+result.Preco);
                }
                else if (entrada == 3)
                {
                    Console.WriteLine("Digite o Codigo: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Tem certeza S ou N? ");
                    string x = Console.ReadLine();
                    bool decisao = x == "S"? true : false;
                    if (decisao)
                    {
                        bool result = produtos.remover(new Produto(codigo, "", 0, 0));
                        if (result)
                        {
                            Console.WriteLine("Apagado com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possivel apagar");
                        }
                    }
                    
                }
                else if (entrada == 4)
                {
                    foreach(Produto elemento in produtos.ListaProdutos)
                    {
                        Produto result = produtos.pesquisar(new Produto(elemento.Codigo, "", 0, 0));
                        Console.WriteLine("Codigo : " + result.Codigo + "\nDescrição : " + result.Descricao + "\nQtde : " + result.Qtde + "\nPreco : " + result.Preco+"\n");
                    }
                    Console.WriteLine("Custo total= " + produtos.custoTotal());
                }
                else if (entrada == 0)
                {
                    key = false;
                }
                else 
                {
                    Console.WriteLine("Valor invalido");
                }
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
