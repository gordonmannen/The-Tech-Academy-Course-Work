# Organizing widgets with Frames
# Could have three frames (Ex vert on left for Navigation Controls,
# and two horizontal on the left for Display Information and User
# Controls...or any number of other layouts and options.
# Would have the luxury of using a different geometry manager for
# each of the example frames mentioned above.

from tkinter import *
from tkinter import ttk        
    
root = Tk()

frame = ttk.Frame(root)
frame.pack()
frame.config(height = 150, width = 250)
frame.config(relief = SUNKEN)
# Different types of frame relief (Flat-no border, raised, sunken, solid,
# ridge, and groove).
ttk.Button(frame, text = 'Click Me').pack()
frame.config(padding = (40, 25))
ttk.LabelFrame(root, height = 80, width = 200, text = 'My Frame').pack()

root.mainloop()
