print("Hello, World!")


a, b = 0, 1
if a < b:
    print('a ({}) is less than b ({})'.format(a, b))
else:
    print('a ({}) is not less than b ({})'.format(a, b))

a, b = 5, 1
if a < b:
    print('a ({}) is less than b ({})'.format(a, b))
else:
    print('a ({}) is not less than b ({})'.format(a, b))

# blocks are called suites in the Python documentation.
# 4 spaces is the traditional Python indentation, but one space would also work.

print("foo" if a < b else "bar")

a, b = 0, 1
print("foo" if a < b else "bar")

# simple fibonacci series
# the sum of two elements defines the next set
a, b = 0, 1
while b < 50:
    print(b)
    a, b = b, a + b

# read the lines from the file
# for loops work with iterators
fh = open('lines.txt')
for line in fh.readlines():
    print(line, end='')

def isprime(n):
    if n == 1:
        print("1 is special")
        return False
    for x in range(2, n):
        if n % x == 0:
            print("{} equals {} x {}".format(n, x, n // x))
    else:
        print(n, "is a prime number")
        return True

# the variable used here can be called n, but it isn't actually the same n as that
# referenced above, so it might make it clearer to use a different letter.
for x in range(1, 20):
    isprime(x)

def isprime(n):
    if n == 1:
        return False
    for x in range(2, n):
        if n % x == 0:
            return False
    else:
        return True

def primes(n = 1):
   while(True):
       if isprime(n): yield n
       n += 1 

for n in primes():
    if n > 100: break
    print(n)

# simple fibonacci series
# the sum of two elements defines the next set
# class - the definition or blueprint used to create an object.  Objects are instances of classes.
# self is a traditional choice for the first instance, it doesn't have to be used, but is common.
# the init function is a constructor.
class Fibonacci():
    def __init__(self, a, b):
        self.a = a
        self.b = b

    def series(self):
        while(True):
            yield(self.b)
            self.a, self.b = self.b, self.a + self.b

# instantiating, creating an instance of the class (that instance is an object).
f = Fibonacci(0, 1)
for r in f.series():
    if r > 100: break    
    print(r, end=' ')


            
