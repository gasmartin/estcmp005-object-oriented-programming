class Subject

    def attach(observer)
      raise NotImplementedError, "#{self.class} has not implemented method '#{__method__}'"
    end
  
    def detach(observer)
      raise NotImplementedError, "#{self.class} has not implemented method '#{__method__}'"
    end
  
    def notify
      raise NotImplementedError, "#{self.class} has not implemented method '#{__method__}'"
    end
  end
  

  class ConcreteSubject < Subject

    attr_accessor :state
    
    def initialize
      @observers = []
    end
  
    def attach(observer)
      puts 'Atenção: um observador foi acoplado.'
      @observers << observer
    end

    def detach(observer)
      @observers.delete(observer)
    end
  
    def notify
      puts 'Atenção: Notificando observadores...'
      @observers.each { |observer| observer.update(self) }
    end
  
    def some_business_logic
      puts "\nAtenção: Estou fazendo algo importante."
      @state = rand(0..10)
  
      puts "Atenção: Meu estado mudou para: #{@state}"
      notify
    end
  end
  
  class Observer

    def update(_subject)
      raise NotImplementedError, "#{self.class} has not implemented method '#{__method__}'"
    end
  end
  
  class ConcreteObserverA < Observer

    def update(subject)
      puts 'Concrete Observer A: Reagiu ao evento' if subject.state < 3
    end
  end
  
  class ConcreteObserverB < Observer

    def update(subject)
      return unless subject.state.zero? || subject.state >= 2
  
      puts 'Concrete Observer B: Reagiu ao evento'
    end
  end
  
  subject = ConcreteSubject.new
  
  observer_a = ConcreteObserverA.new
  subject.attach(observer_a)
  
  observer_b = ConcreteObserverB.new
  subject.attach(observer_b)
  
  subject.some_business_logic
  subject.some_business_logic
  
  subject.detach(observer_a)
  
  subject.some_business_logic