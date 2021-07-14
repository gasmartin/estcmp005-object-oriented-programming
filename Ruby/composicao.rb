class Adicionar
    def incrementar (x)
        x +=1
    end
end

class Sup
    def initialize; end

    def somar (x)
        Adicionar.new.incrementar(x)
    end
end

puts Sup.new.somar(5)