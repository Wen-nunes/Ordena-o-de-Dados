using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using namespace Aluno;
using namespace util;

public class Program
{
    public static void Main()
    {
        Console.Clear(); 

        int tamanho = 60000;

        List<Aluno> listaBolha = Aluno.GerarAlunos(tamanho);
        List<Aluno> listaInsercao = Aluno.CopiarListaAlunos(listaBolha);
        List<Aluno> listaSelecao = Aluno.CopiarListaAlunos(listaBolha);
        List<Aluno> listaSort = Aluno.CopiarListaAlunos(listaBolha);

        Task.Run(() =>
        {
            Console.WriteLine("Ordenando a lista para o bolha...");
            Ordenacao.Bolha(listaBolha);
            Console.WriteLine("feito... com bolha");
        });

        Task.Run(() =>
        {
            Console.WriteLine("Ordenando a lista para o sort...");
            listaSort.Sort((a, b) => a.Nome.CompareTo(b.Nome) != 0 ? a.Nome.CompareTo(b.Nome) : a.Idade.CompareTo(b.Idade));
            Console.WriteLine("feito... sort C#");
        });

        Task.Run(() =>
        {
            Console.WriteLine("Ordenando a lista para inserção...");
            Ordenacao.Insercao(listaInsercao);
            Console.WriteLine("feito... com inserção");
        });

        Task.Run(() =>
        {
            Console.WriteLine("Ordenando a lista para seleção...");
            Ordenacao.Selecao(listaSelecao);
            Console.WriteLine("feito... com seleção");
        });

        Task.WaitAll();
    }
}
