from tkinter import *
from tkinter import ttk        
    
root = Tk()

month = StringVar()
combobox = ttk.Combobox(root, textvariable = month)
combobox.pack()
combobox.config(values = ('Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun',
                          'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'))
print(month.get())
month.set('Dec')
month.set('Not a month!')
# Would likely want to somehow account for the entry of invalid inputs.

year = StringVar()
Spinbox(root, from_ = 1990, to = 2016, textvariable = year).pack()
print(year.get())
# Similarly here you would need to account for an invalid entry.

root.mainloop()
