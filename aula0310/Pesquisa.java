import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

public class Pesquisa {

    boolean binaria(int valor, ArrayList<Integer> lista) {
        int ini = 0;
        int fim = lista.size() - 1; // Usando o tamanho da lista
        int meio;

        while (ini <= fim) {
            meio = (ini + fim) / 2;
            if (valor == lista.get(meio)) { // Comparando com o valor na lista
                return true; // Valor encontrado
            }
            if (valor < lista.get(meio)) {
                fim = meio - 1;
            } else {
                ini = meio + 1;
            }
        }
        return false; // Retorno falso se não encontrado
    }

    public static void main(String[] args) {
        ArrayList<Integer> lista = new ArrayList<>();
        Random random = new Random();
        int n = 1000000; // Quantidade de números
        int quantidade = 100000; // Limite dos números

        // Gerar números aleatórios
        for (int i = 0; i < n; i++) {
            int numero = random.nextInt(quantidade); // Gera um número dentro do intervalo
            lista.add(numero);
        }

        // Ordenar a lista para a busca binária
        Collections.sort(lista);

        // Marcar o tempo inicial
        long tempoInicial = System.nanoTime();
        // Executar a busca binária
        boolean encontrado = new Pesquisa().binaria(50000, lista); // Valor a ser buscado
        long tempoFinal = System.nanoTime();
        
        // Calcular a duração em milissegundos
        long duracao = (tempoFinal - tempoInicial) / 1_000_000; // Converte de nanos para milissegundos
        // Exibir o tempo de resposta
        System.out.println("Tempo de resposta da busca binária: " + duracao + " ms. Valor encontrado: " + encontrado);

        // Marcar o tempo inicial
        tempoInicial = System.nanoTime();
        // Executar busca com contains
        encontrado = lista.contains(50000); // Valor a ser buscado
        tempoFinal = System.nanoTime();
        
        // Calcular a duração em milissegundos
        duracao = (tempoFinal - tempoInicial) / 1_000_000; // Converte de nanos para milissegundos
        // Exibir o tempo de resposta
        System.out.println("Tempo de resposta do contains: " + duracao + " ms. Valor encontrado: " + encontrado);
    }
}
