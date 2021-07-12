class CarrinhoDeCompras:
    def __init__(self):
        self.itens = []

    def inserir_item(self, item):
        self.itens.append(item)

    def lista_item(self):
        for item in self.itens:
            print(item.nome, item.valor)

    def soma_total(self):
        total = 0
        for item in self.itens:
            total += item.valor
        return total


class Item:
    def __init__(self, nome, valor):
        self.nome = nome
        self.valor = valor


carrinho = CarrinhoDeCompras()

i1 = Item('Armadura', 500)
i2 = Item('Espada', 200)
i3 = Item('Poção de vida', 100)

carrinho.inserir_item(i1)
carrinho.inserir_item(i2)
carrinho.inserir_item(i3)
carrinho.inserir_item(i2)

carrinho.lista_item()
print(carrinho.soma_total())
