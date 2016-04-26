from tkinter import *
from tkinter import ttk

# Callback vs. Events
# Callbacks only avilable for specific actions
# Tkinter can bind to events with specific handlers
# There's a wide variety of event handlers

# Tk Event Types
# ButtonPress, ButtonRelease, Enter, Leave, Motion, KeyPress, KeyRelease,
# FocusIn, FocusOut

def key_press(event):
    print('type: {}'.format(event.type))
    print('widget: {}'.format(event.widget))
    print('char: {}'.format(event.char))
    print('keysym: {}'.format(event.keysym))
    print('keycode: {}\n'.format(event.keycode))

def shortcut(action):
    print(action)
    
root = Tk()

root.bind('<Control-c>', lambda e: shortcut('Copy'))
root.bind('<Control-v>', lambda e: shortcut('Paste'))
# Both the lambda and the e 'lamda e:' are needed for this to work, without the
# lambda it won't work at all, without the e it will throw an error, this is true
# for bind events, but the variable 'e' isn't needed for simple command callbacks.

root.mainloop()
