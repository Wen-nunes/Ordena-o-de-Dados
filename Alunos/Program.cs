using Alunos;
using System.Collections.Generic;
using System.Threading;

int tamanho = 60000;

List<Aluno> listaBolha = Aluno.GerarAlunos(tamanho);
List<Aluno> listaInsercao = Aluno.CopiarListaAlunos(listaBolha);
List<Aluno> listaSelecao = Aluno.CopiarListaAlunos(listaBolha);
List<Aluno> listaSort = Aluno.CopiarListaAlunos(listaBolha);

void rodaBolha()
{
    Console.WriteLine("Ordenando a lista para o bolha...");
    Ordenacao.Bolha(listaBolha);
    Console.WriteLine("feito... com bolha");
}

void rodaSelecao()
{
    Console.WriteLine("Ordenando a lista para seleção...");
    Ordenacao.Selecao(listaSelecao);
    Console.WriteLine("feito... com seleção");
}

void rodaSort()
{
    Console.WriteLine("Ordenando a lista para o sort...");
    listaSort.Sort((a, b) => a.Nome.CompareTo(b.Nome) != 0 ? a.Nome.CompareTo(b.Nome) : a.Idade.CompareTo(b.Idade));
    Console.WriteLine("feito... sort C#");
}

void rodaInsercao()
{
    Console.WriteLine("Ordenando a lista para inserção...");
    Ordenacao.Insercao(listaInsercao);
    Console.WriteLine("feito... com inserção");
}

new Thread(
    () => rodaBolha()
).Start();

new Thread(
    () => rodaSelecao()
).Start();

new Thread(
    () => rodaInsercao()
).Start();

new Thread(
    () => rodaSort()
).Start();
