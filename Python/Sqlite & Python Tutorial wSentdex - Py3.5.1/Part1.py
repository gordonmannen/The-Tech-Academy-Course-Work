import sqlite3

conn = sqlite3.connect('tutorial.db')
c = conn.cursor()

#def tableCreate():
#    c.execute("CREATE TABLE stuffToPlot(ID INT, unix REAL, datestamp TEXT, keyword TEXT, value REAL)")

def dataEntry():
    c.execute("INSERT INTO stuffToPlot VALUES(1, 1234567891.123, '2013-04-14', 'Python Sentiment', 5)")
    c.execute("INSERT INTO stuffToPlot VALUES(2, 2345678922.456, '2013-05-11', 'Python Sentiment', 6)")
    c.execute("INSERT INTO stuffToPlot VALUES(3, 3456789133.789, '2013-06-17', 'Python Sentiment', 4)")
    conn.commit()
    
