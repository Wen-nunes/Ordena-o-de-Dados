using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    internal class Ordenacao
    {
        public static void Bolha(List<Aluno> lista)
        {
            bool houveTroca = true;
            while (houveTroca)
            {
                houveTroca = false;
                for (int i = 0; i < lista.Count - 1; i++)
                {
                    if (lista[i].CompareTo(lista[i + 1]) > 0)   
                    {
                        houveTroca = true;
                        Aluno tmp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = tmp;
                    }
                }
            }
        }

        public static void Selecao(List<Aluno> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                int posMenor = i;
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[j].CompareTo(lista[posMenor]) < 0)
                    {
                        posMenor = j;
                    }
                }

                if (i != posMenor)
                {
                    Aluno tmp = lista[i];
                    lista[i] = lista[posMenor];
                    lista[posMenor] = tmp;
                }
            }
        }

        public static void Insercao(List<Aluno> lista)
        {
            for (int i = 1; i < lista.Count; i++)
            {
                Aluno tmp = lista[i];
                int j = i - 1;
                while (j >= 0)
                {
                    if (tmp.CompareTo(lista[j]) < 0)
                    {
                        lista[j + 1] = lista[j];
                    }
                    else
                    {
                        break;
                    }
                    j--;
                }

                lista[j + 1] = tmp;
            }
        }
    }
}
