using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class Util
{
    /// <summary>
    /// Gera palavras aleatórias e as salva em um arquivo.
    /// </summary>
    public static void GerarPalavrasArquivo(string nomeArquivo, int quantidade, int tamanho)
    {
        using (StreamWriter arquivo = new StreamWriter(nomeArquivo, false, System.Text.Encoding.UTF8))
        {
            for (int i = 0; i < quantidade; i++)
            {
                arquivo.WriteLine(GerarPalavra(tamanho));
            }
        }
        Console.WriteLine($"As palavras foram salvas em {nomeArquivo}.");
    }

    /// <summary>
    /// Gera números aleatórios e os salva em um arquivo.
    /// </summary>
    public static void GerarNumerosArquivo(string nomeArquivo, int quantidade, int tamanho)
    {
        Random random = new Random();
        using (StreamWriter arquivo = new StreamWriter(nomeArquivo, false, System.Text.Encoding.UTF8))
        {
            for (int i = 0; i < quantidade; i++)
            {
                arquivo.WriteLine(random.Next(0, tamanho + 1));
            }
        }
        Console.WriteLine($"Os números foram salvos em {nomeArquivo}.");
    }

    /// <summary>
    /// Popula uma lista com números inteiros aleatórios.
    /// </summary>
    public static void GerarNumerosLista(List<int> lista, int quantidade, int tamanho)
    {
        Random random = new Random();
        for (int i = 0; i < quantidade; i++)
        {
            lista.Add(random.Next(0, tamanho + 1));
        }
    }

    /// <summary>
    /// Gera uma palavra aleatória com um tamanho específico.
    /// </summary>
    public static string GerarPalavra(int tamanho)
    {
        const string letras = "abcdefghijklmnopqrstuvwxyz ";
        Random random = new Random();
        char[] palavra = new char[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            palavra[i] = letras[random.Next(letras.Length)];
        }

        return new string(palavra);
    }

    /// <summary>
    /// Popula uma lista com palavras aleatórias.
    /// </summary>
    public static void GerarPalavrasLista(List<string> lista, int quantidade, int tamanho)
    {
        for (int i = 0; i < quantidade; i++)
        {
            lista.Add(GerarPalavra(tamanho));
        }
    }

    /// <summary>
    /// Exibe os elementos de qualquer lista.
    /// </summary>
    public static void Exibir<T>(IEnumerable<T> lista, string frase)
    {
        Console.WriteLine(frase);
        foreach (T item in lista)
        {
            Console.WriteLine(item);
        }
    }
}
