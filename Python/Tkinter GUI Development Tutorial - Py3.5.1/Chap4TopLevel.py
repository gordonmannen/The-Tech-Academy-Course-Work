from tkinter import *      
    
root = Tk()

window = Toplevel(root)
window.title('New Window')

window.lower()
window.lift(root)

window.state('zoomed')
window.state('withdrawn')
window.state('iconic')
window.state('normal')
print(window.state())
window.state('normal')

window.iconify()
window.deiconify()

window.geometry('640x480+50+100')
# geometry() Method takes one parameter Ex window.geometry('WIDTHxHEIGHT+X+Y')
print(window.geometry())
window.resizable(False, False)
window.maxsize(640, 480)
window.minsize(200, 200)
# Maxsize and minsize allow users partial control over the size of the window
# rather than full control.
window.resizable(True, True)

root.destroy()
# Destroys the top level window and any children of that window.

root.mainloop()
