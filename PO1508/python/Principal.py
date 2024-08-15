from util import Util
import time

import threading
from ordenacao_Bolha import Ordenacao



lista = []
lista_bolha = []

Util.gerar_numeros_lista(lista, 10000, 10000)
Util.gerar_numeros_lista(lista_bolha, 10000, 10000)

threading.Thread(
    target=lambda:(
        #Marcando tempo de ordenação 
        #inicio = time.time(),

        print("Ordenando a lista de numeros em bolha ..."),

        #ordenando a lista por bolha....
        Ordenacao.bolha(lista_bolha),

       # fim = time.time(),
       # tempo_decorrido = fim - inicio,

        #print(f"Tempo decorrido: {tempo_decorrido:.6f} segundos"),


        #Util.exibir(lista_palavras, "Lista de palavras ordenadas")
        print("Feita a ordenacao em bolha..;"),
    )
).start()

threading.Thread(
    target=lambda: (
        #Marcando tempo de ordenação 
        #inicio = time.time(),

        print("Ordenando a lista de numeros com o sort..."),

        #ordenando a lista....
        lista.sort(),

        #fim = time.time(),
        #tempo_decorrido = fim - inicio,

        #print(f"Tempo decorrido: {tempo_decorrido:.6f} segundos"),


        #Util.exibir(lista_palavras, "Lista de palavras ordenadas")
        print("Feita a ordenacao em sort..;"),
    )
).start()



