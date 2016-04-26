# wxPython calls windows - frames.

import wx

class windowClass(wx.Frame):
    def __init__(self, parent, title):
        super(windowClass, self).__init__(parent, title=title, size =(600,500))

        self.Move((1000,350))
        self.Show()
                

app = wx.App()
windowClass(None, title='epic window!!@')

app.MainLoop()
