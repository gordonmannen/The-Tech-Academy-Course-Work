import sqlite3
import time
import datetime

conn = sqlite3.connect('tutorial.db')
c = conn.cursor()
sql = "SELECT * FROM stuffToPlot WHERE keyword =?"
# sql = "SELECT * FROM stuffToPlot WHERE keyword =? AND source =?"
# Here's an example if you also wanted to limit by source (Twitter)

wordUsed = 'Python Sentiment'
# sourceVariable = 'twitter'
# Twitter example

def readData():
    for row in c.execute(sql, [(wordUsed)]):
    # for row in c.execute(sql, [(wordUsed), (sourceVariable)]):
    # This is how you would setup the Twitter example.
        print str(row).replace(')','').replace('(','').replace('u\'','').replace("'","")
        # This replace deal doesn't seem to be working for me, but this is the general idea.


    
