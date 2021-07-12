class Personagem:
    def __init__(self, nome):
        self.nome = nome
        self.item = None


class Arco:
    def usar(self):
        print('Usando arco e flecha...')


class Lanca:
    def usar(self):
        print('Usando a lança...')


p1 = Personagem('Aloy')
arco = Arco()
lanca = Lanca()

p1.item = arco
p1.item.usar()

p1.item = lanca
p1.item.usar()
