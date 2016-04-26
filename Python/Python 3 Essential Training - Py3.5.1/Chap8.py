x = 5 + 5
print(x)
x = 5 * 5
print(x)
x = 5 - 3
print(x)
x = 5 / 3
print(x)
x = 5 // 3
print(x)
x = 5 % 3
# returns the remainder
print(x)
x = divmod(5,3)
print(x)
# returns a tuple, the second number of the remainder
num = 5
num += 1
print(num)
num = 5
num *= 5
print(num)
num = 5
num //= 5
print(num)
num *= 5
num /= 5
print(num)

def b(n): print('{:08b}'.format(n))
b(5)

x, y = 0x55, 0xaa
b(x)
b(y)
b(x | y)
b(x & y)
b (x ^ y)
b(x ^ 0)
b(x ^ 0xff)
b(x << 4)
b(x >> 4)
b(~ x)
# bitwise or binary operators

print(5 < 6)
print(6 < 5)
print(5 <= 6)
print(5 <= 5)
print(6 >= 5)
print(6 >= 6)
print(6 >= 7)
print(5 == 5)
print(5 == 6)
print(6 != 7)
print(6 != 6)
x, y = 5, 6
print(id(x))
print(id(y))
print(x is y)
print(x is not y)

y = 5
print(id(y))
print(x is y)

x, y = [5], [5]
print(id(x))
print(id(y))
print(x == y)
print(x is y)

print(True and False)
print(True and True)
print(True or False)
print(False or False)
print(True & True)
# boolean operators are the spelled out 'and' and 'or'
# that last one above uses the bitwise rather than boolean operaator.

a, b = 0, 1
x, y = 'zero', 'one'
print(x < y)
print(a < b)
if a < b and x < y: print('yes')
else: print('no')

list = []
list = [1,2,3,4,5,6,7,8,9,10]
print(list[0])
print(list[9])
print(list[0:5])
# a slice of the code/list/string, etc. up to, but not including the last item referenced in the slice.
print(list[4])
print(list[5])
range(0, 10)
for i in range(0,10): print(i)
# remember that ranges in Python are non-inclusive.
print(list[0:10])
list[:] = range(100)
print(list[27])
print(list[27:42])
print(list[27:42:3])
# The third number is increment, every third number in the range is returned.
# Slice expression can have up to three arguments, 1) index where slice begins
# optionally a 2) second index where slice ends, and 3) the increment or iterator
# how many elements do we step over before returning a value and the value returned
# is an iterator.
for i in list[27:43:3] : print(i)
list[27:43:3] = (99,99,99,99,99,99)
print(list)

print(5 * 25 + 14 / 2)
print(5 * ( 25 + 14 ) / 2)
# operator precedence, can also use parentheses to force it to be evaluated in your
# preferred order.  But mult & div are ahead of + & -.
# it is a good idea when writing Python code to be explicit with your formulas so
# it is clear to you and easy for somebody else to read and follow your code.
