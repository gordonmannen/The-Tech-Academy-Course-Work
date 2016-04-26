class Duck:
    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

def main():
    donald = Duck()
    donald.quack()
    donald.walk()

if __name__ == "__main__": main()

class Duck:
    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

def main():
    donald = Duck()
    print(donald)
    donald.quack()
    donald.walk()
# Duck is the class, donald is an instance of Duck (so donald is an object), and
# the quack and walk functions call a method which in this case is self.
# functions that are attributes of an object are methods.

if __name__ == "__main__": main()

class Duck:
    def __init__(self):
        print('constructor')

    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

def main():
    donald = Duck()
    donald.quack()
    donald.walk()

if __name__ == "__main__": main()

class Duck:
    def __init__(self, value):
        self._v = value

    def quack(self):
        print('Quaaack!', self._v)

    def walk(self):
        print('Walks like a duck.', self._v)

def main():
    donald = Duck(47)
    donald.quack()
    donald.walk()

if __name__ == "__main__": main()
# Encapsulation

class Duck:
    def __init__(self, value):
        self._v = value

    def quack(self):
        print('Quaaack!', self._v)

    def walk(self):
        print('Walks like a duck.', self._v)

def main():
    donald = Duck(47)
    frank = Duck(151)
    donald.quack()
    donald.walk()
    frank.quack()
    frank.walk()

if __name__ == "__main__": main()
# Encapsulation
# First argument is self and that argument doesn't get passed explicitly.  It is passed
# implicitly through the dot operator.

class Duck:
    def __init__(self, color = 'white'):
        self._color = color # the underscore before the color is to remind us this is
        # an attribute that we are only going to be using directly, we won't be accessing
        # this variable from outside of the object.
        
    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

def main():
    donald = Duck()
    print(donald._color)
    donald._color = 'blue'
    print(donald._color)

if __name__ == "__main__": main()

class Duck:
    def __init__(self, color = 'white'):
        self._color = color
        
    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

    def set_color(self, color):
        self._color = color

    def get_color(self):
        return self._color

def main():
    donald = Duck()
    print(donald.get_color())
    donald.set_color('blue')
    print(donald.get_color()) 
    
if __name__ == "__main__": main()
# This is the same thing, but using accessor methods

class Duck:
    def __init__(self, **kwargs):
        self._color = kwargs.get('color', 'white')
        
    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

    def set_color(self, color):
        self._color = color

    def get_color(self):
        return self._color

def main():
    donald = Duck(color = 'blue')
    print(donald.get_color()) 
    
if __name__ == "__main__": main()
# Example with kwargs - very applicable when you start to get many different flags,
# attributes, values, and need a dictionary to bring the data together.

class Duck:
    def __init__(self, **kwargs):
        self._color = kwargs.get('color', 'white')
        
    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

    def set_color(self, color):
        self._color = color

    def get_color(self):
        return self._color

def main():
    donald = Duck()
    print(donald.get_color()) 
    
if __name__ == "__main__": main()
# This method scales, where the previous example does not.

class Duck:
    def __init__(self, **kwargs):
        self.variables = kwargs
        
    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

    def set_color(self, color):
        self.variables['color'] = color

    def get_color(self):
        return self.variables.get('color', None)

def main():
    donald = Duck(feet = 2)
    print(donald.get_color()) 
    
if __name__ == "__main__": main()
# The feet thing hasn't had anything set up for it yet, so there nothing will be
# printed out yet.

class Duck:
    def __init__(self, **kwargs):
        self.variables = kwargs
        
    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

    def set_variable(self, k, v):
        self.variables[k] = v

    def get_variable(self, k):
        return self.variables.get(k, None)

def main():
    donald = Duck(feet = 2)
    donald.set_variable('color', 'blue')
    print(donald.get_variable('feet')) 
    print(donald.get_variable('color'))
    
if __name__ == "__main__": main()
# kwargs allow for a lot of flexibility and make it easy to set, get, and control data.

class Animal:
    def talk(self): print('I have something to say!')
    def walk(self): print('Hey!  I''m walkin'' here!')
    def clothes(self): print('I have nice clothes!')

class Duck(Animal):
    # Now Duck 'is a' (as in Duck 'is an' Animal > OOP speak for Duck inherits properties of Animal)
    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

def main():
    donald = Duck()
    donald.quack()
    donald.walk()
    donald.clothes()

if __name__ == "__main__": main()

class Animal:
    def talk(self): print('I have something to say!')
    def walk(self): print('Hey!  I''m walkin'' here!')
    def clothes(self): print('I have nice clothes!')

class Duck(Animal):
    # Now Duck 'is a' (as in Duck 'is an' Animal > OOP speak for Duck inherits properties of Animal)
    def quack(self):
        print('Quaaack!')

    def walk(self):
        super().walk()
        print('Walks like a duck.') 

def main():
    donald = Duck()
    donald.quack()
    donald.walk()
    donald.clothes()

if __name__ == "__main__": main()
# Need to add an additional piece of code (see def walk above) in order for 'donald'
# to do the inherited walk function as well as the Duck walk function, without that
# the Duck walk function overrides the inherited walk function.

class Animal:
    def talk(self): print('I have something to say!')
    def walk(self): print('Hey!  I''m walkin'' here!')
    def clothes(self): print('I have nice clothes!')

class Duck(Animal):
    # Now Duck 'is a' (as in Duck 'is an' Animal > OOP speak for Duck inherits properties of Animal)
    def quack(self):
        print('Quaaack!')

    def walk(self):
        super().walk()
        print('Walks like a duck.')

class Dog(Animal):
    def clothes(self):
        print('I have brown and white fur')

def main():
    donald = Duck()
    donald.quack()
    donald.walk()
    donald.clothes()

    fido = Dog()
    fido.walk()
    fido.clothes()
    

if __name__ == "__main__": main()
# Once this is setup it is quite easy to add additional Animals.

class Duck:
    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

    def bark(self):
        print('The duck cannot bark')

    def fur(self):
        print('The duck has feathers')

class Dog:
    def bark(self):
        print('Woof!')

    def fur(self):
        print('The dog has brown and white fur')

    def walk(self):
        print('Walks like a dog')

    def quack(self):
        print('The dog cannot quack')

def main():
    donald = Duck()
    fido = Dog()

    for o in (donald, fido):
        o.quack()
        o.walk()
        o.bark()
        o.fur()

if __name__ == "__main__": main()
# Polymorphism

class Duck:
    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

    def bark(self):
        print('The duck cannot bark')

    def fur(self):
        print('The duck has feathers')

class Dog:
    def bark(self):
        print('Woof!')

    def fur(self):
        print('The dog has brown and white fur')

    def walk(self):
        print('Walks like a dog')

    def quack(self):
        print('The dog cannot quack')

def main():
    donald = Duck()
    fido = Dog()
    in_the_forest(donald)
    in_the_pond(fido)

def in_the_forest(dog):
    dog.bark()
    dog.fur()

def in_the_pond(duck):
    duck.walk()
    duck.quack()

if __name__ == "__main__": main()
# Polymorphism > Python is referred to as 'duck typing' because polymorphism is
# natural in Python, if it walks like a duck you can use it like a duck.

def main():
    o = range(25)
    for i in o: print(i, end = ' ')

if __name__ == "__main__": main()

def main():
    o = range(5, 25, 2) # range takes up to three arguments, start/stop/step
    for i in o: print(i)

if __name__ == "__main__": main()

class inclusive_range:
    def __init__(self, *args): # __init__ is for constructors
        numargs = len(args)
        if numargs < 1: raise TypeError('requires at least one argument')
        elif numargs == 1:
            self.stop = args[0]
            self.start = 0
            self.step = 1
        elif numargs == 2:
            (self.start, self.stop) = args
            self.step = 1
        elif numargs == 3:
            (self.start, self.stop, self.step) = args
        else: raise TypeError('expected at most 3 arguments, got {}'.format(numargs))

    def __iter__(self): # __iter__ is for making the object an iterable object
        i = self.start
        while i <= self.stop:
            yield i
            i += self.step

def main():
    o = inclusive_range(25)
    for i in o: print(i, end = ' ')

if __name__ == "__main__": main()

class inclusive_range:
    def __init__(self, *args): # __init__ is for constructors
        numargs = len(args)
        if numargs < 1: raise TypeError('requires at least one argument')
        elif numargs == 1:
            self.stop = args[0]
            self.start = 0
            self.step = 1
        elif numargs == 2:
            (self.start, self.stop) = args
            self.step = 1
        elif numargs == 3:
            (self.start, self.stop, self.step) = args
        else: raise TypeError('expected at most 3 arguments, got {}'.format(numargs))

    def __iter__(self): # __iter__ is for making the object an iterable object
        i = self.start
        while i <= self.stop:
            yield i
            i += self.step

def main():
    o = inclusive_range(5, 25)
    for i in o: print(i)

if __name__ == "__main__": main()

class inclusive_range:
    def __init__(self, *args): # __init__ is for constructors
        numargs = len(args)
        if numargs < 1: raise TypeError('requires at least one argument')
        elif numargs == 1:
            self.stop = args[0]
            self.start = 0
            self.step = 1
        elif numargs == 2:
            (self.start, self.stop) = args
            self.step = 1
        elif numargs == 3:
            (self.start, self.stop, self.step) = args
        else: raise TypeError('expected at most 3 arguments, got {}'.format(numargs))

    def __iter__(self): # __iter__ is for making the object an iterable object
        i = self.start
        while i <= self.stop:
            yield i
            i += self.step

def main():
    o = inclusive_range(5, 25, 7)
    for i in o: print(i, end = ' ' )

if __name__ == "__main__": main()

class Duck:
    def __init__(self, **kwargs):
        self.properties = kwargs

    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

    def get_properties(self):
        return self.properties

    def get_property(self, key):
        return self.properties.get(key, None)

def main():
    donald = Duck(color = 'blue')
    print(donald.get_property('color'))

if __name__ == "__main__": main()

class Duck:
    def __init__(self, **kwargs):
        self.properties = kwargs

    def quack(self):
        print('Quaaack!')

    def walk(self):
        print('Walks like a duck.')

    def get_properties(self):
        return self.properties

    def get_property(self, key):
        return self.properties.get(key, None)

    @property
    def color(self):
        return self.properties.get('color', None)

    @color.setter
    def color(self, c):
        self.properties['color'] = c

    @color.deleter
    def color(self):
        del self.properties['color']

def main():
    donald = Duck()
    donald.color = 'blue'
    print(donald.color)

if __name__ == "__main__": main()
# Decorators fundamentally change the behavior of a function, so they can be called
# with simple normal properties syntax.

