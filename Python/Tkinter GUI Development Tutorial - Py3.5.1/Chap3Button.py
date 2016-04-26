from tkinter import *
from tkinter import ttk        
    
root = Tk()

button = ttk.Button(root, text = "Click Me")
button.pack()

def callback():
    print('Clicked!')

button.config(command = callback)
button.invoke()

button.state(['disabled'])
print(button.instate(['disabled']))
button.state(['!disabled'])
print(button.instate(['!disabled']))
# Various states - disabled or not, active, focus, etc.  See http://tcl.tk for
# full list.

logo = PhotoImage(file = 'python_logo.gif')
button.config(image = logo, compound = LEFT)
small_logo = logo.subsample(3, 3)
button.config(image = small_logo)

root.mainloop()
