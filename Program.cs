using System.Runtime.CompilerServices;

namespace PTI;

class Program
{
    static void Main(string[] args)
    {
        int opcao;

        while(true)
        {
            opcao = Menu();
        

            string[] nome_instrumento = new string [10];
            double[] precos = new double [10];
            // double quantidade_estoque[] = 
            // string marca[] = 
            string[] categoria = new string [10];
            // string material[] = 


            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Cadastrar novo produto:");
                    Console.WriteLine("Nome do intrumento:\n");
                    nome_instrumento[0] = Console.ReadLine();
                    Console.WriteLine("Preço unitário:\n");
                    precos[0] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Categoria (ordas, sopro, percussão):");
                    categoria[0] = Console.ReadLine();

                    break;

                case 2:
                    Console.WriteLine("Lista de produtos:");
                    break;

                case 3:
                    Console.WriteLine("Remover produto:");
                    break;

                case 4:
                    Console.WriteLine("Entrada de estoque:");
                    break;

                case 5:
                    Console.WriteLine("Saída de estoque:");
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
    
    }
    public static int Menu()
    {
        Console.WriteLine("\nQual operação deseja realizar");
        Console.WriteLine("[1] Adição");
        Console.WriteLine("[2] Subtração");
        Console.WriteLine("[3] Multiplicação");
        Console.WriteLine("[4] Divisão\n");
        Console.WriteLine("[0] Sair\n");

        int opcao = Convert.ToInt32(Console.ReadLine());
        return opcao;
    }
    public static string Novo()
    {

    }

}
