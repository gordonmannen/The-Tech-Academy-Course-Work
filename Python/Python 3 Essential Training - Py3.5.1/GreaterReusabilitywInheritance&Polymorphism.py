class AnimalActions:
    def quack(self): return self.strings['quack']
    def feathers(self): return self.strings['feathers']
    def bark(self): return self.strings['bark']
    def fur(self): return self.strings['fur']

class Duck(AnimalActions):
    strings = dict(
        quack = "Quaaaaak!",
        feathers = "The duck has gray and white feathers.",
        bark = "The duck cannot bark.",
        fur = "The duck has no fur."
    )
 
class Person(AnimalActions):
    strings = dict(
        quack = "The person imitates a duck.",
        feathers = "The person takes a feather from the ground and shows it.",
        bark = "The person says woof!",
        fur = "The person puts on a fur coat."
    )

class Dog(AnimalActions):
    strings = dict(
        quack = "The dog cannot quack.",
        feathers = "The dog has no feathers.",
        bark = "Arf!",
        fur = "The dog has white fur with black spots."
    )

def in_the_doghouse(dog):
    print(dog.bark())
    print(dog.fur())

def in_the_forest(duck):
    print(duck.quack())
    print(duck.feathers())
 
def main():
    donald = Duck()
    john = Person()
    fido = Dog()

    print("- In the forest:")
    for o in ( donald, john, fido ):
        in_the_forest(o)

    print("- In the doghouse:")
    for o in ( donald, john, fido ):
        in_the_doghouse(o)
 
if __name__ == "__main__": main()

# Below is the same thing, but uses the Model-View-Controller pattern of OOP.

class AnimalActions2:
    def bark(self): return self._doAction('bark')
    def fur(self): return self._doAction('fur')
    def quack(self): return self._doAction('quack')
    def feathers(self): return self._doAction('feathers')

    def _doAction(self, action):
        # the underscore with _doAction tells us that this function is going to be called internally, you are
        # only going to want to call it from inside the object or inside the class.
        if action in self.strings:
            return self.strings[action]
        else:
            return 'The {} has no {}'.format(self.animalName(), action)

    def animalName(self):
        return self.__class__.__name__.lower()

# -- MODEL -- 

class Duck(AnimalActions2):
    strings = dict(
        quack = "Quaaaaak!",
        feathers = "The duck has gray and white feathers."
    )
 
class Person(AnimalActions2):
    strings = dict(
        bark = "The person says woof!",
        fur = "The person puts on a fur coat.",
        quack = "The person imitates a duck.",
        feathers = "The person takes a feather from the ground and shows it."
    )

class Dog(AnimalActions2):
    strings = dict(
        bark = "Arf!",
        fur = "The dog has white fur with black spots.",
    )

# -- CONTROLLER -- 

def in_the_doghouse(dog):
    print(dog.bark())
    print(dog.fur())

def in_the_forest(duck):
    print(duck.quack())
    print(duck.feathers())
 
def main():
    donald = Duck()
    john = Person()
    fido = Dog()

    print("-- In the forest:")
    for o in ( donald, john, fido ):
        in_the_forest(o)

    print("-- In the doghouse:")
    for o in ( donald, john, fido ):
        in_the_doghouse(o)
 
if __name__ == "__main__": main()
