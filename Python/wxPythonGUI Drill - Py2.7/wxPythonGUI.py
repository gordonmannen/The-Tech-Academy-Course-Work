import wx

class windowClass(wx.Frame):
    
    def __init__(self, *args, **kwargs):
        super(windowClass, self).__init__(*args, **kwargs)

        self.basicGUI()

    def basicGUI(self):

        panel = wx.Panel(self)
        
        menuBar = wx.MenuBar()
        
        fileButton = wx.Menu()
        editButton = wx.Menu()
        importButton = wx.Menu()
        toolsButton = wx.Menu()
        optionsButton = wx.Menu()
        helpButton = wx.Menu()

        exitItem = wx.MenuItem(fileButton, wx.ID_EXIT, 'Quit\tCtrl+Q')
        fileButton.AppendItem(exitItem)

        menuBar.Append(fileButton, 'File')
        menuBar.Append(editButton, 'Edit')
        menuBar.Append(importButton, 'Import')
        menuBar.Append(toolsButton, 'Tools')
        menuBar.Append(optionsButton, 'Options')
        menuBar.Append(helpButton, 'Help')

        self.SetMenuBar(menuBar)
        self.Bind(wx.EVT_MENU, self.Quit, exitItem)

        wx.TextCtrl(panel, pos=(3, 60), size=(300,100))

        aText = wx.StaticText(panel, -1, "VOTE", (3,3))
        aText.SetForegroundColour('white')
        aText.SetBackgroundColour('black')
        
        bText = wx.StaticText(panel, -1, "Trump for President ~ 2016",(3,20))
        bText.SetForegroundColour('blue')
        bText.SetBackgroundColour('white')

        cText = wx.StaticText(panel, -1, "Hillary for Prison ~ 2016",(3,40))
        cText.SetForegroundColour('blue')
        cText.SetBackgroundColour('white')  

        self.SetTitle('Welcome Voter')
        self.Show(True)

    def Quit(self, e):
        self.Close()

def main():
    app = wx.App()
    windowClass(None)
    app.MainLoop()

main()
