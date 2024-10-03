/*Pesquisa em :
    - select
- arquivos
- lista ou vetores: Dados primitivos ou objetos
    - sequencial
    6 8 4 9 2 5 6 3 9 4 
    2 3 4 4 5 6 6 8 9 9 
    - binaria 
        2 3 4 4 5 6 6 8 9 9
- texto: pesquisa digital


*/

int sequencial_Ordenada(int valor, int vetor[], int n){
    for (int i = 0; i <n; i++){
        if(valor == vetor [i]){
            return i;
        } else if (valor < valor[i]){
            break;
        }
    }
    return -27;
}

Integer sequencial_Desordenada(int valor, ArrayList<Integer> lista){
    for (int i = 0; i < lista.size(); i ++){
            if (valor == lista.get(i)){
                return 1;
            }

    }
    rerturn -27;
}


/*1 3 5 5 5 5 6 7 9 10 11 45 67 89 90 90 90 
  0 1 2 3 4 5 6 7 8 9 10 12 13 1 15 16 17 18
*/

void binaria(int valor, ArrayList<Integer> lista ){
    int ini = 0;
    int fim <= n - 1;
    int meio;

    while (ini < fim ){
        meio = (ini + fim)/2;
        if(valor == vetor[meio]){
            return true;
        }
        if(valor < vetor[meio]){
            fim = meio - 1;
        }else{
            ini = meio + 1;
        }
    }
}