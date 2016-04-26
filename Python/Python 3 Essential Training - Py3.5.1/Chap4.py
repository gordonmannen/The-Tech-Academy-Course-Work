def main():
    print("This is the Chap4.py file.")

if __name__ == "__main__": main()

def main2():
    for n in primes(): # generate a list of prime numbers
        if n > 100: break
        print(n)

def isprime(n):
    if n == 1: # one is never prime
        return False
    for x in range(2, n):
        if n % x == 0:
            return False # found a divisor, not prime
    else:
        return True

def primes(n = 1):
   while(True):
       if isprime(n): yield n
       n += 1 

if __name__ == "__main__": main2()

# Whitespace in Python, the indentations let Python know that the lines below that are
# indented have a relationship to the line above, etc.  The indents need to be consistent
# in length or Python gets confused.  The indents indicated a block or suite of text where
# curly braces might be used in say JavaScript.
# In a single line, the whitespace isn't significant, you can have multiple spaces in certain
# areas and it generally will not affect how the code runs.

# Comments in Python (and other languages), should help make the code more readable
# and help in understanding what it does or remembering what it does for yourself.


def main():
    a = 1
    print(a)

if __name__ == "__main__": main()

def main():
    a = (1, 2, 3, 4, 5)
    # This is a tuple when we put in in parentheses
    print(a)

if __name__ == "__main__": main()

# Two types of conditions in Python, conditional execution and conditional values.

# Example of conditional execution

def main():
    a, b = 0, 1
    if a < b:
        print("a is less than b")
        # whenever we use a colon there will be a block or suite of code under it.
    elif a > b:
        print("a is greater than b")
    else:
        print("a is equal to b")

if __name__ == "__main__": main()

# Example of conditional values

def main():
    a, b = 0, 1
    s = "Less than" if a < b else "not less than"
    print(s)

if __name__ == "__main__": main()

def main2():
   func() 

def func():
    for i in range(10):
        print(i, end=' ')
    print()
    
if __name__ == "__main__": main2()

class Egg:
    def __init__(self, kind = "fried"):
        self.kind = kind

    def whatKind(self):
        return self.kind

def main3():
   fried = Egg()
   scrambled = Egg('scrambled')
   print(fried.whatKind())
   print(scrambled.whatKind())
    
if __name__ == "__main__": main3()
