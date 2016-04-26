import MySQLdb
import time

conn = MySQLdb.connect ("mysql.server", "gmannen", "Yankees11", "gmannen$Test")

c = conn.cursor()

username = "Python"
tweet = "man I'm so cool"

c.execute("INSERT INTO severino (time,username,tweet) VALUES(%s,%s,%s)",
            (time.time(),username,tweet))

conn.commit()


c.execute("SELECT * FROM severino")

rows = c.fetchall()

for eachRow in rows:
    print (rows)
