from tkinter import messagebox

messagebox.showinfo(title = "A Friendly Message", message = 'Hello, Tkinter!')
print(messagebox.askyesno(title = 'Hungry?', message = 'Do you want SPAM?'))

# Messagebox Types:  Informational
# showinfo(), showwarning(), showerror()
# Messagebox Types:  Questions
# askyesno(), askokcancel(), askretrycancel(), askyesnocancel(), askquestion()

from tkinter import filedialog
filename = filedialog.askopenfile()
print(filename.name)

# Filedialog Types
# askdirectory(), asksaveasfile(mode), asksaveasfilename()
# askopenfile(mode), askopenfiles(mode), askopenfilename(), askopenfilenames()

from tkinter import colorchooser
print(colorchooser.askcolor(initialcolor = "#FFFFFF"))


