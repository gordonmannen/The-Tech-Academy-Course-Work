# def someFunction(< input variables >):
#    < Do stuff here with input variables >
#    return < some value>

def letsAdd(x,y):
    addition = x + y
    return addition

print letsAdd(3,5)

def letsAdd(x,y):
    addition = x + y
    someValue = 10
    return addition

someValue = 5
print letsAdd(3,5)
print someValue

# Make function called subtraction
def subtraction(x,y):
    # Make subtract variable equal to x - y
    subtract = x - y

    # Return subtract variable
    return subtract

print subtraction(10,4)

def moreSubtraction(x,y,z):
    # Make subtract variable equal to x - y - z
    subtract = x - y - z

    # Return subtract variable
    return subtract

print moreSubtraction(40,3,11)

def multiplication(x,y):
    multiply = x * y

    return multiply

print multiplication(5,6)

def division(x,y):
    divide = x / y

    return divide

print division(39,3)

# If you need division to return decimal numbers use
# divide = float(x)/float(y)

length = len("How epic are built-in functions, huh?")
print length

length = len("How epic was Trump's domination on Super Tuesday?")
print length

x = 23
print str(x)

x = 2.32
print str(x)

y = float(40)/float(7)
print y

yInt = int(y)
print yInt

print round(y)

print int(round(y))


    

