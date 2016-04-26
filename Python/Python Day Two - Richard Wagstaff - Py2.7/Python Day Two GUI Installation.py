import wx

class Frame(wx.Frame):
    # Added title Parameter
    def __init__(self, title):
        # title = title variable
        wx.Frame.__init__(self, None,\
            title=title, size=(300,200))
        panel = wx.Panel(self)
        button = wx.Button(panel,label="Exit",size=(100,40),pos=(100,30))
        # Bind button event to the function self.exit
        button.Bind(wx.EVT_BUTTON, self.exit)
        
        # Create menu bar
        menuBar = wx.MenuBar()
        # Create the menus
        fileMenu = wx.Menu()
        editMenu = wx.Menu()
         
        # Add items to fileMenu
        fileMenu.Append(wx.NewId(), "New File", \
            "Create a new file")
        fileMenu.Append(wx.NewId(), "Open")
        exitItem = fileMenu.Append(wx.NewId(), "Exit")

        # Bind exit menu item to exit function
        self.Bind(wx.EVT_MENU, self.exit, exitItem)

        # Add items to editMenu
        editMenu.Append(wx.NewId(), "Indict Hillary Clinton")
        editMenu.Append(wx.NewId(), "Arrest Hillary Clinton")
        editMenu.Append(wx.NewId(), "Condemn Hillary Clinton")   

        # Add fileMenu and editMenu to menuBar
        menuBar.Append(fileMenu, "File")
        menuBar.Append(editMenu, "Edit")

        self.SetMenuBar(menuBar)

        self.CreateStatusBar()

    def exit(self, event):
        self.Destroy()

        wx.StaticBox(panel, label='Static Box Title', \
            pos=(10,10), size=(280,200))
        wx.StaticText(panel, label='Single line', \
            pos=(100,100))


app = wx.App()
# Pass in the frame title
frame = Frame("Python GUI")
frame.Show()
app.MainLoop()
