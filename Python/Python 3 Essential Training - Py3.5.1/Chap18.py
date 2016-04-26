import sys
import time

__version__ = "1.1.0"

class numwords():
    """
        return a number as words,
        e.g., 42 becomes "forty-two"
    """
    _words = {
        'ones': (
            'oh', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'
        ), 'tens': (
            '', 'ten', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'
        ), 'teens': (
            'ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen' 
        ), 'quarters': (
            'o\'clock', 'quarter', 'half'
        ), 'range': {
            'hundred': 'hundred'
        }, 'misc': {
            # there was an error above here, it was a missing comma before the 'misc'.
            'minus': 'minus'
        }
    }
    _oor = 'OOR'    # Out Of Range

    def __init__(self, n):
        self.__number = n;

    def numwords(self, num = None):
        "Return the number as words"
        n = self.__number if num is None else num
        s = ''
        if n < 0:           # negative numbers
            s += self._words['misc']['minus'] + ' '
            n = abs(n)
        if n < 10:          # single-digit numbers
            s += self._words['ones'][n]  
        elif n < 20:        # teens
            s += self._words['teens'][n - 10]
        elif n < 100:       # tens
            m = n % 10
            t = n // 10
            s += self._words['tens'][t]
            if m: s += '-' + numwords(m).numwords()    # recurse for remainder
        elif n < 1000:      # hundreds
            m = n % 100
            t = n // 100
            s += self._words['ones'][t] + ' ' + self._words['range']['hundred']
            if m: s += ' ' + numwords(m).numwords()    # recurse for remainder
        else:
            s += self._oor
        return s

    def number(self):
        "Return the number as a number"
        return str(self.__number);

class saytime(numwords):
    """
        return the time (from two parameters) as words,
        e.g., fourteen til noon, quarter past one, etc.
    """

    _specials = {
        # the _specials wasn't in line with the indentations of the lines above.
        'noon': 'noon',
        'midnight': 'midnight',
        'til': 'til',
        'past': 'past'
    }

    def __init__(self, h, m):
        self._hour = abs(int(h))
        self._min = abs(int(m))

    def words(self):
        h = self._hour
        m = self._min
        
        if h > 23: return self._oor     # OOR errors
        if m > 59: return self._oor

        sign = self._specials['past']        
        if self._min > 30:
            sign = self._specials['til']
            h += 1
            m = 60 - m
        if h > 23: h -= 24
        elif h > 12: h -= 12

        # hword is the hours word)
        if h is 0: hword = self._specials['midnight']
        elif h is 12: hword = self._specials['noon']
        else: hword = self.numwords(h)

        if m is 0:
            if h in (0, 12): return hword   # for noon and midnight
            else: return "{} {}".format(self.numwords(h), self._words['quarters'][m])
        if m % 15 is 0:
            return "{} {} {}".format(self._words['quarters'][m // 15], sign, hword) 
        return "{} {} {}".format(self.numwords(m), sign, hword) 

    def digits(self):
        "return the traditionl time, e.g., 13:42"
        return "{:02}:{:02}".format(self._hour, self._min)

class saytime_t(saytime):   # wrapper for saytime to use time object
    """
        return the time (from a time object) as words
        e.g., fourteen til noon
    """
    def __init__(self, t):
        self._hour = t.tm_hour
        self._min = t.tm_min

def main():
    if len(sys.argv) > 1:
        if sys.argv[1] == 'test':
            test()
        else:
            try: print(saytime(*(sys.argv[1].split(':'))).words())
            except TypeError: print("Invalid time ({})".format(sys.argv[1]))
    else:
        print(saytime_t(time.localtime()).words())
        # was set as (time.localtime) so it was treating it like an attribute rather than a function.
        # similarly .words should be .words().

def test():
    print("\nnumbers test:")
    list = (
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 15, 19, 20, 30, 
        50, 51, 52, 55, 59, 99, 100, 101, 112, 900, 999, 1000 
    )
    for l in list:
        print(l, numwords(l).numwords())

    print("\ntime test:")
    list = (
        (0, 0), (0, 1), (11, 0), (12, 0), (13, 0), (12, 29), (12, 30),
        (12, 31), (12, 15), (12, 30), (12, 45), (11, 59), (23, 15), 
        (23, 59), (12, 59), (13, 59), (1, 60), (24, 0)
    )
    for l in list:
        print(saytime(*l).digits(), saytime(*l).words())

    print("\nlocal time is " + saytime_t(time.localtime()).words())

if __name__ == "__main__": main()

# -- CONTROLLER --

class AnimalActions:
    def bark(self): return self._doAction('bark')
    def fur(self): return self._doAction('fur')
    def quack(self): return self._doAction('quack')
    def feathers(self): return self._doAction('feathers')

    def _doAction(self, action):
        if action in self.strings:
            return self.strings[action]
        else:
            return 'The {} has no {}'.format(self.animalName(), action)

    def animalName(self):
        return self.__class__.__name__.lower()

# -- MODEL -- 

class Duck(AnimalActions):
    strings = dict(
        quack = "Quaaaaak!",
        feathers = "The duck has gray and white feathers."
        # Error caused by mispelled feathers above.
    )
 
class Person(AnimalActions):
    strings = dict(
        bark = "The person says woof!",
        fur = "The person puts on a fur coat.",
        quack = "The person imitates a duck.",
        feathers = "The person takes a feather from the ground and shows it."
    )

class Dog(AnimalActions):
    strings = dict(
        bark = "Arf!",
        fur = "The dog has white fur with black spots.",
    )

# -- VIEW -- 

def in_the_doghouse(dog):
    print(dog.bark())
    print(dog.fur())

def in_the_forest(duck):
    print(duck.quack())
    print(duck.feathers())
    # This example is only runtime errors, and feathers above was missing ().
 
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

class inclusive_range:
    def __init__(self, *args):
        numargs = len(args)
        if numargs < 1: raise TypeError('Requires at least one argument')
        elif numargs == 1:
            self.start = 0
            self.stop = args[0]
            self.step = 1
        elif numargs == 2:
            (self.start, self.stop) = args
            step = 1
        elif numargs == 3:
            (self.start, self.stop, self.step) = args
            # the above were assigned in the wrong order.
        else: raise TypeError('inclusiveRange expected at most 3 arguments, got {}'.format(numargs))

    def __iter__(self):
        i = self.start
        while i <= self.stop:
            # was a typo above in operator.
            yield i
            i += self.step

def main():
    o = inclusive_range(4, 25, 3)
    for i in o: print(i, end = ' ')

if __name__ == "__main__": main()
# This example is for logical errors, where the code is not working like you had intended.

import saytime
import unittest

class TestSaytime(unittest.TestCase):
    def setUp(self):
        self.nums = list(range(11))

    def test_numbers(self):
        # make sure the numbers translate correctly
        words = (
            'oh', 'one', 'two', 'three', 'four', 'five',
            'six', 'seven', 'eight', 'nine', 'ten'
        )
        for i, n in enumerate(self.nums):
            self.assertEqual(saytime.numwords(n).numwords(), words[i])

    def test_time(self):
        time_tuples = (
            (0, 0), (0, 1), (11, 0), (12, 0), (13, 0), (12, 29), (12, 30),
            (12, 31), (12, 15), (12, 30), (12, 45), (11, 59), (23, 15), 
            (23, 59), (12, 59), (13, 59), (1, 60), (24, 0)
        )
        time_words = (
            "midnight",
            "one past midnight",
            "eleven o'clock",
            "noon",
            "one o'clock",
            "twenty-nine past noon",
            "half past noon",
            "twenty-nine til one",
            "quarter past noon",
            "half past noon",
            "quarter til one",
            "one til noon",
            "quarter past eleven",
            "one til midnight",
            "one til one",
            "one til two",
            "OOR",
            "OOR"
        )
        for i, t in enumerate(time_tuples):
            self.assertEqual(saytime.saytime(*t).words(), time_words[i])

if __name__ == "__main__": unittest.main()
# Example using unit tests
