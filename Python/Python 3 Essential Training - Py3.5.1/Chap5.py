x = 42
print(x)

# id and type will show in the shell, I would need to write these differently
# for them to show up when running this file.
id(x)
type(x)

# Objects in Python are mutable or immutable
# Mutable objects may change value, immutable may not
# In some cases it may appear that value changes, but the distinction
# is visible using id()
# Container objects(tuples, lists, etc.) may appear to change value

x = 42
# if you change x to = 43 it will really cause this to become a different object,
# rather than changing the value, integers are immutable.  So if look in the shell
# and do a id(x) when the x = 42 and when x = 43 you will get two different ids.
# If you then switch back to x = 42 it will return to that previous id associated
# with x = 42.

# Most fundamental types in Python are immutable:
    # numbers, strings, tuples
# Mutable objects include
    # lists, dictionaries, other objects depending upon implementation.

def main():
    num = 42
    print(type(num), num)

if __name__ == "__main__": main()

def main():
    num = 42.0
    print(type(num), num)

if __name__ == "__main__": main()

def main():
    num = 42 / 9
    print(type(num), num)

if __name__ == "__main__": main()

def main():
    num = 42 // 9
    print(type(num), num)

if __name__ == "__main__": main()

def main():
    num = round(42 / 9)
    print(type(num), num)

if __name__ == "__main__": main()

def main():
    num = round(42 / 9, 2)
    print(type(num), num)

if __name__ == "__main__": main()

def main():
    num = 42 % 9
    print(type(num), num)

if __name__ == "__main__": main()
# returns the remainder.

def main():
    num = int(42.9)
    print(type(num), num)

if __name__ == "__main__": main()

def main():
    num = float(42)
    print(type(num), num)

if __name__ == "__main__": main()


def main():
    s = r"This is a/nstring!"
    print(s)

if __name__ == "__main__": main()

def main():
    n = 42
    s = "This is a {} string!".format(n)
    print(s)

# Best to code Python using the 3.x version method, because eventually the Python 2.0
# methods will no longer be supported and some of those methods have been made obsolete
# using the 3.0+ versions of Python.
# format is a method of the string object.

if __name__ == "__main__": main()

def main():
    n = 42
    s = '''\
this is a string
line after line
of text and more
text.
'''
    print(s)

if __name__ == "__main__": main()
# the triple ''' or triple """ is often used for docstrings in functions.

def main():
    x = (1, 2, 3)
    print(type(x), x)

if __name__ == "__main__": main()
# Immutable

def main():
    x = [1, 2, 3]
    print(type(x), x)

if __name__ == "__main__": main()
# Mutable

def main():
    x = [1, 2, 3]
    x.append(5)
    x.insert(0, 7)
    print(type(x), x)

if __name__ == "__main__": main()
# Mutable

def main():
    x = 'string'
    print(type(x), x)

if __name__ == "__main__": main()


def main():
    x = 'string'
    print(type(x), x[2])

if __name__ == "__main__": main()

def main():
    x = 'string'
    print(type(x), x[2:4])

if __name__ == "__main__": main()
# This one is setup to return a slice of the string.

def main():
    x = (1, 2, 3, 4, 5)
    for i in x:
        print(i)

if __name__ == "__main__": main()

def main():
    x = "string"
    for i in x:
        print(i)

if __name__ == "__main__": main()
# this will work examptly as the tuple above.
# (tuple) - immutable, [list] - mutable,'string' - immutable sequence

def main():
    d = {'one': 1, 'two': 2, 'three': 3, 'four': 4, 'five': 5}
    for k in d:
        print(k, d[k])

if __name__ == "__main__": main()
# {dictionary} - like an associative array or hash in other prog languages.

def main():
    d = {'one': 1, 'two': 2, 'three': 3, 'four': 4, 'five': 5}
    for k in sorted(d.keys()):
        print(k, d[k])

if __name__ == "__main__": main()
# if you want it to be sorted in a certain way.

def main():
    d = dict(
        one = 1, two = 2, three = 3, four = 4, five = 5
    )
    d['seven'] = 7
    for k in sorted(d.keys()):
        print(k, d[k])

if __name__ == "__main__": main()
# This is the more refined, cleaner way to define a dictionary
# Dictionaries are mutuable, we can add and change things

x = 42
x
y = 42
y
print(x == y) # compares value
print(x is y) # compares id
x = dict( x = 42 )
print(id(x))
y = dict( x = 42 )
print(id(y))
# won't be the same because dictionaries are immutable.
print(x == y) # compares value
print(x is y) # compares id

a, b = 0, 1
print(a == b)
print(a < b)
print(a > b)
a = True
print(type(a), a)

