class Produto
    def initialize(id, nome, preco)
        @id = id
        @nome = nome
        @preco = preco
    end
    attr_accessor :id, :nome, :preco
end

class Carrinhos
    def initialize
        @cesta = []
    end

    def addProduto (produto)
        @cesta << produto
    end

    def itens
        @quantidade = @cesta.length
    end 
    attr_accessor :cesta
end

p1 = Produto.new(01, "Coca", 2.99)
p2 = Produto.new(02, "Leite", 5.99)

carro = Carrinhos.new
carro.addProduto(p1)
puts carro.cesta[0].nome
carro.addProduto(p2)
puts carro.cesta[1].nome
puts carro.itens