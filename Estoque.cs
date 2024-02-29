
using System.Runtime.InteropServices;

public class Estoque
{

    Var_instrumentos[] instrumentos = new Var_instrumentos[0];

    public void Adicionar(Var_instrumentos instrumento)
    {
        Var_instrumentos[] novoVetor = new Var_instrumentos[instrumentos.Length + 1];
        for (int pos = 0; pos < instrumentos.Length; pos++)
        {
            Var_instrumentos item = instrumentos[pos]; //for copiando os valores atuais do vetor instrumentos
            novoVetor[pos] = item;     
        }

        novoVetor[novoVetor.Length - 1] = instrumento;
        instrumentos = novoVetor;

    }

    public void Listar()
    {
        int cont = 1;
        foreach (Var_instrumentos item in instrumentos)
        {
            Console.WriteLine($"{cont}. {item.Nome_instrumento} (R${item.Preco}) - {item.Quantidade_estoque} dispiníveis no estoque");
            cont ++;
        }
    }

    
    public void Entrada(int posi, int qtd)
    {
        Var_instrumentos instrumento = instrumentos[posi - 1];
        instrumento.Quantidade_estoque += qtd;
    }

    public void Saida(int posi, int qtd)
    {
        Var_instrumentos instrumento = instrumentos[posi - 1];
        instrumento.Quantidade_estoque -= qtd;
    }

    public void Remover()
    {
        
    }



}