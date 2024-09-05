import random
import string

class Aluno:
    """
    Classe aluno com nome e idade.
    """

    def __init__(self, nome, idade):
        """
        Inicializa objeto Aluno.

        """
        self.nome = nome
        self.idade = idade

    def __repr__(self):
        """
        Retorna string aluno.

        """
        return f"Aluno(nome={self.nome}, idade={self.idade})"

    @staticmethod
    def gerar_nome_aleatorio(tamanho=5):
        """
        Gera um nome aleatório com o um tamanho especifico.

        """
        letras = string.ascii_lowercase
        return ''.join(random.choice(letras) for _ in range(tamanho)).capitalize()

    @classmethod
    def gerar_alunos(cls, qtd):
        """
        Gera uma lista de alunos com a quantidade desejada.

        """
        return [cls(cls.gerar_nome_aleatorio(), random.randint(18, 70)) for _ in range(qtd)]

    @staticmethod
    def copiar_lista_alunos(lista):
        """
        Cria uma cópia de uma lista de alunos.

        """
        return [Aluno(aluno.nome, aluno.idade) for aluno in lista]

