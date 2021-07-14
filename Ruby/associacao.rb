class Usuario
    @nome
    @email
    @amigos

    def initialize (nome, email)
        @nome = nome
        @email = email
        @amigo = []
    end

    def addAmigos(usuario)
        @amigo << usuario
    end

    attr_accessor :nome
    attr_accessor :email
end


gabriel = Usuario.new("Gabriel Sena", "gssm.snf19@uea.edu.br")
alexander = Usuario.new("Gabriel Alexander", "gafdlt.snf19@uea.edu.br")

puts gabriel.addAmigos(alexander)
puts alexander.addAmigos(gabriel)

puts gabriel.nome
puts alexander.nome

