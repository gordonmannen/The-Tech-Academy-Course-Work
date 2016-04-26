def main():
    f = open('lines.txt')
    for line in f:
        print(line, end = '')

if __name__ == "__main__": main()
# If not specified 'r' read mode is the default.

def main():
    f = open('lines.txt', 'r') # or w for write, a for append (special write mode that
    # that sets current position to the end, everything you write gets added on the end
    # 'r+' - read AND write, 'rt' - text mode, 'rb' - byte mode.
    for line in f:
        print(line, end = '')

if __name__ == "__main__": main()
# If not specified 'r' read mode is the default.

def main():
    f = open('lines.txt', 'r')
    for line in f.readlines():
        print(line, end = '')

if __name__ == "__main__": main()

def main():
    infile = open('lines.txt', 'r')
    outfile = open('new.txt', 'w')
    for line in infile:
        print(line, file = outfile, end = '')
    print('Done.')

if __name__ == "__main__": main()

def main():
    buffersize = 50000
    infile = open('bigfile.txt', 'r')
    outfile = open('new1.txt', 'w')
    buffer = infile.read(buffersize)
    while len(buffer):
        outfile.write(buffer)
        print('.', end = '')
        buffer = infile.read(buffersize)
    print()    
    print('Done.')

if __name__ == "__main__": main()

def main():
    buffersize = 50000
    infile = open('olives.jpg', 'rb')
    outfile = open('new.jpg', 'wb')
    buffer = infile.read(buffersize)
    while len(buffer): # infile.read is not iterable, so we need to use a while loop.
        outfile.write(buffer)
        print('.', end = '')
        buffer = infile.read(buffersize)
    print()
    print('Done.')

if __name__ == "__main__": main()
# Python handles reading files in binary differently than reading text files.
