using System;
using System.Collections.Generic;

public class GeradorNumeros
{
    // Método para gerar números inteiros aleatórios e adicionar à lista
    public static void GerarNumerosLista(List<int> lista, int quantidade)
    {
        // Cria uma instância da classe Random
        Random random = new Random();

        for (int i = 0; i < quantidade; i++)
        {
            // Gera um número aleatório no intervalo especificado
            int numero = random.Next(0,100000);
            lista.Add(numero);
        }
    }
}
