using System;
using System.Collections.Generic;
using System.Linq;
namespace Aluno;
public class Aluno
{
    /// <summary>
    /// Nome do aluno.
    /// </summary>
    public string Nome { get; set; }

    /// <summary>
    /// Idade do aluno.
    /// </summary>
    public int Idade { get; set; }

    /// <summary>
    /// Inicializa o objeto Aluno.
    /// </summary>
    public Aluno(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    /// <summary>
    /// Retorna uma string representando o aluno.
    /// </summary>
    public override string ToString()
    {
        return $"Aluno(nome={Nome}, idade={Idade})";
    }

    /// <summary>
    /// Gera um nome aleatório com um tamanho específico.
    /// </summary>
    public static string GerarNomeAleatorio(int tamanho = 5)
    {
        const string letras = "abcdefghijklmnopqrstuvwxyz";
        var random = new Random();
        var nome = new char[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            nome[i] = letras[random.Next(letras.Length)];
        }

       
        return char.ToUpper(nome[0]) + new string(nome, 1, tamanho - 1);
    }

    /// <summary>
    /// Gera uma lista de alunos com a quantidade desejada.
    /// </summary>
    public static List<Aluno> GerarAlunos(int qtd)
    {
        var alunos = new List<Aluno>();
        var random = new Random();

        for (int i = 0; i < qtd; i++)
        {
            string nome = GerarNomeAleatorio();
            int idade = random.Next(18, 71); 
            alunos.Add(new Aluno(nome, idade));
        }

        return alunos;
    }

    /// <summary>
    /// Cria uma cópia de uma lista de alunos.
    /// </summary>
    public static List<Aluno> CopiarListaAlunos(List<Aluno> lista)
    {
        return lista.Select(aluno => new Aluno(aluno.Nome, aluno.Idade)).ToList();
    }
}
