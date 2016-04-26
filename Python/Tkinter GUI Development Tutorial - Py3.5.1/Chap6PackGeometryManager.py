from tkinter import *
from tkinter import ttk

# Pack Geometry Manager - Pros
# Simplest geometry manager.
# Use when a widget is expanded to fill its entire parent.
# Use to stack multiple widgets vertically or horizontally.
# Cons - Limited capability for complex layouts.
    
root = Tk()

ttk.Label(root, text = 'GO',
          background = 'light gray').pack(side = LEFT, anchor = 'nw')
        # Options with 'side' are TOP, LEFT, RIGHT, & BOTTOM.
        # Anchor options are cardinal directions in string form like 'sw'.
ttk.Label(root, text = 'Yankees!',
          background = 'blue').pack(side = LEFT, padx = 10, pady = 10)
        # padx and pady are external padding - pad around the outside of the widget.
        # ipadx and ipady are internal padding - pad around the inside of the widget.
label = ttk.Label(root, text = 'Hello, Tkinter!',
          background = 'green')
label.pack(side = LEFT, ipadx = 10, ipady = 10)
print(label)

for widget in root.pack_slaves():
    widget.pack_configure(fill = BOTH, expand = True)
    # Expand is what causes the content to expand even as the parent window is resized.
    print(widget.pack_info())

label.pack_forget()

root.mainloop()
