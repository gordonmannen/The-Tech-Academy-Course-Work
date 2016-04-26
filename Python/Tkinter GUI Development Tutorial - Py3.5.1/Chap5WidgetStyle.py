from tkinter import *
from tkinter import ttk
# Widget States (active/disabled/focus/pressed/selected/background/readonly/
# alternate/invalid/hover).
    
root = Tk()

button1 = ttk.Button(root, text = 'Button 1')
button2 = ttk.Button(root, text = 'Button 2')      
button1.pack()
button2.pack()

style = ttk.Style()

print(style.theme_names())
print(style.theme_use())
style.theme_use('classic')
style.theme_use('vista')

print(button1.winfo_class())
style.configure('TButton', foreground = 'blue')
# Widget Sytle Names - Usually "T" + widget name (Ex TButton, TFrame, TCombobox)
# Exceptions (Treeview (no extra "T"), TPanedwindow("w" is only lowercase),
# Horizontal.TScale/TScrollbar/TProgressbar or Vertical.TScale/TScrollbar/TProgressbar)
style.configure('Alarm.TButton', foreground = 'orange',
                font = ('Arial', 24, 'bold'))
button2.configure(style = 'Alarm.TButton')
style.map('Alarm.TButton', foreground = [('pressed', 'pink'),
                                         ('disabled', 'grey')])
# button2.state(['disabled'])

print(style.layout('TButton'))
# Border around the widget 'TButton' Output.  [('Button.button', {'sticky':  'nswe',
# 'children': - The Button Element
# 2d layer - Focus Element [('Button.focus', {{'sticky': 'nswe', 'children':
# 3d layer - Padding Element [('Button.padding', {{'sticky': 'nswe', 'children':
# 4th layer - Label Element [('Button.label', {{'sticky': 'nswe'})]})]})]})]

print(style.element_options('Button.label'))
print(style.lookup('TButton', 'foreground'))

root.mainloop()


