class Personagem:
    def __init__(self, nome):
        self.nome = nome
        self.nomeclasse = self.__class__.__name__

    def levelup(self):
        print(f'A {self.nomeclasse} {self.nome} subiu de nível!')


class Jedi(Personagem):
    def usar_forca(self):
        print(f'A {self.nomeclasse} {self.nome} está usando a força...')


class Mecanica(Personagem):
    def reparar(self):
        print(f'A {self.nomeclasse} {self.nome} está fazendo reparos...')


p1 = Jedi('Amira')
p1.levelup()
p1.usar_forca()

p2 = Mecanica('Lief')
p2.levelup()
p2.reparar()
