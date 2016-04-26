import MySQLdb

conn = MySQLdb.connect ("mysql.server", "gmannen", "Yankees11", "gmannen$Test")

c = conn.cursor()

c.execute("SELECT * FROM severino")

rows = c.fetchall()

for eachRow in rows:
    print (rows)
