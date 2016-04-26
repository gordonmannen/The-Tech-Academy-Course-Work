from tkinter import *

win=Tk()

b1 = Button(win,text='One')
b2 = Button(win,text='Two')
b3 = Button(win,text='Three')
b4 = Button(win,text='Four')

b1.pack()
b2.pack()
b3.pack()
b4.pack()

b4.pack(side=RIGHT, padx=10)
b3.pack(side=BOTTOM, padx=10)
b2.pack(side=LEFT, padx=10)
b1.pack(side=LEFT, padx=10)
