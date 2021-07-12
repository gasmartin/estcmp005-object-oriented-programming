class Cachorro:
    def __init__(self, nome, comendo=False, latindo=False):
        self.nome = nome
        self.comendo = comendo
        self.latindo = latindo

    def comer(self):
        print(f'{self.nome} está comendo.')
        self.comendo = True

    def latir(self):
        print(f'{self.nome} está latindo.')
        self.latindo = True


c1 = Cachorro('Luke')
c2 = Cachorro('Noah')

c1.comer()
c2.latir()
