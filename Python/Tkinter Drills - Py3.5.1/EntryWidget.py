from tkinter import *

win=Tk()

v = StringVar()
e = Entry(win,textvariable=v)
e.pack()

v.get()

v.set("this is set from the program")


