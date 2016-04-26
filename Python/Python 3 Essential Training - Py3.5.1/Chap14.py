t = 1,2,3,4,5
print(t)
print(t[4])
print(t[-1]) # last element
print(len(t)) # length
print(min(t)) # minimum element
print(max(t)) # maximum element
t = (1, 2, 3, 4, 5) # it is the commas that make the tuple, the parentheses in this
# example are just for binding.
t = (1)
print(type(t)) # in order for this to be a tuple, need a comma.
t = (1,)
print(type(t))
x = [1,2,3,4,5]
print(type(x))
print(x)
print(x[4])
print(x[-1]) # last element
print(len(x)) # length
print(min(x)) # minimum element
print(max(x)) # maximum element
t = tuple(range(25))
print(t)
print(type(t))
# Cannot change the values though, tuples are immutable.

x = list(range(25))
print(x)
print(type(x))
x[10] = 42
print(x)
# it is a benefit that tuples are immutable, tuples should be used wherever you want
# the array to remain the same as you cannot accidentally change the values, lists
# should be used where you KNOW you will want/need to change values.

t = tuple( range(25) )
print(type(t))
print(10 in t)
print(50 in t)
print(50 not in t)
print(t[10])
print(len(t))
for i in t: print(i)

x = list(range(20))
print(x)
print(10 in x)
print(20 in x)
for i in x: print(i)
print(t.count(5))
print(t.index(5))
# can't modify t as it is a tuple, but can do all sorts of things with it that
# don't modify it.
# no such restriction with a list.
x.append(100)
print(x)
print(len(x))
x.extend(range(20))
print(x)
x.insert(0,25)
print(x)
x.insert(12,100)
print(x)
x.remove(12)
print(x)
del x[12]
print(x)
print(x.pop())
print(x)
print(x.pop(0)) # this will pop that first item and remove it.
print(x)

d = { 'one': 1, 'two': 2, 'three': 3 }
print(d)
d = dict( one = 1, two = 2, three = 3)
print(d)
print(type(d))
# Named parameters method, same result and it is easier to type out.

x = dict( four = 4, five = 5, six = 6)
print(x)
d = dict( one = 1, two = 2, three = 3, **x)
print(d)
print('four' in x)
print('three' in x)
for k in d: print(k)
for k, v, in d.items(): print(k, v)
print(x.get('three')) # will silently return None because it isn't in there.
# But if you didn't use get and just tried to print(x['three']) it would return an error.
print(d.get('three'))
print(x.get('three', 'not found'))
del x['four']
print(x)
x.pop('five')
print(x)
# dictionaries - Pythons version of associative arrays or hashed arrays.
# Hierarchical, can store dictionaries within dictionaries, can store lists and
# tuples within dictionaries.  Often useful to carry one dictionary in a global
# namespace and put all of your data inside of that and then it becomes manageable.
# Like a halfway point between flat data and an object with methods.  Good for
# organizing a whole bunch of global variables or flags and for organizing object
# data within an object.
# basic array types in Python:  tuples - immutable, lists - mutable

def main():
    fin = open('utf8.txt', 'r', encoding = 'utf_8')
    fout = open('utf8.html', 'w')
    outbytes = bytearray()
    for line in fin:
        for c in line:
            if ord(c) > 127:
                outbytes += bytes('&#{:04d};'.format(ord(c)), encoding = 'utf_8')
            else: outbytes.append(ord(c))
        outstr = str(outbytes, encoding = 'utf_8')
        print(outstr, file = fout)
        print(outstr)
        print('Done.')

if __name__ == "__main__": main()
# a byte array is a mutable list of bytes.
