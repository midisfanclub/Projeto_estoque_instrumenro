using System.Runtime.CompilerServices;

namespace PTI;

class Program
{
    static void Main(string[] args)
    {
        int opcao;

       Estoque estoque = new Estoque();

        do
        {
            opcao = Menu();
        
            switch (opcao)
            {
                case 1:
                   
                   Var_instrumentos novo_instrumento = new Var_instrumentos();

                    Console.WriteLine("\n>> Cadastrar novo produto");
                    Console.WriteLine("\nNome do intrumento:");
                    novo_instrumento.Nome_instrumento = Console.ReadLine();
                    Console.WriteLine("\nPreço unitário:");
                    novo_instrumento.Preco = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nCategoria (cordas, sopro ou percussão):");
                    novo_instrumento.Categoria = Console.ReadLine();
                    Console.WriteLine("\nMarca:");
                    novo_instrumento.Marca = Console.ReadLine();
                    Console.WriteLine("\nMaterial:");
                    novo_instrumento.Material = Console.ReadLine();
                    estoque.Adicionar(novo_instrumento);
                    Console.WriteLine("\n>>Instrumento adicionado!<<\n\n");

                    break;

                case 2:
                    Console.WriteLine("\nLista de produtos:\n");
                    estoque.Listar();
                    Console.WriteLine("\n");
                    break;

                case 3:
                    Console.WriteLine("Remover produto:");
                    break;

                case 4:
                    Console.WriteLine(">> Entrada de estoque");
                    
                    Console.WriteLine("\nLista de produtos:\n");
                    estoque.Listar();
                    Console.WriteLine("\n");
                    
                    Console.WriteLine("Posição do produto:");
                    int pos = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Quantidade a ser adicionada ao estoque:");
                    int qtd = Convert.ToInt32(Console.ReadLine());

                    estoque.Entrada(pos, qtd);

                    break;

                case 5:
                    Console.WriteLine(">> Saída de estoque");
                   
                    Console.WriteLine("\nLista de produtos:\n");
                    estoque.Listar();
                    Console.WriteLine("\n");
                    
                    Console.WriteLine("Posição do produto:");
                    int posi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Quantidade de saída:");
                    int quantidade = Convert.ToInt32(Console.ReadLine());

                    estoque.Saida(posi, quantidade);
                    break;

                case 6: 
                    Console.WriteLine("Programa encerrado");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente!");
                    break;


            }
        }
        while (Menu() != 0);
    
    }
    public static int Menu()
    {
        Console.WriteLine("\nDigite o número correspondente a opção desejada:");
        Console.WriteLine("[1] Novo");
        Console.WriteLine("[2] Listar produtos");
        Console.WriteLine("[3] Remover produtos");
        Console.WriteLine("[4] Entrada estoque");
        Console.WriteLine("[5] Saída estoque");
        Console.WriteLine("\n[6] Sair");

        int opcao = Convert.ToInt32(Console.ReadLine());
        return opcao;
    }
    

}
