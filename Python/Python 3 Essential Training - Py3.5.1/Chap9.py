import re

def main():
    fh = open('raven.txt')
    for line in fh:
        if re.search('(Len|Neverm)ore', line):
            print(line, end='')

if __name__ == "__main__": main()

def main1():
    fh = open('raven.txt')
    for line in fh:
        match = re.search('(Len|Neverm)ore', line)
        if match:
            print(match.group())

if __name__ == "__main__": main1()

def main2():
    fh = open('raven.txt')
    for line in fh:
        print(re.sub('(Len|Neverm)ore', '###', line), end='')

if __name__ == "__main__": main2()

def main3():
    fh = open('raven.txt')
    for line in fh:
        match = re.search('(Len|Neverm)ore', line)
        if match:
            print(line.replace(match.group(), '###'), end='')

if __name__ == "__main__": main3()

def main4():
    fh = open('raven.txt')
    pattern = re.compile('(Len|Neverm)ore')
    for line in fh:
        if re.search(pattern, line):
            print(line, end='')

if __name__ == "__main__": main4()
# This will be faster, the loop will be tighter because it only has to compile once.

def main5():
    fh = open('raven.txt')
    pattern = re.compile('(Len|Neverm)ore', re.IGNORECASE)
    for line in fh:
        if re.search(pattern, line):
            print(line, end='')

if __name__ == "__main__": main5()

def main6():
    fh = open('raven.txt')
    pattern = re.compile('(Len|Neverm)ore', re.IGNORECASE)
    for line in fh:
        if re.search(pattern, line):
            print(pattern.sub('###', line), end='')

if __name__ == "__main__": main6()
