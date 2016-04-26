def main():
    testfunc()

def testfunc():
    print('This is a test function')

if __name__ == "__main__": main()
# function has to be defined before it can be called.

def main1():
    testfunc()

def testfunc():
    pass

if __name__ == "__main__": main1()
# pass can be used as a placeholder, it is a stub, it makes the suite syntactically
# correct, but it won't actually do anything.  It can however, be useful for testing.

def main2():
    testfunc(42)

def testfunc(number):
    print('This is a test function', number)

if __name__ == "__main__": main2()

def main3():
    testfunc(42, 43, 75)

def testfunc(number, another, onemore):
    print('This is a test function', number, another, onemore)

if __name__ == "__main__": main3()
# Once you add additional positional arguments you must include values for those arguments
# or the call will return an error explaining that in this case three arguments are required.

def main4():
    testfunc(42)

def testfunc(number, another = 43, onemore = 75):
    print('This is a test function', number, another, onemore)

if __name__ == "__main__": main4()
# Doing it this way makes some of the arguments optional and provides default values so you can
# provide less than the full 'three in this case' arguments and not have errors returned.

def main5():
    testfunc(42, 16)

def testfunc(number, another = 43, onemore = 75):
    print('This is a test function', number, another, onemore)

if __name__ == "__main__": main5()
# Alternatively, if desired you could use the special value None so that if no value
# was provided for that argument it would return None in that position when the
# function is called.

def main6():
    testfunc(42, 61)

def testfunc(number, another = 43, onemore = 75):
    if another is None:
        another = 112
    print('This is a test function', number, another, onemore)

if __name__ == "__main__": main6()

def main7():
    testfunc(1, 2, 3, 42, 43, 45, 46)

def testfunc(this, that, other, *args):
    print(this, that, other, args)

if __name__ == "__main__": main7()

def main8():
    testfunc(1, 2, 3, 42, 43, 45, 46)

def testfunc(this, that, other, *args):
    print(this, that, other)
    for n in args: print(n)

if __name__ == "__main__": main8()
# remember that the *args will go into a tuple and therefore be immutable.

def main9():
    testfunc(one = 1, two = 2, four = 42)

def testfunc(**kwargs):
    print('This is a test function', kwargs['one'], kwargs['two'], kwargs['four'])

if __name__ == "__main__": main9()
# kwargs stand for keyword arguments and kwargs is actually a dictionary.

def main10():
    testfunc(5, 6, 7, 8, 9, 10, one = 1, two = 2, four = 42)

def testfunc(this, that, other, *args, **kwargs):
    print('This is a test function',
        this, that, other, args,
        kwargs['one'], kwargs['two'], kwargs['four'])

if __name__ == "__main__": main10()
# This example combines different types of arguments, but although the number of them
# is unlimited, they have to be in order as they are referenced in testfunc,
# normal, tuple (*args), and kwargs.

def main11():
    print(testfunc())

def testfunc():
    return 'This is a test function'

if __name__ == "__main__": main11()

def main12():
    for n in testfunc(): print(n, end=' ')

def testfunc():
    return range(25)

if __name__ == "__main__": main12()

def main13():
    print("This is the Chap11.py file.")
    for i in range(25):
        print(i, end = ' ')

if __name__ == "__main__": main13()

def main14():
    print("This is the Chap11.py file.")
    for i in inclusive_range(0, 25, 1):
        print(i, end = ' ')

def inclusive_range(start, stop, step):
    i = start
    while i <= stop:
        yield i
        i += step

if __name__ == "__main__": main14()
# example of creating an inclusive range

def main15():
    print("This is the Chap11.py file.")
    for i in inclusive_range(25):
        print(i, end = ' ')

def inclusive_range(*args):
    numargs = len(args)
    if numargs < 1: raise TypeError('requires at least one argument')
    elif numargs == 1:
        stop = args[0]
        start = 0
        step = 1
    elif numargs == 2:
        (start, stop) = args
        step = 1
    elif numargs == 3:
        (start, stop, step) = args
    else: raise TypeError('inclusive_range expected at most 3 arguments, got {}'.format(numargs))
    i = start
    while i <= stop:
        yield i
        i += step

if __name__ == "__main__": main15()
# yield is used to create a generator and generators return an iterator which can be used just like any other iterator.
