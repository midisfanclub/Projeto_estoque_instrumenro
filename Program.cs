namespace PTI;

class Program
{
    static void Main(string[] args)
    {
        string opcao;

        while(true)
    {
        Console.WriteLine("digite o número correspondente a opção desejada:");
        Console.WriteLine("[1] Novo");
        Console.WriteLine("[2] Listar produtos");
        Console.WriteLine("[3] Remover produtos");
        Console.WriteLine("[4] Entrada estoque");
        Console.WriteLine("[5] Saída estoque");
        Console.WriteLine("[6] Sair");

        opcao = Console.ReadLine();
        string[] nome_instrumento = new string [10];
        double[] precos = new double [10];
        // double quantidade_estoque[] = 
        // string marca[] = 
        // string categoria[] = 
        // string material[] = 


        switch (opcao)
        {
            case "1":
                Console.WriteLine("Cadastrar novo produto:");
                Console.WriteLine("Nome do intrumento:\n");
                nome_instrumento[1] = Console.ReadLine();
                Console.WriteLine("Preço unitário:\n");
                precos[1] = Convert.ToDouble(Console.ReadLine());
                break;

            case "2":
                Console.WriteLine("Lista de produtos:");
                break;

            case "3":
                Console.WriteLine("Remover produto:");
                break;

            case "4":
                Console.WriteLine("Entrada de estoque:");
                break;

            case "5":
                Console.WriteLine("Saída de estoque:");
                break;

            case "6": 
                Console.WriteLine("Programa encerrado");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Opção inválida, tente novamente!");
                break;


        }
    }
    }
}
