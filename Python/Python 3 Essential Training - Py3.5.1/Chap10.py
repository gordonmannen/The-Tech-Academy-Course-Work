def main():
    fh = open('lines.txt')
    for line in fh: print(line.strip())

if __name__ == "__main__": main()

#def main1():
   # fh = open('xlines.txt')
   # for line in fh: print(line.strip())

#if __name__ == "__main__": main1()
   # This one results in an error because of incorrect file name.

def main3():
    try:
        fh = open('xlines.txt')
    except:
        print('could not open the file.  come back tomorrow.')
    else:
        for line in fh: print(line.strip())

if __name__ == "__main__": main3()

def main4():
    try:
        fh = open('xlines.txt')
    except IOError:
        print('could not open the file.  come back tomorrow.')
    else:
        for line in fh: print(line.strip())

if __name__ == "__main__": main4()

def main5():
    try:
        fh = open('xlines.txt')
    except IOError as e:
        print('could not open the file:', e)
    else:
        for line in fh: print(line.strip())

if __name__ == "__main__": main5()

def main6():
    try:
        fh = open('xlines.txt')
        for line in fh: print(line.strip())
    except IOError as e:
        print('could not open the file:', e)

if __name__ == "__main__": main6()
# An alternative way to present it, without the else.

def main7():
    try:
        for line in readfile('xlines.doc'): print(line.strip())
    except IOError as e:
        print('cannot read file:', e)
    except ValueError as e:
        print('bad filename', e)

def readfile(filename):
    if filename.endswith('.txt'):
        fh = open(filename)
        return fh.readlines()
    else: raise ValueError('Filename must end with .txt')

if __name__ == "__main__": main7()
