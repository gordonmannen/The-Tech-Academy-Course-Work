def main():
    # simple fibonacci series
    # the sum of two elements defines the next set
    a, b = 0, 1
    while b < 50:
        print(b)
        a, b = b, a + b

if __name__ == "__main__": main()

def main1():
    # simple fibonacci series
    # the sum of two elements defines the next set
    a, b = 0, 1
    while b < 150:
        print(b, end=' ')
        a, b = b, a + b

if __name__ == "__main__": main1()

def main2():
    fh = open('lines.txt')
    for line in fh.readlines():
        print(line)

if __name__ == "__main__": main2()

def main3():
    fh = open('lines.txt')
    for line in [1, 2, 3, 4, 5]:
        print(line)

if __name__ == "__main__": main3()

def main4():
    fh = open('lines.txt')
    for line in 'string':
        print(line, end='')

if __name__ == "__main__": main4()

def main5():
    fh = open('lines.txt')
    for index, line in enumerate(fh.readlines()):
        print(index, line, end='')

if __name__ == "__main__": main5()

def main6():
    s = 'this is a string'
    for i, c in enumerate(s):
        print(i, c)

if __name__ == "__main__": main6()

def main7():
    s = 'this is a string'
    for i, c in enumerate(s):
        if c == 's': print('index {} is an s'.format(i))

if __name__ == "__main__": main7()

def main8():
    s = 'this is a string'
    for c in s:
        print(c)

if __name__ == "__main__": main8()

def main9():
    s = 'this is a string'
    for c in s:
        if c == 's': continue
        print(c, end='')

if __name__ == "__main__": main9()

def main10():
    s = 'this is a string'
    for c in s:
        if c == 's': break
        print(c)

if __name__ == "__main__": main10()

x = 42
print(x)

def main11():
    s = 'this is a string'
    for c in s:
        print(c, end='')
    else:
        print('else')

if __name__ == "__main__": main11()

def main12():
    s = 'this is a string'
    i = 0
    while(i < len(s)):
        print(s[i], end='')
        i += 1
    else:
        print('else')

if __name__ == "__main__": main12()
# Conditions for shortening or breaking out of a loop.
