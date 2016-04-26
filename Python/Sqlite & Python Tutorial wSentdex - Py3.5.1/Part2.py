import sqlite3
import time
import datetime

conn = sqlite3.connect('tutorial.db')
c = conn.cursor()

def tableCreate():
    c.execute("CREATE TABLE stuffToPlot(ID INT, unix REAL, datestamp TEXT, keyword TEXT, value REAL)")

idfordb = 4
keyword = 'Python Sentiment'
value = 7




def dataEntry():
    date = str(datetime.datetime.fromtimestamp(int(time.time())).strftime('%Y-%m-%d %H:%M:%S'))
    # Uppercase Y is full year like 2013, lowercase y is just the last two digits, and so on.                                                                     
    c.execute("INSERT INTO stuffToPlot (ID, unix, datestamp, keyword, value) VALUES (?,?,?,?,?)",
              (idfordb, time.time(), date, keyword, value))
    conn.commit()
    
