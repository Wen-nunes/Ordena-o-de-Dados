using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Principal
{
    public static void Main()
    {
        List<int> lista = new List<int>();
        List<int> listaBolha = new List<int>();

        GeradorNumeros.GerarNumerosLista(lista, 1000);
        GeradorNumeros.GerarNumerosLista(listaBolha, 1000);
        
            Console.WriteLine("Ordenando a lista de números com o algoritmo de bolha ...");
            Ordenacao.Bolha(listaBolha);
            Console.WriteLine("Feita a ordenação com o algoritmo de bolha.");


        
            Console.WriteLine("Ordenando a lista de números com o método Sort ...");
            lista.Sort();
            Console.WriteLine("Feita a ordenação com o método Sort.");
      
    }
}
