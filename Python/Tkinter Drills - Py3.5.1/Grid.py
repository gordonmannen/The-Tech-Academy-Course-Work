from tkinter import *

win=Tk()

b1 = Button(win,text='One')
b2 = Button(win,text='Two')

b1.grid(row=0, column=0)
b2.grid(row=1, column=1)

l = Label(win,text="This is a label")
l.grid(row=1,column=0)
