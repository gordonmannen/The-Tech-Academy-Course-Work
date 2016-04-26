def main():
    a, b = 0, 1
    if a < b:
        print("this is true")

if __name__ == "__main__": main()

def main():
    a, b = 1, 1
    if a < b:
        print("this is true")
    else:
        print('it is not true')

if __name__ == "__main__": main()

def main():
    a, b = 0, 1 #This could be any expression that evaluates to true or false.
    if a < b:
        print("this is true")
    else:
        print('it is not true')

if __name__ == "__main__": main()

def main():
    v = 'one'
    if v == 'one':
        print('v is one')
    elif v == 'two':
        print('v is two')
    elif v == 'three':
        print('v is three')
    else:
        print('v is something else')

if __name__ == "__main__": main()

def main():
    v = 'seven'
    if v == 'one':
        print('v is one')
    elif v == 'two':
        print('v is two')
    elif v == 'three':
        print('v is three')
    else:
        print('v is something else')

if __name__ == "__main__": main()
# only one of the suites will actually get executed, but each is evaluated in order
# until one can be selected for execution.

def main():
    choices = dict(
        one = 'first',
        two = 'two',
        three = 'three',
        four = 'four',
        five = 'five'
    )
    v = 'one'
    print(choices[v])

if __name__ == "__main__": main()

def main():
    choices = dict(
        one = 'first',
        two = 'two',
        three = 'three',
        four = 'four',
        five = 'five'
    )
    v = 'three'
    print(choices[v])

if __name__ == "__main__": main()
# pitfall of this method is that if you enter a value outside of those defined
# you will get an error returned.

def main():
    choices = dict(
        one = 'first',
        two = 'two',
        three = 'three',
        four = 'four',
        five = 'five'
    )
    v = 'seven'
    print(choices.get(v, 'other'))

if __name__ == "__main__": main()
# to combat the above pitall, you can do this to get around that shortcoming.
# this setup is generally used for switch or multiple choice type expressions.

def main():
    a, b = 0, 1
    if a < b:
        v = 'this is true'
    else:
        v = 'this is not true'
    print(v)

if __name__ == "__main__": main()
# This is the long way

def main():
    a, b = 0, 1
    v = 'this is true' if a < b else 'this is not true'
    print(v)

if __name__ == "__main__": main()
