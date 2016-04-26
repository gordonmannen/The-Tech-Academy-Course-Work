from tkinter import *
from tkinter import ttk        
    
root = Tk()

label = ttk.Label(root, text = "Hello, Tkinter!")
label.pack()
label.config(text = 'Howdy, Tkinter!')
label.config(text = 'Howdy, Tkinter! It\'s been a really long time since we last met.  Great to see you again!')
label.config(wraplength = 150)
label.config(justify = CENTER)
label.config(foreground = 'blue', background = 'yellow')
label.config(font = ('Courier', 18, 'bold'))
label.config(text = 'Howdy, Tkinter!')

logo = PhotoImage(file = 'python_logo.gif')
# Change the path to the image as necessary if it isn't local.
# For logo (PhotoImage) Python can accept GIF, PGM, or PPM files or use an external
# library and convert the file to one of those three.  Python Image Library for example.
label.config(image = logo)
label.config(compound = 'text')
label.config(compound = 'center')
label.config(compound = 'left')

label.img = logo
# Keeps the PhotoImage as long as the Label exists, rather than having it become
# garbage collected, because it is stored within the label.
label.config(image = label.img)

root.mainloop()
