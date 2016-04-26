from tkinter import *
from tkinter import ttk

# Place Geometry Manager - Pros
# Provides exact control of widget location and size.
# Describe location in absolute and/or relative terms
# Cons - Difficult to manage a large number of widgets.
# Recommendation - Use Place Geo Mgr when you need to
# craft a very specialized piece of the GUI, and to do
# that inside of a frame which you prevent from changing
# in size if the rest of the GUI is resized.
    
root = Tk()
root.geometry('640x480+200+200')

ttk.Label(root, text = 'Yellow', background = 'yellow').place(x = 100, y = 50, width = 100, height = 50)
# x and y 'place' are fixed.
ttk.Label(root, text = 'Blue', background = 'blue').place(relx = 0.5, rely = 0.5, anchor = 'center', relwidth = 0.5, relheight = 0.5)
# relx and rely 'place' allow the items to move relative to the window as it is resized.
ttk.Label(root, text = 'Green', background = 'green').place(relx = 0.5, x = 100, rely = 0.5, y = 50)
# when you use x/y & relx/rely allow the items to move some, but keep them consistent relative to for ex the center.
ttk.Label(root, text = 'Orange', background = 'orange').place(relx = 1.0, x = -5, y = 5, anchor = 'ne')

# width, height, relwidth, relheight - these work similarly to x/y & relx/rely, but affect the width and height to the widget and the 'rel'
# affects that width and height relative to the size of the parent window as it is expanded, etc.

# Other grid methods usable with place:
# place_slaves(), place_configure(), place_info(), place_forget()


root.mainloop()

