import wx

class Frame(wx.Frame):
    def __init__(self, title):
        wx.Frame.__init__(self, None, title=title, size=(300,250))
        panel = wx.Panel(self)
        
        sc = wx.SpinCtrl(panel, value='0', pos=(130, 50), size=(70, 25))
        self.valueText = wx.StaticText(panel, label='', pos=(130,80))
        
        sc.Bind(wx.EVT_SPINCTRL, self.spinControl)

    def spinControl(self, event):
        # Get spin control value
        value = event.GetPosition()
        # Update static text
        self.valueText.SetLabel(str(value))
        # This one is working in general, but throwing errors as soon as clicking on the
        # spin control 'dials' rather than updating and displaying a changing text somewhere
        # on the panel as the spin control changes.

        #wx.RadioButton(panel, label='Male', pos=(100,50), style=wx.RB_GROUP)
        #wx.RadioButton(panel, label='Female', pos=(100,80))

        #wx.TextCtrl(panel, size=(200, -1), pos=(50,30))
        #wx.TextCtrl(panel, style=wx.TE_MULTILINE, size=(200, 100), pos=(50,80))

        #wx.SpinCtrl(panel, value='0', pos=(130,50), \
        #    size=(70,25))
        
app = wx.App()
frame = Frame("wxPython Widgets!")
frame.Show()
app.MainLoop()
