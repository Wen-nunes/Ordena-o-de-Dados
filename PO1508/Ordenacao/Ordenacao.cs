using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ordenacao
{
    public static void Bolha(List<int> lista)
    {
        bool houveTroca = true;

        while (houveTroca)
        {
            houveTroca = false;

            for (int i = 0; i < lista.Count - 1; i++)
            {
                if (lista[i] > lista[i + 1])
                {
                    houveTroca = true;
                    int aux = lista[i];
                    lista[i] = lista[i + 1];
                    lista[i + 1] = aux;
                }
            }
        }
    }
}
