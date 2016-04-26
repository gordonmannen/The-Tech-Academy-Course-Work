s = 'This is a string'
s
s.upper()
'This is a string'.upper() # As an object it can instead be affected directly.
'This is a string {}'.format(42)
# a string is an object and a variable containing a string is really just a variable
# that contains a reference to a string object.  Everything you can do on that string
# object you can do on the string itself, because the string itself IS the string object.

s = 'this is a sring'
print(s)
print(s.capitalize())
print(s.upper())
print(s.lower())
print(s.swapcase())
print(s.find('is'))
print(id(s))
newstring = s.upper()
print(newstring)
print(id(newstring))
x = 'This is another string            '
print(x.strip())

a, b = 5, 43
print(a, b)
print('this is {}, that is {}'.format(a, b))
s = 'this is {}, that is {}'
print(s)
print(s.format(a, b))
print(id(s))
new = s.format(a, b)
print(id(new))
'this is %d, that is %d' % ( a, b )
# This was the old Python 2 method and you needed to know what the 'type' was, the
# new method for Python 3 is known as the repr method > you don't need to know what
# type the variables are in order to use format.
print('this is {}, that is {}'.format(b, a))
print('this is {1}, that is {0}'.format(a, b))
print('this is {1}, that is {0}, this too is {1}'.format(a, b))
print('this is {bob}, that is {fred}'.format( bob = a, fred = b ))
d = dict(bob = a, fred = b)
print('this is {bob} and that is {fred}'.format(**d))

s = 'This is a string of words'
print(s.split())
x = 'This     is   a   string    of          words'
print(x.split())
print(x.split('i'))
words = s.split()
print(words)
for w in words: print(w)
new = ':'.join(words)
print(new)
# Splitting and joining strings
      
# The Python documentation library has all of the information on what you can do to strings,
# and so on (40 different string methods?!?).

s = 'this is a string Again'
print(s)
new = s.center(80)
print(new)

def main():
    s = 'this is a string'
    print(s.capitalize())
    print(s.title())
    print(s.upper())
    print(s.swapcase())
    print(s.find('is'))
    print(s.replace('this', 'that'))
    print(s.strip())
    print(s.isalnum())
    print(s.isalpha())
    print(s.isdigit())
    print(s.isprintable())

if __name__ == "__main__": main()
# In Python everything is an object (including strings).
