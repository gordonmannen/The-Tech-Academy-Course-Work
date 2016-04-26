# Pack Geometry Manager
# Define edge of parent to pack widget master
# Example:  widget.pack(side = RIGHT)

# Grid Geometry Manager
# Define row/column of 2D table in master
# Example: widget.grid(row = 0, column = 1)

# Place Geometry Manager
# Define relative or absolute x/y coordinates in master
# Example:  widget.place(x = 200, y = 150)

# Can mix and match in a program/application, but not within the same master.

# Handling User Events
# When Event Occurs (ButtonPress, Key, Leave, Motion, Configure)
# Execute Handler Code - Ex handle_buttonpress() or handle_cofigure()
# root.mainloop() > Event Loop (such as a button click) > Execute Mouse Click Handler
# > Return to Event Loop and wait for next Event. > Cannot process multiple events
# simultaneously, but other events can be queued up.
# Configuring Event Handlers
# Command callbacks & Event bindings

from tkinter import *
from tkinter import ttk

class HelloApp:

    def __init__(self, master):

        self.label = ttk.Label(master, text = "Hello, Tkinter!")
        self.label.grid(row = 0, column = 0, columnspan = 2)
        
        ttk.Button(master, text = "Texas",
                   command = self.texas_hello).grid(row = 1, column = 0)

        ttk.Button(master, text = "Hawaii",
                   command = self.hawaii_hello).grid(row = 1, column = 1)

    def texas_hello(self):
        self.label.config(text = 'Howdy, Tkinter!')

    def hawaii_hello(self):
        self.label.config(text = 'Aloha, Tkinter!')

            
def main():            
    
    root = Tk()
    app = HelloApp(root)
    root.mainloop()
    
if __name__ == "__main__": main()
