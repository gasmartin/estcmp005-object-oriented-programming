class Pai
    def falar
        puts "Pai tá On."
    end
end

class Filho < Pai 
    def falar
        puts "Filho tá On."
    end
end

Pai.new.falar
Filho.new.falar