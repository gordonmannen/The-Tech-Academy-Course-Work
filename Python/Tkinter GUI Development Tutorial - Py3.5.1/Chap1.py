#from tkinter import *

#root = Tk()
#Label(root, text="Hello, Tkinter!").pack()
#root.mainloop()

# TK is an open source toolkit for building GUI applications across most versions
# of the most popular platforms.
# "Root" - Window - acts as the geometry manager for the buttons, etc. that are
# hierarchical children widgets of this parent widget.

from tkinter import *
from tkinter import ttk

root = Tk()

button = ttk.Button(root, text = 'Click Me')
button.pack()

print(button['text'])
button['text'] = 'Press Me'
button.config(text = 'Push Me')
print(button.config())

print(str(button))
print(str(root))

ttk.Label(root, text ='Hello, Tkinter!').pack()

# mainloop() add
root.mainloop()

