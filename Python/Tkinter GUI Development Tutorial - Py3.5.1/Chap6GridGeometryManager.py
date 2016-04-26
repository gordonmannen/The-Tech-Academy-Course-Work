from tkinter import *
from tkinter import ttk

# Grid Geometry Manager Pros
# Easy to organize widgets in two dimensions
# Grid organizational style typical in modern GUI layouts
# Cons - Slightly more involved than Pack Geometry Manager
    
root = Tk()

ttk.Label(root, text = 'Yellow', background = 'yellow').grid(row = 0, column = 2, rowspan = 2, sticky = 'nsew')
ttk.Label(root, text = 'Blue', background = 'Blue').grid(row = 1, column = 0, columnspan = 2, sticky = 'nsew')
ttk.Label(root, text = 'Green', background = 'Green').grid(row = 0, column = 0, sticky = 'nsew', padx = 10, pady = 10)
ttk.Label(root, text = 'Orange', background = 'Orange').grid(row = 0, column = 1, sticky = 'nsew', ipadx = 25, ipady = 25)
# these are all children of root.
# It is a good idea when using Grid Geom Mgr to plan out the grid layout, so
# draw out the rows and columns and label things in such a way that you have a
# logical visual representation of what you are trying to build.  This helps
# with indexing and referencing the various labels/'cells'.

# You can also make it more complex where some other layout is desired beyond
# something traditional like quadrants, there are innumberabel possible combos.

root.rowconfigure(0, weight = 1)
root.rowconfigure(1, weight = 3)
root.columnconfigure(2, weight = 1)

# Some other Grid methods available with Grid Geo Mgr are
# grid_slaves(), grid_configure(), grid_info(), grid_forget()

root.mainloop()
