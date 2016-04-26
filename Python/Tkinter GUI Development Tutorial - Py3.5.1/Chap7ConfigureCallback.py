from tkinter import *
from tkinter import ttk        

def callback(number):
    print(number)
    
root = Tk()

ttk.Button(root, text = 'Click Me 1', command = lambda: callback(1)).pack()
# By creating a lambda function, the lambda keyword creates an anonymous function
# containing the callback method which we can then use to configure the command
# callback.  This doesn't work properly without that.
ttk.Button(root, text = 'Click Me 2', command = lambda: callback(2)).pack()
ttk.Button(root, text = 'Click Me 3', command = lambda: callback(3)).pack()

# Widgets with Command Callbacks:
# Button, Checkbutton, Radiobutton, Spinbox, Scale, Scrollbar

root.mainloop()

